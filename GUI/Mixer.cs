using iRANE_62.Handlers;
using iRANE_62.Models;
using NAudio.Extras;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;

namespace iRANE_62
{
    public partial class Mixer : Form
    {
        private readonly AudioSourceHandler audioSource1;
        private readonly AudioSourceHandler audioSource2;
        private readonly MicrophoneHandler microphoneHandler;
        private readonly AudioOutputHandler audioOutputHandler;
        private readonly SystemVolumeHandler systemVolumeHandler;
        private readonly ChannelVolumeHandler channel1VolumeHandler;
        private readonly ChannelVolumeHandler channel2VolumeHandler;

        public event Action<AudioSourceHandler, TimeSpan, Color> CuePointAdded;

        private float chanel1OriginalVolume = 0.5f;
        private float chanel2OriginalVolume = 0.5f;
        private bool isMicOverActive = false;


        public Mixer() { }

        public Mixer(ref AudioSourceHandler player1, ref AudioSourceHandler player2, AudioOutputHandler audioOutputHandler) : this()
        {
            this.audioSource1 = player1 ?? throw new ArgumentNullException(nameof(player1));
            this.audioSource2 = player2 ?? throw new ArgumentNullException(nameof(player2));
            this.audioOutputHandler = audioOutputHandler ?? throw new ArgumentNullException(nameof(audioOutputHandler));
            microphoneHandler = new MicrophoneHandler();
            systemVolumeHandler = new SystemVolumeHandler();
            InitializeComponent();

            channel1VolumeHandler = new ChannelVolumeHandler(audioSource1, pot_gain_ch1, verticalVolumeSlider_ch2, pot_systemVolume);
            channel2VolumeHandler = new ChannelVolumeHandler(audioSource2, pot_gain_ch2, verticalVolumeSlider_ch1, pot_systemVolume);

            efxCheckedChangedEventHandler();
            blockCueButtons();
            SetupMicrophoneControls();
            SetupVolumeMeters();
            SetupSystemVolume();
            microphoneHandler.IsActiveChanged += UpdateMicrophoneOutput;
        }

        #region FX

        private void efxCheckedChangedEventHandler()
        {
            chBox_efx_echo.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            chBox_efx_flanger.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            chBox_efx_filter.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            chBox_efx_phaser.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            chBox_efx_reverb.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            chBox_efx_robot.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
        }

        private void efx_flanger_CheckedChanged(object sender, EventArgs e){}

        private void efx_phaser_CheckedChanged(object sender, EventArgs e){}

        private void efx_echo_CheckedChanged(object sender, EventArgs e){}

        private void efx_robot_CheckedChanged(object sender, EventArgs e){}

        private void efx_reverb_CheckedChanged(object sender, EventArgs e){}

        private void efx_ext_insert_CheckedChanged(object sender, EventArgs e){}

        private void efx_insert_CheckedChanged(object sender, EventArgs e){}

        private void efx_filter_CheckedChanged(object sender, EventArgs e){}

        private void Efx_CheckBox_Change(object? sender, EventArgs e)
        {
            CheckBox clickedCheckBox = sender as CheckBox;

            if (clickedCheckBox.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox && control != clickedCheckBox)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
            }
        }

        private void efx_time_Scroll(object sender, ScrollEventArgs e)
        {

        }
        #endregion

        #region Eq

        private void pot_gain_ch1_ValueChanged(object sender, EventArgs e) { }

        private void pot_gain_ch2_ValueChanged(object sender, EventArgs e) { }

