﻿using iRANE_62.Models;
using NAudio.Wave;
using NAudio.WaveFormRenderer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRANE_62
{
    public partial class Odtwarzacz : Form
    {
        private Player player1;
        private Player player2;

        private string? imageFile;
        private readonly WaveFormRenderer waveFormRenderer;
        private readonly WaveFormRendererSettings standardSettings;



        public Odtwarzacz()
        {
            InitializeComponent();
            Disposed += PlaybackPanel_Disposed;
            timer1.Interval = 250;
            timer1.Tick += OnTimerTick;

            player1 = new Player(1);
            player2 = new Player(2);

            standardSettings = new StandardWaveFormRendererSettings() { Name = "Standard" };
            waveFormRenderer = new WaveFormRenderer();
        }


        #region Play button
        private void btnPlay1_Click(object sender, EventArgs e)
        {
            Play(player1);
        }
        private void btnPlay_2_Click(object sender, EventArgs e)
        {
            Play(player2);
        }



        private void Play(Player player)
        {
            if (player.fileName == null) player.fileName = SelectInputFile();
            if (player.fileName != null)
            {
                BeginPlayback(ref player);
            }
        }

        private void BeginPlayback(ref Player player)
        {

            if (player.wavePlayer != null)
            {
                if (player.wavePlayer.PlaybackState == PlaybackState.Playing)
                {
                    player.wavePlayer.Stop();
                    player.wavePlayer.Play();
                    return;
                }

                if (player.wavePlayer.PlaybackState == PlaybackState.Paused)
                {
                    player.wavePlayer.Play();
                    return;
                }

                player.wavePlayer.Stop();
                player.wavePlayer.Dispose();
            }

            if (player.fileName == String.Empty) return;

            player.wavePlayer = new WaveOutEvent();

            player.audioFileReader = new AudioFileReader(player.fileName);
            player.wavePlayer.Init(player.audioFileReader);

            player.wavePlayer.Play();
            timer1.Enabled = true;
        }

        // ten kawałek kodu może być potrzebny później przy dodaniu obsługi słuchawek
        /* private IWavePlayer CreateWavePlayer()//możesz to dodać jako menu rozwijane z paska u góry
         {
             switch (comboBoxOutputDriver.SelectedIndex)
             {
                 case 2:
                     return new WaveOutEvent();
                 case 1:
                     return new WaveOut(WaveCallbackInfo.FunctionCallback());
                 default:
                     return new WaveOut();
             }
         }*/


        #endregion

        #region Open button

        private void btnOpen_1_Click(object sender, EventArgs e)
        {
            Open(player1);
        }

        private void btnOpen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O && e.Shift)
            {
                Open(player2);
            }

            if (e.KeyCode == Keys.O)
            {
                Open(player1);
            }
        }

        private void btnOpen_2_Click(object sender, EventArgs e)
        {
            Open(player2);
        }

        private void Open(Player player)
        {
            player.fileName = SelectInputFile();
            if (player.fileName != String.Empty)
            {
                LabelTrackUpdate(player);
                RenderWaveform(player);
            }
        }

        private string SelectInputFile()
        {

            var ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.mp3;*.wav;*.aiff;*.wma";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return String.Empty;
        }

        private void LabelTrackUpdate(Player player)
        {
            string songName = player.fileName.Split('\\').Last().ToString();
            if (player.Id == 1)
            {
                labelTrack1.Text = songName;
            }
            else
            {
                labelTrack2.Text = songName;
            }

        }

        #endregion

        #region Stop button

        private void btnStop_1_Click(object sender, EventArgs e)
        {
            Stop(ref player1);
        }
        private void btnStop_2_Click(object sender, EventArgs e)
        {

            Stop(ref player2);
        }
        private void Stop(ref Player player)
        {
            if (player.wavePlayer != null)
            {
                player.wavePlayer.Stop();
            }
        }
        #endregion

        #region Pause button

        private void btnPause_1_Click(object sender, EventArgs e)
        {
            Pause(ref player1);
        }

        private void btnPause_2_Click(object sender, EventArgs e)
        {
            Pause(ref player2);
        }

        private void Pause(ref Player player)
        {
            if (player.wavePlayer != null)
                player.wavePlayer.Pause();
        }

        #endregion


        #region Waveform Rendering

        /*  private WaveFormRendererSettings GetRendererSettings()
          {//TODO tu opcje robię na sztywno, można pomyśleć o dodaniu ich paramrtryzacji;
              //z drugiej strony dobrze będzie mieć wszystkie waveFormy w jednym formacie, zeby nie było problemów z ich późniejszym ładowaniem

              var settings = (WaveFormRendererSettings)comboBoxRenderSettings.SelectedItem;
              settings.TopHeight = ((int)upDownBlockSize.Value);
              settings.BottomHeight = ((int)upDownBlockSize.Value);
              settings.Width = (int)upDownWidth.Value;
              settings.DecibelScale = checkBoxDecibels.Checked;
              return settings;
          }*/

        private void RenderWaveform(Player player)
        {
            if (player.fileName == null) return;

            var settings = standardSettings;//TODO zmień na jednolity "ładny" kolor waveforma

            if (imageFile != null)
            {
                settings.BackgroundImage = new Bitmap(imageFile);
            }

            if (player.Id == 1)
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox2.Image = null;
            }

            Enabled = false; //nie wiem czy to nie będzie blokować obu odtwarzaczy na raz
            var peakProvider = new RmsPeakProvider(200);
            Task.Factory.StartNew(() => RenderThreadFunc(peakProvider, settings, player));
        }

        private void RenderThreadFunc(IPeakProvider peakProvider, WaveFormRendererSettings settings, Player player)
        {
            Image image = null;
            try
            {
                using (var wavestream = new AudioFileReader(player.fileName))
                {
                    image = waveFormRenderer.Render(wavestream, peakProvider, settings);
                }

                BeginInvoke((Action)(() => FinishedRender(image, player)));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FinishedRender(Image image, Player player)
        {
            if (player.Id == 1)
            {

                labelRendering1.Visible = false;
                pictureBox1.Image = image;
                Enabled = true;
            }
            else
            {
                labelRendering2.Visible = false;
                pictureBox2.Image = image;
                Enabled = true;

            }
        }

        #endregion

        void PlaybackPanel_Disposed(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void CleanUp()
        {
            if (player1.audioFileReader != null)
            {
                player1.audioFileReader.Dispose();
                player1.audioFileReader = null;
            }

            if (player2.audioFileReader != null)
            {
                player2.audioFileReader.Dispose();
                player2.audioFileReader = null;
            }
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            if (player1.audioFileReader != null)
            {
                labelNowTime_1.Text = FormatTimeSpan(player1.audioFileReader.CurrentTime);
                labelTotalTime_1.Text = FormatTimeSpan(player1.audioFileReader.TotalTime);//TODO zmienić na czas pobierany z właściwości utworu
            }
            if (player2.audioFileReader != null)
            {
                labelNowTime_2.Text = FormatTimeSpan(player2.audioFileReader.CurrentTime);
                labelTotalTime_2.Text = FormatTimeSpan(player2.audioFileReader.TotalTime);//zmienić na czas pobierany z właściwości utworu
            }
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return string.Format("{0:D2}:{1:D2}", (int)ts.TotalMinutes, ts.Seconds);
        }


        private void Odtwarzacz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                PressedSpacebarOrEnter(ref player1);
            }

            if (e.KeyCode == Keys.Enter)
            {
                PressedSpacebarOrEnter(ref player2);
            }
        }

        private void PressedSpacebarOrEnter(ref Player player)
        {
            if (player.wavePlayer == null) return;

            if (player.wavePlayer.PlaybackState == PlaybackState.Playing)
            {
                player.wavePlayer.Pause();
            }
            player.wavePlayer.Play();
        }

    }

}
