namespace iRANE_62
{
    partial class Odtwarzacz
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
            btnOpen_1 = new Button();
            btnPlay_1 = new Button();
            btnPause_1 = new Button();
            btnStop_1 = new Button();
            btnOpen_2 = new Button();
            btnPlay_2 = new Button();
            btnPause_2 = new Button();
            btnStop_2 = new Button();
            listBox1 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelNowTime_1 = new Label();
            labelTotalTime_1 = new Label();
            labelNowTime_2 = new Label();
            labelTotalTime_2 = new Label();
            pictureBox1 = new PictureBox();
            labelRendering1 = new Label();
            pictureBox2 = new PictureBox();
            labelRendering2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            labelTrack1 = new Label();
            labelTrack2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnOpen_1
            // 
            btnOpen_1.Location = new Point(31, 72);
            btnOpen_1.Name = "btnOpen_1";
            btnOpen_1.Size = new Size(85, 34);
            btnOpen_1.TabIndex = 1;
            btnOpen_1.Text = "Open";
            btnOpen_1.UseVisualStyleBackColor = true;
            btnOpen_1.Click += btnOpen_1_Click;
            btnOpen_1.KeyDown += btnOpen_KeyDown;
            // 
            // btnPlay_1
            // 
            btnPlay_1.Location = new Point(122, 72);
            btnPlay_1.Name = "btnPlay_1";
            btnPlay_1.Size = new Size(76, 34);
            btnPlay_1.TabIndex = 1;
            btnPlay_1.Text = "Play";
            btnPlay_1.UseVisualStyleBackColor = true;
            btnPlay_1.Click += btnPlay1_Click;
            btnPlay_1.KeyDown += Odtwarzacz_KeyDown;
            // 
            // btnPause_1
            // 
            btnPause_1.Location = new Point(204, 72);
            btnPause_1.Name = "btnPause_1";
            btnPause_1.Size = new Size(79, 34);
            btnPause_1.TabIndex = 1;
            btnPause_1.Text = "Pause";
            btnPause_1.UseVisualStyleBackColor = true;
            btnPause_1.Click += btnPause_1_Click;
            // 
            // btnStop_1
            // 
            btnStop_1.Location = new Point(289, 72);
            btnStop_1.Name = "btnStop_1";
            btnStop_1.Size = new Size(82, 34);
            btnStop_1.TabIndex = 1;
            btnStop_1.Text = "Stop";
            btnStop_1.UseVisualStyleBackColor = true;
            btnStop_1.Click += btnStop_1_Click;
            // 
            // btnOpen_2
            // 
            btnOpen_2.Location = new Point(735, 72);
            btnOpen_2.Name = "btnOpen_2";
            btnOpen_2.Size = new Size(69, 34);
            btnOpen_2.TabIndex = 1;
            btnOpen_2.Text = "Open";
            btnOpen_2.UseVisualStyleBackColor = true;
            btnOpen_2.Click += btnOpen_2_Click;
            btnOpen_2.KeyDown += btnOpen_KeyDown;
            // 
            // btnPlay_2
            // 
            btnPlay_2.Location = new Point(810, 72);
            btnPlay_2.Name = "btnPlay_2";
            btnPlay_2.Size = new Size(72, 34);
            btnPlay_2.TabIndex = 1;
            btnPlay_2.Text = "Play";
            btnPlay_2.UseVisualStyleBackColor = true;
            btnPlay_2.Click += btnPlay_2_Click;
            btnPlay_2.KeyDown += Odtwarzacz_KeyDown;
            // 
            // btnPause_2
            // 
            btnPause_2.Location = new Point(888, 72);
            btnPause_2.Name = "btnPause_2";
            btnPause_2.Size = new Size(78, 34);
            btnPause_2.TabIndex = 1;
            btnPause_2.Text = "Pause";
            btnPause_2.UseVisualStyleBackColor = true;
            btnPause_2.Click += btnPause_2_Click;
            // 
            // btnStop_2
            // 
            btnStop_2.Location = new Point(972, 72);
            btnStop_2.Name = "btnStop_2";
            btnStop_2.Size = new Size(75, 34);
            btnStop_2.TabIndex = 1;
            btnStop_2.Text = "Stop";
            btnStop_2.UseVisualStyleBackColor = true;
            btnStop_2.Click += btnStop_2_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(22, 283);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1344, 304);
            listBox1.TabIndex = 2;
            listBox1.DragDrop += listBox1_DragDrop;
            listBox1.DragEnter += listBox1_DragEnter;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // labelNowTime_1
            // 
            labelNowTime_1.AutoSize = true;
            labelNowTime_1.Location = new Point(489, 72);
            labelNowTime_1.Name = "labelNowTime_1";
            labelNowTime_1.Size = new Size(56, 25);
            labelNowTime_1.TabIndex = 3;
            labelNowTime_1.Text = "00:00";
            // 
            // labelTotalTime_1
            // 
            labelTotalTime_1.AutoSize = true;
            labelTotalTime_1.Location = new Point(588, 72);
            labelTotalTime_1.Name = "labelTotalTime_1";
            labelTotalTime_1.Size = new Size(56, 25);
            labelTotalTime_1.TabIndex = 3;
            labelTotalTime_1.Text = "00:00";
            // 
            // labelNowTime_2
            // 
            labelNowTime_2.AutoSize = true;
            labelNowTime_2.Location = new Point(1143, 72);
            labelNowTime_2.Name = "labelNowTime_2";
            labelNowTime_2.Size = new Size(56, 25);
            labelNowTime_2.TabIndex = 3;
            labelNowTime_2.Text = "00:00";
            // 
            // labelTotalTime_2
            // 
            labelTotalTime_2.AutoSize = true;
            labelTotalTime_2.Location = new Point(1242, 72);
            labelTotalTime_2.Name = "labelTotalTime_2";
            labelTotalTime_2.Size = new Size(56, 25);
            labelTotalTime_2.TabIndex = 3;
            labelTotalTime_2.Text = "00:00";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 125);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelRendering1
            // 
            labelRendering1.AutoSize = true;
            labelRendering1.Font = new Font("Segoe UI", 20F);
            labelRendering1.Location = new Point(31, 163);
            labelRendering1.Name = "labelRendering1";
            labelRendering1.Size = new Size(239, 54);
            labelRendering1.TabIndex = 5;
            labelRendering1.Text = "Ładowanie...";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(711, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(655, 125);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // labelRendering2
            // 
            labelRendering2.AutoSize = true;
            labelRendering2.Font = new Font("Segoe UI", 20F);
            labelRendering2.Location = new Point(735, 163);
            labelRendering2.Name = "labelRendering2";
            labelRendering2.Size = new Size(239, 54);
            labelRendering2.TabIndex = 5;
            labelRendering2.Text = "Ładowanie...";
            // 
            // labelTrack1
            // 
            labelTrack1.AutoSize = true;
            labelTrack1.Location = new Point(31, 23);
            labelTrack1.Name = "labelTrack1";
            labelTrack1.Size = new Size(108, 25);
            labelTrack1.TabIndex = 6;
            labelTrack1.Text = "Ładowanie...";
            // 
            // labelTrack2
            // 
            labelTrack2.AutoSize = true;
            labelTrack2.Location = new Point(735, 23);
            labelTrack2.Name = "labelTrack2";
            labelTrack2.Size = new Size(108, 25);
            labelTrack2.TabIndex = 6;
            labelTrack2.Text = "Ładowanie...";
            // 
            // Odtwarzacz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1393, 622);
            Controls.Add(labelTrack2);
            Controls.Add(labelTrack1);
            Controls.Add(labelRendering2);
            Controls.Add(labelRendering1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelTotalTime_2);
            Controls.Add(labelTotalTime_1);
            Controls.Add(labelNowTime_2);
            Controls.Add(labelNowTime_1);
            Controls.Add(listBox1);
            Controls.Add(btnStop_2);
            Controls.Add(btnStop_1);
            Controls.Add(btnPause_2);
            Controls.Add(btnPause_1);
            Controls.Add(btnPlay_2);
            Controls.Add(btnPlay_1);
            Controls.Add(btnOpen_2);
            Controls.Add(btnOpen_1);
            Name = "Odtwarzacz";
            Text = "Odtwarzacz";
            KeyDown += Odtwarzacz_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NAudio.Gui.WaveViewer waveViewer_2;
        private Button btnOpen_1;
        private Button btnPlay_1;
        private Button btnPause_1;
        private Button btnStop_1;
        private Button btnOpen_2;
        private Button btnPlay_2;
        private Button btnPause_2;
        private Button btnStop_2;
        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private Label labelNowTime_1;
        private Label labelTotalTime_1;
        private Label labelNowTime_2;
        private Label labelTotalTime_2;
        private PictureBox pictureBox1;
        private Label labelRendering1;
        private PictureBox pictureBox2;
        private Label labelRendering2;
        private System.Windows.Forms.Timer timer2;
        private Label labelTrack1;
        private Label labelTrack2;
    }
}