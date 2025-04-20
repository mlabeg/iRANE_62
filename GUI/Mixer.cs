using iRANE_62.Handlers;
using iRANE_62.Models;
using NAudio.Gui;
using NAudio.Wave.SampleProviders;

namespace iRANE_62
{
    public partial class Mixer : Form
    {
        private readonly AudioSourceHandler audioSource1;
        private readonly AudioSourceHandler audioSource2;
        private readonly MicrophoneHandler microphoneHandler;
        private readonly BpmCounterHandler bpmCounterHandler;
        private readonly AudioOutputHandler audioOutputHandler;
        private readonly SystemVolumeHandler systemVolumeHandler;
        private CueButtonHandler cueButtonHandler;
        private List<CheckBox> effectCheckBoxes;

        public EffectParametersHolder EffectHolder;
        public EqSectionHolder EqSectionHolderChannel1;
        public EqSectionHolder EqSectionHolderChannel2;

        public event Action<AudioSourceHandler, TimeSpan, Color> CuePointAdded;

        public Mixer(AudioSourceHandler player1, AudioSourceHandler player2, AudioOutputHandler audioOutputHandler)
        {
            audioSource1 = player1 ?? throw new ArgumentNullException(nameof(player1));
            audioSource2 = player2 ?? throw new ArgumentNullException(nameof(player2));
            this.audioOutputHandler = audioOutputHandler ?? throw new ArgumentNullException(nameof(audioOutputHandler));

            microphoneHandler = new MicrophoneHandler(audioOutputHandler);
            systemVolumeHandler = new SystemVolumeHandler();
            bpmCounterHandler = new BpmCounterHandler();

            InitializeComponent();
            BlockCueButtons();
            BlockLoopButtons();
            InitializeHolders();
            UpdateChannelsVolumeHandlers();
            InitializeEffectCheckBoxes();
            SetupMicrophoneControls();
            SetupVolumeMeters();
            SetupSystemVolume();
            SetupCrossfader();
        }

        #region FX
        private void InitializeEffectCheckBoxes()
        {
            effectCheckBoxes = new List<CheckBox>
                {
                    chBox_efx_echo,
                    chBox_efx_flanger,
                    chBox_efx_filter,
                    chBox_efx_phaser,
                    chBox_efx_reverb,
                    chBox_efx_robot
                };

            foreach (var checkBox in effectCheckBoxes)
            {
                checkBox.CheckedChanged += EffectCheckBox_CheckedChanged;
            }
        }

        private void EffectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = sender as CheckBox;

            if (clickedCheckBox.Checked)
            {
                foreach (var checkBox in effectCheckBoxes)
                {
                    if (checkBox != clickedCheckBox)
                        checkBox.Checked = false;
                }

                EffectHolder.Effect = GetEffectFromCheckBox(clickedCheckBox);
            }
            else
            {
                if (!effectCheckBoxes.Any(cb => cb.Checked))
                {
                    EffectHolder.Effect = EffectsEnum.Disabled;
                }
            }

            UpdateEffect();
            label_Effect_Name.Text = EffectHolder.Effect.ToString();
        }

        private EffectsEnum GetEffectFromCheckBox(CheckBox checkBox)
        {
            return checkBox == chBox_efx_echo ? EffectsEnum.Echo :
                   checkBox == chBox_efx_flanger ? EffectsEnum.Flanger :
                   checkBox == chBox_efx_filter ? EffectsEnum.Filter :
                   checkBox == chBox_efx_phaser ? EffectsEnum.Phaser :
                   checkBox == chBox_efx_reverb ? EffectsEnum.Reverb :
                   checkBox == chBox_efx_robot ? EffectsEnum.Robot :
                   EffectsEnum.Disabled;
        }

        private void chBox_efx_on_CheckedChanged(object sender, EventArgs e)
        {
            EffectHolder.EffectEnabled = chBox_efx_on.Checked;
            UpdateEffect();
        }

        private void Pot_fx_gain_ValueChanged(object sender, EventArgs e)
        {
            EffectHolder.Gain = (float)Pot_fx_gain.Value;
            UpdateEffect();
        }

