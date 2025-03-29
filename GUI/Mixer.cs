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
        private readonly MicrophoneHandler microphoneHandler;
        private readonly BpmCounterHandler bpmCounterHandler;
        private readonly AudioSourceHandler audioSource1;
        private readonly AudioSourceHandler audioSource2;
        private readonly AudioOutputHandler audioOutputHandler;
        private readonly SystemVolumeHandler systemVolumeHandler;

        public EffectParametersHolder EffectHolder;
        public EqSectionHolder EqSectionHolderChannel1;
        public EqSectionHolder EqSectionHolderChannel2;


        public event Action<AudioSourceHandler, TimeSpan, Color> CuePointAdded;

        public Mixer() { }

        public Mixer(ref AudioSourceHandler player1, ref AudioSourceHandler player2, AudioOutputHandler audioOutputHandler) : this()
        {
            this.audioSource1 = player1 ?? throw new ArgumentNullException(nameof(player1));
            this.audioSource2 = player2 ?? throw new ArgumentNullException(nameof(player2));
            this.audioOutputHandler = audioOutputHandler ?? throw new ArgumentNullException(nameof(audioOutputHandler));

            microphoneHandler = new MicrophoneHandler();
            systemVolumeHandler = new SystemVolumeHandler();
            bpmCounterHandler = new BpmCounterHandler();
            InitializeComponent();


            InitializeHolders();
            UpdateChannelsVolumeHandlers();
            efxCheckedChangedEventHandler();
            BlockCueButtons();
            BlockLoopButtons();
            SetupMicrophoneControls();
            SetupVolumeMeters();
            SetupSystemVolume();
            SetupCrossfader();
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

        private void efx_flanger_CheckedChanged(object sender, EventArgs e)
        {
            EffectHolder.Effect = chBox_efx_flanger.Checked ? EffectsEnum.Flanger : EffectsEnum.Disabled;
        }

        private void efx_phaser_CheckedChanged(object sender, EventArgs e)
        {
            EffectHolder.Effect = chBox_efx_phaser.Checked ? EffectsEnum.Phaser : EffectsEnum.Disabled;
        }

        private void efx_echo_CheckedChanged(object sender, EventArgs e)
        {
            EffectHolder.Effect = chBox_efx_echo.Checked ? EffectsEnum.Echo : EffectsEnum.Disabled;
        }

        private void efx_robot_CheckedChanged(object sender, EventArgs e)
        {
            EffectHolder.Effect = chBox_efx_robot.Checked ? EffectsEnum.Robot : EffectsEnum.Disabled;
        }

        private void efx_reverb_CheckedChanged(object sender, EventArgs e)
        {
            EffectHolder.Effect = chBox_efx_reverb.Checked ? EffectsEnum.Reverb : EffectsEnum.Disabled;
        }

        private void efx_filter_CheckedChanged(object sender, EventArgs e)
        {
            EffectHolder.Effect = chBox_efx_filter.Checked ? EffectsEnum.Filter : EffectsEnum.Disabled;
        }

        private void Efx_CheckBox_Change(object? sender, EventArgs e)
        {
            CheckBox clickedCheckBox = sender as CheckBox;
            label_Effect_Name.Text = EffectHolder.Effect.ToString();

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

        private void chBox_efx_on_CheckedChanged(object sender, EventArgs e)
        {
            var effectChecked = chBox_efx_on.Checked;

            EffectHolder.EffectEnabled = effectChecked;
            audioSource1.UpdateEffect((float)Pot_fx_gain.Value, effectChecked);
            audioSource2.UpdateEffect((float)Pot_fx_gain.Value, effectChecked);
        }

        private void Pot_fx_gain_ValueChanged(object sender, EventArgs e)
        {
            float gain = (float)Pot_fx_gain.Value;

            EffectHolder.Gain = gain;
            audioSource1.UpdateEffect(gain, chBox_efx_on.Checked);
            audioSource2.UpdateEffect(gain, chBox_efx_on.Checked);
        }

        private void btn_fx_tap_Click(object sender, EventArgs e)
        {
            bpmCounterHandler.AddTap();

            if (bpmCounterHandler.Bpm != 0)
            {
                label_Bpm_count.Text = bpmCounterHandler.Bpm.ToString();
            }
        }

        #endregion

        #region Eq

        private void InitializeHolders()
        {
            EffectHolder = new EffectParametersHolder(EffectsEnum.Disabled, chBox_efx_on.Checked, (float)Pot_fx_gain.Value);
            EqSectionHolderChannel1 = new EqSectionHolder(pot_low_ch1, pot_mid_ch1, pot_high_ch1, panSlider_ch1, pot_filter_ch1);
            EqSectionHolderChannel2 = new EqSectionHolder(pot_low_ch2, pot_mid_ch2, pot_high_ch2, panSlider_ch2, pot_filter_ch2);
        }

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
        {//doda�em bardziej �agodne przej�cie mi�dzy bandami, na studyjnych nie s�ycha� fuzej r�nicy, b�dzie m�g� usun�� jak oka�e si�, �e program jest za wolny   
            if (audioSource1.AudioFileReader != null)
            {
                audioSource1.Equalizer.Band9 = (float)pot_high_ch1.Value;
                audioSource1.Equalizer.Band8 = (float)pot_high_ch1.Value;
                audioSource1.Equalizer.Band7 = (float)(pot_high_ch1.Value + pot_mid_ch1.Value) / 2;
                audioSource1.Equalizer.Equalizer.Update();
            }
        }

        private void mid_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource1.AudioFileReader != null)
            {
                audioSource1.Equalizer.Band6 = (float)(pot_mid_ch1.Value + pot_high_ch1.Value) / 2;
                audioSource1.Equalizer.Band5 = (float)pot_mid_ch1.Value;
                audioSource1.Equalizer.Band4 = (float)(pot_mid_ch1.Value + pot_low_ch1.Value) / 2;
                audioSource1.Equalizer.Equalizer.Update();
            }
        }

        private void low_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource1.AudioFileReader != null)
            {
                audioSource1.Equalizer.Band3 = (float)(pot_low_ch1.Value + pot_mid_ch1.Value) / 2;
                audioSource1.Equalizer.Band2 = (float)pot_low_ch1.Value;
                audioSource1.Equalizer.Band1 = (float)pot_low_ch1.Value;
                audioSource1.Equalizer.Equalizer.Update();
            }
        }

        private void high_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                audioSource2.Equalizer.Band7 = (float)pot_high_ch2.Value;
                audioSource2.Equalizer.Band9 = (float)pot_high_ch2.Value;
                audioSource2.Equalizer.Band8 = (float)pot_high_ch2.Value;
                audioSource2.Equalizer.Equalizer.Update();
            }
        }

        private void mid_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                audioSource2.Equalizer.Band4 = (float)pot_mid_ch2.Value;
                audioSource2.Equalizer.Band5 = (float)pot_mid_ch2.Value;
                audioSource2.Equalizer.Band6 = (float)pot_mid_ch2.Value;
                audioSource2.Equalizer.Equalizer.Update();
            }
        }

        private void low_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                audioSource2.Equalizer.Band1 = (float)pot_low_ch2.Value;
                audioSource2.Equalizer.Band2 = (float)pot_low_ch2.Value;
                audioSource2.Equalizer.Band3 = (float)pot_low_ch2.Value;
                audioSource2.Equalizer.Equalizer.Update();
            }
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
            if (audioSource2.AudioFileReader != null)
            {
                float panValue = (float)panSlider_ch2.Pan;
                audioSource2.Equalizer.PanningProvider.Pan = panValue;
            }
        }

        private void filter_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource1.AudioFileReader != null)
            {
                float potValue = (float)pot_filter_ch1.Value;
                audioSource1.Equalizer.FilterSampleProvider.FilterValue = potValue;
            }
        }

        private void filter_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                float potValue = (float)pot_filter_ch2.Value;
                audioSource2.Equalizer.FilterSampleProvider.FilterValue = potValue;
            }
        }
        #endregion

        #region Loop
        private void loopOut_ch1_Click(object sender, EventArgs e)
        {
            audioSource1.Loop.SetLoopOut(audioSource1.AudioFileReader.CurrentTime);
            btn_loopOut_ch1.BackColor = Color.YellowGreen;
        }

        private void loopIn_ch1_Click(object sender, EventArgs e)
        {
            audioSource1.Loop.SetLoopIn(audioSource1.AudioFileReader.CurrentTime);
            audioSource1.Loop.LoopActive = true;
            btn_loopIn_ch1.BackColor = Color.YellowGreen;
        }

        private void exitLoop_ch1_Click(object sender, EventArgs e)
        {
            audioSource1.Loop.LoopActive = false;
            CleanLoop(audioSource1);

            btn_loopIn_ch1.BackColor = Color.White;
            btn_loopOut_ch1.BackColor = Color.White;
        }

        private void loopOut_ch2_Click(object sender, EventArgs e)
        {
            audioSource2.Loop.SetLoopOut(audioSource2.AudioFileReader.CurrentTime);
            btn_loopOut_ch2.BackColor = Color.YellowGreen;
        }

        private void loopIn_ch2_Click(object sender, EventArgs e)
        {
            audioSource2.Loop.SetLoopIn(audioSource2.AudioFileReader.CurrentTime);
            audioSource2.Loop.LoopActive = true;
            btn_loopIn_ch2.BackColor = Color.YellowGreen;
        }

        private void exitLoop_ch2_Click(object sender, EventArgs e)
        {
            audioSource2.Loop.LoopActive = false;
            CleanLoop(audioSource2);

            btn_loopIn_ch2.BackColor = Color.White;
            btn_loopOut_ch2.BackColor = Color.White;
        }

        public void CleanLoop(AudioSourceHandler audioSource)
        {
            audioSource.Loop.CleanLoop();
        }

        private void BlockLoopButtons()
        {
            btn_loopIn_ch1.Enabled = false;
            btn_loopOut_ch1.Enabled = false;
            btn_exitLoop_ch1.Enabled = false;
            btn_loopIn_ch2.Enabled = false;
            btn_loopOut_ch2.Enabled = false;
            btn_exitLoop_ch2.Enabled = false;
        }

        public void EableLoopButtons(int playerId)
        {
            if (playerId == 1)
            {
                btn_loopIn_ch1.Enabled = true;
                btn_loopOut_ch1.Enabled = true;
                btn_exitLoop_ch1.Enabled = true;
            }
            else
            {
                btn_loopIn_ch2.Enabled = true;
                btn_loopOut_ch2.Enabled = true;
                btn_exitLoop_ch2.Enabled = true;
            }
        }

        #endregion

        #region CuePoint

        private void BlockCueButtons()
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
                cuePoint.StartTime = currentTime - TimeSpan.FromMilliseconds(700);

                CuePointAdded?.Invoke(player, (TimeSpan)cuePoint.StartTime, cuePoint.Color);
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
            btn_micOver.BackColor = microphoneHandler.IsMicOverActive ? Color.Green : SystemColors.Control;
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
                TurnOffMicrophoneOver();
            }
        }

        private void TurnOffMicrophoneOver()
        {
            microphoneHandler.IsMicOverActive = false;
            audioSource1.ChannelVolumeHandler.IsMicOverActive = false;
            audioSource2.ChannelVolumeHandler.IsMicOverActive = false;
            btn_micOver.BackColor = SystemColors.Control;
        }

        private void btn_micOver_Click(object sender, EventArgs e)
        {
            if (!microphoneHandler.IsActive) return;

            microphoneHandler.IsMicOverActive = !microphoneHandler.IsMicOverActive;

            audioSource1.ChannelVolumeHandler.IsMicOverActive = microphoneHandler.IsMicOverActive;
            audioSource2.ChannelVolumeHandler.IsMicOverActive = microphoneHandler.IsMicOverActive;
            btn_micOver.BackColor = microphoneHandler.IsMicOverActive ? Color.Green : SystemColors.Control;
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
                microphoneHandler.Equalizer.Equalizer.Update();
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
                microphoneHandler.Equalizer.Equalizer.Update();
            }
        }
        #endregion

        #region Volume + Faders

        private void UpdateChannelsVolumeHandlers()
        {
            audioSource1.UpdateChannelVolumeHandler(pot_gain_ch1, verticalVolumeSlider_ch1, pot_systemVolume);
            audioSource2.UpdateChannelVolumeHandler(pot_gain_ch2, verticalVolumeSlider_ch2, pot_systemVolume);
        }

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

        private void UpdateMainVolumeMeters()
        {
            float leftLevel = Math.Max(audioSource1.LeftChanelVolumeLevel, audioSource2.LeftChanelVolumeLevel);
            float rightLevel = Math.Max(audioSource1.RightChanelVolumeLevel, audioSource2.RightChanelVolumeLevel);
            volumeMeter_mainLeft.Amplitude = Math.Max(leftLevel, microphoneHandler.MicLeftLevel);
            volumeMeter_mainRight.Amplitude = Math.Max(rightLevel, microphoneHandler.MicRightLevel);
        }

        private void SetupCrossfader()
        {
            UpdateCrossfaderVolumes(crossfaderSlider.Position);
        }

        private void crossfaderSlider_PositionChanged(object sender, EventArgs e)
        {
            UpdateCrossfaderVolumes(crossfaderSlider.Position);
        }

        private void UpdateCrossfaderVolumes(float position)
        {
            audioSource1.ChannelVolumeHandler.SetCrossfadeBalance(position);
            audioSource2.ChannelVolumeHandler.SetCrossfadeBalance(position);
        }

        #endregion

        #region GUI doubleClick
        private void doubleClick(Pot pot)
        {
            pot.Value = 0.5f;
        }

        private void pot_mic_level_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_mic_high_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_mic_low_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_gain_ch1_Load(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_high_ch1_Load(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_mid_ch1_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_low_ch1_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_gain_ch2_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_high_ch2_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_mid_ch2_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_low_ch2_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_filter_ch2_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_headphones_gain_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);

        private void pot_phones_pan_DoubleClick(object sender, EventArgs e) => doubleClick((Pot)sender);
        #endregion



    }
}
