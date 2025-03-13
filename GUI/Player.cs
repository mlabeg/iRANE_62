using iRANE_62.Extensions;
using iRANE_62.Handlers;
using iRANE_62.Models;
using NAudio.Dmo.Effect;
using NAudio.Extras;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.WaveFormRenderer;


namespace iRANE_62
{
    public partial class Player : Form
    {
        private readonly Mixer mixer;

        private AudioSourceHandler chanel1;
        private AudioSourceHandler chanel2;

        private readonly AudioOutputHandler audioOutputHandler;
        private readonly WaveFormRenderer waveFormRenderer;//TODO można pomyśleć o wydzielieniu oddzielnej klasy


        public Player()
        {
            InitializeComponent();
            Disposed += PlaybackPanel_Disposed;
            timer1.Interval = 250;
            timer1.Tick += OnTimerTick;

            chanel1 = new AudioSourceHandler(1);
            chanel2 = new AudioSourceHandler(2);
            audioOutputHandler = new AudioOutputHandler();
            mixer = new Mixer(ref chanel1, ref chanel2, audioOutputHandler);

            waveFormRenderer = new WaveFormRenderer();

            mixer.CuePointAdded += DrawCuePoint;
            mixer.Show();
            SetupVolumeMeters();
        }

        private void SetupVolumeMeters()
        {
            chanel1.VolumeMetered += mixer.OnPostChanel1VolumeMeter;
            chanel2.VolumeMetered += mixer.OnPostChanel2VolumeMeter;
        }

        #region Play button

        private void Play(AudioSourceHandler audioSource)
        {
            if (audioSource.FileName == null)
            {
                OpenFromButton(audioSource);
            }

            if (audioSource.FileName != null)
            {
                BeginPlayback(audioSource);
            }
        }
        private void BeginPlayback(AudioSourceHandler audioSource)
        {
            try
            {
                if (audioSource.IsPlaying)
                {
                    audioSource.Pause(audioOutputHandler);
                }
                else
                {
                    mixer.Channel1VolumeHandler.UpdateVolume();
                    mixer.Channel2VolumeHandler.UpdateVolume();

                    audioSource.Play(audioOutputHandler);
                    timer1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd odtwarzacza: {ex.Message}");
            }
        }

        private void SetVolumeFromMixerLevel(AudioSourceHandler audioSource)
        {
            audioSource.SetVolume(audioSource.Id == 1 ? (float)mixer.pot_gain_ch1.Value : (float)mixer.pot_gain_ch2.Value);
        }

        #endregion

        #region Open button

        private void LoadTrack(AudioSourceHandler player, string fileName)
        {
            try
            {
                player.LoadFile(fileName);
                LabelTrackUpdate(player);
                RenderWaveform(player);
                UpadteTotalSongTime(player, player.Song);
                EnableGuiOnChanel(player.Id);
                mixer.CueColorClear(player.Id);//TODO2 zmienić to na sprawdzanie czy dany utwór ma zapisane CuePointy
                                               //nie używać pola mkxer w ten sposób
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania ścieżki: {ex.Message}");
            }
        }

        private void AddToPlaylist(Song song)
        {
            if (!playlista.Items.Contains(song))
            {
                playlista.Items.Add(song);
            }
        }

        private void OpenFromButton(AudioSourceHandler player)
        {
            var fileName = SelectInputFile();
            if (fileName != String.Empty)
            {
                //player.LoadFile(fileName);
                LoadTrack(player, fileName);
                AddToPlaylist(player.Song);
            }
        }

        private void LoadSongFromPlaylist(AudioSourceHandler player, Song song)
        {
            LoadTrack(player, song.Path);
        }

        private void UpadteTotalSongTime(AudioSourceHandler player, Song song)
        {
            (player.Id == 1 ? labelTotalTime_1 : labelTotalTime_2).Text = FormatTimeSpan(song.SongSpan);
        }

        private string SelectInputFile()
        {
            using var ofd = new OpenFileDialog() { Filter = "Audio Files|*.mp3;*.wav;*.aiff;*.wma" };
            return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : string.Empty;
        }

        private void LabelTrackUpdate(AudioSourceHandler player)
        {
            string songName = player.FileName.Split('\\').Last();
            (player.Id == 1 ? labelTrack1 : labelTrack2).Text = songName;
        }

        #endregion

        #region GUI + keyboard shortcuts

        private void btnPlay1_Click(object sender, EventArgs e) => Play(chanel1);
        private void btnPlay_2_Click(object sender, EventArgs e) => Play(chanel2);

        private void Odtwarzacz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) PressedSpacebarOrEnter(ref chanel1);
            if (e.KeyCode == Keys.Enter) PressedSpacebarOrEnter(ref chanel2);

        }

