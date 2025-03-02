namespace iRANE_62
{
    partial class Player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnOpen_ch1 = new Button();
            btnPlay_ch1 = new Button();
            btnPause_ch1 = new Button();
            btnStop_ch1 = new Button();
            btnOpen_ch2 = new Button();
            btnPlay_ch2 = new Button();
            btnPause_ch2 = new Button();
            btnStop_ch2 = new Button();
            playlista = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelNowTime_1 = new Label();
            labelTotalTime_1 = new Label();
            labelNowTime_2 = new Label();
            labelTotalTime_2 = new Label();
            waveform_ch1 = new PictureBox();
            labelRendering1 = new Label();
            waveform_ch2 = new PictureBox();
            labelRendering2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            labelTrack1 = new Label();
            labelTrack2 = new Label();
            ((System.ComponentModel.ISupportInitialize)waveform_ch1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waveform_ch2).BeginInit();
            SuspendLayout();
            // 
            // btnOpen_ch1
            // 
            btnOpen_ch1.Enabled = false;
            btnOpen_ch1.Location = new Point(25, 58);
            btnOpen_ch1.Margin = new Padding(2);
            btnOpen_ch1.Name = "btnOpen_ch1";
            btnOpen_ch1.Size = new Size(68, 27);
            btnOpen_ch1.TabIndex = 1;
            btnOpen_ch1.Text = "Open";
            btnOpen_ch1.UseVisualStyleBackColor = true;
            btnOpen_ch1.Click += btnOpen_1_Click;
            btnOpen_ch1.KeyDown += btnOpen_KeyDown;
            // 
            // btnPlay_ch1
            // 
            btnPlay_ch1.Location = new Point(98, 58);
            btnPlay_ch1.Margin = new Padding(2);
            btnPlay_ch1.Name = "btnPlay_ch1";
            btnPlay_ch1.Size = new Size(61, 27);
            btnPlay_ch1.TabIndex = 1;
            btnPlay_ch1.Text = "Play";
            btnPlay_ch1.UseVisualStyleBackColor = true;
            btnPlay_ch1.Click += btnPlay1_Click;
            btnPlay_ch1.KeyDown += Odtwarzacz_KeyDown;
            // 
            // btnPause_ch1
            // 
            btnPause_ch1.Location = new Point(163, 58);
            btnPause_ch1.Margin = new Padding(2);
            btnPause_ch1.Name = "btnPause_ch1";
            btnPause_ch1.Size = new Size(63, 27);
            btnPause_ch1.TabIndex = 1;
            btnPause_ch1.Text = "Pause";
            btnPause_ch1.UseVisualStyleBackColor = true;
            btnPause_ch1.Click += btnPause_1_Click;
            // 
            // btnStop_ch1
            // 
            btnStop_ch1.Location = new Point(231, 58);
            btnStop_ch1.Margin = new Padding(2);
            btnStop_ch1.Name = "btnStop_ch1";
            btnStop_ch1.Size = new Size(66, 27);
            btnStop_ch1.TabIndex = 1;
            btnStop_ch1.Text = "Stop";
            btnStop_ch1.UseVisualStyleBackColor = true;
            btnStop_ch1.Click += btnStop_1_Click;
            // 
            // btnOpen_ch2
            // 
            btnOpen_ch2.Location = new Point(588, 58);
            btnOpen_ch2.Margin = new Padding(2);
            btnOpen_ch2.Name = "btnOpen_ch2";
            btnOpen_ch2.Size = new Size(55, 27);
            btnOpen_ch2.TabIndex = 1;
            btnOpen_ch2.Text = "Open";
            btnOpen_ch2.UseVisualStyleBackColor = true;
            btnOpen_ch2.Click += btnOpen_2_Click;
            btnOpen_ch2.KeyDown += btnOpen_KeyDown;
            // 
            // btnPlay_ch2
            // 
            btnPlay_ch2.Location = new Point(648, 58);
            btnPlay_ch2.Margin = new Padding(2);
            btnPlay_ch2.Name = "btnPlay_ch2";
            btnPlay_ch2.Size = new Size(58, 27);
            btnPlay_ch2.TabIndex = 1;
            btnPlay_ch2.Text = "Play";
            btnPlay_ch2.UseVisualStyleBackColor = true;
            btnPlay_ch2.Click += btnPlay_2_Click;
            btnPlay_ch2.KeyDown += Odtwarzacz_KeyDown;
            // 
            // btnPause_ch2
            // 
            btnPause_ch2.Location = new Point(710, 58);
            btnPause_ch2.Margin = new Padding(2);
            btnPause_ch2.Name = "btnPause_ch2";
            btnPause_ch2.Size = new Size(62, 27);
            btnPause_ch2.TabIndex = 1;
            btnPause_ch2.Text = "Pause";
            btnPause_ch2.UseVisualStyleBackColor = true;
            btnPause_ch2.Click += btnPause_2_Click;
            // 
            // btnStop_ch2
            // 
            btnStop_ch2.Location = new Point(778, 58);
            btnStop_ch2.Margin = new Padding(2);
            btnStop_ch2.Name = "btnStop_ch2";
            btnStop_ch2.Size = new Size(60, 27);
            btnStop_ch2.TabIndex = 1;
            btnStop_ch2.Text = "Stop";
            btnStop_ch2.UseVisualStyleBackColor = true;
            btnStop_ch2.Click += btnStop_2_Click;
            // 
            // playlista
            // 
            playlista.AllowDrop = true;
            playlista.FormattingEnabled = true;
            playlista.Location = new Point(18, 226);
            playlista.Margin = new Padding(2);
            playlista.Name = "playlista";
            playlista.Size = new Size(1076, 244);
            playlista.TabIndex = 2;
            playlista.DragDrop += listBox1_DragDrop;
            playlista.DragEnter += listBox1_DragEnter;
            playlista.KeyDown += listBox1_KeyDown;
            // 
            // labelNowTime_1
            // 
            labelNowTime_1.AutoSize = true;
            labelNowTime_1.Location = new Point(391, 58);
            labelNowTime_1.Margin = new Padding(2, 0, 2, 0);
            labelNowTime_1.Name = "labelNowTime_1";
            labelNowTime_1.Size = new Size(44, 20);
            labelNowTime_1.TabIndex = 3;
            labelNowTime_1.Text = "00:00";
            // 
            // labelTotalTime_1
            // 
            labelTotalTime_1.AutoSize = true;
            labelTotalTime_1.Location = new Point(470, 58);
            labelTotalTime_1.Margin = new Padding(2, 0, 2, 0);
            labelTotalTime_1.Name = "labelTotalTime_1";
            labelTotalTime_1.Size = new Size(44, 20);
            labelTotalTime_1.TabIndex = 3;
            labelTotalTime_1.Text = "00:00";
            // 
            // labelNowTime_2
            // 
            labelNowTime_2.AutoSize = true;
            labelNowTime_2.Location = new Point(914, 58);
            labelNowTime_2.Margin = new Padding(2, 0, 2, 0);
            labelNowTime_2.Name = "labelNowTime_2";
            labelNowTime_2.Size = new Size(44, 20);
            labelNowTime_2.TabIndex = 3;
            labelNowTime_2.Text = "00:00";
            // 
            // labelTotalTime_2
            // 
            labelTotalTime_2.AutoSize = true;
            labelTotalTime_2.Location = new Point(994, 58);
            labelTotalTime_2.Margin = new Padding(2, 0, 2, 0);
            labelTotalTime_2.Name = "labelTotalTime_2";
            labelTotalTime_2.Size = new Size(44, 20);
            labelTotalTime_2.TabIndex = 3;
            labelTotalTime_2.Text = "00:00";
            // 
            // waveform_ch1
            // 
            waveform_ch1.BorderStyle = BorderStyle.FixedSingle;
            waveform_ch1.Enabled = false;
            waveform_ch1.Location = new Point(18, 101);
            waveform_ch1.Margin = new Padding(2);
            waveform_ch1.Name = "waveform_ch1";
            waveform_ch1.Size = new Size(524, 100);
            waveform_ch1.TabIndex = 4;
            waveform_ch1.TabStop = false;
            waveform_ch1.Paint += waveform_ch1_Paint;
            waveform_ch1.MouseClick += waveform_ch1_MouseClick;
            // 
            // labelRendering1
            // 
            labelRendering1.AutoSize = true;
            labelRendering1.Font = new Font("Segoe UI", 20F);
            labelRendering1.Location = new Point(25, 130);
            labelRendering1.Margin = new Padding(2, 0, 2, 0);
            labelRendering1.Name = "labelRendering1";
            labelRendering1.Size = new Size(201, 46);
            labelRendering1.TabIndex = 5;
            labelRendering1.Text = "Ładowanie...";
            // 
            // waveform_ch2
            // 
            waveform_ch2.BorderStyle = BorderStyle.FixedSingle;
            waveform_ch2.Enabled = false;
            waveform_ch2.Location = new Point(569, 101);
            waveform_ch2.Margin = new Padding(2);
            waveform_ch2.Name = "waveform_ch2";
            waveform_ch2.Size = new Size(524, 100);
            waveform_ch2.TabIndex = 4;
            waveform_ch2.TabStop = false;
            waveform_ch2.Paint += waveform_ch2_Paint;
            waveform_ch2.MouseClick += waveform_ch2_MouseClick;
            // 
            // labelRendering2
            // 
            labelRendering2.AutoSize = true;
            labelRendering2.Font = new Font("Segoe UI", 20F);
            labelRendering2.Location = new Point(588, 130);
            labelRendering2.Margin = new Padding(2, 0, 2, 0);
            labelRendering2.Name = "labelRendering2";
            labelRendering2.Size = new Size(201, 46);
            labelRendering2.TabIndex = 5;
            labelRendering2.Text = "Ładowanie...";
            // 
            // labelTrack1
            // 
            labelTrack1.AutoSize = true;
            labelTrack1.Location = new Point(25, 18);
            labelTrack1.Margin = new Padding(2, 0, 2, 0);
            labelTrack1.Name = "labelTrack1";
            labelTrack1.Size = new Size(90, 20);
            labelTrack1.TabIndex = 6;
            labelTrack1.Text = "Ładowanie...";
            // 
            // labelTrack2
            // 
            labelTrack2.AutoSize = true;
            labelTrack2.Location = new Point(588, 18);
            labelTrack2.Margin = new Padding(2, 0, 2, 0);
            labelTrack2.Name = "labelTrack2";
            labelTrack2.Size = new Size(90, 20);
            labelTrack2.TabIndex = 6;
            labelTrack2.Text = "Ładowanie...";
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1114, 498);
            Controls.Add(labelTrack2);
            Controls.Add(labelTrack1);
            Controls.Add(labelRendering2);
            Controls.Add(labelRendering1);
            Controls.Add(waveform_ch2);
            Controls.Add(labelTotalTime_2);
            Controls.Add(labelTotalTime_1);
            Controls.Add(labelNowTime_2);
            Controls.Add(labelNowTime_1);
            Controls.Add(playlista);
            Controls.Add(btnStop_ch2);
            Controls.Add(btnStop_ch1);
            Controls.Add(btnPause_ch2);
            Controls.Add(btnPause_ch1);
            Controls.Add(btnPlay_ch2);
            Controls.Add(btnPlay_ch1);
            Controls.Add(btnOpen_ch2);
            Controls.Add(btnOpen_ch1);
            Controls.Add(waveform_ch1);
            Margin = new Padding(2);
            Name = "Player";
            Text = "Player";
            KeyDown += Odtwarzacz_KeyDown;
            ((System.ComponentModel.ISupportInitialize)waveform_ch1).EndInit();
            ((System.ComponentModel.ISupportInitialize)waveform_ch2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NAudio.Gui.WaveViewer waveViewer_2;
        private Button btnOpen_ch1;
        private Button btnPlay_ch1;
        private Button btnPause_ch1;
        private Button btnStop_ch1;
        private Button btnOpen_ch2;
        private Button btnPlay_ch2;
        private Button btnPause_ch2;
        private Button btnStop_ch2;
        private ListBox playlista;
        private System.Windows.Forms.Timer timer1;
        private Label labelNowTime_1;
        private Label labelTotalTime_1;
        private Label labelNowTime_2;
        private Label labelTotalTime_2;
        private PictureBox waveform_ch1;
        private Label labelRendering1;
        private PictureBox waveform_ch2;
        private Label labelRendering2;
        private System.Windows.Forms.Timer timer2;
        private Label labelTrack1;
        private Label labelTrack2;
    }
}