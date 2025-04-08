using iRANE_62.Handlers;
using iRANE_62.Models;
using NAudio.Wave;
using NAudio.WaveFormRenderer;


namespace iRANE_62
{
    public partial class Player : Form
    {
        private readonly Mixer mixer;
        private AudioSourceHandler audioSource1;
        private AudioSourceHandler audioSource2;
        private WaveformHandler waveformHandler1;
        private WaveformHandler waveformHandler2;
        private readonly AudioOutputHandler audioOutputHandler;

        public Player()
        {
            InitializeComponent();
            timer1.Interval = 5;
            timer1.Tick += OnTimerTick;
            Disposed += PlaybackPanel_Disposed;

            audioOutputHandler = new AudioOutputHandler();
            audioSource1 = new AudioSourceHandler(1, audioOutputHandler);
            audioSource2 = new AudioSourceHandler(2, audioOutputHandler);
            waveformHandler1 = new WaveformHandler(waveform_ch1, labelRendering1, audioSource1);
            waveformHandler2 = new WaveformHandler(waveform_ch2, labelRendering2, audioSource2);

            mixer = new Mixer(audioSource1, audioSource2, audioOutputHandler);

            mixer.CuePointAdded += (player, cuePoint, color) =>
                (player.Id == 1 ? waveformHandler1 : waveformHandler2).DrawCuePoint(cuePoint, color);
            mixer.Show();
            SetupVolumeMeters();
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
                    audioSource.Pause();
                }
                else
                {
                    UpdateEqSection(audioSource);

                    audioSource.Play();
                    timer1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd odtwarzacza: {ex.Message}");
            }
        }

        private void UpdateEqSection(AudioSourceHandler audioSource)
        {
            audioSource.ChannelVolumeHandler.UpdateVolume();
            audioSource.UpdateEffect(mixer.EffectHolder.Gain, mixer.EffectHolder.EffectEnabled);

            if (audioSource.Id == 1)
            {
                audioSource.UpdateEqualizer(mixer.EqSectionHolderChannel1);
            }
            else
            {
                audioSource.UpdateEqualizer(mixer.EqSectionHolderChannel2);
            }
        }
        #endregion

        #region Open button

        private void LoadTrack(AudioSourceHandler player, string fileName)
        {
            try
            {
                player.LoadFile(fileName);
                LabelTrackUpdate(player);
                (player.Id == 1 ? waveformHandler1 : waveformHandler2).RenderWaveform();
                UpadteTotalSongTime(player);
                EnableGuiOnChanel(player.Id);
                mixer.CueColorClear(player.Id);
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
                LoadTrack(player, fileName);
                AddToPlaylist(player.Song);
            }
        }

        private void LoadSongFromPlaylist(AudioSourceHandler player, Song song)
        {
            LoadTrack(player, song.Path);
        }

