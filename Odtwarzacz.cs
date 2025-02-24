using iRANE_62.Extensions;
using iRANE_62.Models;
using Microsoft.VisualBasic;
using NAudio.Dmo.Effect;
using NAudio.Extras;
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
    public partial class Player : Form
    {
        private Mixer mixer;

        private AudioSource chanel1;
        private AudioSource chanel2;

        private string? imageFile;
        private readonly WaveFormRenderer waveFormRenderer;
        private readonly WaveFormRendererSettings standardSettings;

        public Player()
        {
            InitializeComponent();
            Disposed += PlaybackPanel_Disposed;
            timer1.Interval = 250;
            timer1.Tick += OnTimerTick;

            chanel1 = new AudioSource(1);
            chanel2 = new AudioSource(2);

            standardSettings = new StandardWaveFormRendererSettings() { Name = "Standard" };
            waveFormRenderer = new WaveFormRenderer();
        }

        private void PlayerLoad(object sender, EventArgs e)
        {
            OpenMikser();
        }

        private void OpenMikser()
        {
            if (mixer == null || mixer.IsDisposed)
            {
                mixer = new Mixer(ref chanel1, ref chanel2);
                mixer.Show();
            }
            else
            {
                mixer.Focus();
            }
        }


        #region Play button

        private void Play(AudioSource player)
        {
            if (player.FileName == null) player.FileName = SelectInputFile();
            if (player.FileName != null)
            {
                BeginPlayback(player);
            }
        }

        private void BeginPlayback(AudioSource player)//rozbić na drobniejsze!

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

            #region Sekcja EQ
            //High- LowPassFilter -
            player.Equalizer.FilterSampleProvider = new FilterSampleProvider(sampleChannel, player.AudioFileReader.WaveFormat.SampleRate);

            //Pan
            player.Equalizer.PanningProvider = new StereoPanningSampleProvider(player.Equalizer.FilterSampleProvider);

            //EQ
            player.Equalizer.equalizer = new Equalizer(player.Equalizer.PanningProvider, player.Equalizer.bands);
            #endregion


            //Post
            var postVolumeMeter = new MeteringSampleProvider(player.Equalizer.equalizer);
            postVolumeMeter.StreamVolume += mixer.OnPostMainVolumeMeter;
            //zronić z tego funkcję??

            player.WavePlayer.Init(postVolumeMeter);

            SetVolumeFromMixerLevel(player);

            player.WavePlayer.Play();
            timer1.Enabled = true;

        }

        private void SetVolumeFromMixerLevel(AudioSource player)//zmienić na private void Set..(Player player, float gain)
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

        #region Open button

        private void LoadTrack(AudioSource player, string fileName)
        {
            player.FileName = fileName;
            player.AudioFileReader = new AudioFileReader(player.FileName);

            LabelTrackUpdate(player);
            RenderWaveform(player);

            Song song = new Song(player.FileName);
            player.Song = song;

            UpadteTotalSongTime(player, song);
            EnableGuiOnChanel(player.Id);
            mixer.CueColorClear(player.Id);//TODO2 zmienić to na sprawdzanie czy dany utwór ma zapisane CuePointy
            //nie używać pola mkxer w ten sposób
        }

        private void AddToPlaylist(Song song)
        {
            if (!playlista.Items.Contains(song))
            {
                playlista.Items.Add(song);
            }
        }

        private void OpenFromButton(AudioSource player)
        {
            var fileName = SelectInputFile();
            if (fileName != String.Empty)
            {
                LoadTrack(player, fileName);
                AddToPlaylist(player.Song);
            }
        }

        private void LoadSongFromPlaylist(AudioSource player, Song song)
        {
            LoadTrack(player, song.Path);
        }

        private void UpadteTotalSongTime(AudioSource player, Song song)
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

        private void LabelTrackUpdate(AudioSource player)
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

        #endregion

        #region GUI + keyboard shortcuts

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            Play(chanel1);
        }

        private void btnPlay_2_Click(object sender, EventArgs e)
        {
            Play(chanel2);
        }

        private void Odtwarzacz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                PressedSpacebarOrEnter(ref chanel1);
            }

            if (e.KeyCode == Keys.Enter)
            {
                PressedSpacebarOrEnter(ref chanel2);
            }
        }

        private void PressedSpacebarOrEnter(ref AudioSource player)
        {
            if (player.WavePlayer == null) return;

            if (player.WavePlayer.PlaybackState == PlaybackState.Playing)
            {
                player.WavePlayer.Pause();
            }
            player.WavePlayer.Play();
        }

        private void EnableGuiOnChanel(int playerId)
        {
            EnableWaveformOnChanel(playerId);
            mixer.EnableCuePoints(playerId);
            EnableButtonsOnChanel(playerId);
        }

        private void EnableButtonsOnChanel(int playerId)
        {
            if (playerId == 1)
            {
                btnOpen_ch1.Enabled = true;
                btnPlay_ch1.Enabled = true;
                btnPause_ch1.Enabled = true;
                btnStop_ch1.Enabled = true;
            }
            else
            {
                btnOpen_ch2.Enabled = true;
                btnPlay_ch2.Enabled = true;
                btnPause_ch2.Enabled = true;
                btnStop_ch2.Enabled = true;
            }
        }

        private void EnableWaveformOnChanel(int playerId)
        {
            if (playerId == 1)
            {
                chanel1.CurrentPlaybackPosition = 0;
                waveform_ch1.Enabled = true;
                waveform_ch1.Invalidate();
            }
            else
            {
                chanel2.CurrentPlaybackPosition = 0;
                waveform_ch2.Enabled = true;
                waveform_ch2.Invalidate();
            }
        }

        private void btnOpen_1_Click(object sender, EventArgs e)
        {
            OpenFromButton(chanel1);
        }

        private void btnOpen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O && e.Shift)
            {
                OpenFromButton(chanel2);
            }

            if (e.KeyCode == Keys.O)
            {
                OpenFromButton(chanel1);
            }
        }

        private void btnOpen_2_Click(object sender, EventArgs e)
        {
            OpenFromButton(chanel2);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && e.Shift)
            {
                if (playlista.SelectedItem != null)
                {
                    Song song = (Song)playlista.SelectedItem;
                    LoadSongFromPlaylist(chanel1, song);
                }
            }

            if (e.KeyCode == Keys.Right && e.Shift)
            {

                if (playlista.SelectedItem != null)
                {
                    Song song = (Song)playlista.SelectedItem;
                    LoadSongFromPlaylist(chanel2, song);
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (chanel1.FileName != null)
                {
                    BeginPlayback(chanel1);
                }
            }

            if (e.KeyCode == Keys.Enter)
            {

                if (chanel2.FileName != null)
                {
                    BeginPlayback(chanel2);
                }
            }

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    Song song = new Song(file);
                    AddToPlaylist(song);
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

        private void waveform_ch1_MouseClick(object sender, MouseEventArgs e)
        {
            double clickPositionRatio = (double)e.X / waveform_ch1.Width;
            TimeSpan newTime = TimeSpan.FromSeconds(chanel1.AudioFileReader.TotalTime.TotalSeconds * clickPositionRatio);

            chanel1.AudioFileReader.CurrentTime = newTime;

            chanel1.CurrentPlaybackPosition = e.X;
            waveform_ch1.Invalidate();
        }

        private void waveform_ch2_MouseClick(object sender, MouseEventArgs e)
        {
            double clickPositionRatio = (double)e.X / waveform_ch2.Width;
            TimeSpan newTime = TimeSpan.FromSeconds(chanel2.AudioFileReader.TotalTime.TotalSeconds * clickPositionRatio);

            chanel2.AudioFileReader.CurrentTime = newTime;

            chanel2.CurrentPlaybackPosition = e.X;
            waveform_ch2.Invalidate();
        }

        private void playlista_Click(object sender, EventArgs e)
        {/*
            var fileName = SelectInputFile();
            if (fileName != String.Empty)
            {
                AddToPlaylist(new Song(fileName));
            }*/
        }

        #endregion

        #region Stop button

        private void btnStop_1_Click(object sender, EventArgs e)
        {
            Stop(ref chanel1);
        }
        private void btnStop_2_Click(object sender, EventArgs e)
        {

            Stop(ref chanel2);
        }
        private void Stop(ref AudioSource player)
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
            Pause(ref chanel1);
        }

        private void btnPause_2_Click(object sender, EventArgs e)
        {
            Pause(ref chanel2);
        }

        private void Pause(ref AudioSource player)
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

        private void RenderWaveform(AudioSource player)
        {
            if (player.FileName == null) return;

            var settings = standardSettings;//TODO zmień na jednolity "ładny" kolor waveforma

            if (imageFile != null)
            {
                settings.BackgroundImage = new Bitmap(imageFile);
            }

            if (player.Id == 1)
            {
                waveform_ch1.Image = null;
            }
            else
            {
                waveform_ch2.Image = null;
            }

            Enabled = false; //nie wiem czy to nie będzie blokować obu odtwarzaczy na raz
            var peakProvider = new RmsPeakProvider(200);
            Task.Factory.StartNew(() => RenderThreadFunc(peakProvider, settings, player));
        }

        private void RenderThreadFunc(IPeakProvider peakProvider, WaveFormRendererSettings settings, AudioSource player)
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

        private void FinishedRender(Image image, AudioSource player)
        {
            if (player.Id == 1)
            {

                labelRendering1.Visible = false;
                waveform_ch1.Image = image;
                Enabled = true;
            }
            else
            {
                labelRendering2.Visible = false;
                waveform_ch2.Image = image;
                Enabled = true;

            }
        }

        private void waveform_ch1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawLine(pen, chanel1.CurrentPlaybackPosition, 0, chanel1.CurrentPlaybackPosition, waveform_ch1.Height);
            }
        }

        private void waveform_ch2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawLine(pen, chanel2.CurrentPlaybackPosition, 0, chanel2.CurrentPlaybackPosition, waveform_ch2.Height);
            }
        }

    

        #endregion

        void PlaybackPanel_Disposed(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void CleanUp()
        {
            if (chanel1.AudioFileReader != null)
            {
                chanel1.AudioFileReader.Dispose();
                chanel1.AudioFileReader = null;
            }

            if (chanel2.AudioFileReader != null)
            {
                chanel2.AudioFileReader.Dispose();
                chanel2.AudioFileReader = null;
            }
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            if (chanel1.AudioFileReader != null)
            {
                labelNowTime_1.Text = FormatTimeSpan(chanel1.AudioFileReader.CurrentTime);

                //Loop logic
                if (chanel1.Loop.LoopActive && chanel1.Loop.LoopOut != TimeSpan.Zero && chanel1.Loop.LoopIn != TimeSpan.Zero)
                {
                    if (chanel1.AudioFileReader.CurrentTime >= chanel1.Loop.LoopOut)
                    {
                        chanel1.AudioFileReader.CurrentTime = chanel1.Loop.LoopIn;
                    }
                }

                //wyświetlanie linii na waveform
                double progress = chanel1.AudioFileReader.CurrentTime.TotalSeconds / chanel1.AudioFileReader.TotalTime.TotalSeconds;
                chanel1.CurrentPlaybackPosition = (int)(waveform_ch1.Width * progress);
                waveform_ch1.Invalidate();
            }

            if (chanel2.AudioFileReader != null)
            {
                labelNowTime_2.Text = FormatTimeSpan(chanel2.AudioFileReader.CurrentTime);

                //Loop logic
                if (chanel2.Loop.LoopActive && chanel2.Loop.LoopOut != TimeSpan.Zero && chanel2.Loop.LoopIn != TimeSpan.Zero)
                {
                    if (chanel2.AudioFileReader.CurrentTime >= chanel2.Loop.LoopOut)
                    {
                        chanel2.AudioFileReader.CurrentTime = chanel2.Loop.LoopIn;
                    }
                }

                //wyświetlanie linii na waveform
                double progress = chanel2.AudioFileReader.CurrentTime.TotalSeconds / chanel2.AudioFileReader.TotalTime.TotalSeconds;
                chanel2.CurrentPlaybackPosition = (int)(waveform_ch1.Width * progress);
                waveform_ch2.Invalidate();
            }
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return string.Format("{0:D2}:{1:D2}", (int)ts.TotalMinutes, ts.Seconds);
        }

        
    }

}
