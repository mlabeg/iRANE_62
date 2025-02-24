using iRANE_62.Models;
using NAudio.Extras;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.ComponentModel;
using System.Numerics;

namespace iRANE_62
{
    public partial class Mixer : Form
    {
        private AudioSource player1;
        private AudioSource player2;

        public Mixer() { }

        public Mixer(ref AudioSource player1, ref AudioSource player2) : this()
        {
            this.player1 = player1;
            this.player2 = player2;
            InitializeComponent();

            efxCheckedChangedEventHandler();
            blockCueButtons();
        }

        #region FX

        private void efxCheckedChangedEventHandler()
        {
            efx_echo.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_ext_insert.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_flanger.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_filter.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_phaser.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_reverb.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_robot.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_insert.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
        }

        private void efx_flanger_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void efx_phaser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void efx_echo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void efx_robot_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void efx_reverb_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void efx_ext_insert_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void efx_insert_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void efx_filter_CheckedChanged(object sender, EventArgs e)
        {


        }

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

        #region EQ

        private void level_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (player1.WavePlayer != null)
            {
                player1.SetVolumeDelegate((float)gain_ch1.Value);
            }
        }

        private void level_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (player2.WavePlayer != null)
            {
                player2.SetVolumeDelegate((float)gain_ch2.Value);
            }
        }

        public void OnPostMainVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            mainVolumeLeft.Amplitude = e.MaxSampleValues[0];
            mainVolumeRight.Amplitude = e.MaxSampleValues[1];
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

            player1.Equalizer.Band9 = (float)high_odt1.Value;
            player1.Equalizer.Band8 = (float)high_odt1.Value;
            player1.Equalizer.Band7 = (float)(high_odt1.Value + mid_odt1.Value) / 2;
            player1.Equalizer.equalizer.Update();
        }

        private void mid_odt1_ValueChanged(object sender, EventArgs e)
        {
            player1.Equalizer.Band6 = (float)(mid_odt1.Value + high_odt1.Value) / 2;
            player1.Equalizer.Band5 = (float)mid_odt1.Value;
            player1.Equalizer.Band4 = (float)(mid_odt1.Value + low_odt1.Value) / 2;
            player1.Equalizer.equalizer.Update();
        }

        private void low_odt1_ValueChanged(object sender, EventArgs e)
        {
            player1.Equalizer.Band3 = (float)(low_odt1.Value + mid_odt1.Value) / 2;
            player1.Equalizer.Band2 = (float)low_odt1.Value;
            player1.Equalizer.Band1 = (float)low_odt1.Value;
            player1.Equalizer.equalizer.Update();
        }

        private void high_odt2_ValueChanged(object sender, EventArgs e)
        {
            player2.Equalizer.Band7 = (float)high_odt2.Value;
            player2.Equalizer.Band9 = (float)high_odt2.Value;
            player2.Equalizer.Band8 = (float)high_odt2.Value;
            player2.Equalizer.equalizer.Update();
        }

        private void mid_odt2_ValueChanged(object sender, EventArgs e)
        {
            player2.Equalizer.Band4 = (float)mid_odt2.Value;
            player2.Equalizer.Band5 = (float)mid_odt2.Value;
            player2.Equalizer.Band6 = (float)mid_odt2.Value;
            player2.Equalizer.equalizer.Update();
        }

        private void low_odt2_ValueChanged(object sender, EventArgs e)
        {

            player2.Equalizer.Band1 = (float)low_odt2.Value;
            player2.Equalizer.Band2 = (float)low_odt2.Value;
            player2.Equalizer.Band3 = (float)low_odt2.Value;
            player2.Equalizer.equalizer.Update();
        }

        private void pan_odt1_PanChanged(object sender, EventArgs e)
        {
            if (player1.Equalizer.PanningProvider != null)
            {
                float panValue = (float)pan_odt1.Pan;
                player1.Equalizer.PanningProvider.Pan = panValue;
            }
        }

        private void pan_odt2_PanChanged(object sender, EventArgs e)
        {
            float panValue = (float)pan_odt2.Pan;
            player2.Equalizer.PanningProvider.Pan = panValue;
        }

        private void filter_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (player1 != null)
            {
                float potValue = (float)filter_odt1.Value;
                player1.Equalizer.FilterSampleProvider.FilterValue = potValue;
            }
        }

        private void filter_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (player2 != null)
            {
                float potValue = (float)filter_odt2.Value;
                player2.Equalizer.FilterSampleProvider.FilterValue = potValue;
            }
        }
        #endregion

        #region Loop
        private void loopOut_ch1_Click(object sender, EventArgs e)
        {
            if (player1.AudioFileReader != null)
            {
                player1.Loop.SetLoopOut(player1.AudioFileReader.CurrentTime);
            }
        }

        private void loopIn_ch1_Click(object sender, EventArgs e)
        {
            if (player1.AudioFileReader != null)
            {
                player1.Loop.SetLoopIn(player1.AudioFileReader.CurrentTime);
                player1.Loop.LoopActive = true;
            }
        }

        private void exitLoop_ch1_Click(object sender, EventArgs e)
        {
            player1.Loop.LoopActive = false;
            player1.Loop.LoopIn = TimeSpan.Zero;
            player1.Loop.LoopOut = TimeSpan.Zero;
        }

        private void loopOut_ch2_Click(object sender, EventArgs e)
        {
            if (player2.AudioFileReader != null)
            {
                player2.Loop.SetLoopOut(player2.AudioFileReader.CurrentTime);
            }
        }

        private void loopIn_ch2_Click(object sender, EventArgs e)
        {
            if (player2.AudioFileReader != null)
            {
                player2.Loop.SetLoopIn(player2.AudioFileReader.CurrentTime);
                player2.Loop.LoopActive = true;
            }
        }

        private void exitLoop_ch2_Click(object sender, EventArgs e)
        {
            player2.Loop.LoopActive = false;
            player2.Loop.LoopIn = TimeSpan.Zero;
            player2.Loop.LoopOut = TimeSpan.Zero;
        }
        #endregion

        #region CuePoint

        private void blockCueButtons()
        {
            cue1_ch1.Enabled = false;
            cue2_ch1.Enabled = false;
            cue3_ch1.Enabled = false;
            cue4_ch1.Enabled = false;
            cue5_ch1.Enabled = false;

            cue1_ch2.Enabled = false;
            cue2_ch2.Enabled = false;
            cue3_ch2.Enabled = false;
            cue4_ch2.Enabled = false;
            cue5_ch2.Enabled = false;

        }

        public void EnableCuePoints(int playerId)
        {
            if (playerId == 1)
            {
                cue1_ch1.Enabled = true;
                cue2_ch1.Enabled = true;
                cue3_ch1.Enabled = true;
                cue4_ch1.Enabled = true;
                cue5_ch1.Enabled = true;
            }
            else
            {
                cue1_ch2.Enabled = true;
                cue2_ch2.Enabled = true;
                cue3_ch2.Enabled = true;
                cue4_ch2.Enabled = true;
                cue5_ch2.Enabled = true;
            }
        }

        private void cue1_ch1_Click(object sender, EventArgs e)
        {

            TimeSpan currentTime = player1.AudioFileReader.CurrentTime;

            CueClick(player1, 0, currentTime);
            cue1_ch1.BackColor = Color.Bisque;
        }
        private void cue2_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player1.AudioFileReader.CurrentTime;

            CueClick(player1, 1, currentTime);
            cue2_ch1.BackColor = Color.CadetBlue;

        }
        private void cue3_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player1.AudioFileReader.CurrentTime;

            CueClick(player1, 2, currentTime);
            cue3_ch1.BackColor = Color.Thistle;
        }
        private void cue4_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player1.AudioFileReader.CurrentTime;
            CueClick(player1, 3, currentTime);
            cue4_ch1.BackColor = Color.Khaki;
        }
        private void cue5_ch1_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player1.AudioFileReader.CurrentTime;
            CueClick(player1, 4, currentTime);
            cue5_ch1.BackColor=Color.Fuchsia;
        }
        private void cue1_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player2.AudioFileReader.CurrentTime;
            CueClick(player2, 0, currentTime);
            cue1_ch2.BackColor = Color.Bisque;
        }
        private void cue2_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player2.AudioFileReader.CurrentTime;
            CueClick(player2, 1, currentTime);
            cue2_ch2.BackColor = Color.CadetBlue;
        }
        private void cue3_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player2.AudioFileReader.CurrentTime;
            CueClick(player2, 2, currentTime);
            cue2_ch2.BackColor = Color.Khaki;
        }
        private void cue4_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player2.AudioFileReader.CurrentTime;
            CueClick(player2, 3, currentTime);
            cue4_ch2.BackColor = Color.Khaki;
        }
        private void cue5_ch2_Click(object sender, EventArgs e)
        {
            TimeSpan currentTime = player2.AudioFileReader.CurrentTime;
            CueClick(player2, 4, currentTime);
            cue5_ch2.BackColor = Color.Fuchsia;
        }

        public void CueColorClear(int playerId)
        {
            if (playerId == 1)
            {
                cue1_ch1.BackColor = Color.White;
                cue2_ch1.BackColor = Color.White;
                cue3_ch1.BackColor = Color.White;
                cue4_ch1.BackColor = Color.White;
                cue5_ch1.BackColor = Color.White;
            }
            else
            {

                cue1_ch2.BackColor = Color.White;
                cue2_ch2.BackColor = Color.White;
                cue3_ch2.BackColor = Color.White;
                cue4_ch2.BackColor = Color.White;
                cue5_ch2.BackColor = Color.White;
            }
        }
        private void CueClick(AudioSource player, int cue, TimeSpan currentTime)
        {
            if (player.Song.CuePoints[cue].Ticks >= 0)
            {
                player.AudioFileReader.CurrentTime = player.Song.CuePoints[cue];
            }
            else
            {
                player.Song.CuePoints[cue] = currentTime;
            }
        }
        #endregion

    }
}