        private void UpadteTotalSongTime(AudioSourceHandler player)
        {
            (player.Id == 1 ? labelTotalTime_1 : labelTotalTime_2).Text = FormatTimeSpan(player.Song.SongSpan);
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

        private void btnPlay_1_Click(object sender, EventArgs e) => Play(audioSource1);
        private void btnPlay_2_Click(object sender, EventArgs e) => Play(audioSource2);
        private void btnStop_1_Click(object sender, EventArgs e) => Stop(audioSource1);
        private void btnStop_2_Click(object sender, EventArgs e) => Stop(audioSource2);
        private void btnPause_1_Click(object sender, EventArgs e) => Pause(audioSource1);
        private void btnPause_2_Click(object sender, EventArgs e) => Pause(audioSource2);
        private void btnOpen_1_Click(object sender, EventArgs e) => OpenFromButton(audioSource1);
        private void btnOpen_2_Click(object sender, EventArgs e) => OpenFromButton(audioSource2);

        private void Odtwarzacz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) PressedSpacebarOrEnter(ref audioSource1);
            if (e.KeyCode == Keys.Enter) PressedSpacebarOrEnter(ref audioSource2);

        }

        private void PressedSpacebarOrEnter(ref AudioSourceHandler player)
        {
            if (player.FileName != null) BeginPlayback(player);
        }

        private void EnableGuiOnChanel(int playerId)
        {
            EnableWaveformOnChanel(playerId);
            EnableButtonsOnChanel(playerId);
            mixer.EnableCuePoints(playerId);
            mixer.EnableLoopButtons(playerId);
        }

        private void EnableButtonsOnChanel(int playerId)
        {
            if (playerId == 1)
            {
                btnPlay_ch1.Enabled = true;
                btnPause_ch1.Enabled = true;
                btnStop_ch1.Enabled = true;
            }
            else
            {
                btnPlay_ch2.Enabled = true;
                btnPause_ch2.Enabled = true;
                btnStop_ch2.Enabled = true;
            }
        }

        private void EnableWaveformOnChanel(int playerId)
        {
            if (playerId == 1)
            {
                audioSource1.CurrentPlaybackPosition = 0;
                waveformHandler1.ClearWaveform();
                waveform_ch1.Enabled = true;
            }
            else
            {
                audioSource2.CurrentPlaybackPosition = 0;
                waveformHandler2.ClearWaveform();
                waveform_ch2.Enabled = true;
            }
        }

        private void btnOpen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O && e.Shift)
            {
                OpenFromButton(audioSource2);
            }

            if (e.KeyCode == Keys.O)
            {
                OpenFromButton(audioSource1);
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && e.Shift)
            {
                if (playlista.SelectedItem != null)
                {
                    Song song = (Song)playlista.SelectedItem;
                    LoadSongFromPlaylist(audioSource1, song);
                }
            }

            if (e.KeyCode == Keys.Right && e.Shift)
            {
                if (playlista.SelectedItem != null)
                {
                    Song song = (Song)playlista.SelectedItem;
                    LoadSongFromPlaylist(audioSource2, song);
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (audioSource1.FileName != null)
                {
                    BeginPlayback(audioSource1);
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (audioSource2.FileName != null)
                {
                    BeginPlayback(audioSource2);
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
            audioSource1.AudioFileReader.CurrentTime = TimeSpan.FromSeconds(audioSource1.AudioFileReader.TotalTime.TotalSeconds * clickPositionRatio);
            audioSource1.CurrentPlaybackPosition = e.X;
            waveform_ch1.Invalidate();
        }

        private void waveform_ch2_MouseClick(object sender, MouseEventArgs e)
        {
            double clickPositionRatio = (double)e.X / waveform_ch2.Width;
            audioSource2.AudioFileReader.CurrentTime = TimeSpan.FromSeconds(audioSource2.AudioFileReader.TotalTime.TotalSeconds * clickPositionRatio);
            audioSource2.CurrentPlaybackPosition = e.X;
            waveform_ch2.Invalidate();
        }

        #endregion

        #region Stop button

        private void Stop(AudioSourceHandler player)
        {
            player.Stop();
            mixer.ExitLoop(player);
            mixer.CleanVolumeMeters(player);
            (player.Id == 1 ? waveformHandler1 : waveformHandler2).UpdatePlayingPositionLine();
            timer1.Stop();
        }

        #endregion

        #region Pause button

        private void Pause(AudioSourceHandler player)
        {
            player.Pause();
            mixer.CleanVolumeMeters(player);
            timer1.Stop();
        }

        #endregion

        private void SetupVolumeMeters()
        {
            audioSource1.VolumeMetered += mixer.OnPostChanel1VolumeMeter;
            audioSource2.VolumeMetered += mixer.OnPostChanel2VolumeMeter;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (audioSource1.IsPlaying)
            {
                labelNowTime_1.Text = FormatTimeSpan(audioSource1.AudioFileReader.CurrentTime);

                audioSource1.LoopLogic();
                waveformHandler1.UpdatePlayingPositionLine();
            }

            if (audioSource2.IsPlaying)
            {
                labelNowTime_2.Text = FormatTimeSpan(audioSource2.AudioFileReader.CurrentTime);

                audioSource2.LoopLogic();
                waveformHandler2.UpdatePlayingPositionLine();
            }
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            return string.Format("{0:D2}:{1:D2}", (int)ts.TotalMinutes, ts.Seconds);
        }

        private void PlaybackPanel_Disposed(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void CleanUp()
        {
            audioSource1.Dispose();
            audioSource2.Dispose();
            audioOutputHandler.Dispose();
        }
    }
}