        public void OnPostMainVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter_mainLeft.Amplitude = e.MaxSampleValues[0];
            volumeMeter_mainRight.Amplitude = e.MaxSampleValues[1];
        }

        public void OnPostChanel1VolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter_ch1.Amplitude = Math.Max(e.MaxSampleValues[0], e.MaxSampleValues[1]);
        }

        public void OnPostChanel2VolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter_ch2.Amplitude = Math.Max(e.MaxSampleValues[0], e.MaxSampleValues[1]);
        }

        private void high_odt1_ValueChanged(object sender, EventArgs e)
        {//doda³em bardziej ³agodne przejœcie miêdzy bandami, na studyjnych nie s³ychaæ fuzej ró¿nicy, bêdzie móg³ usun¹æ jak oka¿e siê, ¿e program jest za wolny   

            audioSource1.Equalizer.Band9 = (float)pot_high_ch1.Value;
            audioSource1.Equalizer.Band8 = (float)pot_high_ch1.Value;
            audioSource1.Equalizer.Band7 = (float)(pot_high_ch1.Value + pot_mid_ch1.Value) / 2;
            audioSource1.Equalizer.equalizer.Update();
        }

        private void mid_odt1_ValueChanged(object sender, EventArgs e)
        {
            audioSource1.Equalizer.Band6 = (float)(pot_mid_ch1.Value + pot_high_ch1.Value) / 2;
            audioSource1.Equalizer.Band5 = (float)pot_mid_ch1.Value;
            audioSource1.Equalizer.Band4 = (float)(pot_mid_ch1.Value + pot_low_ch1.Value) / 2;
            audioSource1.Equalizer.equalizer.Update();
        }

        private void low_odt1_ValueChanged(object sender, EventArgs e)
        {
            audioSource1.Equalizer.Band3 = (float)(pot_low_ch1.Value + pot_mid_ch1.Value) / 2;
            audioSource1.Equalizer.Band2 = (float)pot_low_ch1.Value;
            audioSource1.Equalizer.Band1 = (float)pot_low_ch1.Value;
            audioSource1.Equalizer.equalizer.Update();
        }

        private void high_odt2_ValueChanged(object sender, EventArgs e)
        {
            audioSource2.Equalizer.Band7 = (float)pot_high_ch2.Value;
            audioSource2.Equalizer.Band9 = (float)pot_high_ch2.Value;
            audioSource2.Equalizer.Band8 = (float)pot_high_ch2.Value;
            audioSource2.Equalizer.equalizer.Update();
        }

        private void mid_odt2_ValueChanged(object sender, EventArgs e)
        {
            audioSource2.Equalizer.Band4 = (float)pot_mid_ch2.Value;
            audioSource2.Equalizer.Band5 = (float)pot_mid_ch2.Value;
            audioSource2.Equalizer.Band6 = (float)pot_mid_ch2.Value;
            audioSource2.Equalizer.equalizer.Update();
        }

        private void low_odt2_ValueChanged(object sender, EventArgs e)
        {

            audioSource2.Equalizer.Band1 = (float)pot_low_ch2.Value;
            audioSource2.Equalizer.Band2 = (float)pot_low_ch2.Value;
            audioSource2.Equalizer.Band3 = (float)pot_low_ch2.Value;
            audioSource2.Equalizer.equalizer.Update();
        }

        private void pan_odt1_PanChanged(object sender, EventArgs e)
        {
            if (audioSource1.Equalizer.PanningProvider != null)
            {
                float panValue = (float)panSlider_ch1.Pan;
                audioSource1.Equalizer.PanningProvider.Pan = panValue;
            }
        }

        private void pan_odt2_PanChanged(object sender, EventArgs e)
        {
            float panValue = (float)panSlider_ch2.Pan;
            audioSource2.Equalizer.PanningProvider.Pan = panValue;
        }

        private void filter_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource1 != null)
            {
                float potValue = (float)pot_filter_ch1.Value;
                audioSource1.Equalizer.FilterSampleProvider.FilterValue = potValue;
            }
        }

        private void filter_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2 != null)
            {
                float potValue = (float)pot_filter_ch2.Value;
                audioSource2.Equalizer.FilterSampleProvider.FilterValue = potValue;
            }
        }
        #endregion

        #region Loop
        private void loopOut_ch1_Click(object sender, EventArgs e)
        {
            if (audioSource1.IsPlaying)
            {
                audioSource1.Loop.SetLoopOut(audioSource1.AudioFileReader.CurrentTime);
            }
        }

        private void loopIn_ch1_Click(object sender, EventArgs e)
        {
            if (audioSource1.IsPlaying)
            {
                audioSource1.Loop.SetLoopIn(audioSource1.AudioFileReader.CurrentTime);
                audioSource1.Loop.LoopActive = true;
            }
        }

        private void exitLoop_ch1_Click(object sender, EventArgs e)
        {
            audioSource1.Loop.LoopActive = false;
            audioSource1.Loop.LoopIn = TimeSpan.Zero;
            audioSource1.Loop.LoopOut = TimeSpan.Zero;
        }

        private void loopOut_ch2_Click(object sender, EventArgs e)
        {
            if (audioSource2.IsPlaying)
            {
                audioSource2.Loop.SetLoopOut(audioSource2.AudioFileReader.CurrentTime);
            }
        }

        private void loopIn_ch2_Click(object sender, EventArgs e)
        {
            if (audioSource2.IsPlaying)
            {
                audioSource2.Loop.SetLoopIn(audioSource2.AudioFileReader.CurrentTime);
                audioSource2.Loop.LoopActive = true;
            }
        }

        private void exitLoop_ch2_Click(object sender, EventArgs e)
        {
            audioSource2.Loop.LoopActive = false;
            audioSource2.Loop.LoopIn = TimeSpan.Zero;
            audioSource2.Loop.LoopOut = TimeSpan.Zero;
        }
        #endregion

        #region CuePoint

        private void blockCueButtons()
        {
            btn_cue1_ch1.Enabled = false;
            btn_cue2_ch1.Enabled = false;
            btn_cue3_ch1.Enabled = false;
            btn_cue4_ch1.Enabled = false;
            btn_cue5_ch1.Enabled = false;

            btn_cue1_ch2.Enabled = false;
            btn_cue2_ch2.Enabled = false;
            btn_cue3_ch2.Enabled = false;
            btn_cue4_ch2.Enabled = false;
            btn_cue5_ch2.Enabled = false;

        }

        public void EnableCuePoints(int playerId)
        {
            if (playerId == 1)
            {
                btn_cue1_ch1.Enabled = true;
                btn_cue2_ch1.Enabled = true;
                btn_cue3_ch1.Enabled = true;
                btn_cue4_ch1.Enabled = true;
                btn_cue5_ch1.Enabled = true;
            }
            else
            {
                btn_cue1_ch2.Enabled = true;
                btn_cue2_ch2.Enabled = true;
                btn_cue3_ch2.Enabled = true;
                btn_cue4_ch2.Enabled = true;
                btn_cue5_ch2.Enabled = true;
            }
        }

        private void cue1_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource1.AudioFileReader.CurrentTime;

            CueButtonClick(audioSource1, 0, currentTime);
            btn_cue1_ch1.BackColor = CuePointsColors.Colors[0];
        }
        private void cue2_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource1.AudioFileReader.CurrentTime;

            CueButtonClick(audioSource1, 1, currentTime);
            btn_cue2_ch1.BackColor = CuePointsColors.Colors[1];

        }
        private void cue3_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource1.AudioFileReader.CurrentTime;
            CueButtonClick(audioSource1, 2, currentTime);
            btn_cue3_ch1.BackColor = CuePointsColors.Colors[2];
        }
        private void cue4_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource1.AudioFileReader.CurrentTime;
            CueButtonClick(audioSource1, 3, currentTime);
            btn_cue4_ch1.BackColor = CuePointsColors.Colors[3];
        }
        private void cue5_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource1.AudioFileReader.CurrentTime;
            CueButtonClick(audioSource1, 4, currentTime);
            btn_cue5_ch1.BackColor = CuePointsColors.Colors[4];
        }
        private void cue1_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource2.AudioFileReader.CurrentTime;
            CueButtonClick(audioSource2, 0, currentTime);
            btn_cue1_ch2.BackColor = CuePointsColors.Colors[0];
        }
        private void cue2_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource2.AudioFileReader.CurrentTime;
            CueButtonClick(audioSource2, 1, currentTime);
            btn_cue2_ch2.BackColor = CuePointsColors.Colors[1];
        }
        private void cue3_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource2.AudioFileReader.CurrentTime;
            CueButtonClick(audioSource2, 2, currentTime);
            btn_cue3_ch2.BackColor = CuePointsColors.Colors[2];
        }
        private void cue4_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource2.AudioFileReader.CurrentTime;
            CueButtonClick(audioSource2, 3, currentTime);
            btn_cue4_ch2.BackColor = CuePointsColors.Colors[3];
        }
        private void cue5_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = audioSource2.AudioFileReader.CurrentTime;
            CueButtonClick(audioSource2, 4, currentTime);
            btn_cue5_ch2.BackColor = CuePointsColors.Colors[4];
        }

        public void CueColorClear(int playerId)
        {
            if (playerId == 1)
            {
                btn_cue1_ch1.BackColor = Color.White;
                btn_cue2_ch1.BackColor = Color.White;
                btn_cue3_ch1.BackColor = Color.White;
                btn_cue4_ch1.BackColor = Color.White;
                btn_cue5_ch1.BackColor = Color.White;
            }
            else
            {

                btn_cue1_ch2.BackColor = Color.White;
                btn_cue2_ch2.BackColor = Color.White;
                btn_cue3_ch2.BackColor = Color.White;
                btn_cue4_ch2.BackColor = Color.White;
                btn_cue5_ch2.BackColor = Color.White;
            }
        }
        private void CueButtonClick(AudioSourceHandler player, int cue, TimeSpan currentTime)
        {
            var cuePoint = player.Song.CuePoints[cue];

            if (cuePoint.StartTime.HasValue)
            {
                player.AudioFileReader.CurrentTime = (TimeSpan)cuePoint.StartTime;
            }
            else
            {
                cuePoint.StartTime = currentTime;

                CuePointAdded?.Invoke(player, currentTime, cuePoint.Color);
            }

        }

        #endregion

        #region Microphone

        private void UpdateMicrophoneOutput(bool isActive)
        {
            if (isActive)
            {
                audioOutputHandler.AddSource(microphoneHandler, microphoneHandler.GetMeteringSampleProvider());
            }
            else
            {
                audioOutputHandler.RemoveSource(microphoneHandler);

            }
        }

        private void SetupMicrophoneControls()
        {
            microphoneHandler.VolumeIndicator += OnMicrophoneVolumeMeter;
            microphoneHandler.Volume = (float)pot_mic_level.Value;
            btn_micOnOff.BackColor = microphoneHandler.IsActive ? Color.Green : SystemColors.Control;
            btn_micOver.BackColor = isMicOverActive ? Color.Green : SystemColors.Control;
            if (microphoneHandler.IsActive)
                UpdateMicrophoneOutput(true);
        }

        private void btn_micOnOff_Click(object sender, EventArgs e)
        {
            microphoneHandler.IsActive = !microphoneHandler.IsActive;
            btn_micOnOff.BackColor = microphoneHandler.IsActive ? Color.Green : SystemColors.Control;

            if (!microphoneHandler.IsActive)
            {
                microphoneHandler.MicLeftLevel = 0f;
                microphoneHandler.MicRightLevel = 0f;
                UpdateMainVolumeMeters();
            }
        }

        private void btn_micOver_Click(object sender, EventArgs e)
        {
            if (!microphoneHandler.IsActive) return;

            isMicOverActive = !isMicOverActive;

            channel1VolumeHandler.IsMicOverActive = isMicOverActive;
            channel2VolumeHandler.IsMicOverActive = isMicOverActive;
            btn_micOver.BackColor = isMicOverActive ? Color.Green : SystemColors.Control;
        }

        private void UpdateMainVolumeMeters()
        {
            float leftLevel = Math.Max(audioSource1.LeftChanelVolumeLevel, audioSource2.LeftChanelVolumeLevel);
            float rightLevel = Math.Max(audioSource1.RightChanelVolumeLevel, audioSource2.RightChanelVolumeLevel);
            volumeMeter_mainLeft.Amplitude = Math.Max(leftLevel, microphoneHandler.MicLeftLevel);
            volumeMeter_mainRight.Amplitude = Math.Max(rightLevel, microphoneHandler.MicRightLevel);
        }

        private void mic_level_ValueChanged(object sender, EventArgs e)
        {
            microphoneHandler.Volume = (float)pot_mic_level.Value;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            microphoneHandler?.Dispose();
        }

        private void OnMicrophoneVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            microphoneHandler.MicLeftLevel = e.MaxSampleValues[0];
            microphoneHandler.MicRightLevel = e.MaxSampleValues[1];
            volumeMeter_mic_volume.Amplitude = Math.Max(microphoneHandler.MicLeftLevel, microphoneHandler.MicRightLevel);
            UpdateMainVolumeMeters();
        }

        private void mic_high_ValueChanged(object sender, EventArgs e)
        {
            if (microphoneHandler.Equalizer != null)
            {
                float highValue = (float)pot_mic_high.Value;
                microphoneHandler.Equalizer.Bands[6].Gain = highValue;
                microphoneHandler.Equalizer.Bands[7].Gain = highValue;
                microphoneHandler.Equalizer.Bands[8].Gain = highValue;
                microphoneHandler.Equalizer.equalizer.Update();
            }
        }

        private void mic_low_ValueChanged(object sender, EventArgs e)
        {
            if (microphoneHandler.Equalizer != null)
            {
                float lowValue = (float)pot_mic_low.Value;
                microphoneHandler.Equalizer.Bands[0].Gain = lowValue;
                microphoneHandler.Equalizer.Bands[1].Gain = lowValue;
                microphoneHandler.Equalizer.Bands[2].Gain = lowValue;
                microphoneHandler.Equalizer.equalizer.Update();
            }
        }
        #endregion

        #region Volume

        private void pot_mainVolume_ValueChanged(object sender, EventArgs e)
        {
            systemVolumeHandler.Volume = (float)pot_systemVolume.Value;
        }

        private void SetupSystemVolume()
        {
            pot_systemVolume.Value = systemVolumeHandler.Volume;
        }

        private void SetupVolumeMeters()
        {
            audioSource1.VolumeMetered += OnChannelVolumeMetered;
            audioSource2.VolumeMetered += OnChannelVolumeMetered;
        }

        private void OnChannelVolumeMetered(object sender, StreamVolumeEventArgs e)
        {
            UpdateMainVolumeMeters();
        }

        #endregion
    }
}
