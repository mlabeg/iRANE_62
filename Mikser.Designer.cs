using NAudio;
using NAudio.Wave;

namespace iRANE_62
{
    partial class Mikser
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
            pan_odt1 = new NAudio.Gui.PanSlider();
            level_odt1 = new NAudio.Gui.Pot();
            high_odt1 = new NAudio.Gui.Pot();
            mid_odt1 = new NAudio.Gui.Pot();
            aux_level = new NAudio.Gui.Pot();
            filter_odt1 = new NAudio.Gui.Pot();
            pan_odt2 = new NAudio.Gui.PanSlider();
            level_odt2 = new NAudio.Gui.Pot();
            high_odt2 = new NAudio.Gui.Pot();
            mid_odt2 = new NAudio.Gui.Pot();
            filter_odt2 = new NAudio.Gui.Pot();
            low_odt2 = new NAudio.Gui.Pot();
            mic_level = new NAudio.Gui.Pot();
            mic_high = new NAudio.Gui.Pot();
            mic_low = new NAudio.Gui.Pot();
            mic_on = new Button();
            mic_over = new Button();
            button1 = new Button();
            imageList1 = new ImageList(components);
            button2 = new Button();
            efx_insert = new CheckBox();
            odt2_flexfx = new CheckBox();
            odt1_source = new ComboBox();
            odt2_source = new ComboBox();
            odt1 = new Panel();
            volumeMeter_ch1 = new NAudio.Gui.VolumeMeter();
            odt1_low = new NAudio.Gui.Pot();
            odt1_flexfx = new CheckBox();
            odt1_volume = new NAudio.Gui.VolumeMeter();
            odt2 = new Panel();
            odt2_volume = new NAudio.Gui.VolumeMeter();
            mainVolumeRight = new NAudio.Gui.VolumeMeter();
            mainVolumeLeft = new NAudio.Gui.VolumeMeter();
            loops1 = new Panel();
            button14 = new Button();
            hScrollBar5 = new HScrollBar();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            hScrollBar1 = new HScrollBar();
            main = new NAudio.Gui.Pot();
            session_out = new NAudio.Gui.Pot();
            session_in = new NAudio.Gui.Pot();
            booth = new NAudio.Gui.Pot();
            button8 = new Button();
            deck1_back = new Button();
            odt1_load = new HScrollBar();
            efx_time = new HScrollBar();
            efx_filter = new CheckBox();
            efx_flanger = new CheckBox();
            efx_phaser = new CheckBox();
            efx_echo = new CheckBox();
            efx_reverb = new CheckBox();
            efx_robot = new CheckBox();
            efx_ext_insert = new CheckBox();
            efx_beat = new HScrollBar();
            efx_tap = new Button();
            efx_wyswietlacz = new Panel();
            efx_on = new CheckBox();
            efx_cue = new CheckBox();
            efx_depth = new NAudio.Gui.Pot();
            efx = new Panel();
            loops2 = new Panel();
            button15 = new Button();
            hScrollBar6 = new HScrollBar();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            odt1_cue1 = new Button();
            odt1_cue2 = new Button();
            odt1_cue3 = new Button();
            odt1_cue4 = new Button();
            odt1_cue5 = new Button();
            odt2_cue1 = new Button();
            odt2_cue3 = new Button();
            odt2_cue2 = new Button();
            odt2_cue4 = new Button();
            odt2_cue5 = new Button();
            cue = new Panel();
            chBox_cue_samples = new CheckBox();
            odt1_cue_pgm1 = new CheckBox();
            btn_cue_usb_aux = new CheckBox();
            odt2_cue_pgm2 = new CheckBox();
            aux_filter = new NAudio.Gui.Pot();
            aux_flexfx = new CheckBox();
            panel_aux = new Panel();
            panel_phones = new Panel();
            phones_level = new NAudio.Gui.Pot();
            phones_pan = new NAudio.Gui.Pot();
            phones_split_sue = new CheckBox();
            mix = new Panel();
            mic = new Panel();
            mic_flexfx = new CheckBox();
            odt2_upfader = new NAudio.Gui.VolumeSlider();
            odt1_upfader = new NAudio.Gui.VolumeSlider();
            fader1 = new NAudio.Gui.Fader();
            odt1.SuspendLayout();
            odt2.SuspendLayout();
            loops1.SuspendLayout();
            efx.SuspendLayout();
            loops2.SuspendLayout();
            cue.SuspendLayout();
            mic.SuspendLayout();
            SuspendLayout();
            // 
            // pan_odt1
            // 
            pan_odt1.Location = new Point(330, 163);
            pan_odt1.Name = "pan_odt1";
            pan_odt1.Pan = 0F;
            pan_odt1.Size = new Size(83, 40);
            pan_odt1.TabIndex = 1;
            // 
            // level_odt1
            // 
            level_odt1.Location = new Point(486, 49);
            level_odt1.Margin = new Padding(5, 6, 5, 6);
            level_odt1.Maximum = 1D;
            level_odt1.Minimum = 0D;
            level_odt1.Name = "level_odt1";
            level_odt1.Size = new Size(54, 69);
            level_odt1.TabIndex = 3;
            level_odt1.Value = 0D;
            level_odt1.ValueChanged += level_odt1_ValueChanged;
            // 
            // high_odt1
            // 
            high_odt1.Location = new Point(486, 147);
            high_odt1.Margin = new Padding(5, 6, 5, 6);
            high_odt1.Maximum = 1D;
            high_odt1.Minimum = 0D;
            high_odt1.Name = "high_odt1";
            high_odt1.Size = new Size(54, 69);
            high_odt1.TabIndex = 3;
            high_odt1.Value = 0.5D;
            // 
            // mid_odt1
            // 
            mid_odt1.Location = new Point(486, 243);
            mid_odt1.Margin = new Padding(5, 6, 5, 6);
            mid_odt1.Maximum = 1D;
            mid_odt1.Minimum = 0D;
            mid_odt1.Name = "mid_odt1";
            mid_odt1.Size = new Size(54, 69);
            mid_odt1.TabIndex = 3;
            mid_odt1.Value = 0.5D;
            // 
            // aux_level
            // 
            aux_level.Location = new Point(24, 798);
            aux_level.Margin = new Padding(5, 6, 5, 6);
            aux_level.Maximum = 1D;
            aux_level.Minimum = 0D;
            aux_level.Name = "aux_level";
            aux_level.Size = new Size(54, 69);
            aux_level.TabIndex = 3;
            aux_level.Value = 0.5D;
            // 
            // filter_odt1
            // 
            filter_odt1.Location = new Point(340, 240);
            filter_odt1.Margin = new Padding(5, 6, 5, 6);
            filter_odt1.Maximum = 1D;
            filter_odt1.Minimum = 0D;
            filter_odt1.Name = "filter_odt1";
            filter_odt1.Size = new Size(54, 69);
            filter_odt1.TabIndex = 3;
            filter_odt1.Value = 0.5D;
            // 
            // pan_odt2
            // 
            pan_odt2.Location = new Point(766, 163);
            pan_odt2.Name = "pan_odt2";
            pan_odt2.Pan = 0F;
            pan_odt2.Size = new Size(83, 40);
            pan_odt2.TabIndex = 1;
            // 
            // level_odt2
            // 
            level_odt2.Location = new Point(643, 49);
            level_odt2.Margin = new Padding(5, 6, 5, 6);
            level_odt2.Maximum = 1D;
            level_odt2.Minimum = 0D;
            level_odt2.Name = "level_odt2";
            level_odt2.Size = new Size(54, 69);
            level_odt2.TabIndex = 3;
            level_odt2.Value = 0D;
            level_odt2.ValueChanged += level_odt2_ValueChanged;
            // 
            // high_odt2
            // 
            high_odt2.Location = new Point(643, 147);
            high_odt2.Margin = new Padding(5, 6, 5, 6);
            high_odt2.Maximum = 1D;
            high_odt2.Minimum = 0D;
            high_odt2.Name = "high_odt2";
            high_odt2.Size = new Size(54, 69);
            high_odt2.TabIndex = 3;
            high_odt2.Value = 0.5D;
            // 
            // mid_odt2
            // 
            mid_odt2.Location = new Point(643, 243);
            mid_odt2.Margin = new Padding(5, 6, 5, 6);
            mid_odt2.Maximum = 1D;
            mid_odt2.Minimum = 0D;
            mid_odt2.Name = "mid_odt2";
            mid_odt2.Size = new Size(54, 69);
            mid_odt2.TabIndex = 3;
            mid_odt2.Value = 0.5D;
            // 
            // filter_odt2
            // 
            filter_odt2.Location = new Point(776, 240);
            filter_odt2.Margin = new Padding(5, 6, 5, 6);
            filter_odt2.Maximum = 1D;
            filter_odt2.Minimum = 0D;
            filter_odt2.Name = "filter_odt2";
            filter_odt2.Size = new Size(54, 69);
            filter_odt2.TabIndex = 3;
            filter_odt2.Value = 0.5D;
            // 
            // low_odt2
            // 
            low_odt2.Location = new Point(643, 341);
            low_odt2.Margin = new Padding(5, 6, 5, 6);
            low_odt2.Maximum = 1D;
            low_odt2.Minimum = 0D;
            low_odt2.Name = "low_odt2";
            low_odt2.Size = new Size(54, 69);
            low_odt2.TabIndex = 3;
            low_odt2.Value = 0.5D;
            // 
            // mic_level
            // 
            mic_level.Location = new Point(145, 111);
            mic_level.Margin = new Padding(5, 6, 5, 6);
            mic_level.Maximum = 1D;
            mic_level.Minimum = 0D;
            mic_level.Name = "mic_level";
            mic_level.Size = new Size(54, 69);
            mic_level.TabIndex = 3;
            mic_level.Value = 0.5D;
            // 
            // mic_high
            // 
            mic_high.Location = new Point(145, 209);
            mic_high.Margin = new Padding(5, 6, 5, 6);
            mic_high.Maximum = 1D;
            mic_high.Minimum = 0D;
            mic_high.Name = "mic_high";
            mic_high.Size = new Size(54, 69);
            mic_high.TabIndex = 3;
            mic_high.Value = 0.5D;
            // 
            // mic_low
            // 
            mic_low.Location = new Point(145, 305);
            mic_low.Margin = new Padding(5, 6, 5, 6);
            mic_low.Maximum = 1D;
            mic_low.Minimum = 0D;
            mic_low.Name = "mic_low";
            mic_low.Size = new Size(54, 69);
            mic_low.TabIndex = 3;
            mic_low.Value = 0.5D;
            // 
            // mic_on
            // 
            mic_on.Location = new Point(116, 69);
            mic_on.Name = "mic_on";
            mic_on.Size = new Size(54, 33);
            mic_on.TabIndex = 4;
            mic_on.Text = "button1";
            mic_on.UseVisualStyleBackColor = true;
            // 
            // mic_over
            // 
            mic_over.Location = new Point(176, 69);
            mic_over.Name = "mic_over";
            mic_over.Size = new Size(54, 33);
            mic_over.TabIndex = 4;
            mic_over.Text = "button1";
            mic_over.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1160, 69);
            button1.Name = "button1";
            button1.Size = new Size(54, 33);
            button1.TabIndex = 4;
            button1.Text = "SP-6 ASSIGN";
            button1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button2
            // 
            button2.Location = new Point(1160, 130);
            button2.Name = "button2";
            button2.Size = new Size(54, 33);
            button2.TabIndex = 4;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            // 
            // efx_insert
            // 
            efx_insert.AutoSize = true;
            efx_insert.Location = new Point(127, 481);
            efx_insert.Name = "efx_insert";
            efx_insert.Size = new Size(94, 29);
            efx_insert.TabIndex = 5;
            efx_insert.Text = "INSERT";
            efx_insert.UseVisualStyleBackColor = true;
            efx_insert.CheckedChanged += efx_insert_CheckedChanged;
            // 
            // odt2_flexfx
            // 
            odt2_flexfx.AutoSize = true;
            odt2_flexfx.Location = new Point(776, 345);
            odt2_flexfx.Name = "odt2_flexfx";
            odt2_flexfx.Size = new Size(95, 29);
            odt2_flexfx.TabIndex = 5;
            odt2_flexfx.Text = "FLEXFX";
            odt2_flexfx.UseVisualStyleBackColor = true;
            // 
            // odt1_source
            // 
            odt1_source.FormattingEnabled = true;
            odt1_source.Location = new Point(323, 70);
            odt1_source.Name = "odt1_source";
            odt1_source.Size = new Size(90, 33);
            odt1_source.TabIndex = 6;
            // 
            // odt2_source
            // 
            odt2_source.FormattingEnabled = true;
            odt2_source.Location = new Point(759, 70);
            odt2_source.Name = "odt2_source";
            odt2_source.Size = new Size(90, 33);
            odt2_source.TabIndex = 6;
            // 
            // odt1
            // 
            odt1.Controls.Add(volumeMeter_ch1);
            odt1.Controls.Add(odt1_low);
            odt1.Controls.Add(odt1_flexfx);
            odt1.Location = new Point(298, 41);
            odt1.Name = "odt1";
            odt1.Size = new Size(291, 399);
            odt1.TabIndex = 7;
            // 
            // volumeMeter_ch1
            // 
            volumeMeter_ch1.Amplitude = 0F;
            volumeMeter_ch1.Location = new Point(146, 89);
            volumeMeter_ch1.MaxDb = 18F;
            volumeMeter_ch1.MinDb = -60F;
            volumeMeter_ch1.Name = "volumeMeter_ch1";
            volumeMeter_ch1.Size = new Size(30, 271);
            volumeMeter_ch1.TabIndex = 12;
            volumeMeter_ch1.Text = "volumeMeter1";
            // 
            // odt1_low
            // 
            odt1_low.Location = new Point(188, 300);
            odt1_low.Margin = new Padding(5, 6, 5, 6);
            odt1_low.Maximum = 1D;
            odt1_low.Minimum = 0D;
            odt1_low.Name = "odt1_low";
            odt1_low.Size = new Size(54, 69);
            odt1_low.TabIndex = 3;
            odt1_low.Value = 0.5D;
            // 
            // odt1_flexfx
            // 
            odt1_flexfx.AutoSize = true;
            odt1_flexfx.Location = new Point(43, 304);
            odt1_flexfx.Name = "odt1_flexfx";
            odt1_flexfx.Size = new Size(95, 29);
            odt1_flexfx.TabIndex = 5;
            odt1_flexfx.Text = "FLEXFX";
            odt1_flexfx.UseVisualStyleBackColor = true;
            // 
            // odt1_volume
            // 
            odt1_volume.Amplitude = 0F;
            odt1_volume.Location = new Point(117, 72);
            odt1_volume.MaxDb = 18F;
            odt1_volume.MinDb = -60F;
            odt1_volume.Name = "odt1_volume";
            odt1_volume.Size = new Size(30, 271);
            odt1_volume.TabIndex = 12;
            odt1_volume.Text = "volumeMeter1";
            // 
            // odt2
            // 
            odt2.Controls.Add(odt2_volume);
            odt2.Location = new Point(620, 41);
            odt2.Name = "odt2";
            odt2.Size = new Size(251, 399);
            odt2.TabIndex = 7;
            // 
            // odt2_volume
            // 
            odt2_volume.Amplitude = 0F;
            odt2_volume.Location = new Point(98, 89);
            odt2_volume.MaxDb = 18F;
            odt2_volume.MinDb = -60F;
            odt2_volume.Name = "odt2_volume";
            odt2_volume.Size = new Size(30, 271);
            odt2_volume.TabIndex = 12;
            odt2_volume.Text = "volumeMeter1";
            // 
            // mainVolumeRight
            // 
            mainVolumeRight.Amplitude = 0F;
            mainVolumeRight.Location = new Point(936, 130);
            mainVolumeRight.MaxDb = 18F;
            mainVolumeRight.MinDb = -60F;
            mainVolumeRight.Name = "mainVolumeRight";
            mainVolumeRight.Size = new Size(30, 271);
            mainVolumeRight.TabIndex = 12;
            mainVolumeRight.Text = "volumeMeter1";
            // 
            // mainVolumeLeft
            // 
            mainVolumeLeft.Amplitude = 0F;
            mainVolumeLeft.Location = new Point(889, 130);
            mainVolumeLeft.MaxDb = 18F;
            mainVolumeLeft.MinDb = -60F;
            mainVolumeLeft.Name = "mainVolumeLeft";
            mainVolumeLeft.Size = new Size(30, 271);
            mainVolumeLeft.TabIndex = 12;
            mainVolumeLeft.Text = "volumeMeter1";
            // 
            // loops1
            // 
            loops1.Controls.Add(button14);
            loops1.Controls.Add(hScrollBar5);
            loops1.Controls.Add(button13);
            loops1.Controls.Add(button12);
            loops1.Controls.Add(button11);
            loops1.Controls.Add(button10);
            loops1.Location = new Point(12, 214);
            loops1.Name = "loops1";
            loops1.Size = new Size(87, 528);
            loops1.TabIndex = 7;
            // 
            // button14
            // 
            button14.Location = new Point(12, 460);
            button14.Name = "button14";
            button14.Size = new Size(54, 33);
            button14.TabIndex = 4;
            button14.Text = "button1";
            button14.UseVisualStyleBackColor = true;
            // 
            // hScrollBar5
            // 
            hScrollBar5.Location = new Point(12, 131);
            hScrollBar5.Name = "hScrollBar5";
            hScrollBar5.Size = new Size(54, 39);
            hScrollBar5.TabIndex = 8;
            // 
            // button13
            // 
            button13.Location = new Point(12, 384);
            button13.Name = "button13";
            button13.Size = new Size(54, 33);
            button13.TabIndex = 4;
            button13.Text = "button1";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(12, 305);
            button12.Name = "button12";
            button12.Size = new Size(54, 33);
            button12.TabIndex = 4;
            button12.Text = "button1";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(12, 216);
            button11.Name = "button11";
            button11.Size = new Size(54, 33);
            button11.TabIndex = 4;
            button11.Text = "button1";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(12, 31);
            button10.Name = "button10";
            button10.Size = new Size(72, 33);
            button10.TabIndex = 4;
            button10.Text = "A/M";
            button10.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(1160, 177);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(54, 39);
            hScrollBar1.TabIndex = 8;
            // 
            // main
            // 
            main.Location = new Point(1012, 49);
            main.Margin = new Padding(5, 6, 5, 6);
            main.Maximum = 1D;
            main.Minimum = 0D;
            main.Name = "main";
            main.Size = new Size(54, 69);
            main.TabIndex = 3;
            main.Value = 0.5D;
            // 
            // session_out
            // 
            session_out.Location = new Point(1012, 147);
            session_out.Margin = new Padding(5, 6, 5, 6);
            session_out.Maximum = 1D;
            session_out.Minimum = 0D;
            session_out.Name = "session_out";
            session_out.Size = new Size(54, 69);
            session_out.TabIndex = 3;
            session_out.Value = 0.5D;
            // 
            // session_in
            // 
            session_in.Location = new Point(1012, 243);
            session_in.Margin = new Padding(5, 6, 5, 6);
            session_in.Maximum = 1D;
            session_in.Minimum = 0D;
            session_in.Name = "session_in";
            session_in.Size = new Size(54, 69);
            session_in.TabIndex = 3;
            session_in.Value = 0.5D;
            // 
            // booth
            // 
            booth.Location = new Point(1012, 341);
            booth.Margin = new Padding(5, 6, 5, 6);
            booth.Maximum = 1D;
            booth.Minimum = 0D;
            booth.Name = "booth";
            booth.Size = new Size(54, 69);
            booth.TabIndex = 3;
            booth.Value = 0.5D;
            // 
            // button8
            // 
            button8.Location = new Point(24, 69);
            button8.Name = "button8";
            button8.Size = new Size(54, 33);
            button8.TabIndex = 4;
            button8.Text = "SP-6 ASSIGN";
            button8.UseVisualStyleBackColor = true;
            // 
            // deck1_back
            // 
            deck1_back.Location = new Point(24, 130);
            deck1_back.Name = "deck1_back";
            deck1_back.Size = new Size(72, 33);
            deck1_back.TabIndex = 4;
            deck1_back.Text = "BACK";
            deck1_back.UseVisualStyleBackColor = true;
            // 
            // odt1_load
            // 
            odt1_load.Location = new Point(24, 177);
            odt1_load.Name = "odt1_load";
            odt1_load.Size = new Size(54, 39);
            odt1_load.TabIndex = 8;
            // 
            // efx_time
            // 
            efx_time.Location = new Point(40, 122);
            efx_time.Name = "efx_time";
            efx_time.Size = new Size(54, 39);
            efx_time.TabIndex = 8;
            efx_time.Scroll += efx_time_Scroll;
            // 
            // efx_filter
            // 
            efx_filter.AutoSize = true;
            efx_filter.Location = new Point(254, 481);
            efx_filter.Name = "efx_filter";
            efx_filter.Size = new Size(88, 29);
            efx_filter.TabIndex = 5;
            efx_filter.Text = "FILTER";
            efx_filter.UseVisualStyleBackColor = true;
            efx_filter.CheckedChanged += efx_filter_CheckedChanged;
            // 
            // efx_flanger
            // 
            efx_flanger.AutoSize = true;
            efx_flanger.Location = new Point(381, 481);
            efx_flanger.Name = "efx_flanger";
            efx_flanger.Size = new Size(113, 29);
            efx_flanger.TabIndex = 5;
            efx_flanger.Text = "FLANGER";
            efx_flanger.UseVisualStyleBackColor = true;
            efx_flanger.CheckedChanged += efx_flanger_CheckedChanged;
            // 
            // efx_phaser
            // 
            efx_phaser.AutoSize = true;
            efx_phaser.Location = new Point(508, 481);
            efx_phaser.Name = "efx_phaser";
            efx_phaser.Size = new Size(103, 29);
            efx_phaser.TabIndex = 5;
            efx_phaser.Text = "PHASER";
            efx_phaser.UseVisualStyleBackColor = true;
            efx_phaser.CheckedChanged += efx_phaser_CheckedChanged;
            // 
            // efx_echo
            // 
            efx_echo.AutoSize = true;
            efx_echo.Location = new Point(635, 481);
            efx_echo.Name = "efx_echo";
            efx_echo.Size = new Size(85, 29);
            efx_echo.TabIndex = 5;
            efx_echo.Text = "ECHO";
            efx_echo.UseVisualStyleBackColor = true;
            efx_echo.CheckedChanged += efx_echo_CheckedChanged;
            // 
            // efx_reverb
            // 
            efx_reverb.AutoSize = true;
            efx_reverb.Location = new Point(889, 481);
            efx_reverb.Name = "efx_reverb";
            efx_reverb.Size = new Size(99, 29);
            efx_reverb.TabIndex = 5;
            efx_reverb.Text = "REVERB";
            efx_reverb.UseVisualStyleBackColor = true;
            efx_reverb.CheckedChanged += efx_reverb_CheckedChanged;
            // 
            // efx_robot
            // 
            efx_robot.AutoSize = true;
            efx_robot.Location = new Point(762, 481);
            efx_robot.Name = "efx_robot";
            efx_robot.Size = new Size(95, 29);
            efx_robot.TabIndex = 5;
            efx_robot.Text = "ROBOT";
            efx_robot.UseVisualStyleBackColor = true;
            efx_robot.CheckedChanged += efx_robot_CheckedChanged;
            // 
            // efx_ext_insert
            // 
            efx_ext_insert.AutoSize = true;
            efx_ext_insert.Location = new Point(1016, 481);
            efx_ext_insert.Name = "efx_ext_insert";
            efx_ext_insert.Size = new Size(132, 29);
            efx_ext_insert.TabIndex = 5;
            efx_ext_insert.Text = "EXT. INSERT";
            efx_ext_insert.UseVisualStyleBackColor = true;
            efx_ext_insert.CheckedChanged += efx_ext_insert_CheckedChanged;
            // 
            // efx_beat
            // 
            efx_beat.Location = new Point(135, 122);
            efx_beat.Name = "efx_beat";
            efx_beat.Size = new Size(54, 39);
            efx_beat.TabIndex = 8;
            // 
            // efx_tap
            // 
            efx_tap.Location = new Point(235, 122);
            efx_tap.Name = "efx_tap";
            efx_tap.Size = new Size(54, 33);
            efx_tap.TabIndex = 4;
            efx_tap.Text = "TAP";
            efx_tap.UseVisualStyleBackColor = true;
            // 
            // efx_wyswietlacz
            // 
            efx_wyswietlacz.Location = new Point(437, 529);
            efx_wyswietlacz.Name = "efx_wyswietlacz";
            efx_wyswietlacz.Size = new Size(260, 134);
            efx_wyswietlacz.TabIndex = 9;
            // 
            // efx_on
            // 
            efx_on.AutoSize = true;
            efx_on.Location = new Point(639, 122);
            efx_on.Name = "efx_on";
            efx_on.Size = new Size(65, 29);
            efx_on.TabIndex = 5;
            efx_on.Text = "ON";
            efx_on.UseVisualStyleBackColor = true;
            // 
            // efx_cue
            // 
            efx_cue.AutoSize = true;
            efx_cue.Location = new Point(766, 122);
            efx_cue.Name = "efx_cue";
            efx_cue.Size = new Size(70, 29);
            efx_cue.TabIndex = 5;
            efx_cue.Text = "CUE";
            efx_cue.UseVisualStyleBackColor = true;
            // 
            // efx_depth
            // 
            efx_depth.Location = new Point(911, 104);
            efx_depth.Margin = new Padding(5, 6, 5, 6);
            efx_depth.Maximum = 10D;
            efx_depth.Minimum = 0D;
            efx_depth.Name = "efx_depth";
            efx_depth.Size = new Size(54, 69);
            efx_depth.TabIndex = 3;
            efx_depth.Value = 0D;
            // 
            // efx
            // 
            efx.Controls.Add(efx_tap);
            efx.Controls.Add(efx_time);
            efx.Controls.Add(efx_beat);
            efx.Controls.Add(efx_on);
            efx.Controls.Add(efx_cue);
            efx.Controls.Add(efx_depth);
            efx.Location = new Point(105, 458);
            efx.Name = "efx";
            efx.Size = new Size(1025, 232);
            efx.TabIndex = 7;
            // 
            // loops2
            // 
            loops2.Controls.Add(button15);
            loops2.Controls.Add(hScrollBar6);
            loops2.Controls.Add(button16);
            loops2.Controls.Add(button17);
            loops2.Controls.Add(button18);
            loops2.Controls.Add(button19);
            loops2.Location = new Point(1148, 214);
            loops2.Name = "loops2";
            loops2.Size = new Size(87, 528);
            loops2.TabIndex = 7;
            // 
            // button15
            // 
            button15.Location = new Point(12, 460);
            button15.Name = "button15";
            button15.Size = new Size(54, 33);
            button15.TabIndex = 4;
            button15.Text = "button1";
            button15.UseVisualStyleBackColor = true;
            // 
            // hScrollBar6
            // 
            hScrollBar6.Location = new Point(12, 131);
            hScrollBar6.Name = "hScrollBar6";
            hScrollBar6.Size = new Size(54, 39);
            hScrollBar6.TabIndex = 8;
            // 
            // button16
            // 
            button16.Location = new Point(12, 384);
            button16.Name = "button16";
            button16.Size = new Size(54, 33);
            button16.TabIndex = 4;
            button16.Text = "button1";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(12, 305);
            button17.Name = "button17";
            button17.Size = new Size(54, 33);
            button17.TabIndex = 4;
            button17.Text = "button1";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(12, 216);
            button18.Name = "button18";
            button18.Size = new Size(54, 33);
            button18.TabIndex = 4;
            button18.Text = "button1";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(3, 31);
            button19.Name = "button19";
            button19.Size = new Size(72, 33);
            button19.TabIndex = 4;
            button19.Text = "A/M";
            button19.UseVisualStyleBackColor = true;
            // 
            // odt1_cue1
            // 
            odt1_cue1.Location = new Point(145, 743);
            odt1_cue1.Name = "odt1_cue1";
            odt1_cue1.Size = new Size(71, 33);
            odt1_cue1.TabIndex = 4;
            odt1_cue1.Text = "CUE1";
            odt1_cue1.UseVisualStyleBackColor = true;
            // 
            // odt1_cue2
            // 
            odt1_cue2.Location = new Point(222, 743);
            odt1_cue2.Name = "odt1_cue2";
            odt1_cue2.Size = new Size(70, 33);
            odt1_cue2.TabIndex = 4;
            odt1_cue2.Text = "CUE2";
            odt1_cue2.UseVisualStyleBackColor = true;
            // 
            // odt1_cue3
            // 
            odt1_cue3.Location = new Point(298, 743);
            odt1_cue3.Name = "odt1_cue3";
            odt1_cue3.Size = new Size(71, 33);
            odt1_cue3.TabIndex = 4;
            odt1_cue3.Text = "CUE3";
            odt1_cue3.UseVisualStyleBackColor = true;
            // 
            // odt1_cue4
            // 
            odt1_cue4.Location = new Point(375, 743);
            odt1_cue4.Name = "odt1_cue4";
            odt1_cue4.Size = new Size(63, 33);
            odt1_cue4.TabIndex = 4;
            odt1_cue4.Text = "CUE4";
            odt1_cue4.UseVisualStyleBackColor = true;
            // 
            // odt1_cue5
            // 
            odt1_cue5.Location = new Point(339, 31);
            odt1_cue5.Name = "odt1_cue5";
            odt1_cue5.Size = new Size(68, 33);
            odt1_cue5.TabIndex = 4;
            odt1_cue5.Text = "CUE5";
            odt1_cue5.UseVisualStyleBackColor = true;
            // 
            // odt2_cue1
            // 
            odt2_cue1.Location = new Point(706, 743);
            odt2_cue1.Name = "odt2_cue1";
            odt2_cue1.Size = new Size(71, 33);
            odt2_cue1.TabIndex = 4;
            odt2_cue1.Text = "CUE1";
            odt2_cue1.UseVisualStyleBackColor = true;
            // 
            // odt2_cue3
            // 
            odt2_cue3.Location = new Point(859, 743);
            odt2_cue3.Name = "odt2_cue3";
            odt2_cue3.Size = new Size(71, 33);
            odt2_cue3.TabIndex = 4;
            odt2_cue3.Text = "CUE3";
            odt2_cue3.UseVisualStyleBackColor = true;
            // 
            // odt2_cue2
            // 
            odt2_cue2.Location = new Point(783, 743);
            odt2_cue2.Name = "odt2_cue2";
            odt2_cue2.Size = new Size(70, 33);
            odt2_cue2.TabIndex = 4;
            odt2_cue2.Text = "CUE2";
            odt2_cue2.UseVisualStyleBackColor = true;
            // 
            // odt2_cue4
            // 
            odt2_cue4.Location = new Point(936, 743);
            odt2_cue4.Name = "odt2_cue4";
            odt2_cue4.Size = new Size(62, 33);
            odt2_cue4.TabIndex = 4;
            odt2_cue4.Text = "CUE4";
            odt2_cue4.UseVisualStyleBackColor = true;
            // 
            // odt2_cue5
            // 
            odt2_cue5.Location = new Point(1016, 743);
            odt2_cue5.Name = "odt2_cue5";
            odt2_cue5.Size = new Size(68, 33);
            odt2_cue5.TabIndex = 4;
            odt2_cue5.Text = "CUE5";
            odt2_cue5.UseVisualStyleBackColor = true;
            // 
            // cue
            // 
            cue.Controls.Add(chBox_cue_samples);
            cue.Controls.Add(odt1_cue5);
            cue.Location = new Point(105, 712);
            cue.Name = "cue";
            cue.Size = new Size(1025, 104);
            cue.TabIndex = 7;
            // 
            // chBox_cue_samples
            // 
            chBox_cue_samples.AutoSize = true;
            chBox_cue_samples.Location = new Point(445, 35);
            chBox_cue_samples.Name = "chBox_cue_samples";
            chBox_cue_samples.Size = new Size(121, 29);
            chBox_cue_samples.TabIndex = 5;
            chBox_cue_samples.Text = "checkBox1";
            chBox_cue_samples.UseVisualStyleBackColor = true;
            // 
            // odt1_cue_pgm1
            // 
            odt1_cue_pgm1.AutoSize = true;
            odt1_cue_pgm1.Location = new Point(176, 878);
            odt1_cue_pgm1.Name = "odt1_cue_pgm1";
            odt1_cue_pgm1.Size = new Size(128, 29);
            odt1_cue_pgm1.TabIndex = 5;
            odt1_cue_pgm1.Text = "CUE PGM 1";
            odt1_cue_pgm1.UseVisualStyleBackColor = true;
            // 
            // btn_cue_usb_aux
            // 
            btn_cue_usb_aux.AutoSize = true;
            btn_cue_usb_aux.Location = new Point(550, 878);
            btn_cue_usb_aux.Name = "btn_cue_usb_aux";
            btn_cue_usb_aux.Size = new Size(147, 29);
            btn_cue_usb_aux.TabIndex = 5;
            btn_cue_usb_aux.Text = "CUE USB AUX";
            btn_cue_usb_aux.UseVisualStyleBackColor = true;
            // 
            // odt2_cue_pgm2
            // 
            odt2_cue_pgm2.AutoSize = true;
            odt2_cue_pgm2.Location = new Point(889, 878);
            odt2_cue_pgm2.Name = "odt2_cue_pgm2";
            odt2_cue_pgm2.Size = new Size(128, 29);
            odt2_cue_pgm2.TabIndex = 5;
            odt2_cue_pgm2.Text = "CUE PGM 2";
            odt2_cue_pgm2.UseVisualStyleBackColor = true;
            // 
            // aux_filter
            // 
            aux_filter.Location = new Point(24, 896);
            aux_filter.Margin = new Padding(5, 6, 5, 6);
            aux_filter.Maximum = 1D;
            aux_filter.Minimum = 0D;
            aux_filter.Name = "aux_filter";
            aux_filter.Size = new Size(54, 69);
            aux_filter.TabIndex = 3;
            aux_filter.Value = 0.5D;
            // 
            // aux_flexfx
            // 
            aux_flexfx.AutoSize = true;
            aux_flexfx.Location = new Point(24, 994);
            aux_flexfx.Name = "aux_flexfx";
            aux_flexfx.Size = new Size(95, 29);
            aux_flexfx.TabIndex = 5;
            aux_flexfx.Text = "FLEXFX";
            aux_flexfx.UseVisualStyleBackColor = true;
            // 
            // panel_aux
            // 
            panel_aux.Location = new Point(12, 782);
            panel_aux.Name = "panel_aux";
            panel_aux.Size = new Size(87, 269);
            panel_aux.TabIndex = 10;
            // 
            // panel_phones
            // 
            panel_phones.Location = new Point(1148, 782);
            panel_phones.Name = "panel_phones";
            panel_phones.Size = new Size(87, 269);
            panel_phones.TabIndex = 10;
            // 
            // phones_level
            // 
            phones_level.Location = new Point(1160, 798);
            phones_level.Margin = new Padding(5, 6, 5, 6);
            phones_level.Maximum = 1D;
            phones_level.Minimum = 0D;
            phones_level.Name = "phones_level";
            phones_level.Size = new Size(54, 69);
            phones_level.TabIndex = 3;
            phones_level.Value = 0.5D;
            // 
            // phones_pan
            // 
            phones_pan.Location = new Point(1160, 896);
            phones_pan.Margin = new Padding(5, 6, 5, 6);
            phones_pan.Maximum = 1D;
            phones_pan.Minimum = 0D;
            phones_pan.Name = "phones_pan";
            phones_pan.Size = new Size(54, 69);
            phones_pan.TabIndex = 3;
            phones_pan.Value = 0.5D;
            // 
            // phones_split_sue
            // 
            phones_split_sue.AutoSize = true;
            phones_split_sue.Location = new Point(1160, 994);
            phones_split_sue.Name = "phones_split_sue";
            phones_split_sue.Size = new Size(117, 29);
            phones_split_sue.TabIndex = 5;
            phones_split_sue.Text = "SPLIT CUE";
            phones_split_sue.UseVisualStyleBackColor = true;
            // 
            // mix
            // 
            mix.Location = new Point(975, 41);
            mix.Name = "mix";
            mix.Size = new Size(132, 407);
            mix.TabIndex = 7;
            // 
            // mic
            // 
            mic.Controls.Add(odt1_volume);
            mic.Controls.Add(mic_flexfx);
            mic.Location = new Point(105, 41);
            mic.Name = "mic";
            mic.Size = new Size(163, 399);
            mic.TabIndex = 7;
            // 
            // mic_flexfx
            // 
            mic_flexfx.AutoSize = true;
            mic_flexfx.Location = new Point(11, 356);
            mic_flexfx.Name = "mic_flexfx";
            mic_flexfx.Size = new Size(95, 29);
            mic_flexfx.TabIndex = 5;
            mic_flexfx.Text = "FLEXFX";
            mic_flexfx.UseVisualStyleBackColor = true;
            // 
            // odt2_upfader
            // 
            odt2_upfader.Location = new Point(889, 1043);
            odt2_upfader.Name = "odt2_upfader";
            odt2_upfader.Size = new Size(68, 383);
            odt2_upfader.TabIndex = 13;
            // 
            // odt1_upfader
            // 
            odt1_upfader.AutoScroll = true;
            odt1_upfader.ForeColor = SystemColors.ControlText;
            odt1_upfader.Location = new Point(274, 1043);
            odt1_upfader.Name = "odt1_upfader";
            odt1_upfader.Size = new Size(68, 383);
            odt1_upfader.TabIndex = 13;
            // 
            // fader1
            // 
            fader1.Location = new Point(403, 1425);
            fader1.Maximum = 0;
            fader1.Minimum = 1;
            fader1.Name = "fader1";
            fader1.Orientation = Orientation.Horizontal;
            fader1.Size = new Size(427, 124);
            fader1.TabIndex = 14;
            fader1.Text = "fader1";
            fader1.Value = 1;
            // 
            // Mikser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1319, 1570);
            Controls.Add(fader1);
            Controls.Add(odt1_upfader);
            Controls.Add(odt2_upfader);
            Controls.Add(mainVolumeLeft);
            Controls.Add(mainVolumeRight);
            Controls.Add(efx_wyswietlacz);
            Controls.Add(odt1_load);
            Controls.Add(hScrollBar1);
            Controls.Add(odt2_source);
            Controls.Add(odt1_source);
            Controls.Add(odt2_flexfx);
            Controls.Add(efx_ext_insert);
            Controls.Add(efx_phaser);
            Controls.Add(efx_robot);
            Controls.Add(efx_filter);
            Controls.Add(efx_reverb);
            Controls.Add(odt2_cue_pgm2);
            Controls.Add(btn_cue_usb_aux);
            Controls.Add(phones_split_sue);
            Controls.Add(aux_flexfx);
            Controls.Add(odt1_cue_pgm1);
            Controls.Add(efx_flanger);
            Controls.Add(efx_echo);
            Controls.Add(efx_insert);
            Controls.Add(low_odt2);
            Controls.Add(deck1_back);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(odt2_cue5);
            Controls.Add(odt2_cue4);
            Controls.Add(odt1_cue4);
            Controls.Add(odt2_cue2);
            Controls.Add(odt1_cue2);
            Controls.Add(odt2_cue3);
            Controls.Add(odt1_cue3);
            Controls.Add(odt2_cue1);
            Controls.Add(odt1_cue1);
            Controls.Add(mic_over);
            Controls.Add(mic_on);
            Controls.Add(booth);
            Controls.Add(phones_pan);
            Controls.Add(aux_filter);
            Controls.Add(phones_level);
            Controls.Add(aux_level);
            Controls.Add(filter_odt2);
            Controls.Add(filter_odt1);
            Controls.Add(mid_odt2);
            Controls.Add(mic_low);
            Controls.Add(session_in);
            Controls.Add(mid_odt1);
            Controls.Add(mic_high);
            Controls.Add(high_odt2);
            Controls.Add(session_out);
            Controls.Add(high_odt1);
            Controls.Add(mic_level);
            Controls.Add(level_odt2);
            Controls.Add(main);
            Controls.Add(level_odt1);
            Controls.Add(pan_odt2);
            Controls.Add(pan_odt1);
            Controls.Add(mix);
            Controls.Add(odt2);
            Controls.Add(efx);
            Controls.Add(loops2);
            Controls.Add(loops1);
            Controls.Add(cue);
            Controls.Add(mic);
            Controls.Add(odt1);
            Controls.Add(panel_phones);
            Controls.Add(panel_aux);
            Name = "Mikser";
            Text = "Form1";
            odt1.ResumeLayout(false);
            odt1.PerformLayout();
            odt2.ResumeLayout(false);
            loops1.ResumeLayout(false);
            efx.ResumeLayout(false);
            efx.PerformLayout();
            loops2.ResumeLayout(false);
            cue.ResumeLayout(false);
            cue.PerformLayout();
            mic.ResumeLayout(false);
            mic.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NAudio.Gui.PanSlider pan_odt1;
        private NAudio.Gui.Pot high_odt1;
        private NAudio.Gui.Pot mid_odt1;
        private NAudio.Gui.Pot aux_level;
        private NAudio.Gui.Pot filter_odt1;
        private NAudio.Gui.PanSlider pan_odt2;
        private NAudio.Gui.Pot high_odt2;
        private NAudio.Gui.Pot mid_odt2;
        private NAudio.Gui.Pot filter_odt2;
        private NAudio.Gui.Pot low_odt2;
        private NAudio.Gui.Pot mic_level;
        private NAudio.Gui.Pot mic_high;
        private NAudio.Gui.Pot mic_low;
        private Button mic_on;
        private Button mic_over;
        private Button qwe;
        private Button button1;
        private ImageList imageList1;
        private Button button2;
        private CheckBox efx_insert;
        private CheckBox odt2_flexfx;
        private ComboBox odt1_source;
        private ComboBox odt2_source;
        private Panel odt1;
        private Panel odt2;
        private Panel loops1;
        private HScrollBar hScrollBar1;
        private NAudio.Gui.Pot main;
        private NAudio.Gui.Pot session_out;
        private NAudio.Gui.Pot session_in;
        private NAudio.Gui.Pot booth;
        private Button button8;
        private Button deck1_back;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private HScrollBar odt1_load;
        private HScrollBar hScrollBar5;
        private HScrollBar efx_time;
        private CheckBox efx_filter;
        private CheckBox efx_flanger;
        private CheckBox efx_phaser;
        private CheckBox efx_echo;
        private CheckBox efx_reverb;
        private CheckBox efx_robot;
        private CheckBox efx_ext_insert;
        private HScrollBar efx_beat;
        private Button efx_tap;
        private Panel efx_wyswietlacz;
        private CheckBox efx_on;
        private CheckBox efx_cue;
        private NAudio.Gui.Pot efx_depth;
        private Panel efx;
        private Panel loops2;
        private Button button15;
        private HScrollBar hScrollBar6;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button odt1_cue1;
        private Button odt1_cue2;
        private Button odt1_cue3;
        private Button odt1_cue4;
        private Button odt1_cue5;
        private Button odt2_cue1;
        private Button odt2_cue3;
        private Button odt2_cue2;
        private Button odt2_cue4;
        private Button odt2_cue5;
        private Panel cue;
        private CheckBox odt1_cue_pgm1;
        private CheckBox btn_cue_usb_aux;
        private CheckBox odt2_cue_pgm2;
        private NAudio.Gui.Pot aux_filter;
        private CheckBox aux_flexfx;
        private Panel panel_aux;
        private Panel panel_phones;
        private NAudio.Gui.Pot phones_level;
        private NAudio.Gui.Pot phones_pan;
        private CheckBox phones_split_sue;
        private NumericUpDown odt1_upfaer;
        private NumericUpDown odt2_upfaer;
        private NumericUpDown cross_fader;
        private NAudio.Gui.Pot odt1_low;
        private CheckBox odt1_flexfx;
        private Panel mix;
        private Panel mic;
        private CheckBox mic_flexfx;
        private NAudio.Gui.VolumeMeter odt1_volume;
        private NAudio.Gui.VolumeMeter mainVolumeRight;
        private NAudio.Gui.VolumeMeter mainVolumeLeft;
        private NAudio.Gui.VolumeMeter odt2_volume;
        private NAudio.Gui.VolumeSlider odt2_upfader;
        public NAudio.Gui.VolumeSlider odt1_upfader;
        private CheckBox chBox_cue_samples;
        private NAudio.Gui.VolumeMeter volumeMeter_ch1;
        private NAudio.Gui.Fader fader1;
        internal NAudio.Gui.Pot level_odt1;
        internal NAudio.Gui.Pot level_odt2;
    }
}
