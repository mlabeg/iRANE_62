using iRANE_62.Models;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace iRANE_62
{
    public partial class Mikser : Form
    {
        private Player player1;
        private Player player2;


        public Mikser()
        {

        }

        public Mikser(ref Player player1, ref Player player2)
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



        private void level_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (player1.wavePlayer != null)
            {
                player1.setVolumeDelegate((float)level_odt1.Value);
            }
        }

        private void level_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (player2.wavePlayer != null)
            {
                player2.setVolumeDelegate((float)level_odt2.Value);
            }
        }

        public void OnPostMainVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            mainVolumeLeft.Amplitude = e.MaxSampleValues[0];
            mainVolumeRight.Amplitude = e.MaxSampleValues[1];
        }

        public void OnPostChanelVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter_ch1.Amplitude = Math.Max(e.MaxSampleValues[0], e.MaxSampleValues[1]);
        }


    }
}
