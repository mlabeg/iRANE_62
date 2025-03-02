using NAudio;
using NAudio.Wave;

namespace iRANE_62
{
    partial class Mixer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panSlider_ch1 = new NAudio.Gui.PanSlider();
            pot_gain_ch1 = new NAudio.Gui.Pot();
            pot_high_ch1 = new NAudio.Gui.Pot();
            pot_mid_ch1 = new NAudio.Gui.Pot();
            pot_filter_ch1 = new NAudio.Gui.Pot();
            panSlider_ch2 = new NAudio.Gui.PanSlider();
            pot_gain_ch2 = new NAudio.Gui.Pot();
            pot_high_ch2 = new NAudio.Gui.Pot();
            pot_mid_ch2 = new NAudio.Gui.Pot();
            pot_filter_ch2 = new NAudio.Gui.Pot();
            pot_low_ch2 = new NAudio.Gui.Pot();
            pot_mic_level = new NAudio.Gui.Pot();
            pot_mic_high = new NAudio.Gui.Pot();
            pot_mic_low = new NAudio.Gui.Pot();
            btn_micOnOff = new Button();
            btn_micOver = new Button();
            imageList1 = new ImageList(components);
            chBox_flexfx_ch2 = new CheckBox();
            panel_chanel1 = new Panel();
            volumeMeter_ch1 = new NAudio.Gui.VolumeMeter();
            pot_low_ch1 = new NAudio.Gui.Pot();
            chBox_flexfx_ch1 = new CheckBox();
            volumeMeter_mic_volume = new NAudio.Gui.VolumeMeter();
            panel_chanel2 = new Panel();
            volumeMeter_ch2 = new NAudio.Gui.VolumeMeter();
            volumeMeter_mainRight = new NAudio.Gui.VolumeMeter();
            volumeMeter_mainLeft = new NAudio.Gui.VolumeMeter();
            panel_loops1 = new Panel();
            btn_exitLoop_ch1 = new Button();
            btn_loopOut_ch1 = new Button();
            btn_loopIn_ch1 = new Button();
            pot_systemVolume = new NAudio.Gui.Pot();
            chBox_efx_filter = new CheckBox();
            chBox_efx_flanger = new CheckBox();
            chBox_efx_phaser = new CheckBox();
            chBox_efx_echo = new CheckBox();
            chBox_efx_reverb = new CheckBox();
            chBox_efx_robot = new CheckBox();
            chBox_efx_tap = new Button();
            chBox_efx_wyswietlacz = new Panel();
            chBox_efx_on = new CheckBox();
            chBox_efx_cue = new CheckBox();
            pot_efx_depth = new NAudio.Gui.Pot();
            panel_efx = new Panel();
            panel_loops2 = new Panel();
            btn_exitLoop_ch2 = new Button();
            btn_loopOut_ch2 = new Button();
            btn_loopIn_ch2 = new Button();
            btn_cue1_ch1 = new Button();
            btn_cue2_ch1 = new Button();
            btn_cue3_ch1 = new Button();
            btn_cue4_ch1 = new Button();
            btn_cue5_ch1 = new Button();
            btn_cue1_ch2 = new Button();
            btn_cue3_ch2 = new Button();
            btn_cue2_ch2 = new Button();
            btn_cue4_ch2 = new Button();
            btn_cue5_ch2 = new Button();
            panel_cue = new Panel();
            chBox_cue_samples = new CheckBox();
            chBox_cue_ch1 = new CheckBox();
            chBox_cue_ch2 = new CheckBox();
            panel_phones = new Panel();
            chBox_phones_split = new CheckBox();
            pot_phones_level = new NAudio.Gui.Pot();
            pot_phones_pan = new NAudio.Gui.Pot();
            panel_mic = new Panel();
            chBox_mic_flexfx = new CheckBox();
            fader_crossfader = new NAudio.Gui.Fader();
            panel_volume = new Panel();
            verticalVolumeSlider_ch1 = new Controls.VerticalVolumeSlider();
            verticalVolumeSlider_ch2 = new Controls.VerticalVolumeSlider();
            panel_chanel1.SuspendLayout();
            panel_chanel2.SuspendLayout();
            panel_loops1.SuspendLayout();
            panel_efx.SuspendLayout();
            panel_loops2.SuspendLayout();
            panel_cue.SuspendLayout();
            panel_phones.SuspendLayout();
            panel_mic.SuspendLayout();
            panel_volume.SuspendLayout();
            SuspendLayout();
            // 
            // panSlider_ch1
            // 
            panSlider_ch1.Location = new Point(24, 58);
            panSlider_ch1.Margin = new Padding(2);
            panSlider_ch1.Name = "panSlider_ch1";
            panSlider_ch1.Pan = 0F;
            panSlider_ch1.Size = new Size(66, 32);
            panSlider_ch1.TabIndex = 1;
            panSlider_ch1.PanChanged += pan_odt1_PanChanged;
            // 
            // pot_gain_ch1
            // 
            pot_gain_ch1.Location = new Point(409, 39);
            pot_gain_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_gain_ch1.Maximum = 1D;
            pot_gain_ch1.Minimum = 0D;
            pot_gain_ch1.Name = "pot_gain_ch1";
            pot_gain_ch1.Size = new Size(43, 55);
            pot_gain_ch1.TabIndex = 3;
            pot_gain_ch1.Value = 0.5D;
            pot_gain_ch1.ValueChanged += level_odt1_ValueChanged;
            // 
            // pot_high_ch1
            // 
            pot_high_ch1.Location = new Point(409, 118);
            pot_high_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_high_ch1.Maximum = 30D;
            pot_high_ch1.Minimum = -30D;
            pot_high_ch1.Name = "pot_high_ch1";
            pot_high_ch1.Size = new Size(43, 55);
            pot_high_ch1.TabIndex = 3;
            pot_high_ch1.Value = 0D;
            pot_high_ch1.ValueChanged += high_odt1_ValueChanged;
            // 
            // pot_mid_ch1
            // 
            pot_mid_ch1.Location = new Point(409, 194);
            pot_mid_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_mid_ch1.Maximum = 30D;
            pot_mid_ch1.Minimum = -30D;
            pot_mid_ch1.Name = "pot_mid_ch1";
            pot_mid_ch1.Size = new Size(43, 55);
            pot_mid_ch1.TabIndex = 3;
            pot_mid_ch1.Value = 0D;
            pot_mid_ch1.ValueChanged += mid_odt1_ValueChanged;
            // 
            // pot_filter_ch1
            // 
            pot_filter_ch1.Location = new Point(30, 133);
            pot_filter_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_filter_ch1.Maximum = 1D;
            pot_filter_ch1.Minimum = -1D;
            pot_filter_ch1.Name = "pot_filter_ch1";
            pot_filter_ch1.Size = new Size(43, 55);
            pot_filter_ch1.TabIndex = 3;
            pot_filter_ch1.Value = 0D;
            pot_filter_ch1.ValueChanged += filter_odt1_ValueChanged;
            // 
            // panSlider_ch2
            // 
            panSlider_ch2.Location = new Point(110, 58);
            panSlider_ch2.Margin = new Padding(2);
            panSlider_ch2.Name = "panSlider_ch2";
            panSlider_ch2.Pan = 0F;
            panSlider_ch2.Size = new Size(66, 32);
            panSlider_ch2.TabIndex = 1;
            panSlider_ch2.PanChanged += pan_odt2_PanChanged;
            // 
            // pot_gain_ch2
            // 
            pot_gain_ch2.Location = new Point(540, 39);
            pot_gain_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_gain_ch2.Maximum = 1D;
            pot_gain_ch2.Minimum = 0D;
            pot_gain_ch2.Name = "pot_gain_ch2";
            pot_gain_ch2.Size = new Size(43, 55);
            pot_gain_ch2.TabIndex = 3;
            pot_gain_ch2.Value = 0.5D;
            pot_gain_ch2.ValueChanged += level_odt2_ValueChanged;
            // 
            // pot_high_ch2
            // 
            pot_high_ch2.Location = new Point(540, 118);
            pot_high_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_high_ch2.Maximum = 30D;
            pot_high_ch2.Minimum = -30D;
            pot_high_ch2.Name = "pot_high_ch2";
            pot_high_ch2.Size = new Size(43, 55);
            pot_high_ch2.TabIndex = 3;
            pot_high_ch2.Value = 0D;
            pot_high_ch2.ValueChanged += high_odt2_ValueChanged;
            // 
            // pot_mid_ch2
            // 
            pot_mid_ch2.Location = new Point(540, 194);
            pot_mid_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_mid_ch2.Maximum = 30D;
            pot_mid_ch2.Minimum = -30D;
            pot_mid_ch2.Name = "pot_mid_ch2";
            pot_mid_ch2.Size = new Size(43, 55);
            pot_mid_ch2.TabIndex = 3;
            pot_mid_ch2.Value = 0D;
            pot_mid_ch2.ValueChanged += mid_odt2_ValueChanged;
            // 
            // pot_filter_ch2
            // 
            pot_filter_ch2.Location = new Point(133, 133);
            pot_filter_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_filter_ch2.Maximum = 1D;
            pot_filter_ch2.Minimum = -1D;
            pot_filter_ch2.Name = "pot_filter_ch2";
            pot_filter_ch2.Size = new Size(43, 55);
            pot_filter_ch2.TabIndex = 3;
            pot_filter_ch2.Value = 0D;
            pot_filter_ch2.ValueChanged += filter_odt2_ValueChanged;
            // 
            // pot_low_ch2
            // 
            pot_low_ch2.Location = new Point(540, 273);
            pot_low_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_low_ch2.Maximum = 30D;
            pot_low_ch2.Minimum = -30D;
            pot_low_ch2.Name = "pot_low_ch2";
            pot_low_ch2.Size = new Size(43, 55);
            pot_low_ch2.TabIndex = 3;
            pot_low_ch2.Value = 0D;
            pot_low_ch2.ValueChanged += low_odt2_ValueChanged;
            // 
            // pot_mic_level
            // 
            pot_mic_level.Location = new Point(31, 58);
            pot_mic_level.Margin = new Padding(4, 5, 4, 5);
            pot_mic_level.Maximum = 1D;
            pot_mic_level.Minimum = 0D;
            pot_mic_level.Name = "pot_mic_level";
            pot_mic_level.Size = new Size(43, 55);
            pot_mic_level.TabIndex = 3;
            pot_mic_level.Value = 0.5D;
            pot_mic_level.ValueChanged += mic_level_ValueChanged;
            // 
            // pot_mic_high
            // 
            pot_mic_high.Location = new Point(116, 167);
            pot_mic_high.Margin = new Padding(4, 5, 4, 5);
            pot_mic_high.Maximum = 30D;
            pot_mic_high.Minimum = -30D;
            pot_mic_high.Name = "pot_mic_high";
            pot_mic_high.Size = new Size(43, 55);
            pot_mic_high.TabIndex = 3;
            pot_mic_high.Value = 0.5D;
            pot_mic_high.ValueChanged += mic_high_ValueChanged;
            // 
            // pot_mic_low
            // 
            pot_mic_low.Location = new Point(116, 244);
            pot_mic_low.Margin = new Padding(4, 5, 4, 5);
            pot_mic_low.Maximum = 30D;
            pot_mic_low.Minimum = -30D;
            pot_mic_low.Name = "pot_mic_low";
            pot_mic_low.Size = new Size(43, 55);
            pot_mic_low.TabIndex = 3;
            pot_mic_low.Value = 0.5D;
            pot_mic_low.ValueChanged += mic_low_ValueChanged;
            // 
            // btn_micOnOff
            // 
            btn_micOnOff.Location = new Point(17, 21);
            btn_micOnOff.Margin = new Padding(2);
            btn_micOnOff.Name = "btn_micOnOff";
            btn_micOnOff.Size = new Size(43, 26);
            btn_micOnOff.TabIndex = 4;
            btn_micOnOff.Text = "ON";
            btn_micOnOff.UseVisualStyleBackColor = true;
            btn_micOnOff.Click += btn_micOnOff_Click;
            // 
            // btn_micOver
            // 
            btn_micOver.Location = new Point(75, 21);
            btn_micOver.Margin = new Padding(2);
            btn_micOver.Name = "btn_micOver";
            btn_micOver.Size = new Size(43, 26);
            btn_micOver.TabIndex = 4;
            btn_micOver.Text = "OVER";
            btn_micOver.UseVisualStyleBackColor = true;
            btn_micOver.Click += btn_micOver_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // chBox_flexfx_ch2
            // 
            chBox_flexfx_ch2.AutoSize = true;
            chBox_flexfx_ch2.Location = new Point(119, 223);
            chBox_flexfx_ch2.Margin = new Padding(2);
            chBox_flexfx_ch2.Name = "chBox_flexfx_ch2";
            chBox_flexfx_ch2.Size = new Size(78, 24);
            chBox_flexfx_ch2.TabIndex = 5;
            chBox_flexfx_ch2.Text = "FLEXFX";
            chBox_flexfx_ch2.UseVisualStyleBackColor = true;
            // 
            // panel_chanel1
            // 
            panel_chanel1.BorderStyle = BorderStyle.FixedSingle;
            panel_chanel1.Controls.Add(volumeMeter_ch1);
            panel_chanel1.Controls.Add(pot_low_ch1);
            panel_chanel1.Controls.Add(chBox_flexfx_ch1);
            panel_chanel1.Controls.Add(panSlider_ch1);
            panel_chanel1.Controls.Add(pot_filter_ch1);
            panel_chanel1.Location = new Point(258, 33);
            panel_chanel1.Margin = new Padding(2);
            panel_chanel1.Name = "panel_chanel1";
            panel_chanel1.Size = new Size(233, 319);
            panel_chanel1.TabIndex = 7;
            // 
            // volumeMeter_ch1
            // 
            volumeMeter_ch1.Amplitude = 0F;
            volumeMeter_ch1.Location = new Point(117, 21);
            volumeMeter_ch1.Margin = new Padding(2);
            volumeMeter_ch1.MaxDb = 18F;
            volumeMeter_ch1.MinDb = -60F;
            volumeMeter_ch1.Name = "volumeMeter_ch1";
            volumeMeter_ch1.Size = new Size(24, 282);
            volumeMeter_ch1.TabIndex = 12;
            volumeMeter_ch1.Text = "volumeMeter1";
            // 
            // pot_low_ch1
            // 
            pot_low_ch1.Location = new Point(150, 240);
            pot_low_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_low_ch1.Maximum = 30D;
            pot_low_ch1.Minimum = -30D;
            pot_low_ch1.Name = "pot_low_ch1";
            pot_low_ch1.Size = new Size(43, 55);
            pot_low_ch1.TabIndex = 3;
            pot_low_ch1.Value = 0D;
            pot_low_ch1.ValueChanged += low_odt1_ValueChanged;
            // 
            // chBox_flexfx_ch1
            // 
            chBox_flexfx_ch1.AutoSize = true;
            chBox_flexfx_ch1.Location = new Point(8, 223);
            chBox_flexfx_ch1.Margin = new Padding(2);
            chBox_flexfx_ch1.Name = "chBox_flexfx_ch1";
            chBox_flexfx_ch1.Size = new Size(82, 24);
            chBox_flexfx_ch1.TabIndex = 5;
            chBox_flexfx_ch1.Text = "FLEX FX";
            chBox_flexfx_ch1.UseVisualStyleBackColor = true;
            // 
            // volumeMeter_mic_volume
            // 
            volumeMeter_mic_volume.Amplitude = 0F;
            volumeMeter_mic_volume.Location = new Point(94, 58);
            volumeMeter_mic_volume.Margin = new Padding(2);
            volumeMeter_mic_volume.MaxDb = 18F;
            volumeMeter_mic_volume.MinDb = -60F;
            volumeMeter_mic_volume.Name = "volumeMeter_mic_volume";
            volumeMeter_mic_volume.Size = new Size(24, 217);
            volumeMeter_mic_volume.TabIndex = 12;
            volumeMeter_mic_volume.Text = "volumeMeter1";
            // 
            // panel_chanel2
            // 
            panel_chanel2.BorderStyle = BorderStyle.FixedSingle;
            panel_chanel2.Controls.Add(volumeMeter_ch2);
            panel_chanel2.Controls.Add(panSlider_ch2);
            panel_chanel2.Controls.Add(pot_filter_ch2);
            panel_chanel2.Controls.Add(chBox_flexfx_ch2);
            panel_chanel2.Location = new Point(522, 33);
            panel_chanel2.Margin = new Padding(2);
            panel_chanel2.Name = "panel_chanel2";
            panel_chanel2.Size = new Size(201, 319);
            panel_chanel2.TabIndex = 7;
            // 
            // volumeMeter_ch2
            // 
            volumeMeter_ch2.Amplitude = 0F;
            volumeMeter_ch2.Location = new Point(78, 21);
            volumeMeter_ch2.Margin = new Padding(2);
            volumeMeter_ch2.MaxDb = 18F;
            volumeMeter_ch2.MinDb = -60F;
            volumeMeter_ch2.Name = "volumeMeter_ch2";
            volumeMeter_ch2.Size = new Size(24, 282);
            volumeMeter_ch2.TabIndex = 12;
            volumeMeter_ch2.Text = "volumeMeter1";
            // 
            // volumeMeter_mainRight
            // 
            volumeMeter_mainRight.Amplitude = 0F;
            volumeMeter_mainRight.Location = new Point(86, 21);
            volumeMeter_mainRight.Margin = new Padding(2);
            volumeMeter_mainRight.MaxDb = 18F;
            volumeMeter_mainRight.MinDb = -60F;
            volumeMeter_mainRight.Name = "volumeMeter_mainRight";
            volumeMeter_mainRight.Size = new Size(24, 282);
            volumeMeter_mainRight.TabIndex = 12;
            volumeMeter_mainRight.Text = "volumeMeter1";
            // 
            // volumeMeter_mainLeft
            // 
            volumeMeter_mainLeft.Amplitude = 0F;
            volumeMeter_mainLeft.Location = new Point(30, 21);
            volumeMeter_mainLeft.Margin = new Padding(2);
            volumeMeter_mainLeft.MaxDb = 18F;
            volumeMeter_mainLeft.MinDb = -60F;
            volumeMeter_mainLeft.Name = "volumeMeter_mainLeft";
            volumeMeter_mainLeft.Size = new Size(24, 282);
            volumeMeter_mainLeft.TabIndex = 12;
            volumeMeter_mainLeft.Text = "volumeMeter1";
            // 
            // panel_loops1
            // 
            panel_loops1.BorderStyle = BorderStyle.FixedSingle;
            panel_loops1.Controls.Add(btn_exitLoop_ch1);
            panel_loops1.Controls.Add(btn_loopOut_ch1);
            panel_loops1.Controls.Add(btn_loopIn_ch1);
            panel_loops1.Location = new Point(10, 142);
            panel_loops1.Margin = new Padding(2);
            panel_loops1.Name = "panel_loops1";
            panel_loops1.Size = new Size(70, 210);
            panel_loops1.TabIndex = 7;
            // 
            // btn_exitLoop_ch1
            // 
            btn_exitLoop_ch1.Location = new Point(12, 145);
            btn_exitLoop_ch1.Margin = new Padding(2);
            btn_exitLoop_ch1.Name = "btn_exitLoop_ch1";
            btn_exitLoop_ch1.Size = new Size(45, 45);
            btn_exitLoop_ch1.TabIndex = 4;
            btn_exitLoop_ch1.Text = "Exit";
            btn_exitLoop_ch1.UseVisualStyleBackColor = true;
            btn_exitLoop_ch1.Click += exitLoop_ch1_Click;
            // 
            // btn_loopOut_ch1
            // 
            btn_loopOut_ch1.Location = new Point(12, 82);
            btn_loopOut_ch1.Margin = new Padding(2);
            btn_loopOut_ch1.Name = "btn_loopOut_ch1";
            btn_loopOut_ch1.Size = new Size(45, 45);
            btn_loopOut_ch1.TabIndex = 4;
            btn_loopOut_ch1.Text = "Out";
            btn_loopOut_ch1.UseVisualStyleBackColor = true;
            btn_loopOut_ch1.Click += loopOut_ch1_Click;
            // 
            // btn_loopIn_ch1
            // 
            btn_loopIn_ch1.Location = new Point(12, 21);
            btn_loopIn_ch1.Margin = new Padding(2);
            btn_loopIn_ch1.Name = "btn_loopIn_ch1";
            btn_loopIn_ch1.Size = new Size(45, 45);
            btn_loopIn_ch1.TabIndex = 4;
            btn_loopIn_ch1.Text = "In";
            btn_loopIn_ch1.UseVisualStyleBackColor = true;
            btn_loopIn_ch1.Click += loopIn_ch1_Click;
            // 
            // pot_systemVolume
            // 
            pot_systemVolume.Location = new Point(913, 39);
            pot_systemVolume.Margin = new Padding(4, 5, 4, 5);
            pot_systemVolume.Maximum = 1D;
            pot_systemVolume.Minimum = 0D;
            pot_systemVolume.Name = "pot_systemVolume";
            pot_systemVolume.Size = new Size(43, 55);
            pot_systemVolume.TabIndex = 3;
            pot_systemVolume.Value = 0.5D;
            pot_systemVolume.ValueChanged += pot_mainVolume_ValueChanged;
            // 
            // chBox_efx_filter
            // 
            chBox_efx_filter.AutoSize = true;
            chBox_efx_filter.Location = new Point(203, 385);
            chBox_efx_filter.Margin = new Padding(2);
            chBox_efx_filter.Name = "chBox_efx_filter";
            chBox_efx_filter.Size = new Size(73, 24);
            chBox_efx_filter.TabIndex = 5;
            chBox_efx_filter.Text = "FILTER";
            chBox_efx_filter.UseVisualStyleBackColor = true;
            chBox_efx_filter.CheckedChanged += efx_filter_CheckedChanged;
            // 
            // chBox_efx_flanger
            // 
            chBox_efx_flanger.AutoSize = true;
            chBox_efx_flanger.Location = new Point(305, 385);
            chBox_efx_flanger.Margin = new Padding(2);
            chBox_efx_flanger.Name = "chBox_efx_flanger";
            chBox_efx_flanger.Size = new Size(93, 24);
            chBox_efx_flanger.TabIndex = 5;
            chBox_efx_flanger.Text = "FLANGER";
            chBox_efx_flanger.UseVisualStyleBackColor = true;
            chBox_efx_flanger.CheckedChanged += efx_flanger_CheckedChanged;
            // 
            // chBox_efx_phaser
            // 
            chBox_efx_phaser.AutoSize = true;
            chBox_efx_phaser.Location = new Point(406, 385);
            chBox_efx_phaser.Margin = new Padding(2);
            chBox_efx_phaser.Name = "chBox_efx_phaser";
            chBox_efx_phaser.Size = new Size(85, 24);
            chBox_efx_phaser.TabIndex = 5;
            chBox_efx_phaser.Text = "PHASER";
            chBox_efx_phaser.UseVisualStyleBackColor = true;
            chBox_efx_phaser.CheckedChanged += efx_phaser_CheckedChanged;
            // 
            // chBox_efx_echo
            // 
            chBox_efx_echo.AutoSize = true;
            chBox_efx_echo.Location = new Point(508, 385);
            chBox_efx_echo.Margin = new Padding(2);
            chBox_efx_echo.Name = "chBox_efx_echo";
            chBox_efx_echo.Size = new Size(70, 24);
            chBox_efx_echo.TabIndex = 5;
            chBox_efx_echo.Text = "ECHO";
            chBox_efx_echo.UseVisualStyleBackColor = true;
            chBox_efx_echo.CheckedChanged += efx_echo_CheckedChanged;
            // 
            // chBox_efx_reverb
            // 
            chBox_efx_reverb.AutoSize = true;
            chBox_efx_reverb.Location = new Point(711, 385);
            chBox_efx_reverb.Margin = new Padding(2);
            chBox_efx_reverb.Name = "chBox_efx_reverb";
            chBox_efx_reverb.Size = new Size(83, 24);
            chBox_efx_reverb.TabIndex = 5;
            chBox_efx_reverb.Text = "REVERB";
            chBox_efx_reverb.UseVisualStyleBackColor = true;
            chBox_efx_reverb.CheckedChanged += efx_reverb_CheckedChanged;
            // 
            // chBox_efx_robot
            // 
            chBox_efx_robot.AutoSize = true;
            chBox_efx_robot.Location = new Point(610, 385);
            chBox_efx_robot.Margin = new Padding(2);
            chBox_efx_robot.Name = "chBox_efx_robot";
            chBox_efx_robot.Size = new Size(78, 24);
            chBox_efx_robot.TabIndex = 5;
            chBox_efx_robot.Text = "ROBOT";
            chBox_efx_robot.UseVisualStyleBackColor = true;
            chBox_efx_robot.CheckedChanged += efx_robot_CheckedChanged;
            // 
            // chBox_efx_tap
            // 
            chBox_efx_tap.Location = new Point(114, 99);
            chBox_efx_tap.Margin = new Padding(2);
            chBox_efx_tap.Name = "chBox_efx_tap";
            chBox_efx_tap.Size = new Size(43, 26);
            chBox_efx_tap.TabIndex = 4;
            chBox_efx_tap.Text = "TAP";
            chBox_efx_tap.UseVisualStyleBackColor = true;
            // 
            // chBox_efx_wyswietlacz
            // 
            chBox_efx_wyswietlacz.Location = new Point(198, 61);
            chBox_efx_wyswietlacz.Margin = new Padding(2);
            chBox_efx_wyswietlacz.Name = "chBox_efx_wyswietlacz";
            chBox_efx_wyswietlacz.Size = new Size(208, 107);
            chBox_efx_wyswietlacz.TabIndex = 9;
            // 
            // chBox_efx_on
            // 
            chBox_efx_on.AutoSize = true;
            chBox_efx_on.Location = new Point(437, 99);
            chBox_efx_on.Margin = new Padding(2);
            chBox_efx_on.Name = "chBox_efx_on";
            chBox_efx_on.Size = new Size(53, 24);
            chBox_efx_on.TabIndex = 5;
            chBox_efx_on.Text = "ON";
            chBox_efx_on.UseVisualStyleBackColor = true;
            // 
            // chBox_efx_cue
            // 
            chBox_efx_cue.AutoSize = true;
            chBox_efx_cue.Location = new Point(539, 99);
            chBox_efx_cue.Margin = new Padding(2);
            chBox_efx_cue.Name = "chBox_efx_cue";
            chBox_efx_cue.Size = new Size(58, 24);
            chBox_efx_cue.TabIndex = 5;
            chBox_efx_cue.Text = "CUE";
            chBox_efx_cue.UseVisualStyleBackColor = true;
            // 
            // pot_efx_depth
            // 
            pot_efx_depth.Location = new Point(655, 84);
            pot_efx_depth.Margin = new Padding(4, 5, 4, 5);
            pot_efx_depth.Maximum = 10D;
            pot_efx_depth.Minimum = 0D;
            pot_efx_depth.Name = "pot_efx_depth";
            pot_efx_depth.Size = new Size(43, 55);
            pot_efx_depth.TabIndex = 3;
            pot_efx_depth.Value = 0D;
            // 
            // panel_efx
            // 
            panel_efx.BorderStyle = BorderStyle.FixedSingle;
            panel_efx.Controls.Add(chBox_efx_tap);
            panel_efx.Controls.Add(chBox_efx_on);
            panel_efx.Controls.Add(chBox_efx_cue);
            panel_efx.Controls.Add(pot_efx_depth);
            panel_efx.Controls.Add(chBox_efx_wyswietlacz);
            panel_efx.Location = new Point(84, 366);
            panel_efx.Margin = new Padding(2);
            panel_efx.Name = "panel_efx";
            panel_efx.Size = new Size(802, 186);
            panel_efx.TabIndex = 7;
            // 
            // panel_loops2
            // 
            panel_loops2.BorderStyle = BorderStyle.FixedSingle;
            panel_loops2.Controls.Add(btn_exitLoop_ch2);
            panel_loops2.Controls.Add(btn_loopOut_ch2);
            panel_loops2.Controls.Add(btn_loopIn_ch2);
            panel_loops2.Location = new Point(901, 142);
            panel_loops2.Margin = new Padding(2);
            panel_loops2.Name = "panel_loops2";
            panel_loops2.Size = new Size(70, 210);
            panel_loops2.TabIndex = 7;
            // 
            // btn_exitLoop_ch2
            // 
            btn_exitLoop_ch2.Location = new Point(9, 145);
            btn_exitLoop_ch2.Margin = new Padding(2);
            btn_exitLoop_ch2.Name = "btn_exitLoop_ch2";
            btn_exitLoop_ch2.Size = new Size(45, 45);
            btn_exitLoop_ch2.TabIndex = 4;
            btn_exitLoop_ch2.Text = "Exit";
            btn_exitLoop_ch2.UseVisualStyleBackColor = true;
            btn_exitLoop_ch2.Click += exitLoop_ch2_Click;
            // 
            // btn_loopOut_ch2
            // 
            btn_loopOut_ch2.Location = new Point(9, 82);
            btn_loopOut_ch2.Margin = new Padding(2);
            btn_loopOut_ch2.Name = "btn_loopOut_ch2";
            btn_loopOut_ch2.Size = new Size(45, 45);
            btn_loopOut_ch2.TabIndex = 4;
            btn_loopOut_ch2.Text = "Out";
            btn_loopOut_ch2.UseVisualStyleBackColor = true;
            btn_loopOut_ch2.Click += loopOut_ch2_Click;
            // 
            // btn_loopIn_ch2
            // 
            btn_loopIn_ch2.Location = new Point(9, 21);
            btn_loopIn_ch2.Margin = new Padding(2);
            btn_loopIn_ch2.Name = "btn_loopIn_ch2";
            btn_loopIn_ch2.Size = new Size(45, 45);
            btn_loopIn_ch2.TabIndex = 4;
            btn_loopIn_ch2.Text = "In";
            btn_loopIn_ch2.UseVisualStyleBackColor = true;
            btn_loopIn_ch2.Click += loopIn_ch2_Click;
            // 
            // btn_cue1_ch1
            // 
            btn_cue1_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue1_ch1.Location = new Point(17, 23);
            btn_cue1_ch1.Margin = new Padding(2);
            btn_cue1_ch1.Name = "btn_cue1_ch1";
            btn_cue1_ch1.Size = new Size(57, 26);
            btn_cue1_ch1.TabIndex = 4;
            btn_cue1_ch1.Text = "CUE1";
            btn_cue1_ch1.UseVisualStyleBackColor = true;
            btn_cue1_ch1.Click += cue1_ch1_Click;
            // 
            // btn_cue2_ch1
            // 
            btn_cue2_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue2_ch1.Location = new Point(78, 23);
            btn_cue2_ch1.Margin = new Padding(2);
            btn_cue2_ch1.Name = "btn_cue2_ch1";
            btn_cue2_ch1.Size = new Size(56, 26);
            btn_cue2_ch1.TabIndex = 4;
            btn_cue2_ch1.Text = "CUE2";
            btn_cue2_ch1.UseVisualStyleBackColor = true;
            btn_cue2_ch1.Click += cue2_ch1_Click;
            // 
            // btn_cue3_ch1
            // 
            btn_cue3_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue3_ch1.Location = new Point(138, 23);
            btn_cue3_ch1.Margin = new Padding(2);
            btn_cue3_ch1.Name = "btn_cue3_ch1";
            btn_cue3_ch1.Size = new Size(57, 26);
            btn_cue3_ch1.TabIndex = 4;
            btn_cue3_ch1.Text = "CUE3";
            btn_cue3_ch1.UseVisualStyleBackColor = true;
            btn_cue3_ch1.Click += cue3_ch1_Click;
            // 
            // btn_cue4_ch1
            // 
            btn_cue4_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue4_ch1.Location = new Point(199, 23);
            btn_cue4_ch1.Margin = new Padding(2);
            btn_cue4_ch1.Name = "btn_cue4_ch1";
            btn_cue4_ch1.Size = new Size(50, 26);
            btn_cue4_ch1.TabIndex = 4;
            btn_cue4_ch1.Text = "CUE4";
            btn_cue4_ch1.UseVisualStyleBackColor = true;
            btn_cue4_ch1.Click += cue4_ch1_Click;
            // 
            // btn_cue5_ch1
            // 
            btn_cue5_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue5_ch1.Location = new Point(253, 23);
            btn_cue5_ch1.Margin = new Padding(2);
            btn_cue5_ch1.Name = "btn_cue5_ch1";
            btn_cue5_ch1.Size = new Size(54, 26);
            btn_cue5_ch1.TabIndex = 4;
            btn_cue5_ch1.Text = "CUE5";
            btn_cue5_ch1.UseVisualStyleBackColor = true;
            btn_cue5_ch1.Click += cue5_ch1_Click;
            // 
            // btn_cue1_ch2
            // 
            btn_cue1_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue1_ch2.Location = new Point(478, 23);
            btn_cue1_ch2.Margin = new Padding(2);
            btn_cue1_ch2.Name = "btn_cue1_ch2";
            btn_cue1_ch2.Size = new Size(57, 26);
            btn_cue1_ch2.TabIndex = 4;
            btn_cue1_ch2.Text = "CUE1";
            btn_cue1_ch2.UseVisualStyleBackColor = true;
            btn_cue1_ch2.Click += cue1_ch2_Click;
            // 
            // btn_cue3_ch2
            // 
            btn_cue3_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue3_ch2.Location = new Point(599, 23);
            btn_cue3_ch2.Margin = new Padding(2);
            btn_cue3_ch2.Name = "btn_cue3_ch2";
            btn_cue3_ch2.Size = new Size(57, 26);
            btn_cue3_ch2.TabIndex = 4;
            btn_cue3_ch2.Text = "CUE3";
            btn_cue3_ch2.UseVisualStyleBackColor = true;
            btn_cue3_ch2.Click += cue3_ch2_Click;
            // 
            // btn_cue2_ch2
            // 
            btn_cue2_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue2_ch2.Location = new Point(539, 23);
            btn_cue2_ch2.Margin = new Padding(2);
            btn_cue2_ch2.Name = "btn_cue2_ch2";
            btn_cue2_ch2.Size = new Size(56, 26);
            btn_cue2_ch2.TabIndex = 4;
            btn_cue2_ch2.Text = "CUE2";
            btn_cue2_ch2.UseVisualStyleBackColor = true;
            btn_cue2_ch2.Click += cue2_ch2_Click;
            // 
            // btn_cue4_ch2
            // 
            btn_cue4_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue4_ch2.Location = new Point(660, 23);
            btn_cue4_ch2.Margin = new Padding(2);
            btn_cue4_ch2.Name = "btn_cue4_ch2";
            btn_cue4_ch2.Size = new Size(50, 26);
            btn_cue4_ch2.TabIndex = 4;
            btn_cue4_ch2.Text = "CUE4";
            btn_cue4_ch2.UseVisualStyleBackColor = true;
            btn_cue4_ch2.Click += cue4_ch2_Click;
            // 
            // btn_cue5_ch2
            // 
            btn_cue5_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue5_ch2.Location = new Point(714, 23);
            btn_cue5_ch2.Margin = new Padding(2);
            btn_cue5_ch2.Name = "btn_cue5_ch2";
            btn_cue5_ch2.Size = new Size(54, 26);
            btn_cue5_ch2.TabIndex = 4;
            btn_cue5_ch2.Text = "CUE5";
            btn_cue5_ch2.UseVisualStyleBackColor = true;
            btn_cue5_ch2.Click += cue5_ch2_Click;
            // 
            // panel_cue
            // 
            panel_cue.BorderStyle = BorderStyle.FixedSingle;
            panel_cue.Controls.Add(chBox_cue_samples);
            panel_cue.Controls.Add(btn_cue5_ch1);
            panel_cue.Controls.Add(btn_cue5_ch2);
            panel_cue.Controls.Add(btn_cue4_ch2);
            panel_cue.Controls.Add(btn_cue3_ch2);
            panel_cue.Controls.Add(btn_cue2_ch2);
            panel_cue.Controls.Add(btn_cue1_ch2);
            panel_cue.Controls.Add(btn_cue1_ch1);
            panel_cue.Controls.Add(btn_cue2_ch1);
            panel_cue.Controls.Add(btn_cue3_ch1);
            panel_cue.Controls.Add(btn_cue4_ch1);
            panel_cue.Location = new Point(84, 570);
            panel_cue.Margin = new Padding(2);
            panel_cue.Name = "panel_cue";
            panel_cue.Size = new Size(802, 83);
            panel_cue.TabIndex = 7;
            // 
            // chBox_cue_samples
            // 
            chBox_cue_samples.AutoSize = true;
            chBox_cue_samples.Location = new Point(343, 23);
            chBox_cue_samples.Margin = new Padding(2);
            chBox_cue_samples.Name = "chBox_cue_samples";
            chBox_cue_samples.Size = new Size(101, 24);
            chBox_cue_samples.TabIndex = 5;
            chBox_cue_samples.Text = "checkBox1";
            chBox_cue_samples.UseVisualStyleBackColor = true;
            // 
            // chBox_cue_ch1
            // 
            chBox_cue_ch1.AutoSize = true;
            chBox_cue_ch1.Location = new Point(141, 702);
            chBox_cue_ch1.Margin = new Padding(2);
            chBox_cue_ch1.Name = "chBox_cue_ch1";
            chBox_cue_ch1.Size = new Size(105, 24);
            chBox_cue_ch1.TabIndex = 5;
            chBox_cue_ch1.Text = "CUE PGM 1";
            chBox_cue_ch1.UseVisualStyleBackColor = true;
            // 
            // chBox_cue_ch2
            // 
            chBox_cue_ch2.AutoSize = true;
            chBox_cue_ch2.Location = new Point(711, 702);
            chBox_cue_ch2.Margin = new Padding(2);
            chBox_cue_ch2.Name = "chBox_cue_ch2";
            chBox_cue_ch2.Size = new Size(105, 24);
            chBox_cue_ch2.TabIndex = 5;
            chBox_cue_ch2.Text = "CUE PGM 2";
            chBox_cue_ch2.UseVisualStyleBackColor = true;
            // 
            // panel_phones
            // 
            panel_phones.BorderStyle = BorderStyle.FixedSingle;
            panel_phones.Controls.Add(chBox_phones_split);
            panel_phones.Controls.Add(pot_phones_level);
            panel_phones.Controls.Add(pot_phones_pan);
            panel_phones.Location = new Point(901, 628);
            panel_phones.Margin = new Padding(2);
            panel_phones.Name = "panel_phones";
            panel_phones.Size = new Size(70, 215);
            panel_phones.TabIndex = 10;
            // 
            // chBox_phones_split
            // 
            chBox_phones_split.AutoSize = true;
            chBox_phones_split.Location = new Point(15, 171);
            chBox_phones_split.Margin = new Padding(2);
            chBox_phones_split.Name = "chBox_phones_split";
            chBox_phones_split.Size = new Size(97, 24);
            chBox_phones_split.TabIndex = 5;
            chBox_phones_split.Text = "SPLIT CUE";
            chBox_phones_split.UseVisualStyleBackColor = true;
            // 
            // pot_phones_level
            // 
            pot_phones_level.Location = new Point(11, 23);
            pot_phones_level.Margin = new Padding(4, 5, 4, 5);
            pot_phones_level.Maximum = 1D;
            pot_phones_level.Minimum = 0D;
            pot_phones_level.Name = "pot_phones_level";
            pot_phones_level.Size = new Size(43, 55);
            pot_phones_level.TabIndex = 3;
            pot_phones_level.Value = 0.5D;
            // 
            // pot_phones_pan
            // 
            pot_phones_pan.Location = new Point(11, 88);
            pot_phones_pan.Margin = new Padding(4, 5, 4, 5);
            pot_phones_pan.Maximum = 1D;
            pot_phones_pan.Minimum = 0D;
            pot_phones_pan.Name = "pot_phones_pan";
            pot_phones_pan.Size = new Size(43, 55);
            pot_phones_pan.TabIndex = 3;
            pot_phones_pan.Value = 0.5D;
            // 
            // panel_mic
            // 
            panel_mic.BorderStyle = BorderStyle.FixedSingle;
            panel_mic.Controls.Add(volumeMeter_mic_volume);
            panel_mic.Controls.Add(chBox_mic_flexfx);
            panel_mic.Controls.Add(btn_micOver);
            panel_mic.Controls.Add(btn_micOnOff);
            panel_mic.Controls.Add(pot_mic_level);
            panel_mic.Location = new Point(84, 33);
            panel_mic.Margin = new Padding(2);
            panel_mic.Name = "panel_mic";
            panel_mic.Size = new Size(135, 319);
            panel_mic.TabIndex = 7;
            // 
            // chBox_mic_flexfx
            // 
            chBox_mic_flexfx.AutoSize = true;
            chBox_mic_flexfx.Location = new Point(21, 279);
            chBox_mic_flexfx.Margin = new Padding(2);
            chBox_mic_flexfx.Name = "chBox_mic_flexfx";
            chBox_mic_flexfx.Size = new Size(78, 24);
            chBox_mic_flexfx.TabIndex = 5;
            chBox_mic_flexfx.Text = "FLEXFX";
            chBox_mic_flexfx.UseVisualStyleBackColor = true;
            // 
            // fader_crossfader
            // 
            fader_crossfader.BackColor = SystemColors.ActiveCaption;
            fader_crossfader.Location = new Point(289, 1146);
            fader_crossfader.Margin = new Padding(2);
            fader_crossfader.Maximum = 0;
            fader_crossfader.Minimum = 1;
            fader_crossfader.Name = "fader_crossfader";
            fader_crossfader.Orientation = Orientation.Horizontal;
            fader_crossfader.Size = new Size(410, 99);
            fader_crossfader.TabIndex = 14;
            fader_crossfader.Text = "fader1";
            fader_crossfader.Value = 1;
            // 
            // panel_volume
            // 
            panel_volume.BorderStyle = BorderStyle.FixedSingle;
            panel_volume.Controls.Add(volumeMeter_mainRight);
            panel_volume.Controls.Add(volumeMeter_mainLeft);
            panel_volume.Location = new Point(751, 33);
            panel_volume.Margin = new Padding(2);
            panel_volume.Name = "panel_volume";
            panel_volume.Size = new Size(135, 319);
            panel_volume.TabIndex = 13;
            // 
            // verticalVolumeSlider_ch1
            // 
            verticalVolumeSlider_ch1.BackColor = SystemColors.Control;
            verticalVolumeSlider_ch1.ForeColor = Color.Black;
            verticalVolumeSlider_ch1.Location = new Point(721, 834);
            verticalVolumeSlider_ch1.Maximum = 1F;
            verticalVolumeSlider_ch1.Minimum = 0F;
            verticalVolumeSlider_ch1.Name = "verticalVolumeSlider_ch1";
            verticalVolumeSlider_ch1.Size = new Size(62, 306);
            verticalVolumeSlider_ch1.TabIndex = 15;
            verticalVolumeSlider_ch1.Volume = 0.5F;
            // 
            // verticalVolumeSlider_ch2
            // 
            verticalVolumeSlider_ch2.BackColor = SystemColors.Control;
            verticalVolumeSlider_ch2.ForeColor = Color.Black;
            verticalVolumeSlider_ch2.Location = new Point(223, 834);
            verticalVolumeSlider_ch2.Maximum = 1F;
            verticalVolumeSlider_ch2.Minimum = 0F;
            verticalVolumeSlider_ch2.Name = "verticalVolumeSlider_ch2";
            verticalVolumeSlider_ch2.Size = new Size(53, 306);
            verticalVolumeSlider_ch2.TabIndex = 15;
            verticalVolumeSlider_ch2.Volume = 0.5F;
            // 
            // Mixer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1000, 1256);
            Controls.Add(verticalVolumeSlider_ch2);
            Controls.Add(verticalVolumeSlider_ch1);
            Controls.Add(fader_crossfader);
            Controls.Add(pot_systemVolume);
            Controls.Add(chBox_efx_phaser);
            Controls.Add(chBox_efx_robot);
            Controls.Add(chBox_efx_filter);
            Controls.Add(chBox_efx_reverb);
            Controls.Add(chBox_cue_ch2);
            Controls.Add(chBox_cue_ch1);
            Controls.Add(chBox_efx_flanger);
            Controls.Add(chBox_efx_echo);
            Controls.Add(pot_low_ch2);
            Controls.Add(pot_mid_ch2);
            Controls.Add(pot_mic_low);
            Controls.Add(pot_mid_ch1);
            Controls.Add(pot_mic_high);
            Controls.Add(pot_high_ch2);
            Controls.Add(pot_high_ch1);
            Controls.Add(pot_gain_ch2);
            Controls.Add(pot_gain_ch1);
            Controls.Add(panel_chanel2);
            Controls.Add(panel_efx);
            Controls.Add(panel_loops2);
            Controls.Add(panel_loops1);
            Controls.Add(panel_cue);
            Controls.Add(panel_mic);
            Controls.Add(panel_chanel1);
            Controls.Add(panel_phones);
            Controls.Add(panel_volume);
            Margin = new Padding(2);
            Name = "Mixer";
            Text = "Form1";
            panel_chanel1.ResumeLayout(false);
            panel_chanel1.PerformLayout();
            panel_chanel2.ResumeLayout(false);
            panel_chanel2.PerformLayout();
            panel_loops1.ResumeLayout(false);
            panel_efx.ResumeLayout(false);
            panel_efx.PerformLayout();
            panel_loops2.ResumeLayout(false);
            panel_cue.ResumeLayout(false);
            panel_cue.PerformLayout();
            panel_phones.ResumeLayout(false);
            panel_phones.PerformLayout();
            panel_mic.ResumeLayout(false);
            panel_mic.PerformLayout();
            panel_volume.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NAudio.Gui.PanSlider panSlider_ch1;
        private NAudio.Gui.Pot pot_high_ch1;
        private NAudio.Gui.Pot pot_mid_ch1;
        private NAudio.Gui.Pot pot_filter_ch1;
        private NAudio.Gui.PanSlider panSlider_ch2;
        private NAudio.Gui.Pot pot_high_ch2;
        private NAudio.Gui.Pot pot_mid_ch2;
        private NAudio.Gui.Pot pot_filter_ch2;
        private NAudio.Gui.Pot pot_low_ch2;
        private NAudio.Gui.Pot pot_mic_level;
        private NAudio.Gui.Pot pot_mic_high;
        private NAudio.Gui.Pot pot_mic_low;
        private Button btn_micOnOff;
        private Button btn_micOver;
        private ImageList imageList1;
        private CheckBox chBox_flexfx_ch2;
        private Panel panel_chanel1;
        private Panel panel_chanel2;
        private Panel panel_loops1;
        private NAudio.Gui.Pot pot_systemVolume;
        private Button btn_loopIn_ch1;
        private Button btn_loopOut_ch1;
        private Button btn_exitLoop_ch1;
        private CheckBox chBox_efx_filter;
        private CheckBox chBox_efx_flanger;
        private CheckBox chBox_efx_phaser;
        private CheckBox chBox_efx_echo;
        private CheckBox chBox_efx_reverb;
        private CheckBox chBox_efx_robot;
        private Button chBox_efx_tap;
        private Panel chBox_efx_wyswietlacz;
        private CheckBox chBox_efx_on;
        private CheckBox chBox_efx_cue;
        private NAudio.Gui.Pot pot_efx_depth;
        private Panel panel_efx;
        private Panel panel_loops2;
        private Button btn_exitLoop_ch2;
        private Button btn_loopOut_ch2;
        private Button btn_loopIn_ch2;
        private Button btn_cue1_ch1;
        private Button btn_cue2_ch1;
        private Button btn_cue3_ch1;
        private Button btn_cue4_ch1;
        private Button btn_cue5_ch1;
        private Button btn_cue1_ch2;
        private Button btn_cue3_ch2;
        private Button btn_cue2_ch2;
        private Button btn_cue4_ch2;
        private Button btn_cue5_ch2;
        private Panel panel_cue;
        private CheckBox chBox_cue_ch1;
        private CheckBox chBox_cue_ch2;
        private Panel panel_phones;
        private NAudio.Gui.Pot pot_phones_level;
        private NAudio.Gui.Pot pot_phones_pan;
        private CheckBox chBox_phones_split;
        private NumericUpDown upfaer_ch1;
        private NumericUpDown upfaer_ch2;
        private NumericUpDown cross_fader;
        private NAudio.Gui.Pot pot_low_ch1;
        private CheckBox chBox_flexfx_ch1;
        private Panel panel_mic;
        private CheckBox chBox_mic_flexfx;
        private NAudio.Gui.VolumeMeter volumeMeter_mic_volume;
        private NAudio.Gui.VolumeMeter volumeMeter_mainRight;
        private NAudio.Gui.VolumeMeter volumeMeter_mainLeft;
        private NAudio.Gui.VolumeMeter volumeMeter_ch2;
        private CheckBox chBox_cue_samples;
        private NAudio.Gui.VolumeMeter volumeMeter_ch1;
        private NAudio.Gui.Fader fader_crossfader;
        internal NAudio.Gui.Pot pot_gain_ch1;
        internal NAudio.Gui.Pot pot_gain_ch2;
        private Panel panel_volume;
        private Controls.VerticalVolumeSlider verticalVolumeSlider_ch1;
        private Controls.VerticalVolumeSlider verticalVolumeSlider_ch2;
    }
}