        private void UpdateEffect()
        {
            if (audioSource1.AudioFileReader != null)
            {
                audioSource1.EffectsHandler.UpdateEffect((float)Pot_fx_gain.Value, chBox_efx_on.Checked && chBox_flexfx_ch1.Checked, EffectHolder.Effect);
            }
            if (audioSource2.AudioFileReader != null)
            {
                audioSource2.EffectsHandler.UpdateEffect((float)Pot_fx_gain.Value, chBox_efx_on.Checked && chBox_flexfx_ch2.Checked, EffectHolder.Effect);
            }
            if (microphoneHandler.EffectsHandler != null)
            {
                microphoneHandler.EffectsHandler.UpdateEffect((float)Pot_fx_gain.Value, chBox_efx_on.Checked && ChBox_mic_fx.Checked, EffectHolder.Effect);
            }
        }

        private void ChBox_mic_fx_CheckedChanged(object sender, EventArgs e) => UpdateEffect();

        private void chBox_flexfx_ch1_CheckedChanged(object sender, EventArgs e) => UpdateEffect();

        private void chBox_flexfx_ch2_CheckedChanged(object sender, EventArgs e) => UpdateEffect();

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

        public void OnPostChanel1VolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter_ch1.Amplitude = Math.Max(e.MaxSampleValues[0], e.MaxSampleValues[1]);
        }

        public void OnPostChanel2VolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter_ch2.Amplitude = Math.Max(e.MaxSampleValues[0], e.MaxSampleValues[1]);
        }

        private void high_ch1_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource1.AudioFileReader != null)
            {
                audioSource1.EqSectionHandler.EqualizerWithBands.UpdateEqHigh((float)pot_high_ch1.Value);
            }
        }

        private void mid_ch1_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource1.AudioFileReader != null)
            {
                audioSource1.EqSectionHandler.EqualizerWithBands.UpdateEqMid((float)pot_mid_ch1.Value);
            }
        }

        private void low_ch1_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource1.AudioFileReader != null)
            {
                audioSource1.EqSectionHandler.EqualizerWithBands.UpdateEqLow((float)pot_low_ch1.Value);
            }
        }

        private void high_ch2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                audioSource2.EqSectionHandler.EqualizerWithBands.UpdateEqHigh((float)pot_high_ch2.Value);
            }
        }

        private void mid_ch2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                audioSource2.EqSectionHandler.EqualizerWithBands.UpdateEqMid((float)pot_mid_ch2.Value);
            }
        }

        private void low_ch2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                audioSource2.EqSectionHandler.EqualizerWithBands.UpdateEqLow((float)pot_low_ch2.Value);
            }
        }

        private void pan_odt1_PanChanged(object sender, EventArgs e)
        {
            if (audioSource1.EqSectionHandler.PanningProvider != null)
            {
                float panValue = (float)panSlider_ch1.Pan;
                audioSource1.EqSectionHandler.PanningProvider.Pan = panValue;
            }
        }

        private void pan_odt2_PanChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                float panValue = (float)panSlider_ch2.Pan;
                audioSource2.EqSectionHandler.PanningProvider.Pan = panValue;
            }
        }

        private void filter_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource1.AudioFileReader != null)
            {
                float potValue = (float)pot_filter_ch1.Value;
                audioSource1.EqSectionHandler.FilterSampleProvider.FilterValue = potValue;
            }
        }

        private void filter_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (audioSource2.AudioFileReader != null)
            {
                float potValue = (float)pot_filter_ch2.Value;
                audioSource2.EqSectionHandler.FilterSampleProvider.FilterValue = potValue;
            }
        }
        #endregion

        #region Loop
        private void loopOut_ch1_Click(object sender, EventArgs e)
        {
            LoopOut(audioSource1);
            btn_loopOut_ch1.BackColor = Color.YellowGreen;
        }

        private void loopIn_ch1_Click(object sender, EventArgs e)
        {
            LoopIn(audioSource1);
            btn_loopIn_ch1.BackColor = Color.YellowGreen;
        }

        private void exitLoop_ch1_Click(object sender, EventArgs e)
        {
            //audioSource1.Loop.LoopActive = false;
            ExitLoop(audioSource1);

            btn_loopIn_ch1.BackColor = Color.White;
            btn_loopOut_ch1.BackColor = Color.White;
        }

        private void loopOut_ch2_Click(object sender, EventArgs e)
        {
            LoopOut(audioSource2);
            btn_loopOut_ch2.BackColor = Color.YellowGreen;
        }

        private void loopIn_ch2_Click(object sender, EventArgs e)
        {
            LoopIn(audioSource2);
            btn_loopIn_ch2.BackColor = Color.YellowGreen;
        }

        private void exitLoop_ch2_Click(object sender, EventArgs e)
        {
            ExitLoop(audioSource2);

            btn_loopIn_ch2.BackColor = Color.White;
            btn_loopOut_ch2.BackColor = Color.White;
        }

        private void LoopIn(AudioSourceHandler audioSource)
        {
            audioSource.Loop.SetLoopIn(audioSource.AudioFileReader.CurrentTime);
        }

        private void LoopOut(AudioSourceHandler audioSource)
        {
            audioSource.Loop.SetLoopOut(audioSource.AudioFileReader.CurrentTime);
        }

        public void ExitLoop(AudioSourceHandler audioSource)
        {
            audioSource.Loop.ExitLoop();
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

        public void EnableLoopButtons(int playerId)
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

        public void InitializeCueButtonHandler()
        {
            if (cueButtonHandler == null)
            {
                cueButtonHandler = new CueButtonHandler();
                cueButtonHandler.CuePointAdded += CuePointAdded;
            }
        }

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
            CueButtonClick(audioSource1, 0, btn_cue1_ch1);
        }
        private void cue2_ch1_Click(object sender, EventArgs e)
        {
            CueButtonClick(audioSource1, 1, btn_cue2_ch1);
        }
        private void cue3_ch1_Click(object sender, EventArgs e)
        {
            CueButtonClick(audioSource1, 2, btn_cue3_ch1);
        }
        private void cue4_ch1_Click(object sender, EventArgs e)
        {
            CueButtonClick(audioSource1, 3, btn_cue4_ch1);
        }
        private void cue5_ch1_Click(object sender, EventArgs e)
        {
            CueButtonClick(audioSource1, 4, btn_cue5_ch1);
        }
        private void cue1_ch2_Click(object sender, EventArgs e)
        {
            CueButtonClick(audioSource2, 0, btn_cue1_ch2);
        }
        private void cue2_ch2_Click(object sender, EventArgs e)
        {

            CueButtonClick(audioSource2, 1, btn_cue2_ch2);
        }
        private void cue3_ch2_Click(object sender, EventArgs e)
        {
            CueButtonClick(audioSource2, 2, btn_cue3_ch2);
        }
        private void cue4_ch2_Click(object sender, EventArgs e)
        {
            CueButtonClick(audioSource2, 3, btn_cue4_ch2);
        }

        private void cue5_ch2_Click(object sender, EventArgs e)
        {
            CueButtonClick(audioSource2, 4, btn_cue5_ch2);
        }

        private void CueButtonClick(AudioSourceHandler player, int cue, Button cueButton)
        {
            cueButtonHandler.CueButtonClick(player, cue, cueButton);
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

        #endregion

        #region Microphone

        private void SetupMicrophoneControls()
        {
            microphoneHandler.VolumeIndicator += OnMicrophoneVolumeMeter;
            microphoneHandler.Volume = (float)pot_mic_level.Value;

            btn_micOnOff.BackColor = microphoneHandler.IsActive ? Color.Green : SystemColors.Control;
            btn_micOver.BackColor = microphoneHandler.IsMicOverActive ? Color.Green : SystemColors.Control;
        }

        private void btn_micOnOff_Click(object sender, EventArgs e)
        {
            microphoneHandler.IsActive = !microphoneHandler.IsActive;
            btn_micOnOff.BackColor = microphoneHandler.IsActive ? Color.Green : SystemColors.Control;

            if (!microphoneHandler.IsActive)
            {
                volumeMeter_mic_volume.Amplitude = 0;
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

        private void OnMicrophoneVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            microphoneHandler.UpdateMicLevels(e.MaxSampleValues[0], e.MaxSampleValues[1]);

            volumeMeter_mic_volume.Amplitude = Math.Max(e.MaxSampleValues[0], e.MaxSampleValues[1]);
            UpdateMainVolumeMeters();
        }

        private void mic_high_ValueChanged(object sender, EventArgs e)
        {
            if (microphoneHandler.Equalizer != null)
            {
                microphoneHandler.Equalizer.UpdateEqHigh((float)pot_mic_high.Value);
            }
        }

        private void mic_low_ValueChanged(object sender, EventArgs e)
        {
            if (microphoneHandler.Equalizer != null)
            {
                microphoneHandler.Equalizer.UpdateEqLow((float)pot_mic_low.Value);
            }
        }
        #endregion

        #region Volume + Faders
        public void CleanVolumeMeters(AudioSourceHandler audioSource)
        {
            if (audioSource.Id == 1)
            {
                volumeMeter_ch1.Amplitude = 0;
            }
            else
            {
                volumeMeter_ch2.Amplitude = 0;
            }
            UpdateMainVolumeMeters();
        }

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

        #endregion

   
    }
}
