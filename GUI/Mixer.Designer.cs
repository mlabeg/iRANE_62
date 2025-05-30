﻿using iRANE_62.Models;
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
            chBox_flexfx_ch2 = new CheckBox();
            panel_chanel1 = new Panel();
            label16 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            volumeMeter_ch1 = new NAudio.Gui.VolumeMeter();
            pot_low_ch1 = new NAudio.Gui.Pot();
            chBox_flexfx_ch1 = new CheckBox();
            volumeMeter_mic_volume = new NAudio.Gui.VolumeMeter();
            panel_chanel2 = new Panel();
            label17 = new Label();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
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
            btn_fx_tap = new Button();
            panel_efx_wyswietlacz = new Panel();
            label_Effect_Name = new Label();
            label_Bpm_count = new Label();
            label_Bpm_text = new Label();
            label_Effect_text = new Label();
            chBox_efx_on = new CheckBox();
            Pot_fx_gain = new NAudio.Gui.Pot();
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
            panel_mic = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ChBox_mic_fx = new CheckBox();
            panel_volume = new Panel();
            verticalVolumeSlider_ch2 = new Controls.VerticalVolumeSlider();
            verticalVolumeSlider_ch1 = new Controls.VerticalVolumeSlider();
            crossfaderSlider = new Controls.CrossfaderSlider();
            label18 = new Label();
            label1 = new Label();
            panel_chanel1.SuspendLayout();
            panel_chanel2.SuspendLayout();
            panel_loops1.SuspendLayout();
            panel_efx_wyswietlacz.SuspendLayout();
            panel_efx.SuspendLayout();
            panel_loops2.SuspendLayout();
            panel_cue.SuspendLayout();
            panel_mic.SuspendLayout();
            panel_volume.SuspendLayout();
            SuspendLayout();
            // 
            // panSlider_ch1
            // 
            panSlider_ch1.Location = new Point(22, 28);
            panSlider_ch1.Margin = new Padding(2);
            panSlider_ch1.Name = "panSlider_ch1";
            panSlider_ch1.Pan = 0F;
            panSlider_ch1.Size = new Size(66, 32);
            panSlider_ch1.TabIndex = 1;
            panSlider_ch1.PanChanged += pan_odt1_PanChanged;
            // 
            // pot_gain_ch1
            // 
            pot_gain_ch1.Location = new Point(150, 5);
            pot_gain_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_gain_ch1.Maximum = 1D;
            pot_gain_ch1.Minimum = 0D;
            pot_gain_ch1.Name = "pot_gain_ch1";
            pot_gain_ch1.Size = new Size(43, 55);
            pot_gain_ch1.TabIndex = 3;
            pot_gain_ch1.Value = 0.5D;
            pot_gain_ch1.ValueChanged += pot_gain_ch1_ValueChanged;
            pot_gain_ch1.Load += pot_gain_ch1_Load;
            // 
            // pot_high_ch1
            // 
            pot_high_ch1.Location = new Point(150, 84);
            pot_high_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_high_ch1.Maximum = 30D;
            pot_high_ch1.Minimum = -30D;
            pot_high_ch1.Name = "pot_high_ch1";
            pot_high_ch1.Size = new Size(43, 55);
            pot_high_ch1.TabIndex = 3;
            pot_high_ch1.Value = 0D;
            pot_high_ch1.ValueChanged += high_ch1_ValueChanged;
            pot_high_ch1.Load += pot_high_ch1_Load;
            // 
            // pot_mid_ch1
            // 
            pot_mid_ch1.Location = new Point(150, 170);
            pot_mid_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_mid_ch1.Maximum = 30D;
            pot_mid_ch1.Minimum = -30D;
            pot_mid_ch1.Name = "pot_mid_ch1";
            pot_mid_ch1.Size = new Size(43, 55);
            pot_mid_ch1.TabIndex = 3;
            pot_mid_ch1.Value = 0D;
            pot_mid_ch1.ValueChanged += mid_ch1_ValueChanged;
            pot_mid_ch1.DoubleClick += pot_mid_ch1_DoubleClick;
            // 
            // pot_filter_ch1
            // 
            pot_filter_ch1.Location = new Point(31, 129);
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
            panSlider_ch2.Location = new Point(136, 28);
            panSlider_ch2.Margin = new Padding(2);
            panSlider_ch2.Name = "panSlider_ch2";
            panSlider_ch2.Pan = 0F;
            panSlider_ch2.Size = new Size(66, 32);
            panSlider_ch2.TabIndex = 1;
            panSlider_ch2.PanChanged += pan_odt2_PanChanged;
            // 
            // pot_gain_ch2
            // 
            pot_gain_ch2.Location = new Point(17, 5);
            pot_gain_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_gain_ch2.Maximum = 1D;
            pot_gain_ch2.Minimum = 0D;
            pot_gain_ch2.Name = "pot_gain_ch2";
            pot_gain_ch2.Size = new Size(43, 55);
            pot_gain_ch2.TabIndex = 3;
            pot_gain_ch2.Value = 0.5D;
            pot_gain_ch2.ValueChanged += pot_gain_ch2_ValueChanged;
            pot_gain_ch2.DoubleClick += pot_gain_ch2_DoubleClick;
            // 
            // pot_high_ch2
            // 
            pot_high_ch2.Location = new Point(17, 84);
            pot_high_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_high_ch2.Maximum = 30D;
            pot_high_ch2.Minimum = -30D;
            pot_high_ch2.Name = "pot_high_ch2";
            pot_high_ch2.Size = new Size(43, 55);
            pot_high_ch2.TabIndex = 3;
            pot_high_ch2.Value = 0D;
            pot_high_ch2.ValueChanged += high_ch2_ValueChanged;
            pot_high_ch2.DoubleClick += pot_high_ch2_DoubleClick;
            // 
            // pot_mid_ch2
            // 
            pot_mid_ch2.Location = new Point(17, 170);
            pot_mid_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_mid_ch2.Maximum = 30D;
            pot_mid_ch2.Minimum = -30D;
            pot_mid_ch2.Name = "pot_mid_ch2";
            pot_mid_ch2.Size = new Size(43, 55);
            pot_mid_ch2.TabIndex = 3;
            pot_mid_ch2.Value = 0D;
            pot_mid_ch2.ValueChanged += mid_ch2_ValueChanged;
            pot_mid_ch2.DoubleClick += pot_mid_ch2_DoubleClick;
            // 
            // pot_filter_ch2
            // 
            pot_filter_ch2.Location = new Point(146, 129);
            pot_filter_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_filter_ch2.Maximum = 1D;
            pot_filter_ch2.Minimum = -1D;
            pot_filter_ch2.Name = "pot_filter_ch2";
            pot_filter_ch2.Size = new Size(43, 55);
            pot_filter_ch2.TabIndex = 3;
            pot_filter_ch2.Value = 0D;
            pot_filter_ch2.ValueChanged += filter_odt2_ValueChanged;
            pot_filter_ch2.DoubleClick += pot_filter_ch2_DoubleClick;
            // 
            // pot_low_ch2
            // 
            pot_low_ch2.Location = new Point(17, 255);
            pot_low_ch2.Margin = new Padding(4, 5, 4, 5);
            pot_low_ch2.Maximum = 30D;
            pot_low_ch2.Minimum = -30D;
            pot_low_ch2.Name = "pot_low_ch2";
            pot_low_ch2.Size = new Size(43, 55);
            pot_low_ch2.TabIndex = 3;
            pot_low_ch2.Value = 0D;
            pot_low_ch2.ValueChanged += low_ch2_ValueChanged;
            pot_low_ch2.DoubleClick += pot_low_ch2_DoubleClick;
            // 
            // pot_mic_level
            // 
            pot_mic_level.Location = new Point(17, 59);
            pot_mic_level.Margin = new Padding(4, 5, 4, 5);
            pot_mic_level.Maximum = 1D;
            pot_mic_level.Minimum = 0D;
            pot_mic_level.Name = "pot_mic_level";
            pot_mic_level.Size = new Size(43, 55);
            pot_mic_level.TabIndex = 3;
            pot_mic_level.Value = 0.5D;
            pot_mic_level.ValueChanged += mic_level_ValueChanged;
            pot_mic_level.DoubleClick += pot_mic_level_DoubleClick;
            // 
            // pot_mic_high
            // 
            pot_mic_high.Location = new Point(17, 134);
            pot_mic_high.Margin = new Padding(4, 5, 4, 5);
            pot_mic_high.Maximum = 30D;
            pot_mic_high.Minimum = -30D;
            pot_mic_high.Name = "pot_mic_high";
            pot_mic_high.Size = new Size(43, 55);
            pot_mic_high.TabIndex = 3;
            pot_mic_high.Value = 0.5D;
            pot_mic_high.ValueChanged += mic_high_ValueChanged;
            pot_mic_high.DoubleClick += pot_mic_high_DoubleClick;
            // 
            // pot_mic_low
            // 
            pot_mic_low.Location = new Point(17, 210);
            pot_mic_low.Margin = new Padding(4, 5, 4, 5);
            pot_mic_low.Maximum = 30D;
            pot_mic_low.Minimum = -30D;
            pot_mic_low.Name = "pot_mic_low";
            pot_mic_low.Size = new Size(43, 55);
            pot_mic_low.TabIndex = 3;
            pot_mic_low.Value = 0.5D;
            pot_mic_low.ValueChanged += mic_low_ValueChanged;
            pot_mic_low.DoubleClick += pot_mic_low_DoubleClick;
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
            // chBox_flexfx_ch2
            // 
            chBox_flexfx_ch2.AutoSize = true;
            chBox_flexfx_ch2.Location = new Point(130, 297);
            chBox_flexfx_ch2.Margin = new Padding(2);
            chBox_flexfx_ch2.Name = "chBox_flexfx_ch2";
            chBox_flexfx_ch2.Size = new Size(78, 24);
            chBox_flexfx_ch2.TabIndex = 5;
            chBox_flexfx_ch2.Text = "FLEXFX";
            chBox_flexfx_ch2.UseVisualStyleBackColor = true;
            chBox_flexfx_ch2.CheckedChanged += chBox_flexfx_ch2_CheckedChanged;
            // 
            // panel_chanel1
            // 
            panel_chanel1.BorderStyle = BorderStyle.FixedSingle;
            panel_chanel1.Controls.Add(label16);
            panel_chanel1.Controls.Add(label14);
            panel_chanel1.Controls.Add(label12);
            panel_chanel1.Controls.Add(label10);
            panel_chanel1.Controls.Add(label8);
            panel_chanel1.Controls.Add(label6);
            panel_chanel1.Controls.Add(volumeMeter_ch1);
            panel_chanel1.Controls.Add(pot_low_ch1);
            panel_chanel1.Controls.Add(chBox_flexfx_ch1);
            panel_chanel1.Controls.Add(panSlider_ch1);
            panel_chanel1.Controls.Add(pot_filter_ch1);
            panel_chanel1.Controls.Add(pot_mid_ch1);
            panel_chanel1.Controls.Add(pot_high_ch1);
            panel_chanel1.Controls.Add(pot_gain_ch1);
            panel_chanel1.Location = new Point(225, 10);
            panel_chanel1.Margin = new Padding(2);
            panel_chanel1.Name = "panel_chanel1";
            panel_chanel1.Size = new Size(225, 340);
            panel_chanel1.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(32, 180);
            label16.Name = "label16";
            label16.Size = new Size(42, 20);
            label16.TabIndex = 26;
            label16.Text = "Filter";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 70);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 25;
            label14.Text = "Panorama";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(154, 220);
            label12.Name = "label12";
            label12.Size = new Size(35, 20);
            label12.TabIndex = 23;
            label12.Text = "Mid";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(153, 305);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 21;
            label10.Text = "Low";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(154, 133);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 21;
            label8.Text = "High";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 57);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 19;
            label6.Text = "Gain";
            // 
            // volumeMeter_ch1
            // 
            volumeMeter_ch1.Amplitude = 0F;
            volumeMeter_ch1.Location = new Point(105, 21);
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
            pot_low_ch1.Location = new Point(150, 255);
            pot_low_ch1.Margin = new Padding(4, 5, 4, 5);
            pot_low_ch1.Maximum = 30D;
            pot_low_ch1.Minimum = -30D;
            pot_low_ch1.Name = "pot_low_ch1";
            pot_low_ch1.Size = new Size(43, 55);
            pot_low_ch1.TabIndex = 3;
            pot_low_ch1.Value = 0D;
            pot_low_ch1.ValueChanged += low_ch1_ValueChanged;
            pot_low_ch1.DoubleClick += pot_low_ch1_DoubleClick;
            // 
            // chBox_flexfx_ch1
            // 
            chBox_flexfx_ch1.AutoSize = true;
            chBox_flexfx_ch1.Location = new Point(13, 296);
            chBox_flexfx_ch1.Margin = new Padding(2);
            chBox_flexfx_ch1.Name = "chBox_flexfx_ch1";
            chBox_flexfx_ch1.Size = new Size(82, 24);
            chBox_flexfx_ch1.TabIndex = 5;
            chBox_flexfx_ch1.Text = "FLEX FX";
            chBox_flexfx_ch1.UseVisualStyleBackColor = true;
            chBox_flexfx_ch1.CheckedChanged += chBox_flexfx_ch1_CheckedChanged;
            // 
            // volumeMeter_mic_volume
            // 
            volumeMeter_mic_volume.Amplitude = 0F;
            volumeMeter_mic_volume.Location = new Point(94, 58);
            volumeMeter_mic_volume.Margin = new Padding(2);
            volumeMeter_mic_volume.MaxDb = 18F;
            volumeMeter_mic_volume.MinDb = -60F;
            volumeMeter_mic_volume.Name = "volumeMeter_mic_volume";
            volumeMeter_mic_volume.Size = new Size(24, 235);
            volumeMeter_mic_volume.TabIndex = 12;
            volumeMeter_mic_volume.Text = "volumeMeter1";
            // 
            // panel_chanel2
            // 
            panel_chanel2.BorderStyle = BorderStyle.FixedSingle;
            panel_chanel2.Controls.Add(label17);
            panel_chanel2.Controls.Add(label15);
            panel_chanel2.Controls.Add(label13);
            panel_chanel2.Controls.Add(label11);
            panel_chanel2.Controls.Add(label9);
            panel_chanel2.Controls.Add(label7);
            panel_chanel2.Controls.Add(volumeMeter_ch2);
            panel_chanel2.Controls.Add(panSlider_ch2);
            panel_chanel2.Controls.Add(pot_filter_ch2);
            panel_chanel2.Controls.Add(chBox_flexfx_ch2);
            panel_chanel2.Controls.Add(pot_low_ch2);
            panel_chanel2.Controls.Add(pot_mid_ch2);
            panel_chanel2.Controls.Add(pot_high_ch2);
            panel_chanel2.Controls.Add(pot_gain_ch2);
            panel_chanel2.Location = new Point(455, 10);
            panel_chanel2.Margin = new Padding(2);
            panel_chanel2.Name = "panel_chanel2";
            panel_chanel2.Size = new Size(225, 340);
            panel_chanel2.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(147, 180);
            label17.Name = "label17";
            label17.Size = new Size(42, 20);
            label17.TabIndex = 27;
            label17.Text = "Filter";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(130, 70);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 26;
            label15.Text = "Panorama";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 220);
            label13.Name = "label13";
            label13.Size = new Size(35, 20);
            label13.TabIndex = 24;
            label13.Text = "Mid";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 305);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 22;
            label11.Text = "Low";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 133);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 22;
            label9.Text = "High";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 57);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 20;
            label7.Text = "Gain";
            // 
            // volumeMeter_ch2
            // 
            volumeMeter_ch2.Amplitude = 0F;
            volumeMeter_ch2.Location = new Point(82, 21);
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
            panel_loops1.Location = new Point(10, 140);
            panel_loops1.Margin = new Padding(2);
            panel_loops1.Name = "panel_loops1";
            panel_loops1.Size = new Size(70, 210);
            panel_loops1.TabIndex = 7;
            // 
            // btn_exitLoop_ch1
            // 
            btn_exitLoop_ch1.Location = new Point(10, 145);
            btn_exitLoop_ch1.Margin = new Padding(2);
            btn_exitLoop_ch1.Name = "btn_exitLoop_ch1";
            btn_exitLoop_ch1.Size = new Size(50, 50);
            btn_exitLoop_ch1.TabIndex = 4;
            btn_exitLoop_ch1.Text = "Exit";
            btn_exitLoop_ch1.UseVisualStyleBackColor = true;
            btn_exitLoop_ch1.Click += exitLoop_ch1_Click;
            // 
            // btn_loopOut_ch1
            // 
            btn_loopOut_ch1.Location = new Point(10, 80);
            btn_loopOut_ch1.Margin = new Padding(2);
            btn_loopOut_ch1.Name = "btn_loopOut_ch1";
            btn_loopOut_ch1.Size = new Size(50, 50);
            btn_loopOut_ch1.TabIndex = 4;
            btn_loopOut_ch1.Text = "Out";
            btn_loopOut_ch1.UseVisualStyleBackColor = true;
            btn_loopOut_ch1.Click += loopOut_ch1_Click;
            // 
            // btn_loopIn_ch1
            // 
            btn_loopIn_ch1.Location = new Point(10, 15);
            btn_loopIn_ch1.Margin = new Padding(2);
            btn_loopIn_ch1.Name = "btn_loopIn_ch1";
            btn_loopIn_ch1.Size = new Size(50, 50);
            btn_loopIn_ch1.TabIndex = 4;
            btn_loopIn_ch1.Text = "In";
            btn_loopIn_ch1.UseVisualStyleBackColor = true;
            btn_loopIn_ch1.Click += loopIn_ch1_Click;
            // 
            // pot_systemVolume
            // 
            pot_systemVolume.Location = new Point(836, 16);
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
            chBox_efx_filter.Location = new Point(31, 18);
            chBox_efx_filter.Margin = new Padding(2);
            chBox_efx_filter.Name = "chBox_efx_filter";
            chBox_efx_filter.Size = new Size(73, 24);
            chBox_efx_filter.TabIndex = 5;
            chBox_efx_filter.Text = "FILTER";
            chBox_efx_filter.UseVisualStyleBackColor = true;
            // 
            // chBox_efx_flanger
            // 
            chBox_efx_flanger.AutoSize = true;
            chBox_efx_flanger.Location = new Point(169, 18);
            chBox_efx_flanger.Margin = new Padding(2);
            chBox_efx_flanger.Name = "chBox_efx_flanger";
            chBox_efx_flanger.Size = new Size(93, 24);
            chBox_efx_flanger.TabIndex = 5;
            chBox_efx_flanger.Text = "FLANGER";
            chBox_efx_flanger.UseVisualStyleBackColor = true;
            // 
            // chBox_efx_phaser
            // 
            chBox_efx_phaser.AutoSize = true;
            chBox_efx_phaser.Location = new Point(325, 18);
            chBox_efx_phaser.Margin = new Padding(2);
            chBox_efx_phaser.Name = "chBox_efx_phaser";
            chBox_efx_phaser.Size = new Size(85, 24);
            chBox_efx_phaser.TabIndex = 5;
            chBox_efx_phaser.Text = "PHASER";
            chBox_efx_phaser.UseVisualStyleBackColor = true;
            // 
            // chBox_efx_echo
            // 
            chBox_efx_echo.AutoSize = true;
            chBox_efx_echo.Location = new Point(493, 18);
            chBox_efx_echo.Margin = new Padding(2);
            chBox_efx_echo.Name = "chBox_efx_echo";
            chBox_efx_echo.Size = new Size(70, 24);
            chBox_efx_echo.TabIndex = 5;
            chBox_efx_echo.Text = "ECHO";
            chBox_efx_echo.UseVisualStyleBackColor = true;
            // 
            // chBox_efx_reverb
            // 
            chBox_efx_reverb.AutoSize = true;
            chBox_efx_reverb.Location = new Point(772, 18);
            chBox_efx_reverb.Margin = new Padding(2);
            chBox_efx_reverb.Name = "chBox_efx_reverb";
            chBox_efx_reverb.Size = new Size(83, 24);
            chBox_efx_reverb.TabIndex = 5;
            chBox_efx_reverb.Text = "REVERB";
            chBox_efx_reverb.UseVisualStyleBackColor = true;
            // 
            // chBox_efx_robot
            // 
            chBox_efx_robot.AutoSize = true;
            chBox_efx_robot.Location = new Point(631, 18);
            chBox_efx_robot.Margin = new Padding(2);
            chBox_efx_robot.Name = "chBox_efx_robot";
            chBox_efx_robot.Size = new Size(78, 24);
            chBox_efx_robot.TabIndex = 5;
            chBox_efx_robot.Text = "ROBOT";
            chBox_efx_robot.UseVisualStyleBackColor = true;
            // 
            // btn_fx_tap
            // 
            btn_fx_tap.Location = new Point(78, 99);
            btn_fx_tap.Margin = new Padding(2);
            btn_fx_tap.Name = "btn_fx_tap";
            btn_fx_tap.Size = new Size(60, 40);
            btn_fx_tap.TabIndex = 4;
            btn_fx_tap.Text = "TAP";
            btn_fx_tap.UseVisualStyleBackColor = true;
            btn_fx_tap.Click += btn_fx_tap_Click;
            // 
            // panel_efx_wyswietlacz
            // 
            panel_efx_wyswietlacz.Controls.Add(label_Effect_Name);
            panel_efx_wyswietlacz.Controls.Add(label_Bpm_count);
            panel_efx_wyswietlacz.Controls.Add(label_Bpm_text);
            panel_efx_wyswietlacz.Controls.Add(label_Effect_text);
            panel_efx_wyswietlacz.Location = new Point(237, 59);
            panel_efx_wyswietlacz.Margin = new Padding(2);
            panel_efx_wyswietlacz.Name = "panel_efx_wyswietlacz";
            panel_efx_wyswietlacz.Size = new Size(239, 107);
            panel_efx_wyswietlacz.TabIndex = 9;
            // 
            // label_Effect_Name
            // 
            label_Effect_Name.AutoSize = true;
            label_Effect_Name.BorderStyle = BorderStyle.FixedSingle;
            label_Effect_Name.Location = new Point(126, 23);
            label_Effect_Name.Name = "label_Effect_Name";
            label_Effect_Name.Size = new Size(70, 22);
            label_Effect_Name.TabIndex = 0;
            label_Effect_Name.Text = "Disabled";
            // 
            // label_Bpm_count
            // 
            label_Bpm_count.AutoSize = true;
            label_Bpm_count.BorderStyle = BorderStyle.FixedSingle;
            label_Bpm_count.Location = new Point(126, 56);
            label_Bpm_count.Name = "label_Bpm_count";
            label_Bpm_count.Size = new Size(17, 22);
            label_Bpm_count.TabIndex = 0;
            label_Bpm_count.Text = "-";
            // 
            // label_Bpm_text
            // 
            label_Bpm_text.AutoSize = true;
            label_Bpm_text.BorderStyle = BorderStyle.FixedSingle;
            label_Bpm_text.Location = new Point(38, 56);
            label_Bpm_text.Name = "label_Bpm_text";
            label_Bpm_text.Size = new Size(48, 22);
            label_Bpm_text.TabIndex = 0;
            label_Bpm_text.Text = "BPM: ";
            // 
            // label_Effect_text
            // 
            label_Effect_text.AutoSize = true;
            label_Effect_text.BorderStyle = BorderStyle.FixedSingle;
            label_Effect_text.FlatStyle = FlatStyle.Flat;
            label_Effect_text.Location = new Point(38, 23);
            label_Effect_text.Name = "label_Effect_text";
            label_Effect_text.Size = new Size(52, 22);
            label_Effect_text.TabIndex = 0;
            label_Effect_text.Text = "Effect:";
            // 
            // chBox_efx_on
            // 
            chBox_efx_on.AutoSize = true;
            chBox_efx_on.Location = new Point(537, 101);
            chBox_efx_on.Margin = new Padding(2);
            chBox_efx_on.Name = "chBox_efx_on";
            chBox_efx_on.Size = new Size(53, 24);
            chBox_efx_on.TabIndex = 5;
            chBox_efx_on.Text = "ON";
            chBox_efx_on.UseVisualStyleBackColor = true;
            chBox_efx_on.CheckedChanged += chBox_efx_on_CheckedChanged;
            // 
            // Pot_fx_gain
            // 
            Pot_fx_gain.Location = new Point(717, 87);
            Pot_fx_gain.Margin = new Padding(4, 5, 4, 5);
            Pot_fx_gain.Maximum = 1D;
            Pot_fx_gain.Minimum = 0D;
            Pot_fx_gain.Name = "Pot_fx_gain";
            Pot_fx_gain.Size = new Size(43, 55);
            Pot_fx_gain.TabIndex = 3;
            Pot_fx_gain.Value = 0D;
            Pot_fx_gain.ValueChanged += Pot_fx_gain_ValueChanged;
            // 
            // panel_efx
            // 
            panel_efx.BorderStyle = BorderStyle.FixedSingle;
            panel_efx.Controls.Add(label1);
            panel_efx.Controls.Add(btn_fx_tap);
            panel_efx.Controls.Add(chBox_efx_on);
            panel_efx.Controls.Add(Pot_fx_gain);
            panel_efx.Controls.Add(panel_efx_wyswietlacz);
            panel_efx.Controls.Add(chBox_efx_reverb);
            panel_efx.Controls.Add(chBox_efx_robot);
            panel_efx.Controls.Add(chBox_efx_phaser);
            panel_efx.Controls.Add(chBox_efx_filter);
            panel_efx.Controls.Add(chBox_efx_echo);
            panel_efx.Controls.Add(chBox_efx_flanger);
            panel_efx.Location = new Point(10, 360);
            panel_efx.Margin = new Padding(2);
            panel_efx.Name = "panel_efx";
            panel_efx.Size = new Size(885, 185);
            panel_efx.TabIndex = 7;
            // 
            // panel_loops2
            // 
            panel_loops2.BorderStyle = BorderStyle.FixedSingle;
            panel_loops2.Controls.Add(btn_exitLoop_ch2);
            panel_loops2.Controls.Add(btn_loopOut_ch2);
            panel_loops2.Controls.Add(btn_loopIn_ch2);
            panel_loops2.Location = new Point(825, 140);
            panel_loops2.Margin = new Padding(2);
            panel_loops2.Name = "panel_loops2";
            panel_loops2.Size = new Size(70, 210);
            panel_loops2.TabIndex = 7;
            // 
            // btn_exitLoop_ch2
            // 
            btn_exitLoop_ch2.Location = new Point(10, 145);
            btn_exitLoop_ch2.Margin = new Padding(2);
            btn_exitLoop_ch2.Name = "btn_exitLoop_ch2";
            btn_exitLoop_ch2.Size = new Size(50, 50);
            btn_exitLoop_ch2.TabIndex = 4;
            btn_exitLoop_ch2.Text = "Exit";
            btn_exitLoop_ch2.UseVisualStyleBackColor = true;
            btn_exitLoop_ch2.Click += exitLoop_ch2_Click;
            // 
            // btn_loopOut_ch2
            // 
            btn_loopOut_ch2.Location = new Point(10, 80);
            btn_loopOut_ch2.Margin = new Padding(2);
            btn_loopOut_ch2.Name = "btn_loopOut_ch2";
            btn_loopOut_ch2.Size = new Size(50, 50);
            btn_loopOut_ch2.TabIndex = 4;
            btn_loopOut_ch2.Text = "Out";
            btn_loopOut_ch2.UseVisualStyleBackColor = true;
            btn_loopOut_ch2.Click += loopOut_ch2_Click;
            // 
            // btn_loopIn_ch2
            // 
            btn_loopIn_ch2.Location = new Point(10, 15);
            btn_loopIn_ch2.Margin = new Padding(2);
            btn_loopIn_ch2.Name = "btn_loopIn_ch2";
            btn_loopIn_ch2.Size = new Size(50, 50);
            btn_loopIn_ch2.TabIndex = 4;
            btn_loopIn_ch2.Text = "In";
            btn_loopIn_ch2.UseVisualStyleBackColor = true;
            btn_loopIn_ch2.Click += loopIn_ch2_Click;
            // 
            // btn_cue1_ch1
            // 
            btn_cue1_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue1_ch1.Location = new Point(10, 25);
            btn_cue1_ch1.Margin = new Padding(2);
            btn_cue1_ch1.Name = "btn_cue1_ch1";
            btn_cue1_ch1.Size = new Size(80, 30);
            btn_cue1_ch1.TabIndex = 4;
            btn_cue1_ch1.Text = "CUE1";
            btn_cue1_ch1.UseVisualStyleBackColor = true;
            btn_cue1_ch1.Click += cue1_ch1_Click;
            // 
            // btn_cue2_ch1
            // 
            btn_cue2_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue2_ch1.Location = new Point(95, 25);
            btn_cue2_ch1.Margin = new Padding(2);
            btn_cue2_ch1.Name = "btn_cue2_ch1";
            btn_cue2_ch1.Size = new Size(80, 30);
            btn_cue2_ch1.TabIndex = 4;
            btn_cue2_ch1.Text = "CUE2";
            btn_cue2_ch1.UseVisualStyleBackColor = true;
            btn_cue2_ch1.Click += cue2_ch1_Click;
            // 
            // btn_cue3_ch1
            // 
            btn_cue3_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue3_ch1.Location = new Point(180, 25);
            btn_cue3_ch1.Margin = new Padding(2);
            btn_cue3_ch1.Name = "btn_cue3_ch1";
            btn_cue3_ch1.Size = new Size(80, 30);
            btn_cue3_ch1.TabIndex = 4;
            btn_cue3_ch1.Text = "CUE3";
            btn_cue3_ch1.UseVisualStyleBackColor = true;
            btn_cue3_ch1.Click += cue3_ch1_Click;
            // 
            // btn_cue4_ch1
            // 
            btn_cue4_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue4_ch1.Location = new Point(265, 25);
            btn_cue4_ch1.Margin = new Padding(2);
            btn_cue4_ch1.Name = "btn_cue4_ch1";
            btn_cue4_ch1.Size = new Size(80, 30);
            btn_cue4_ch1.TabIndex = 4;
            btn_cue4_ch1.Text = "CUE4";
            btn_cue4_ch1.UseVisualStyleBackColor = true;
            btn_cue4_ch1.Click += cue4_ch1_Click;
            // 
            // btn_cue5_ch1
            // 
            btn_cue5_ch1.FlatStyle = FlatStyle.Flat;
            btn_cue5_ch1.Location = new Point(350, 25);
            btn_cue5_ch1.Margin = new Padding(2);
            btn_cue5_ch1.Name = "btn_cue5_ch1";
            btn_cue5_ch1.Size = new Size(80, 30);
            btn_cue5_ch1.TabIndex = 4;
            btn_cue5_ch1.Text = "CUE 5";
            btn_cue5_ch1.UseVisualStyleBackColor = true;
            btn_cue5_ch1.Click += cue5_ch1_Click;
            // 
            // btn_cue1_ch2
            // 
            btn_cue1_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue1_ch2.Location = new Point(455, 25);
            btn_cue1_ch2.Margin = new Padding(2);
            btn_cue1_ch2.Name = "btn_cue1_ch2";
            btn_cue1_ch2.Size = new Size(80, 30);
            btn_cue1_ch2.TabIndex = 4;
            btn_cue1_ch2.Text = "CUE1";
            btn_cue1_ch2.UseVisualStyleBackColor = true;
            btn_cue1_ch2.Click += cue1_ch2_Click;
            // 
            // btn_cue3_ch2
            // 
            btn_cue3_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue3_ch2.Location = new Point(625, 25);
            btn_cue3_ch2.Margin = new Padding(2);
            btn_cue3_ch2.Name = "btn_cue3_ch2";
            btn_cue3_ch2.Size = new Size(80, 30);
            btn_cue3_ch2.TabIndex = 4;
            btn_cue3_ch2.Text = "CUE3";
            btn_cue3_ch2.UseVisualStyleBackColor = true;
            btn_cue3_ch2.Click += cue3_ch2_Click;
            // 
            // btn_cue2_ch2
            // 
            btn_cue2_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue2_ch2.Location = new Point(540, 25);
            btn_cue2_ch2.Margin = new Padding(2);
            btn_cue2_ch2.Name = "btn_cue2_ch2";
            btn_cue2_ch2.Size = new Size(80, 30);
            btn_cue2_ch2.TabIndex = 4;
            btn_cue2_ch2.Text = "CUE2";
            btn_cue2_ch2.UseVisualStyleBackColor = true;
            btn_cue2_ch2.Click += cue2_ch2_Click;
            // 
            // btn_cue4_ch2
            // 
            btn_cue4_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue4_ch2.Location = new Point(710, 25);
            btn_cue4_ch2.Margin = new Padding(2);
            btn_cue4_ch2.Name = "btn_cue4_ch2";
            btn_cue4_ch2.Size = new Size(80, 30);
            btn_cue4_ch2.TabIndex = 4;
            btn_cue4_ch2.Text = "CUE4";
            btn_cue4_ch2.UseVisualStyleBackColor = true;
            btn_cue4_ch2.Click += cue4_ch2_Click;
            // 
            // btn_cue5_ch2
            // 
            btn_cue5_ch2.FlatStyle = FlatStyle.Flat;
            btn_cue5_ch2.Location = new Point(795, 25);
            btn_cue5_ch2.Margin = new Padding(2);
            btn_cue5_ch2.Name = "btn_cue5_ch2";
            btn_cue5_ch2.Size = new Size(80, 30);
            btn_cue5_ch2.TabIndex = 4;
            btn_cue5_ch2.Text = "CUE5";
            btn_cue5_ch2.UseVisualStyleBackColor = true;
            btn_cue5_ch2.Click += cue5_ch2_Click;
            // 
            // panel_cue
            // 
            panel_cue.BorderStyle = BorderStyle.FixedSingle;
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
            panel_cue.Location = new Point(10, 555);
            panel_cue.Margin = new Padding(2);
            panel_cue.Name = "panel_cue";
            panel_cue.Size = new Size(885, 80);
            panel_cue.TabIndex = 7;
            // 
            // panel_mic
            // 
            panel_mic.BorderStyle = BorderStyle.FixedSingle;
            panel_mic.Controls.Add(label5);
            panel_mic.Controls.Add(label4);
            panel_mic.Controls.Add(label3);
            panel_mic.Controls.Add(volumeMeter_mic_volume);
            panel_mic.Controls.Add(ChBox_mic_fx);
            panel_mic.Controls.Add(btn_micOver);
            panel_mic.Controls.Add(btn_micOnOff);
            panel_mic.Controls.Add(pot_mic_low);
            panel_mic.Controls.Add(pot_mic_level);
            panel_mic.Controls.Add(pot_mic_high);
            panel_mic.Location = new Point(85, 10);
            panel_mic.Margin = new Padding(2);
            panel_mic.Name = "panel_mic";
            panel_mic.Size = new Size(135, 340);
            panel_mic.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 255);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 20;
            label5.Text = "Low";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 180);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 19;
            label4.Text = "High";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 104);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 18;
            label3.Text = "Gain";
            // 
            // ChBox_mic_fx
            // 
            ChBox_mic_fx.AutoSize = true;
            ChBox_mic_fx.Location = new Point(21, 297);
            ChBox_mic_fx.Margin = new Padding(2);
            ChBox_mic_fx.Name = "ChBox_mic_fx";
            ChBox_mic_fx.Size = new Size(78, 24);
            ChBox_mic_fx.TabIndex = 5;
            ChBox_mic_fx.Text = "FLEXFX";
            ChBox_mic_fx.UseVisualStyleBackColor = true;
            ChBox_mic_fx.CheckedChanged += ChBox_mic_fx_CheckedChanged;
            // 
            // panel_volume
            // 
            panel_volume.BorderStyle = BorderStyle.FixedSingle;
            panel_volume.Controls.Add(volumeMeter_mainRight);
            panel_volume.Controls.Add(volumeMeter_mainLeft);
            panel_volume.Location = new Point(685, 10);
            panel_volume.Margin = new Padding(2);
            panel_volume.Name = "panel_volume";
            panel_volume.Size = new Size(135, 340);
            panel_volume.TabIndex = 13;
            // 
            // verticalVolumeSlider_ch2
            // 
            verticalVolumeSlider_ch2.BackColor = SystemColors.Control;
            verticalVolumeSlider_ch2.ForeColor = Color.Black;
            verticalVolumeSlider_ch2.Location = new Point(660, 645);
            verticalVolumeSlider_ch2.Maximum = 1F;
            verticalVolumeSlider_ch2.Minimum = 0F;
            verticalVolumeSlider_ch2.Name = "verticalVolumeSlider_ch2";
            verticalVolumeSlider_ch2.Size = new Size(60, 300);
            verticalVolumeSlider_ch2.TabIndex = 15;
            verticalVolumeSlider_ch2.Volume = 0.5F;
            // 
            // verticalVolumeSlider_ch1
            // 
            verticalVolumeSlider_ch1.BackColor = SystemColors.Control;
            verticalVolumeSlider_ch1.ForeColor = Color.Black;
            verticalVolumeSlider_ch1.Location = new Point(200, 645);
            verticalVolumeSlider_ch1.Maximum = 1F;
            verticalVolumeSlider_ch1.Minimum = 0F;
            verticalVolumeSlider_ch1.Name = "verticalVolumeSlider_ch1";
            verticalVolumeSlider_ch1.Size = new Size(60, 300);
            verticalVolumeSlider_ch1.TabIndex = 15;
            verticalVolumeSlider_ch1.Volume = 0.5F;
            // 
            // crossfaderSlider
            // 
            crossfaderSlider.BackColor = SystemColors.Control;
            crossfaderSlider.ForeColor = Color.Black;
            crossfaderSlider.Location = new Point(300, 960);
            crossfaderSlider.Name = "crossfaderSlider";
            crossfaderSlider.Position = 0.5F;
            crossfaderSlider.Size = new Size(300, 60);
            crossfaderSlider.TabIndex = 16;
            crossfaderSlider.Text = "crossfaderSlider1";
            crossfaderSlider.PositionChanged += crossfaderSlider_PositionChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(836, 68);
            label18.Name = "label18";
            label18.Size = new Size(47, 20);
            label18.TabIndex = 27;
            label18.Text = "MAIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(717, 132);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 28;
            label1.Text = "Gain";
            // 
            // Mixer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(902, 1033);
            Controls.Add(label18);
            Controls.Add(crossfaderSlider);
            Controls.Add(verticalVolumeSlider_ch1);
            Controls.Add(verticalVolumeSlider_ch2);
            Controls.Add(pot_systemVolume);
            Controls.Add(panel_chanel2);
            Controls.Add(panel_efx);
            Controls.Add(panel_loops2);
            Controls.Add(panel_loops1);
            Controls.Add(panel_cue);
            Controls.Add(panel_mic);
            Controls.Add(panel_chanel1);
            Controls.Add(panel_volume);
            Margin = new Padding(2);
            Name = "Mixer";
            Text = "Mixer";
            panel_chanel1.ResumeLayout(false);
            panel_chanel1.PerformLayout();
            panel_chanel2.ResumeLayout(false);
            panel_chanel2.PerformLayout();
            panel_loops1.ResumeLayout(false);
            panel_efx_wyswietlacz.ResumeLayout(false);
            panel_efx_wyswietlacz.PerformLayout();
            panel_efx.ResumeLayout(false);
            panel_efx.PerformLayout();
            panel_loops2.ResumeLayout(false);
            panel_cue.ResumeLayout(false);
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
        private Button btn_fx_tap;
        private Panel panel_efx_wyswietlacz;
        private CheckBox chBox_efx_on;
        private NAudio.Gui.Pot Pot_fx_gain;
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
        private NAudio.Gui.Pot pot_low_ch1;
        private CheckBox chBox_flexfx_ch1;
        private Panel panel_mic;
        private CheckBox ChBox_mic_fx;
        private NAudio.Gui.VolumeMeter volumeMeter_mic_volume;
        private NAudio.Gui.VolumeMeter volumeMeter_mainRight;
        private NAudio.Gui.VolumeMeter volumeMeter_mainLeft;
        private NAudio.Gui.VolumeMeter volumeMeter_ch2;
        private NAudio.Gui.VolumeMeter volumeMeter_ch1;
        internal NAudio.Gui.Pot pot_gain_ch1;
        internal NAudio.Gui.Pot pot_gain_ch2;
        private Panel panel_volume;
        private Controls.VerticalVolumeSlider verticalVolumeSlider_ch2;
        private Controls.VerticalVolumeSlider verticalVolumeSlider_ch1;
        private Controls.CrossfaderSlider crossfaderSlider;
        private Label label_Bpm_count;
        private Label label_Bpm_text;
        private Label label_Effect_text;
        private Label label_Effect_Name;
        private Label label12;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label16;
        private Label label14;
        private Label label17;
        private Label label15;
        private Label label13;
        private Label label18;
        private Label label1;
    }
}