        private void PressedSpacebarOrEnter(ref AudioSourceHandler player)
        {
            if (player.FileName != null) BeginPlayback(player);
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

        private void btnOpen_1_Click(object sender, EventArgs e) => OpenFromButton(chanel1);
        private void btnOpen_2_Click(object sender, EventArgs e) => OpenFromButton(chanel2);

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
            if (chanel1.AudioFileReader != null)//w miejscach jak to możesz dokładnie sprawdzić czy waveform (lub inne GUI) jest zablokowane,
                                                //żeby nie sprawdać tego w funkcji i nie zwlaniać programu
            {
                double clickPositionRatio = (double)e.X / waveform_ch1.Width;
                chanel1.AudioFileReader.CurrentTime = TimeSpan.FromSeconds(chanel1.AudioFileReader.TotalTime.TotalSeconds * clickPositionRatio);
                chanel1.CurrentPlaybackPosition = e.X;
                waveform_ch1.Invalidate();
            }
        }

        private void waveform_ch2_MouseClick(object sender, MouseEventArgs e)
        {
            if (chanel2.AudioFileReader != null)
            {
                double clickPositionRatio = (double)e.X / waveform_ch2.Width;
                chanel2.AudioFileReader.CurrentTime = TimeSpan.FromSeconds(chanel2.AudioFileReader.TotalTime.TotalSeconds * clickPositionRatio);
                chanel2.CurrentPlaybackPosition = e.X;
                waveform_ch2.Invalidate();
            }
        }

        #endregion

        #region Stop button

        private void btnStop_1_Click(object sender, EventArgs e) => Stop(ref chanel1);
        private void btnStop_2_Click(object sender, EventArgs e) => Stop(ref chanel2);

        private void Stop(ref AudioSourceHandler player)
        {
            player.Stop(audioOutputHandler);
        }

        #endregion

        #region Pause button

        private void btnPause_1_Click(object sender, EventArgs e) => Pause(ref chanel1);
        private void btnPause_2_Click(object sender, EventArgs e) => Pause(ref chanel2);

        private void Pause(ref AudioSourceHandler player)
        {
            player.Pause(audioOutputHandler);
        }

        #endregion

        #region Waveform Rendering

        private void RenderWaveform(AudioSourceHandler player)
        {
            if (player.FileName == null) return;

            var settings = new StandardWaveFormRendererSettings()//nie powinieneś hardcodować tego
            {
                BackgroundColor = Color.Black,
                TopPeakPen = new Pen(Color.White),
                BottomPeakPen = new Pen(Color.White),

                TopSpacerPen = new Pen(Color.Blue),//sprawdzić co to robi
                BottomSpacerPen = new Pen(Color.Red),
            };

            if (player.Id == 1) waveform_ch1.Image = null;
            else waveform_ch2.Image = null;

            Enabled = false;
            var peakProvider = new RmsPeakProvider(100);
            Task.Factory.StartNew(() => RenderThreadFunc(peakProvider, settings, player));
        }

        private void RenderThreadFunc(IPeakProvider peakProvider, WaveFormRendererSettings settings, AudioSourceHandler player)
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

        private void FinishedRender(Image image, AudioSourceHandler player)
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

        public void DrawCuePoint(AudioSourceHandler player, TimeSpan cuePoint, Color color)
        {
            if (player.Song == null || player.AudioFileReader == null)
                return;

            PictureBox waveform = (player.Id == 1) ? waveform_ch1 : waveform_ch2;

            if (waveform.Image == null)
                return;

            using (Graphics g = Graphics.FromImage(waveform.Image))
            {
                if (cuePoint.TotalSeconds >= 0 && cuePoint < player.AudioFileReader.TotalTime)
                {
                    int xPos = (int)(waveform.Width * (cuePoint.TotalSeconds / player.AudioFileReader.TotalTime.TotalSeconds));

                    using (Pen pen = new Pen(color, 3))
                    {
                        g.DrawLine(pen, xPos, 0, xPos, waveform.Height);
                    }
                }
            }

            waveform.Invalidate();
        }

        #endregion

        private void PlaybackPanel_Disposed(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void CleanUp()
        {
            chanel1.Dispose();
            chanel2.Dispose();
            audioOutputHandler.Dispose();
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
