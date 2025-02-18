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
            pan_odt1 = new NAudio.Gui.PanSlider();
            gain_ch1 = new NAudio.Gui.Pot();
            high_odt1 = new NAudio.Gui.Pot();
            mid_odt1 = new NAudio.Gui.Pot();
            aux_level = new NAudio.Gui.Pot();
            filter_odt1 = new NAudio.Gui.Pot();
            pan_odt2 = new NAudio.Gui.PanSlider();
            gain_ch2 = new NAudio.Gui.Pot();
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
            low_odt1 = new NAudio.Gui.Pot();
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
            hScrollBar2 = new HScrollBar();
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
            pan_odt1.Location = new Point(264, 130);
            pan_odt1.Margin = new Padding(2);
            pan_odt1.Name = "pan_odt1";
            pan_odt1.Pan = 0F;
            pan_odt1.Size = new Size(66, 32);
            pan_odt1.TabIndex = 1;
            // 
            // gain_ch1
            // 
            gain_ch1.Location = new Point(389, 39);
            gain_ch1.Margin = new Padding(4, 5, 4, 5);
            gain_ch1.Maximum = 1D;
            gain_ch1.Minimum = 0D;
            gain_ch1.Name = "gain_ch1";
            gain_ch1.Size = new Size(43, 55);
            gain_ch1.TabIndex = 3;
            gain_ch1.Value = 0D;
            gain_ch1.ValueChanged += level_odt1_ValueChanged;
            // 
            // high_odt1
            // 
            high_odt1.Location = new Point(389, 118);
            high_odt1.Margin = new Padding(4, 5, 4, 5);
            high_odt1.Maximum = 30D;
            high_odt1.Minimum = -30D;
            high_odt1.Name = "high_odt1";
            high_odt1.Size = new Size(43, 55);
            high_odt1.TabIndex = 3;
            high_odt1.Value = 0D;
            high_odt1.ValueChanged += high_odt1_ValueChanged;
            // 
            // mid_odt1
            // 
            mid_odt1.Location = new Point(389, 194);
            mid_odt1.Margin = new Padding(4, 5, 4, 5);
            mid_odt1.Maximum = 30D;
            mid_odt1.Minimum = -30D;
            mid_odt1.Name = "mid_odt1";
            mid_odt1.Size = new Size(43, 55);
            mid_odt1.TabIndex = 3;
            mid_odt1.Value = 0D;
            mid_odt1.ValueChanged += mid_odt1_ValueChanged;
            // 
            // aux_level
            // 
            aux_level.Location = new Point(19, 638);
            aux_level.Margin = new Padding(4, 5, 4, 5);
            aux_level.Maximum = 1D;
            aux_level.Minimum = 0D;
            aux_level.Name = "aux_level";
            aux_level.Size = new Size(43, 55);
            aux_level.TabIndex = 3;
            aux_level.Value = 0.5D;
            // 
            // filter_odt1
            // 
            filter_odt1.Location = new Point(272, 192);
            filter_odt1.Margin = new Padding(4, 5, 4, 5);
            filter_odt1.Maximum = 1D;
            filter_odt1.Minimum = 0D;
            filter_odt1.Name = "filter_odt1";
            filter_odt1.Size = new Size(43, 55);
            filter_odt1.TabIndex = 3;
            filter_odt1.Value = 0.5D;
            // 
            // pan_odt2
            // 
            pan_odt2.Location = new Point(613, 130);
            pan_odt2.Margin = new Padding(2);
            pan_odt2.Name = "pan_odt2";
            pan_odt2.Pan = 0F;
            pan_odt2.Size = new Size(66, 32);
            pan_odt2.TabIndex = 1;
            // 
            // gain_ch2
            // 
            gain_ch2.Location = new Point(514, 39);
            gain_ch2.Margin = new Padding(4, 5, 4, 5);
            gain_ch2.Maximum = 1D;
            gain_ch2.Minimum = 0D;
            gain_ch2.Name = "gain_ch2";
            gain_ch2.Size = new Size(43, 55);
            gain_ch2.TabIndex = 3;
            gain_ch2.Value = 0D;
            gain_ch2.ValueChanged += level_odt2_ValueChanged;
            // 
            // high_odt2
            // 
            high_odt2.Location = new Point(514, 118);
            high_odt2.Margin = new Padding(4, 5, 4, 5);
            high_odt2.Maximum = 1D;
            high_odt2.Minimum = 0D;
            high_odt2.Name = "high_odt2";
            high_odt2.Size = new Size(43, 55);
            high_odt2.TabIndex = 3;
            high_odt2.Value = 0.5D;
            // 
            // mid_odt2
            // 
            mid_odt2.Location = new Point(514, 194);
            mid_odt2.Margin = new Padding(4, 5, 4, 5);
            mid_odt2.Maximum = 1D;
            mid_odt2.Minimum = 0D;
            mid_odt2.Name = "mid_odt2";
            mid_odt2.Size = new Size(43, 55);
            mid_odt2.TabIndex = 3;
            mid_odt2.Value = 0.5D;
            // 
            // filter_odt2
            // 
            filter_odt2.Location = new Point(621, 192);
            filter_odt2.Margin = new Padding(4, 5, 4, 5);
            filter_odt2.Maximum = 1D;
            filter_odt2.Minimum = 0D;
            filter_odt2.Name = "filter_odt2";
            filter_odt2.Size = new Size(43, 55);
            filter_odt2.TabIndex = 3;
            filter_odt2.Value = 0.5D;
            // 
            // low_odt2
            // 
            low_odt2.Location = new Point(514, 273);
            low_odt2.Margin = new Padding(4, 5, 4, 5);
            low_odt2.Maximum = 1D;
            low_odt2.Minimum = 0D;
            low_odt2.Name = "low_odt2";
            low_odt2.Size = new Size(43, 55);
            low_odt2.TabIndex = 3;
            low_odt2.Value = 0.5D;
            // 
            // mic_level
            // 
            mic_level.Location = new Point(116, 89);
            mic_level.Margin = new Padding(4, 5, 4, 5);
            mic_level.Maximum = 1D;
            mic_level.Minimum = 0D;
            mic_level.Name = "mic_level";
            mic_level.Size = new Size(43, 55);
            mic_level.TabIndex = 3;
            mic_level.Value = 0.5D;
            // 
            // mic_high
            // 
            mic_high.Location = new Point(116, 167);
            mic_high.Margin = new Padding(4, 5, 4, 5);
            mic_high.Maximum = 1D;
            mic_high.Minimum = 0D;
            mic_high.Name = "mic_high";
            mic_high.Size = new Size(43, 55);
            mic_high.TabIndex = 3;
            mic_high.Value = 0.5D;
            // 
            // mic_low
            // 
            mic_low.Location = new Point(116, 244);
            mic_low.Margin = new Padding(4, 5, 4, 5);
            mic_low.Maximum = 1D;
            mic_low.Minimum = 0D;
            mic_low.Name = "mic_low";
            mic_low.Size = new Size(43, 55);
            mic_low.TabIndex = 3;
            mic_low.Value = 0.5D;
            // 
            // mic_on
            // 
            mic_on.Location = new Point(93, 55);
            mic_on.Margin = new Padding(2);
            mic_on.Name = "mic_on";
            mic_on.Size = new Size(43, 26);
            mic_on.TabIndex = 4;
            mic_on.Text = "button1";
            mic_on.UseVisualStyleBackColor = true;
            // 
            // mic_over
            // 
            mic_over.Location = new Point(141, 55);
            mic_over.Margin = new Padding(2);
            mic_over.Name = "mic_over";
            mic_over.Size = new Size(43, 26);
            mic_over.TabIndex = 4;
            mic_over.Text = "button1";
            mic_over.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(928, 55);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(43, 26);
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
            button2.Location = new Point(928, 104);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(43, 26);
            button2.TabIndex = 4;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            // 
            // efx_insert
            // 
            efx_insert.AutoSize = true;
            efx_insert.Location = new Point(102, 385);
            efx_insert.Margin = new Padding(2);
            efx_insert.Name = "efx_insert";
            efx_insert.Size = new Size(78, 24);
            efx_insert.TabIndex = 5;
            efx_insert.Text = "INSERT";
            efx_insert.UseVisualStyleBackColor = true;
            efx_insert.CheckedChanged += efx_insert_CheckedChanged;
            // 
            // odt2_flexfx
            // 
            odt2_flexfx.AutoSize = true;
            odt2_flexfx.Location = new Point(621, 276);
            odt2_flexfx.Margin = new Padding(2);
            odt2_flexfx.Name = "odt2_flexfx";
            odt2_flexfx.Size = new Size(78, 24);
            odt2_flexfx.TabIndex = 5;
            odt2_flexfx.Text = "FLEXFX";
            odt2_flexfx.UseVisualStyleBackColor = true;
            // 
            // odt1_source
            // 
            odt1_source.FormattingEnabled = true;
            odt1_source.Location = new Point(258, 56);
            odt1_source.Margin = new Padding(2);
            odt1_source.Name = "odt1_source";
            odt1_source.Size = new Size(73, 28);
            odt1_source.TabIndex = 6;
            // 
            // odt2_source
            // 
            odt2_source.FormattingEnabled = true;
            odt2_source.Location = new Point(607, 56);
            odt2_source.Margin = new Padding(2);
            odt2_source.Name = "odt2_source";
            odt2_source.Size = new Size(73, 28);
            odt2_source.TabIndex = 6;
            // 
            // odt1
            // 
            odt1.Controls.Add(volumeMeter_ch1);
            odt1.Controls.Add(low_odt1);
            odt1.Controls.Add(odt1_flexfx);
            odt1.Location = new Point(238, 33);
            odt1.Margin = new Padding(2);
            odt1.Name = "odt1";
            odt1.Size = new Size(233, 319);
            odt1.TabIndex = 7;
            // 
            // volumeMeter_ch1
            // 
            volumeMeter_ch1.Amplitude = 0F;
            volumeMeter_ch1.Location = new Point(117, 71);
            volumeMeter_ch1.Margin = new Padding(2);
            volumeMeter_ch1.MaxDb = 18F;
            volumeMeter_ch1.MinDb = -60F;
            volumeMeter_ch1.Name = "volumeMeter_ch1";
            volumeMeter_ch1.Size = new Size(24, 217);
            volumeMeter_ch1.TabIndex = 12;
            volumeMeter_ch1.Text = "volumeMeter1";
            // 
            // low_odt1
            // 
            low_odt1.Location = new Point(150, 240);
            low_odt1.Margin = new Padding(4, 5, 4, 5);
            low_odt1.Maximum = 30D;
            low_odt1.Minimum = -30D;
            low_odt1.Name = "low_odt1";
            low_odt1.Size = new Size(43, 55);
            low_odt1.TabIndex = 3;
            low_odt1.Value = 0D;
            low_odt1.ValueChanged += low_odt1_ValueChanged;
            // 
            // odt1_flexfx
            // 
            odt1_flexfx.AutoSize = true;
            odt1_flexfx.Location = new Point(34, 243);
            odt1_flexfx.Margin = new Padding(2);
            odt1_flexfx.Name = "odt1_flexfx";
            odt1_flexfx.Size = new Size(78, 24);
            odt1_flexfx.TabIndex = 5;
            odt1_flexfx.Text = "FLEXFX";
            odt1_flexfx.UseVisualStyleBackColor = true;
            // 
            // odt1_volume
            // 
            odt1_volume.Amplitude = 0F;
            odt1_volume.Location = new Point(94, 58);
            odt1_volume.Margin = new Padding(2);
            odt1_volume.MaxDb = 18F;
            odt1_volume.MinDb = -60F;
            odt1_volume.Name = "odt1_volume";
            odt1_volume.Size = new Size(24, 217);
            odt1_volume.TabIndex = 12;
            odt1_volume.Text = "volumeMeter1";
            // 
            // odt2
            // 
            odt2.Controls.Add(odt2_volume);
            odt2.Location = new Point(496, 33);
            odt2.Margin = new Padding(2);
            odt2.Name = "odt2";
            odt2.Size = new Size(201, 319);
            odt2.TabIndex = 7;
            // 
            // odt2_volume
            // 
            odt2_volume.Amplitude = 0F;
            odt2_volume.Location = new Point(78, 71);
            odt2_volume.Margin = new Padding(2);
            odt2_volume.MaxDb = 18F;
            odt2_volume.MinDb = -60F;
            odt2_volume.Name = "odt2_volume";
            odt2_volume.Size = new Size(24, 217);
            odt2_volume.TabIndex = 12;
            odt2_volume.Text = "volumeMeter1";
            // 
            // mainVolumeRight
            // 
            mainVolumeRight.Amplitude = 0F;
            mainVolumeRight.Location = new Point(749, 104);
            mainVolumeRight.Margin = new Padding(2);
            mainVolumeRight.MaxDb = 18F;
            mainVolumeRight.MinDb = -60F;
            mainVolumeRight.Name = "mainVolumeRight";
            mainVolumeRight.Size = new Size(24, 217);
            mainVolumeRight.TabIndex = 12;
            mainVolumeRight.Text = "volumeMeter1";
            // 
            // mainVolumeLeft
            // 
            mainVolumeLeft.Amplitude = 0F;
            mainVolumeLeft.Location = new Point(711, 104);
            mainVolumeLeft.Margin = new Padding(2);
            mainVolumeLeft.MaxDb = 18F;
            mainVolumeLeft.MinDb = -60F;
            mainVolumeLeft.Name = "mainVolumeLeft";
            mainVolumeLeft.Size = new Size(24, 217);
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
            loops1.Location = new Point(10, 171);
            loops1.Margin = new Padding(2);
            loops1.Name = "loops1";
            loops1.Size = new Size(70, 422);
            loops1.TabIndex = 7;
            // 
            // button14
            // 
            button14.Location = new Point(10, 368);
            button14.Margin = new Padding(2);
            button14.Name = "button14";
            button14.Size = new Size(43, 26);
            button14.TabIndex = 4;
            button14.Text = "button1";
            button14.UseVisualStyleBackColor = true;
            // 
            // hScrollBar5
            // 
            hScrollBar5.Location = new Point(10, 105);
            hScrollBar5.Name = "hScrollBar5";
            hScrollBar5.Size = new Size(43, 39);
            hScrollBar5.TabIndex = 8;
            // 
            // button13
            // 
            button13.Location = new Point(10, 307);
            button13.Margin = new Padding(2);
            button13.Name = "button13";
            button13.Size = new Size(43, 26);
            button13.TabIndex = 4;
            button13.Text = "button1";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(10, 244);
            button12.Margin = new Padding(2);
            button12.Name = "button12";
            button12.Size = new Size(43, 26);
            button12.TabIndex = 4;
            button12.Text = "button1";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(10, 173);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(43, 26);
            button11.TabIndex = 4;
            button11.Text = "button1";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(10, 25);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(58, 26);
            button10.TabIndex = 4;
            button10.Text = "A/M";
            button10.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(928, 142);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(43, 39);
            hScrollBar1.TabIndex = 8;
            // 
            // main
            // 
            main.Location = new Point(810, 39);
            main.Margin = new Padding(4, 5, 4, 5);
            main.Maximum = 1D;
            main.Minimum = 0D;
            main.Name = "main";
            main.Size = new Size(43, 55);
            main.TabIndex = 3;
            main.Value = 0.5D;
            // 
            // session_out
            // 
            session_out.Location = new Point(810, 118);
            session_out.Margin = new Padding(4, 5, 4, 5);
            session_out.Maximum = 1D;
            session_out.Minimum = 0D;
            session_out.Name = "session_out";
            session_out.Size = new Size(43, 55);
            session_out.TabIndex = 3;
            session_out.Value = 0.5D;
            // 
            // session_in
            // 
            session_in.Location = new Point(810, 194);
            session_in.Margin = new Padding(4, 5, 4, 5);
            session_in.Maximum = 1D;
            session_in.Minimum = 0D;
            session_in.Name = "session_in";
            session_in.Size = new Size(43, 55);
            session_in.TabIndex = 3;
            session_in.Value = 0.5D;
            // 
            // booth
            // 
            booth.Location = new Point(810, 273);
            booth.Margin = new Padding(4, 5, 4, 5);
            booth.Maximum = 1D;
            booth.Minimum = 0D;
            booth.Name = "booth";
            booth.Size = new Size(43, 55);
            booth.TabIndex = 3;
            booth.Value = 0.5D;
            // 
            // button8
            // 
            button8.Location = new Point(19, 55);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(43, 26);
            button8.TabIndex = 4;
            button8.Text = "SP-6 ASSIGN";
            button8.UseVisualStyleBackColor = true;
            // 
            // deck1_back
            // 
            deck1_back.Location = new Point(19, 104);
            deck1_back.Margin = new Padding(2);
            deck1_back.Name = "deck1_back";
            deck1_back.Size = new Size(58, 26);
            deck1_back.TabIndex = 4;
            deck1_back.Text = "BACK";
            deck1_back.UseVisualStyleBackColor = true;
            // 
            // odt1_load
            // 
            odt1_load.Location = new Point(19, 142);
            odt1_load.Name = "odt1_load";
            odt1_load.Size = new Size(43, 39);
            odt1_load.TabIndex = 8;
            // 
            // efx_time
            // 
            efx_time.Location = new Point(32, 98);
            efx_time.Name = "efx_time";
            efx_time.Size = new Size(43, 39);
            efx_time.TabIndex = 8;
            efx_time.Scroll += efx_time_Scroll;
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
            // efx_ext_insert
            // 
            efx_ext_insert.AutoSize = true;
            efx_ext_insert.Location = new Point(813, 385);
            efx_ext_insert.Margin = new Padding(2);
            efx_ext_insert.Name = "efx_ext_insert";
            efx_ext_insert.Size = new Size(110, 24);
            efx_ext_insert.TabIndex = 5;
            efx_ext_insert.Text = "EXT. INSERT";
            efx_ext_insert.UseVisualStyleBackColor = true;
            efx_ext_insert.CheckedChanged += efx_ext_insert_CheckedChanged;
            // 
            // efx_beat
            // 
            efx_beat.Location = new Point(108, 98);
            efx_beat.Name = "efx_beat";
            efx_beat.Size = new Size(43, 39);
            efx_beat.TabIndex = 8;
            // 
            // efx_tap
            // 
            efx_tap.Location = new Point(188, 98);
            efx_tap.Margin = new Padding(2);
            efx_tap.Name = "efx_tap";
            efx_tap.Size = new Size(43, 26);
            efx_tap.TabIndex = 4;
            efx_tap.Text = "TAP";
            efx_tap.UseVisualStyleBackColor = true;
            // 
            // efx_wyswietlacz
            // 
            efx_wyswietlacz.Location = new Point(350, 423);
            efx_wyswietlacz.Margin = new Padding(2);
            efx_wyswietlacz.Name = "efx_wyswietlacz";
            efx_wyswietlacz.Size = new Size(208, 107);
            efx_wyswietlacz.TabIndex = 9;
            // 
            // efx_on
            // 
            efx_on.AutoSize = true;
            efx_on.Location = new Point(511, 98);
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
            efx_cue.Location = new Point(613, 98);
            efx_cue.Margin = new Padding(2);
            efx_cue.Name = "efx_cue";
            efx_cue.Size = new Size(58, 24);
            efx_cue.TabIndex = 5;
            efx_cue.Text = "CUE";
            efx_cue.UseVisualStyleBackColor = true;
            // 
            // efx_depth
            // 
            efx_depth.Location = new Point(729, 83);
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
            efx.Controls.Add(efx_tap);
            efx.Controls.Add(efx_time);
            efx.Controls.Add(efx_beat);
            efx.Controls.Add(efx_on);
            efx.Controls.Add(efx_cue);
            efx.Controls.Add(efx_depth);
            efx.Location = new Point(84, 366);
            efx.Margin = new Padding(2);
            efx.Name = "efx";
            efx.Size = new Size(820, 186);
            efx.TabIndex = 7;
            // 
            // loops2
            // 
            loops2.Controls.Add(hScrollBar2);
            loops2.Controls.Add(button15);
            loops2.Controls.Add(hScrollBar6);
            loops2.Controls.Add(button16);
            loops2.Controls.Add(button17);
            loops2.Controls.Add(button18);
            loops2.Controls.Add(button19);
            loops2.Location = new Point(918, 171);
            loops2.Margin = new Padding(2);
            loops2.Name = "loops2";
            loops2.Size = new Size(70, 422);
            loops2.TabIndex = 7;
            // 
            // hScrollBar2
            // 
            hScrollBar2.Location = new Point(29, 417);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(8, 8);
            hScrollBar2.TabIndex = 9;
            // 
            // button15
            // 
            button15.Location = new Point(10, 368);
            button15.Margin = new Padding(2);
            button15.Name = "button15";
            button15.Size = new Size(43, 26);
            button15.TabIndex = 4;
            button15.Text = "button1";
            button15.UseVisualStyleBackColor = true;
            // 
            // hScrollBar6
            // 
            hScrollBar6.Location = new Point(10, 105);
            hScrollBar6.Name = "hScrollBar6";
            hScrollBar6.Size = new Size(43, 39);
            hScrollBar6.TabIndex = 8;
            // 
            // button16
            // 
            button16.Location = new Point(10, 307);
            button16.Margin = new Padding(2);
            button16.Name = "button16";
            button16.Size = new Size(43, 26);
            button16.TabIndex = 4;
            button16.Text = "button1";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(10, 244);
            button17.Margin = new Padding(2);
            button17.Name = "button17";
            button17.Size = new Size(43, 26);
            button17.TabIndex = 4;
            button17.Text = "button1";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(10, 173);
            button18.Margin = new Padding(2);
            button18.Name = "button18";
            button18.Size = new Size(43, 26);
            button18.TabIndex = 4;
            button18.Text = "button1";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(2, 25);
            button19.Margin = new Padding(2);
            button19.Name = "button19";
            button19.Size = new Size(58, 26);
            button19.TabIndex = 4;
            button19.Text = "A/M";
            button19.UseVisualStyleBackColor = true;
            // 
            // odt1_cue1
            // 
            odt1_cue1.Location = new Point(116, 594);
            odt1_cue1.Margin = new Padding(2);
            odt1_cue1.Name = "odt1_cue1";
            odt1_cue1.Size = new Size(57, 26);
            odt1_cue1.TabIndex = 4;
            odt1_cue1.Text = "CUE1";
            odt1_cue1.UseVisualStyleBackColor = true;
            // 
            // odt1_cue2
            // 
            odt1_cue2.Location = new Point(178, 594);
            odt1_cue2.Margin = new Padding(2);
            odt1_cue2.Name = "odt1_cue2";
            odt1_cue2.Size = new Size(56, 26);
            odt1_cue2.TabIndex = 4;
            odt1_cue2.Text = "CUE2";
            odt1_cue2.UseVisualStyleBackColor = true;
            // 
            // odt1_cue3
            // 
            odt1_cue3.Location = new Point(238, 594);
            odt1_cue3.Margin = new Padding(2);
            odt1_cue3.Name = "odt1_cue3";
            odt1_cue3.Size = new Size(57, 26);
            odt1_cue3.TabIndex = 4;
            odt1_cue3.Text = "CUE3";
            odt1_cue3.UseVisualStyleBackColor = true;
            // 
            // odt1_cue4
            // 
            odt1_cue4.Location = new Point(300, 594);
            odt1_cue4.Margin = new Padding(2);
            odt1_cue4.Name = "odt1_cue4";
            odt1_cue4.Size = new Size(50, 26);
            odt1_cue4.TabIndex = 4;
            odt1_cue4.Text = "CUE4";
            odt1_cue4.UseVisualStyleBackColor = true;
            // 
            // odt1_cue5
            // 
            odt1_cue5.Location = new Point(271, 25);
            odt1_cue5.Margin = new Padding(2);
            odt1_cue5.Name = "odt1_cue5";
            odt1_cue5.Size = new Size(54, 26);
            odt1_cue5.TabIndex = 4;
            odt1_cue5.Text = "CUE5";
            odt1_cue5.UseVisualStyleBackColor = true;
            // 
            // odt2_cue1
            // 
            odt2_cue1.Location = new Point(565, 594);
            odt2_cue1.Margin = new Padding(2);
            odt2_cue1.Name = "odt2_cue1";
            odt2_cue1.Size = new Size(57, 26);
            odt2_cue1.TabIndex = 4;
            odt2_cue1.Text = "CUE1";
            odt2_cue1.UseVisualStyleBackColor = true;
            // 
            // odt2_cue3
            // 
            odt2_cue3.Location = new Point(687, 594);
            odt2_cue3.Margin = new Padding(2);
            odt2_cue3.Name = "odt2_cue3";
            odt2_cue3.Size = new Size(57, 26);
            odt2_cue3.TabIndex = 4;
            odt2_cue3.Text = "CUE3";
            odt2_cue3.UseVisualStyleBackColor = true;
            // 
            // odt2_cue2
            // 
            odt2_cue2.Location = new Point(626, 594);
            odt2_cue2.Margin = new Padding(2);
            odt2_cue2.Name = "odt2_cue2";
            odt2_cue2.Size = new Size(56, 26);
            odt2_cue2.TabIndex = 4;
            odt2_cue2.Text = "CUE2";
            odt2_cue2.UseVisualStyleBackColor = true;
            // 
            // odt2_cue4
            // 
            odt2_cue4.Location = new Point(749, 594);
            odt2_cue4.Margin = new Padding(2);
            odt2_cue4.Name = "odt2_cue4";
            odt2_cue4.Size = new Size(50, 26);
            odt2_cue4.TabIndex = 4;
            odt2_cue4.Text = "CUE4";
            odt2_cue4.UseVisualStyleBackColor = true;
            // 
            // odt2_cue5
            // 
            odt2_cue5.Location = new Point(813, 594);
            odt2_cue5.Margin = new Padding(2);
            odt2_cue5.Name = "odt2_cue5";
            odt2_cue5.Size = new Size(54, 26);
            odt2_cue5.TabIndex = 4;
            odt2_cue5.Text = "CUE5";
            odt2_cue5.UseVisualStyleBackColor = true;
            // 
            // cue
            // 
            cue.Controls.Add(chBox_cue_samples);
            cue.Controls.Add(odt1_cue5);
            cue.Location = new Point(84, 570);
            cue.Margin = new Padding(2);
            cue.Name = "cue";
            cue.Size = new Size(820, 83);
            cue.TabIndex = 7;
            // 
            // chBox_cue_samples
            // 
            chBox_cue_samples.AutoSize = true;
            chBox_cue_samples.Location = new Point(356, 28);
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
            // btn_cue_usb_aux
            // 
            btn_cue_usb_aux.AutoSize = true;
            btn_cue_usb_aux.Location = new Point(440, 702);
            btn_cue_usb_aux.Margin = new Padding(2);
            btn_cue_usb_aux.Name = "btn_cue_usb_aux";
            btn_cue_usb_aux.Size = new Size(122, 24);
            btn_cue_usb_aux.TabIndex = 5;
            btn_cue_usb_aux.Text = "CUE USB AUX";
            btn_cue_usb_aux.UseVisualStyleBackColor = true;
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
            // aux_filter
            // 
            aux_filter.Location = new Point(19, 717);
            aux_filter.Margin = new Padding(4, 5, 4, 5);
            aux_filter.Maximum = 1D;
            aux_filter.Minimum = 0D;
            aux_filter.Name = "aux_filter";
            aux_filter.Size = new Size(43, 55);
            aux_filter.TabIndex = 3;
            aux_filter.Value = 0.5D;
            // 
            // aux_flexfx
            // 
            aux_flexfx.AutoSize = true;
            aux_flexfx.Location = new Point(19, 795);
            aux_flexfx.Margin = new Padding(2);
            aux_flexfx.Name = "aux_flexfx";
            aux_flexfx.Size = new Size(78, 24);
            aux_flexfx.TabIndex = 5;
            aux_flexfx.Text = "FLEXFX";
            aux_flexfx.UseVisualStyleBackColor = true;
            // 
            // panel_aux
            // 
            panel_aux.Location = new Point(10, 626);
            panel_aux.Margin = new Padding(2);
            panel_aux.Name = "panel_aux";
            panel_aux.Size = new Size(70, 215);
            panel_aux.TabIndex = 10;
            // 
            // panel_phones
            // 
            panel_phones.Location = new Point(918, 626);
            panel_phones.Margin = new Padding(2);
            panel_phones.Name = "panel_phones";
            panel_phones.Size = new Size(70, 215);
            panel_phones.TabIndex = 10;
            // 
            // phones_level
            // 
            phones_level.Location = new Point(928, 638);
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
            phones_pan.Location = new Point(928, 717);
            phones_pan.Margin = new Padding(4, 5, 4, 5);
            phones_pan.Maximum = 1D;
            phones_pan.Minimum = 0D;
            phones_pan.Name = "phones_pan";
            phones_pan.Size = new Size(43, 55);
            phones_pan.TabIndex = 3;
            phones_pan.Value = 0.5D;
            // 
            // phones_split_sue
            // 
            phones_split_sue.AutoSize = true;
            phones_split_sue.Location = new Point(928, 795);
            phones_split_sue.Margin = new Padding(2);
            phones_split_sue.Name = "phones_split_sue";
            phones_split_sue.Size = new Size(97, 24);
            phones_split_sue.TabIndex = 5;
            phones_split_sue.Text = "SPLIT CUE";
            phones_split_sue.UseVisualStyleBackColor = true;
            // 
            // mix
            // 
            mix.Location = new Point(780, 33);
            mix.Margin = new Padding(2);
            mix.Name = "mix";
            mix.Size = new Size(106, 326);
            mix.TabIndex = 7;
            // 
            // mic
            // 
            mic.Controls.Add(odt1_volume);
            mic.Controls.Add(mic_flexfx);
            mic.Location = new Point(84, 33);
            mic.Margin = new Padding(2);
            mic.Name = "mic";
            mic.Size = new Size(130, 319);
            mic.TabIndex = 7;
            // 
            // mic_flexfx
            // 
            mic_flexfx.AutoSize = true;
            mic_flexfx.Location = new Point(9, 285);
            mic_flexfx.Margin = new Padding(2);
            mic_flexfx.Name = "mic_flexfx";
            mic_flexfx.Size = new Size(78, 24);
            mic_flexfx.TabIndex = 5;
            mic_flexfx.Text = "FLEXFX";
            mic_flexfx.UseVisualStyleBackColor = true;
            // 
            // odt2_upfader
            // 
            odt2_upfader.ImeMode = ImeMode.NoControl;
            odt2_upfader.Location = new Point(711, 834);
            odt2_upfader.Margin = new Padding(2);
            odt2_upfader.Name = "odt2_upfader";
            odt2_upfader.Size = new Size(54, 306);
            odt2_upfader.TabIndex = 13;
            // 
            // odt1_upfader
            // 
            odt1_upfader.AutoScroll = true;
            odt1_upfader.ForeColor = SystemColors.ControlText;
            odt1_upfader.Location = new Point(219, 834);
            odt1_upfader.Margin = new Padding(2);
            odt1_upfader.Name = "odt1_upfader";
            odt1_upfader.Size = new Size(54, 306);
            odt1_upfader.TabIndex = 13;
            // 
            // fader1
            // 
            fader1.Location = new Point(289, 1128);
            fader1.Margin = new Padding(2);
            fader1.Maximum = 0;
            fader1.Minimum = 1;
            fader1.Name = "fader1";
            fader1.Orientation = Orientation.Horizontal;
            fader1.Size = new Size(410, 99);
            fader1.TabIndex = 14;
            fader1.Text = "fader1";
            fader1.Value = 1;
            // 
            // Mixer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1011, 1256);
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
            Controls.Add(gain_ch2);
            Controls.Add(main);
            Controls.Add(gain_ch1);
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
            Margin = new Padding(2);
            Name = "Mixer";
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
        private NAudio.Gui.Pot low_odt1;
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
        internal NAudio.Gui.Pot gain_ch1;
        internal NAudio.Gui.Pot gain_ch2;
        private HScrollBar hScrollBar2;
    }
}
