using iRANE_62.Models;
using NAudio.Extras;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.ComponentModel;

namespace iRANE_62
{
    public partial class Mixer : Form//, INotifyPropertyChanged
    {
        private Player player1;
        private Player player2;



        //public event PropertyChangedEventHandler PropertyChanged;

        public Mixer()
        {

        }

        public Mixer(ref Player player1, ref Player player2) : this()
        {
            this.player1 = player1;
            this.player2 = player2;
            InitializeComponent();


            //efx
            efx_echo.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_ext_insert.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_flanger.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_filter.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_phaser.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_reverb.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_robot.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
            efx_insert.CheckedChanged += new EventHandler(Efx_CheckBox_Change);
        }

        #region EFX
        //EFX

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
        /*
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
             equalizer?.Update();
        }

        */


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
        {

            player1.Equalizer.Band7 = (float)high_odt1.Value;
            player1.Equalizer.Band8 = (float)high_odt1.Value;
            player1.Equalizer.Band9 = (float)high_odt1.Value;
            player1.Equalizer.equalizer.Update();
        }

        private void mid_odt1_ValueChanged(object sender, EventArgs e)
        {
            player1.Equalizer.Band4 = (float)mid_odt1.Value;
            player1.Equalizer.Band5 = (float)mid_odt1.Value;
            player1.Equalizer.Band6 = (float)mid_odt1.Value;
            player1.Equalizer.equalizer.Update();
        }

        private void low_odt1_ValueChanged(object sender, EventArgs e)
        {

            player1.Equalizer.Band1 = (float)low_odt1.Value;
            player1.Equalizer.Band2 = (float)low_odt1.Value;
            player1.Equalizer.Band3 = (float)low_odt1.Value;
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


        #endregion

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
    }
}
