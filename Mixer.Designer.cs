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
            pan_ch1 = new NAudio.Gui.PanSlider();
            gain_ch1 = new NAudio.Gui.Pot();
            high_ch1 = new NAudio.Gui.Pot();
            mid_ch1 = new NAudio.Gui.Pot();
            filter_ch1 = new NAudio.Gui.Pot();
            pan_ch2 = new NAudio.Gui.PanSlider();
            gain_ch2 = new NAudio.Gui.Pot();
            high_ch2 = new NAudio.Gui.Pot();
            mid_ch2 = new NAudio.Gui.Pot();
            filter_ch2 = new NAudio.Gui.Pot();
            low_ch2 = new NAudio.Gui.Pot();
            mic_level = new NAudio.Gui.Pot();
            mic_high = new NAudio.Gui.Pot();
            mic_low = new NAudio.Gui.Pot();
            btn_micOnOff = new Button();
            btn_micOver = new Button();
            imageList1 = new ImageList(components);
            odt2_flexfx = new CheckBox();
            chanel1 = new Panel();
            volumeMeter_ch1 = new NAudio.Gui.VolumeMeter();
            pot_low_ch1 = new NAudio.Gui.Pot();
            flexfx_ch1 = new CheckBox();
            mic_volume = new NAudio.Gui.VolumeMeter();
            chanel2 = new Panel();
            volumeMeter_ch2 = new NAudio.Gui.VolumeMeter();
            volumeMeter_mainRight = new NAudio.Gui.VolumeMeter();
            volumeMeter_mainLeft = new NAudio.Gui.VolumeMeter();
            loops1 = new Panel();
            exitLoop_ch1 = new Button();
            loopOut_ch1 = new Button();
            loopIn_ch1 = new Button();
            pot_mainVolume = new NAudio.Gui.Pot();
            efx_filter = new CheckBox();
            efx_flanger = new CheckBox();
            efx_phaser = new CheckBox();
            efx_echo = new CheckBox();
            efx_reverb = new CheckBox();
            efx_robot = new CheckBox();
            efx_tap = new Button();
            efx_wyswietlacz = new Panel();
            efx_on = new CheckBox();
            efx_cue = new CheckBox();
            efx_depth = new NAudio.Gui.Pot();
            efx = new Panel();
            loops2 = new Panel();
            exitLoop_ch2 = new Button();
            loopOut_ch2 = new Button();
            loopIn_ch2 = new Button();
            cue1_ch1 = new Button();
            cue2_ch1 = new Button();
            cue3_ch1 = new Button();
            cue4_ch1 = new Button();
            cue5_ch1 = new Button();
            cue1_ch2 = new Button();
            cue3_ch2 = new Button();
            cue2_ch2 = new Button();
            cue4_ch2 = new Button();
            cue5_ch2 = new Button();
            cue = new Panel();
            chBox_cue_samples = new CheckBox();
            odt1_cue_pgm1 = new CheckBox();
            odt2_cue_pgm2 = new CheckBox();
            panel_phones = new Panel();
            phones_split_sue = new CheckBox();
            phones_level = new NAudio.Gui.Pot();
            phones_pan = new NAudio.Gui.Pot();
            mic = new Panel();
            mic_flexfx = new CheckBox();
            upfader_ch2 = new NAudio.Gui.VolumeSlider();
            upfader_ch1 = new NAudio.Gui.VolumeSlider();
            crossfader = new NAudio.Gui.Fader();
            panel_volume = new Panel();
            chanel1.SuspendLayout();
            chanel2.SuspendLayout();
            loops1.SuspendLayout();
            efx.SuspendLayout();
            loops2.SuspendLayout();
            cue.SuspendLayout();
            panel_phones.SuspendLayout();
            mic.SuspendLayout();
            panel_volume.SuspendLayout();
            SuspendLayout();
            // 
            // pan_ch1
            // 
            pan_ch1.Location = new Point(24, 58);
            pan_ch1.Margin = new Padding(2);
            pan_ch1.Name = "pan_ch1";
            pan_ch1.Pan = 0F;
            pan_ch1.Size = new Size(66, 32);
            pan_ch1.TabIndex = 1;
            pan_ch1.PanChanged += pan_odt1_PanChanged;
            // 
            // gain_ch1
            // 
            gain_ch1.Location = new Point(409, 39);
            gain_ch1.Margin = new Padding(4, 5, 4, 5);
            gain_ch1.Maximum = 1D;
            gain_ch1.Minimum = 0D;
            gain_ch1.Name = "gain_ch1";
            gain_ch1.Size = new Size(43, 55);
            gain_ch1.TabIndex = 3;
            gain_ch1.Value = 0.5D;
            gain_ch1.ValueChanged += level_odt1_ValueChanged;
            // 
            // high_ch1
            // 
            high_ch1.Location = new Point(409, 118);
            high_ch1.Margin = new Padding(4, 5, 4, 5);
            high_ch1.Maximum = 30D;
            high_ch1.Minimum = -30D;
            high_ch1.Name = "high_ch1";
            high_ch1.Size = new Size(43, 55);
            high_ch1.TabIndex = 3;
            high_ch1.Value = 0D;
            high_ch1.ValueChanged += high_odt1_ValueChanged;
            // 
            // mid_ch1
            // 
            mid_ch1.Location = new Point(409, 194);
            mid_ch1.Margin = new Padding(4, 5, 4, 5);
            mid_ch1.Maximum = 30D;
            mid_ch1.Minimum = -30D;
            mid_ch1.Name = "mid_ch1";
            mid_ch1.Size = new Size(43, 55);
            mid_ch1.TabIndex = 3;
            mid_ch1.Value = 0D;
            mid_ch1.ValueChanged += mid_odt1_ValueChanged;
            // 
            // filter_ch1
            // 
            filter_ch1.Location = new Point(30, 133);
            filter_ch1.Margin = new Padding(4, 5, 4, 5);
            filter_ch1.Maximum = 1D;
            filter_ch1.Minimum = -1D;
            filter_ch1.Name = "filter_ch1";
            filter_ch1.Size = new Size(43, 55);
            filter_ch1.TabIndex = 3;
            filter_ch1.Value = 0D;
            filter_ch1.ValueChanged += filter_odt1_ValueChanged;
            // 
            // pan_ch2
            // 
            pan_ch2.Location = new Point(110, 58);
            pan_ch2.Margin = new Padding(2);
            pan_ch2.Name = "pan_ch2";
            pan_ch2.Pan = 0F;
            pan_ch2.Size = new Size(66, 32);
            pan_ch2.TabIndex = 1;
            pan_ch2.PanChanged += pan_odt2_PanChanged;
            // 
            // gain_ch2
            // 
            gain_ch2.Location = new Point(540, 39);
            gain_ch2.Margin = new Padding(4, 5, 4, 5);
            gain_ch2.Maximum = 1D;
            gain_ch2.Minimum = 0D;
            gain_ch2.Name = "gain_ch2";
            gain_ch2.Size = new Size(43, 55);
            gain_ch2.TabIndex = 3;
            gain_ch2.Value = 0.5D;
            gain_ch2.ValueChanged += level_odt2_ValueChanged;
            // 
            // high_ch2
            // 
            high_ch2.Location = new Point(540, 118);
            high_ch2.Margin = new Padding(4, 5, 4, 5);
            high_ch2.Maximum = 30D;
            high_ch2.Minimum = -30D;
            high_ch2.Name = "high_ch2";
            high_ch2.Size = new Size(43, 55);
            high_ch2.TabIndex = 3;
            high_ch2.Value = 0D;
            high_ch2.ValueChanged += high_odt2_ValueChanged;
            // 
            // mid_ch2
            // 
            mid_ch2.Location = new Point(540, 194);
            mid_ch2.Margin = new Padding(4, 5, 4, 5);
            mid_ch2.Maximum = 30D;
            mid_ch2.Minimum = -30D;
            mid_ch2.Name = "mid_ch2";
            mid_ch2.Size = new Size(43, 55);
            mid_ch2.TabIndex = 3;
            mid_ch2.Value = 0D;
            mid_ch2.ValueChanged += mid_odt2_ValueChanged;
            // 
            // filter_ch2
            // 
            filter_ch2.Location = new Point(133, 133);
            filter_ch2.Margin = new Padding(4, 5, 4, 5);
            filter_ch2.Maximum = 1D;
            filter_ch2.Minimum = -1D;
            filter_ch2.Name = "filter_ch2";
            filter_ch2.Size = new Size(43, 55);
            filter_ch2.TabIndex = 3;
            filter_ch2.Value = 0D;
            filter_ch2.ValueChanged += filter_odt2_ValueChanged;
            // 
            // low_ch2
            // 
            low_ch2.Location = new Point(540, 273);
            low_ch2.Margin = new Padding(4, 5, 4, 5);
            low_ch2.Maximum = 30D;
            low_ch2.Minimum = -30D;
            low_ch2.Name = "low_ch2";
            low_ch2.Size = new Size(43, 55);
            low_ch2.TabIndex = 3;
            low_ch2.Value = 0D;
            low_ch2.ValueChanged += low_odt2_ValueChanged;
            // 
            // mic_level
            // 
            mic_level.Location = new Point(31, 58);
            mic_level.Margin = new Padding(4, 5, 4, 5);
            mic_level.Maximum = 1D;
            mic_level.Minimum = 0D;
            mic_level.Name = "mic_level";
            mic_level.Size = new Size(43, 55);
            mic_level.TabIndex = 3;
            mic_level.Value = 0.5D;
            mic_level.ValueChanged += mic_level_ValueChanged;
            // 
            // mic_high
            // 
            mic_high.Location = new Point(116, 167);
            mic_high.Margin = new Padding(4, 5, 4, 5);
            mic_high.Maximum = 30D;
            mic_high.Minimum = -30D;
            mic_high.Name = "mic_high";
            mic_high.Size = new Size(43, 55);
            mic_high.TabIndex = 3;
            mic_high.Value = 0.5D;
            mic_high.ValueChanged += mic_high_ValueChanged;
            // 
            // mic_low
            // 
            mic_low.Location = new Point(116, 244);
            mic_low.Margin = new Padding(4, 5, 4, 5);
            mic_low.Maximum = 30D;
            mic_low.Minimum = -30D;
            mic_low.Name = "mic_low";
            mic_low.Size = new Size(43, 55);
            mic_low.TabIndex = 3;
            mic_low.Value = 0.5D;
            mic_low.ValueChanged += mic_low_ValueChanged;
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
            btn_micOnOff.Click += mic_on_Click;
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
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // odt2_flexfx
            // 
            odt2_flexfx.AutoSize = true;
            odt2_flexfx.Location = new Point(119, 223);
            odt2_flexfx.Margin = new Padding(2);
            odt2_flexfx.Name = "odt2_flexfx";
            odt2_flexfx.Size = new Size(78, 24);
            odt2_flexfx.TabIndex = 5;
            odt2_flexfx.Text = "FLEXFX";
            odt2_flexfx.UseVisualStyleBackColor = true;
            // 
            // chanel1
            // 
            chanel1.BorderStyle = BorderStyle.FixedSingle;
            chanel1.Controls.Add(volumeMeter_ch1);
            chanel1.Controls.Add(pot_low_ch1);
            chanel1.Controls.Add(flexfx_ch1);
            chanel1.Controls.Add(pan_ch1);
            chanel1.Controls.Add(filter_ch1);
            chanel1.Location = new Point(258, 33);
            chanel1.Margin = new Padding(2);
            chanel1.Name = "chanel1";
            chanel1.Size = new Size(233, 319);
            chanel1.TabIndex = 7;
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
            // flexfx_ch1
            // 
            flexfx_ch1.AutoSize = true;
            flexfx_ch1.Location = new Point(8, 223);
            flexfx_ch1.Margin = new Padding(2);
            flexfx_ch1.Name = "flexfx_ch1";
            flexfx_ch1.Size = new Size(82, 24);
            flexfx_ch1.TabIndex = 5;
            flexfx_ch1.Text = "FLEX FX";
            flexfx_ch1.UseVisualStyleBackColor = true;
            // 
            // mic_volume
            // 
            mic_volume.Amplitude = 0F;
            mic_volume.Location = new Point(94, 58);
            mic_volume.Margin = new Padding(2);
            mic_volume.MaxDb = 18F;
            mic_volume.MinDb = -60F;
            mic_volume.Name = "mic_volume";
            mic_volume.Size = new Size(24, 217);
            mic_volume.TabIndex = 12;
            mic_volume.Text = "volumeMeter1";
            // 
            // chanel2
            // 
            chanel2.BorderStyle = BorderStyle.FixedSingle;
            chanel2.Controls.Add(volumeMeter_ch2);
            chanel2.Controls.Add(pan_ch2);
            chanel2.Controls.Add(filter_ch2);
            chanel2.Controls.Add(odt2_flexfx);
            chanel2.Location = new Point(522, 33);
            chanel2.Margin = new Padding(2);
            chanel2.Name = "chanel2";
            chanel2.Size = new Size(201, 319);
            chanel2.TabIndex = 7;
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
            // loops1
            // 
            loops1.BorderStyle = BorderStyle.FixedSingle;
            loops1.Controls.Add(exitLoop_ch1);
            loops1.Controls.Add(loopOut_ch1);
            loops1.Controls.Add(loopIn_ch1);
            loops1.Location = new Point(10, 142);
            loops1.Margin = new Padding(2);
            loops1.Name = "loops1";
            loops1.Size = new Size(70, 210);
            loops1.TabIndex = 7;
            // 
            // exitLoop_ch1
            // 
            exitLoop_ch1.Location = new Point(12, 145);
            exitLoop_ch1.Margin = new Padding(2);
            exitLoop_ch1.Name = "exitLoop_ch1";
            exitLoop_ch1.Size = new Size(45, 45);
            exitLoop_ch1.TabIndex = 4;
            exitLoop_ch1.Text = "Exit";
            exitLoop_ch1.UseVisualStyleBackColor = true;
            exitLoop_ch1.Click += exitLoop_ch1_Click;
            // 
            // loopOut_ch1
            // 
            loopOut_ch1.Location = new Point(12, 82);
            loopOut_ch1.Margin = new Padding(2);
            loopOut_ch1.Name = "loopOut_ch1";
            loopOut_ch1.Size = new Size(45, 45);
            loopOut_ch1.TabIndex = 4;
            loopOut_ch1.Text = "Out";
            loopOut_ch1.UseVisualStyleBackColor = true;
            loopOut_ch1.Click += loopOut_ch1_Click;
            // 
            // loopIn_ch1
            // 
            loopIn_ch1.Location = new Point(12, 21);
            loopIn_ch1.Margin = new Padding(2);
            loopIn_ch1.Name = "loopIn_ch1";
            loopIn_ch1.Size = new Size(45, 45);
            loopIn_ch1.TabIndex = 4;
            loopIn_ch1.Text = "In";
            loopIn_ch1.UseVisualStyleBackColor = true;
            loopIn_ch1.Click += loopIn_ch1_Click;
            // 
            // pot_mainVolume
            // 
            pot_mainVolume.Location = new Point(913, 39);
            pot_mainVolume.Margin = new Padding(4, 5, 4, 5);
            pot_mainVolume.Maximum = 1D;
            pot_mainVolume.Minimum = 0D;
            pot_mainVolume.Name = "pot_mainVolume";
            pot_mainVolume.Size = new Size(43, 55);
            pot_mainVolume.TabIndex = 3;
            pot_mainVolume.Value = 0.5D;
            // 
            // efx_filter
            // 
            efx_filter.AutoSize = true;
            efx_filter.Location = new Point(203, 385);
            efx_filter.Margin = new Padding(2);
            efx_filter.Name = "efx_filter";
            efx_filter.Size = new Size(73, 24);
            efx_filter.TabIndex = 5;
            efx_filter.Text = "FILTER";
            efx_filter.UseVisualStyleBackColor = true;
            efx_filter.CheckedChanged += efx_filter_CheckedChanged;
            // 
            // efx_flanger
            // 
            efx_flanger.AutoSize = true;
            efx_flanger.Location = new Point(305, 385);
            efx_flanger.Margin = new Padding(2);
            efx_flanger.Name = "efx_flanger";
            efx_flanger.Size = new Size(93, 24);
            efx_flanger.TabIndex = 5;
            efx_flanger.Text = "FLANGER";
            efx_flanger.UseVisualStyleBackColor = true;
            efx_flanger.CheckedChanged += efx_flanger_CheckedChanged;
            // 
            // efx_phaser
            // 
            efx_phaser.AutoSize = true;
            efx_phaser.Location = new Point(406, 385);
            efx_phaser.Margin = new Padding(2);
            efx_phaser.Name = "efx_phaser";
            efx_phaser.Size = new Size(85, 24);
            efx_phaser.TabIndex = 5;
            efx_phaser.Text = "PHASER";
            efx_phaser.UseVisualStyleBackColor = true;
            efx_phaser.CheckedChanged += efx_phaser_CheckedChanged;
            // 
            // efx_echo
            // 
            efx_echo.AutoSize = true;
            efx_echo.Location = new Point(508, 385);
            efx_echo.Margin = new Padding(2);
            efx_echo.Name = "efx_echo";
            efx_echo.Size = new Size(70, 24);
            efx_echo.TabIndex = 5;
            efx_echo.Text = "ECHO";
            efx_echo.UseVisualStyleBackColor = true;
            efx_echo.CheckedChanged += efx_echo_CheckedChanged;
            // 
            // efx_reverb
            // 
            efx_reverb.AutoSize = true;
            efx_reverb.Location = new Point(711, 385);
            efx_reverb.Margin = new Padding(2);
            efx_reverb.Name = "efx_reverb";
            efx_reverb.Size = new Size(83, 24);
            efx_reverb.TabIndex = 5;
            efx_reverb.Text = "REVERB";
            efx_reverb.UseVisualStyleBackColor = true;
            efx_reverb.CheckedChanged += efx_reverb_CheckedChanged;
            // 
            // efx_robot
            // 
            efx_robot.AutoSize = true;
            efx_robot.Location = new Point(610, 385);
            efx_robot.Margin = new Padding(2);
            efx_robot.Name = "efx_robot";
            efx_robot.Size = new Size(78, 24);
            efx_robot.TabIndex = 5;
            efx_robot.Text = "ROBOT";
            efx_robot.UseVisualStyleBackColor = true;
            efx_robot.CheckedChanged += efx_robot_CheckedChanged;
            // 
            // efx_tap
            // 
            efx_tap.Location = new Point(114, 99);
            efx_tap.Margin = new Padding(2);
            efx_tap.Name = "efx_tap";
            efx_tap.Size = new Size(43, 26);
            efx_tap.TabIndex = 4;
            efx_tap.Text = "TAP";
            efx_tap.UseVisualStyleBackColor = true;
            // 
            // efx_wyswietlacz
            // 
            efx_wyswietlacz.Location = new Point(198, 61);
            efx_wyswietlacz.Margin = new Padding(2);
            efx_wyswietlacz.Name = "efx_wyswietlacz";
            efx_wyswietlacz.Size = new Size(208, 107);
            efx_wyswietlacz.TabIndex = 9;
            // 
            // efx_on
            // 
            efx_on.AutoSize = true;
            efx_on.Location = new Point(437, 99);
            efx_on.Margin = new Padding(2);
            efx_on.Name = "efx_on";
            efx_on.Size = new Size(53, 24);
            efx_on.TabIndex = 5;
            efx_on.Text = "ON";
            efx_on.UseVisualStyleBackColor = true;
            // 
            // efx_cue
            // 
            efx_cue.AutoSize = true;
            efx_cue.Location = new Point(539, 99);
            efx_cue.Margin = new Padding(2);
            efx_cue.Name = "efx_cue";
            efx_cue.Size = new Size(58, 24);
            efx_cue.TabIndex = 5;
            efx_cue.Text = "CUE";
            efx_cue.UseVisualStyleBackColor = true;
            // 
            // efx_depth
            // 
            efx_depth.Location = new Point(655, 84);
            efx_depth.Margin = new Padding(4, 5, 4, 5);
            efx_depth.Maximum = 10D;
            efx_depth.Minimum = 0D;
            efx_depth.Name = "efx_depth";
            efx_depth.Size = new Size(43, 55);
            efx_depth.TabIndex = 3;
            efx_depth.Value = 0D;
            // 
            // efx
            // 
            efx.BorderStyle = BorderStyle.FixedSingle;
            efx.Controls.Add(efx_tap);
            efx.Controls.Add(efx_on);
            efx.Controls.Add(efx_cue);
            efx.Controls.Add(efx_depth);
            efx.Controls.Add(efx_wyswietlacz);
            efx.Location = new Point(84, 366);
            efx.Margin = new Padding(2);
            efx.Name = "efx";
            efx.Size = new Size(802, 186);
            efx.TabIndex = 7;
            // 
            // loops2
            // 
            loops2.BorderStyle = BorderStyle.FixedSingle;
            loops2.Controls.Add(exitLoop_ch2);
            loops2.Controls.Add(loopOut_ch2);
            loops2.Controls.Add(loopIn_ch2);
            loops2.Location = new Point(901, 142);
            loops2.Margin = new Padding(2);
            loops2.Name = "loops2";
            loops2.Size = new Size(70, 210);
            loops2.TabIndex = 7;
            // 
            // exitLoop_ch2
            // 
            exitLoop_ch2.Location = new Point(9, 145);
            exitLoop_ch2.Margin = new Padding(2);
            exitLoop_ch2.Name = "exitLoop_ch2";
            exitLoop_ch2.Size = new Size(45, 45);
            exitLoop_ch2.TabIndex = 4;
            exitLoop_ch2.Text = "Exit";
            exitLoop_ch2.UseVisualStyleBackColor = true;
            exitLoop_ch2.Click += exitLoop_ch2_Click;
            // 
            // loopOut_ch2
            // 
            loopOut_ch2.Location = new Point(9, 82);
            loopOut_ch2.Margin = new Padding(2);
            loopOut_ch2.Name = "loopOut_ch2";
            loopOut_ch2.Size = new Size(45, 45);
            loopOut_ch2.TabIndex = 4;
            loopOut_ch2.Text = "Out";
            loopOut_ch2.UseVisualStyleBackColor = true;
            loopOut_ch2.Click += loopOut_ch2_Click;
            // 
            // loopIn_ch2
            // 
            loopIn_ch2.Location = new Point(9, 21);
            loopIn_ch2.Margin = new Padding(2);
            loopIn_ch2.Name = "loopIn_ch2";
            loopIn_ch2.Size = new Size(45, 45);
            loopIn_ch2.TabIndex = 4;
            loopIn_ch2.Text = "In";
            loopIn_ch2.UseVisualStyleBackColor = true;
            loopIn_ch2.Click += loopIn_ch2_Click;
            // 
            // cue1_ch1
            // 
            cue1_ch1.FlatStyle = FlatStyle.Flat;
            cue1_ch1.Location = new Point(17, 23);
            cue1_ch1.Margin = new Padding(2);
            cue1_ch1.Name = "cue1_ch1";
            cue1_ch1.Size = new Size(57, 26);
            cue1_ch1.TabIndex = 4;
            cue1_ch1.Text = "CUE1";
            cue1_ch1.UseVisualStyleBackColor = true;
            cue1_ch1.Click += cue1_ch1_Click;
            // 
            // cue2_ch1
            // 
            cue2_ch1.FlatStyle = FlatStyle.Flat;
            cue2_ch1.Location = new Point(78, 23);
            cue2_ch1.Margin = new Padding(2);
            cue2_ch1.Name = "cue2_ch1";
            cue2_ch1.Size = new Size(56, 26);
            cue2_ch1.TabIndex = 4;
            cue2_ch1.Text = "CUE2";
            cue2_ch1.UseVisualStyleBackColor = true;
            cue2_ch1.Click += cue2_ch1_Click;
            // 
            // cue3_ch1
            // 
            cue3_ch1.FlatStyle = FlatStyle.Flat;
            cue3_ch1.Location = new Point(138, 23);
            cue3_ch1.Margin = new Padding(2);
            cue3_ch1.Name = "cue3_ch1";
            cue3_ch1.Size = new Size(57, 26);
            cue3_ch1.TabIndex = 4;
            cue3_ch1.Text = "CUE3";
            cue3_ch1.UseVisualStyleBackColor = true;
            cue3_ch1.Click += cue3_ch1_Click;
            // 
            // cue4_ch1
            // 
            cue4_ch1.FlatStyle = FlatStyle.Flat;
            cue4_ch1.Location = new Point(199, 23);
            cue4_ch1.Margin = new Padding(2);
            cue4_ch1.Name = "cue4_ch1";
            cue4_ch1.Size = new Size(50, 26);
            cue4_ch1.TabIndex = 4;
            cue4_ch1.Text = "CUE4";
            cue4_ch1.UseVisualStyleBackColor = true;
            cue4_ch1.Click += cue4_ch1_Click;
            // 
            // cue5_ch1
            // 
            cue5_ch1.FlatStyle = FlatStyle.Flat;
            cue5_ch1.Location = new Point(253, 23);
            cue5_ch1.Margin = new Padding(2);
            cue5_ch1.Name = "cue5_ch1";
            cue5_ch1.Size = new Size(54, 26);
            cue5_ch1.TabIndex = 4;
            cue5_ch1.Text = "CUE5";
            cue5_ch1.UseVisualStyleBackColor = true;
            cue5_ch1.Click += cue5_ch1_Click;
            // 
            // cue1_ch2
            // 
            cue1_ch2.FlatStyle = FlatStyle.Flat;
            cue1_ch2.Location = new Point(478, 23);
            cue1_ch2.Margin = new Padding(2);
            cue1_ch2.Name = "cue1_ch2";
            cue1_ch2.Size = new Size(57, 26);
            cue1_ch2.TabIndex = 4;
            cue1_ch2.Text = "CUE1";
            cue1_ch2.UseVisualStyleBackColor = true;
            cue1_ch2.Click += cue1_ch2_Click;
            // 
            // cue3_ch2
            // 
            cue3_ch2.FlatStyle = FlatStyle.Flat;
            cue3_ch2.Location = new Point(599, 23);
            cue3_ch2.Margin = new Padding(2);
            cue3_ch2.Name = "cue3_ch2";
            cue3_ch2.Size = new Size(57, 26);
            cue3_ch2.TabIndex = 4;
            cue3_ch2.Text = "CUE3";
            cue3_ch2.UseVisualStyleBackColor = true;
            cue3_ch2.Click += cue3_ch2_Click;
            // 
            // cue2_ch2
            // 
            cue2_ch2.FlatStyle = FlatStyle.Flat;
            cue2_ch2.Location = new Point(539, 23);
            cue2_ch2.Margin = new Padding(2);
            cue2_ch2.Name = "cue2_ch2";
            cue2_ch2.Size = new Size(56, 26);
            cue2_ch2.TabIndex = 4;
            cue2_ch2.Text = "CUE2";
            cue2_ch2.UseVisualStyleBackColor = true;
            cue2_ch2.Click += cue2_ch2_Click;
            // 
            // cue4_ch2
            // 
            cue4_ch2.FlatStyle = FlatStyle.Flat;
            cue4_ch2.Location = new Point(660, 23);
            cue4_ch2.Margin = new Padding(2);
            cue4_ch2.Name = "cue4_ch2";
            cue4_ch2.Size = new Size(50, 26);
            cue4_ch2.TabIndex = 4;
            cue4_ch2.Text = "CUE4";
            cue4_ch2.UseVisualStyleBackColor = true;
            cue4_ch2.Click += cue4_ch2_Click;
            // 
            // cue5_ch2
            // 
            cue5_ch2.FlatStyle = FlatStyle.Flat;
            cue5_ch2.Location = new Point(714, 23);
            cue5_ch2.Margin = new Padding(2);
            cue5_ch2.Name = "cue5_ch2";
            cue5_ch2.Size = new Size(54, 26);
            cue5_ch2.TabIndex = 4;
            cue5_ch2.Text = "CUE5";
            cue5_ch2.UseVisualStyleBackColor = true;
            cue5_ch2.Click += cue5_ch2_Click;
            // 
            // cue
            // 
            cue.BorderStyle = BorderStyle.FixedSingle;
            cue.Controls.Add(chBox_cue_samples);
            cue.Controls.Add(cue5_ch1);
            cue.Controls.Add(cue5_ch2);
            cue.Controls.Add(cue4_ch2);
            cue.Controls.Add(cue3_ch2);
            cue.Controls.Add(cue2_ch2);
            cue.Controls.Add(cue1_ch2);
            cue.Controls.Add(cue1_ch1);
            cue.Controls.Add(cue2_ch1);
            cue.Controls.Add(cue3_ch1);
            cue.Controls.Add(cue4_ch1);
            cue.Location = new Point(84, 570);
            cue.Margin = new Padding(2);
            cue.Name = "cue";
            cue.Size = new Size(802, 83);
            cue.TabIndex = 7;
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
            // odt1_cue_pgm1
            // 
            odt1_cue_pgm1.AutoSize = true;
            odt1_cue_pgm1.Location = new Point(141, 702);
            odt1_cue_pgm1.Margin = new Padding(2);
            odt1_cue_pgm1.Name = "odt1_cue_pgm1";
            odt1_cue_pgm1.Size = new Size(105, 24);
            odt1_cue_pgm1.TabIndex = 5;
            odt1_cue_pgm1.Text = "CUE PGM 1";
            odt1_cue_pgm1.UseVisualStyleBackColor = true;
            // 
            // odt2_cue_pgm2
            // 
            odt2_cue_pgm2.AutoSize = true;
            odt2_cue_pgm2.Location = new Point(711, 702);
            odt2_cue_pgm2.Margin = new Padding(2);
            odt2_cue_pgm2.Name = "odt2_cue_pgm2";
            odt2_cue_pgm2.Size = new Size(105, 24);
            odt2_cue_pgm2.TabIndex = 5;
            odt2_cue_pgm2.Text = "CUE PGM 2";
            odt2_cue_pgm2.UseVisualStyleBackColor = true;
            // 
            // panel_phones
            // 
            panel_phones.BorderStyle = BorderStyle.FixedSingle;
            panel_phones.Controls.Add(phones_split_sue);
            panel_phones.Controls.Add(phones_level);
            panel_phones.Controls.Add(phones_pan);
            panel_phones.Location = new Point(901, 628);
            panel_phones.Margin = new Padding(2);
            panel_phones.Name = "panel_phones";
            panel_phones.Size = new Size(70, 215);
            panel_phones.TabIndex = 10;
            // 
            // phones_split_sue
            // 
            phones_split_sue.AutoSize = true;
            phones_split_sue.Location = new Point(15, 171);
            phones_split_sue.Margin = new Padding(2);
            phones_split_sue.Name = "phones_split_sue";
            phones_split_sue.Size = new Size(97, 24);
            phones_split_sue.TabIndex = 5;
            phones_split_sue.Text = "SPLIT CUE";
            phones_split_sue.UseVisualStyleBackColor = true;
            // 
            // phones_level
            // 
            phones_level.Location = new Point(11, 23);
            phones_level.Margin = new Padding(4, 5, 4, 5);
            phones_level.Maximum = 1D;
            phones_level.Minimum = 0D;
            phones_level.Name = "phones_level";
            phones_level.Size = new Size(43, 55);
            phones_level.TabIndex = 3;
            phones_level.Value = 0.5D;
            // 
            // phones_pan
            // 
            phones_pan.Location = new Point(11, 88);
            phones_pan.Margin = new Padding(4, 5, 4, 5);
            phones_pan.Maximum = 1D;
            phones_pan.Minimum = 0D;
            phones_pan.Name = "phones_pan";
            phones_pan.Size = new Size(43, 55);
            phones_pan.TabIndex = 3;
            phones_pan.Value = 0.5D;
            // 
            // mic
            // 
            mic.BorderStyle = BorderStyle.FixedSingle;
            mic.Controls.Add(mic_volume);
            mic.Controls.Add(mic_flexfx);
            mic.Controls.Add(btn_micOver);
            mic.Controls.Add(btn_micOnOff);
            mic.Controls.Add(mic_level);
            mic.Location = new Point(84, 33);
            mic.Margin = new Padding(2);
            mic.Name = "mic";
            mic.Size = new Size(135, 319);
            mic.TabIndex = 7;
            // 
            // mic_flexfx
            // 
            mic_flexfx.AutoSize = true;
            mic_flexfx.Location = new Point(21, 279);
            mic_flexfx.Margin = new Padding(2);
            mic_flexfx.Name = "mic_flexfx";
            mic_flexfx.Size = new Size(78, 24);
            mic_flexfx.TabIndex = 5;
            mic_flexfx.Text = "FLEXFX";
            mic_flexfx.UseVisualStyleBackColor = true;
            // 
            // upfader_ch2
            // 
            upfader_ch2.ImeMode = ImeMode.NoControl;
            upfader_ch2.Location = new Point(718, 834);
            upfader_ch2.Margin = new Padding(2);
            upfader_ch2.Name = "upfader_ch2";
            upfader_ch2.Size = new Size(76, 306);
            upfader_ch2.TabIndex = 13;
            // 
            // upfader_ch1
            // 
            upfader_ch1.AutoScroll = true;
            upfader_ch1.ForeColor = SystemColors.ControlText;
            upfader_ch1.Location = new Point(219, 834);
            upfader_ch1.Margin = new Padding(2);
            upfader_ch1.Name = "upfader_ch1";
            upfader_ch1.Size = new Size(54, 306);
            upfader_ch1.TabIndex = 13;
            // 
            // crossfader
            // 
            crossfader.BackColor = SystemColors.ActiveCaption;
            crossfader.Location = new Point(289, 1146);
            crossfader.Margin = new Padding(2);
            crossfader.Maximum = 0;
            crossfader.Minimum = 1;
            crossfader.Name = "crossfader";
            crossfader.Orientation = Orientation.Horizontal;
            crossfader.Size = new Size(410, 99);
            crossfader.TabIndex = 14;
            crossfader.Text = "fader1";
            crossfader.Value = 1;
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
            // Mixer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1000, 1256);
            Controls.Add(crossfader);
            Controls.Add(upfader_ch1);
            Controls.Add(pot_mainVolume);
            Controls.Add(upfader_ch2);
            Controls.Add(efx_phaser);
            Controls.Add(efx_robot);
            Controls.Add(efx_filter);
            Controls.Add(efx_reverb);
            Controls.Add(odt2_cue_pgm2);
            Controls.Add(odt1_cue_pgm1);
            Controls.Add(efx_flanger);
            Controls.Add(efx_echo);
            Controls.Add(low_ch2);
            Controls.Add(mid_ch2);
            Controls.Add(mic_low);
            Controls.Add(mid_ch1);
            Controls.Add(mic_high);
            Controls.Add(high_ch2);
            Controls.Add(high_ch1);
            Controls.Add(gain_ch2);
            Controls.Add(gain_ch1);
            Controls.Add(chanel2);
            Controls.Add(efx);
            Controls.Add(loops2);
            Controls.Add(loops1);
            Controls.Add(cue);
            Controls.Add(mic);
            Controls.Add(chanel1);
            Controls.Add(panel_phones);
            Controls.Add(panel_volume);
            Margin = new Padding(2);
            Name = "Mixer";
            Text = "Form1";
            chanel1.ResumeLayout(false);
            chanel1.PerformLayout();
            chanel2.ResumeLayout(false);
            chanel2.PerformLayout();
            loops1.ResumeLayout(false);
            efx.ResumeLayout(false);
            efx.PerformLayout();
            loops2.ResumeLayout(false);
            cue.ResumeLayout(false);
            cue.PerformLayout();
            panel_phones.ResumeLayout(false);
            panel_phones.PerformLayout();
            mic.ResumeLayout(false);
            mic.PerformLayout();
            panel_volume.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NAudio.Gui.PanSlider pan_ch1;
        private NAudio.Gui.Pot high_ch1;
        private NAudio.Gui.Pot mid_ch1;
        private NAudio.Gui.Pot filter_ch1;
        private NAudio.Gui.PanSlider pan_ch2;
        private NAudio.Gui.Pot high_ch2;
        private NAudio.Gui.Pot mid_ch2;
        private NAudio.Gui.Pot filter_ch2;
        private NAudio.Gui.Pot low_ch2;
        private NAudio.Gui.Pot mic_level;
        private NAudio.Gui.Pot mic_high;
        private NAudio.Gui.Pot mic_low;
        private Button btn_micOnOff;
        private Button btn_micOver;
        private ImageList imageList1;
        private CheckBox odt2_flexfx;
        private Panel chanel1;
        private Panel chanel2;
        private Panel loops1;
        private NAudio.Gui.Pot pot_mainVolume;
        private Button loopIn_ch1;
        private Button loopOut_ch1;
        private Button exitLoop_ch1;
        private CheckBox efx_filter;
        private CheckBox efx_flanger;
        private CheckBox efx_phaser;
        private CheckBox efx_echo;
        private CheckBox efx_reverb;
        private CheckBox efx_robot;
        private Button efx_tap;
        private Panel efx_wyswietlacz;
        private CheckBox efx_on;
        private CheckBox efx_cue;
        private NAudio.Gui.Pot efx_depth;
        private Panel efx;
        private Panel loops2;
        private Button exitLoop_ch2;
        private Button loopOut_ch2;
        private Button loopIn_ch2;
        private Button cue1_ch1;
        private Button cue2_ch1;
        private Button cue3_ch1;
        private Button cue4_ch1;
        private Button cue5_ch1;
        private Button cue1_ch2;
        private Button cue3_ch2;
        private Button cue2_ch2;
        private Button cue4_ch2;
        private Button cue5_ch2;
        private Panel cue;
        private CheckBox odt1_cue_pgm1;
        private CheckBox odt2_cue_pgm2;
        private Panel panel_phones;
        private NAudio.Gui.Pot phones_level;
        private NAudio.Gui.Pot phones_pan;
        private CheckBox phones_split_sue;
        private NumericUpDown upfaer_ch1;
        private NumericUpDown upfaer_ch2;
        private NumericUpDown cross_fader;
        private NAudio.Gui.Pot pot_low_ch1;
        private CheckBox flexfx_ch1;
        private Panel mic;
        private CheckBox mic_flexfx;
        private NAudio.Gui.VolumeMeter mic_volume;
        private NAudio.Gui.VolumeMeter volumeMeter_mainRight;
        private NAudio.Gui.VolumeMeter volumeMeter_mainLeft;
        private NAudio.Gui.VolumeMeter volumeMeter_ch2;
        private NAudio.Gui.VolumeSlider upfader_ch2;
        public NAudio.Gui.VolumeSlider upfader_ch1;
        private CheckBox chBox_cue_samples;
        private NAudio.Gui.VolumeMeter volumeMeter_ch1;
        private NAudio.Gui.Fader crossfader;
        internal NAudio.Gui.Pot gain_ch1;
        internal NAudio.Gui.Pot gain_ch2;
        private Panel panel_volume;
    }
}
