using iRANE_62.Models;
using Microsoft.VisualBasic;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.WaveFormRenderer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRANE_62
{
    public partial class Odtwarzacz : Form
    {
        private Mixer mixer;

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

        private void Odtwarzacz_Load(object sender, EventArgs e)
        {
            OpenMikser();
        }

        private void OpenMikser()
        {
            if (mixer == null || mixer.IsDisposed)
            {
                mixer = new Mixer(ref player1, ref player2);
                mixer.Show();
            }
            else
            {
                mixer.Focus();
            }
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
            if (player.FileName == null) player.FileName = SelectInputFile();
            if (player.FileName != null)
            {
                BeginPlayback(ref player);
            }
        }

        private void BeginPlayback(ref Player player)
        {

            if (player.WavePlayer != null)
            {
                if (player.WavePlayer.PlaybackState == PlaybackState.Playing)
                {
                    player.WavePlayer.Pause();
                    return;
                }

                if (player.WavePlayer.PlaybackState == PlaybackState.Paused)
                {
                    SetVolumeFromMixerLevel(player);
                    player.WavePlayer.Play();
                    return;
                }

                player.WavePlayer.Stop();
                player.WavePlayer.Dispose();
            }

            if (player.FileName == String.Empty) return;

            player.WavePlayer = new WaveOutEvent();

            player.AudioFileReader = new AudioFileReader(player.FileName);


            //Pre
            var sampleChannel = new SampleChannel(player.AudioFileReader, true);
            player.SetVolumeDelegate = vol => sampleChannel.Volume = vol;
            if (player.Id == 1)
            {
                sampleChannel.PreVolumeMeter += mixer.OnPostChanel1VolumeMeter;
            }
            else
            {
                sampleChannel.PreVolumeMeter += mixer.OnPostChanel2VolumeMeter;
            }

            //EQ
            mixer.equalizer = new NAudio.Extras.Equalizer(sampleChannel, mixer.bands);


            //Post
            var postVolumeMeter = new MeteringSampleProvider(mixer.equalizer);
            postVolumeMeter.StreamVolume += mixer.OnPostMainVolumeMeter;

            player.WavePlayer.Init(postVolumeMeter);

            SetVolumeFromMixerLevel(player);

            player.WavePlayer.Play();
            timer1.Enabled = true;
        }

        private void SetVolumeFromMixerLevel(Player player)
        {
            if (player.Id == 1)
            {
                player.SetVolumeDelegate((float)mixer.gain_ch1.Value);
            }
            else
            {
                player.SetVolumeDelegate((float)mixer.gain_ch2.Value);
            }
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

        #region Open

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
        {//TODO przepisz to tak, żeby nie powielało OpenSongFromPlaylist
            player.FileName = SelectInputFile();
            if (player.FileName != String.Empty)
            {
                LabelTrackUpdate(player);
                RenderWaveform(player);
                Song song = new Song(player.FileName);
                playlista.Items.Add(song);
                UpadteTotalSongTime(player, song);
            }
        }

        private void UpadteTotalSongTime(Player player, Song song)
        {
            if (player.Id == 1)
            {
                labelTotalTime_1.Text = FormatTimeSpan(song.SongSpan);

            }
            else
            {
                labelTotalTime_2.Text = FormatTimeSpan(song.SongSpan);
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
            string songName = player.FileName.Split('\\').Last().ToString();
            if (player.Id == 1)
            {
                labelTrack1.Text = songName;
            }
            else
            {
                labelTrack2.Text = songName;
            }

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && e.Shift)
            {
                if (playlista.SelectedItem != null)
                {
                    Song song = (Song)playlista.SelectedItem;
                    OpenSongFromPlaylist(player1, song);
                }
            }

            if (e.KeyCode == Keys.Right && e.Shift)
            {

                if (playlista.SelectedItem != null)
                {
                    Song song = (Song)playlista.SelectedItem;
                    OpenSongFromPlaylist(player2, song);
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (player1.FileName != null)
                {
                    BeginPlayback(ref player1);
                }
            }

            if (e.KeyCode == Keys.Enter)
            {

                if (player2.FileName != null)
                {
                    BeginPlayback(ref player2);
                }
            }

        }

        private void OpenSongFromPlaylist(Player player, Song song)
        {//TODO scal to z funkcją Open
            player.FileName = song.Path;
            if (player.FileName != null)
            {
                LabelTrackUpdate(player);
                RenderWaveform(player);
                UpadteTotalSongTime(player, song);
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
            if (player.WavePlayer != null)
            {
                player.WavePlayer.Stop();
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
            if (player.WavePlayer != null)
                player.WavePlayer.Pause();
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
            if (player.FileName == null) return;

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
                using (var wavestream = new AudioFileReader(player.FileName))
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
            if (player1.AudioFileReader != null)
            {
                player1.AudioFileReader.Dispose();
                player1.AudioFileReader = null;
            }

            if (player2.AudioFileReader != null)
            {
                player2.AudioFileReader.Dispose();
                player2.AudioFileReader = null;
            }
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            if (player1.AudioFileReader != null)
            {
                labelNowTime_1.Text = FormatTimeSpan(player1.AudioFileReader.CurrentTime);
            }
            if (player2.AudioFileReader != null)
            {
                labelNowTime_2.Text = FormatTimeSpan(player2.AudioFileReader.CurrentTime);
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
            if (player.WavePlayer == null) return;

            if (player.WavePlayer.PlaybackState == PlaybackState.Playing)
            {
                player.WavePlayer.Pause();
            }
            player.WavePlayer.Play();
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    Song song = new Song(file);
                    playlista.Items.Add(song);
                }
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                bool allValid = files.All(file =>
                    file.EndsWith(".wav", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".aiff", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".wma", StringComparison.OrdinalIgnoreCase));


                if (allValid)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


    }

}
