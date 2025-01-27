using iRANE_62.Models;
using NAudio.Extras;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.ComponentModel;

namespace iRANE_62
{
    public partial class Mikser : Form//, INotifyPropertyChanged
    {
        private Player player1;
        private Player player2;

        public Equalizer equalizer;
        public EqualizerBand[] bands { get; }

        //public event PropertyChangedEventHandler PropertyChanged;

        public Mikser()
        {
            bands = new EqualizerBand[]
                {
                new EqualizerBand { Frequency = 60, Gain = 0f, Bandwidth = 0.8f },   // Sub-bass
                new EqualizerBand { Frequency = 120, Gain = 0f, Bandwidth = 0.8f },  // Bass
                new EqualizerBand { Frequency = 250, Gain = 0f, Bandwidth = 0.8f },  // Low-mid
                new EqualizerBand { Frequency = 500, Gain = 0f, Bandwidth = 0.8f },  // Mid
                new EqualizerBand { Frequency = 1000, Gain = 0f, Bandwidth = 0.8f }, // Upper-mid
                new EqualizerBand { Frequency = 2000, Gain = 0f, Bandwidth = 0.8f }, // Presence
                new EqualizerBand { Frequency = 4000, Gain = 0f, Bandwidth = 0.8f }, // High-mid
                new EqualizerBand { Frequency = 8000, Gain = 0f, Bandwidth = 0.8f }, // Treble
                new EqualizerBand { Frequency = 16000, Gain = 0f, Bandwidth = 0.8f } // Air

                };
           // this.PropertyChanged += OnPropertyChanged;

        }

        public Mikser(ref Player player1, ref Player player2) : this()
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
        public float Band1
        {
            get => bands[0].Gain;
            set
            {
                if (bands[0].Gain != value)
                {
                    bands[0].Gain = value;
                    equalizer?.Update();
                    //OnPropertyChanged("high_odt1");
                }
            }
        }

        public float Band2
        {
            get => bands[1].Gain;
            set
            {
                if (bands[1].Gain != value)
                {
                    bands[1].Gain = value;
                    //OnPropertyChanged("Band2");
                }
            }
        }

        public float Band3
        {
            get => bands[2].Gain;
            set
            {
                if (bands[2].Gain != value)
                {
                    bands[2].Gain = value;
                    //OnPropertyChanged("Band3");
                }
            }
        }

        public float Band4
        {
            get => bands[3].Gain;
            set
            {
                if (bands[3].Gain != value)
                {
                    bands[3].Gain = value;
                    equalizer?.Update();
                    //OnPropertyChanged("Band4");
                }
            }
        }

        public float Band5
        {
            get => bands[4].Gain;
            set
            {
                if (bands[4].Gain != value)
                {
                    bands[4].Gain = value;
                    //OnPropertyChanged("Band5");
                }
            }
        }

        public float Band6
        {
            get => bands[5].Gain;
            set
            {
                if (bands[5].Gain != value)
                {
                    bands[5].Gain = value;
                    //OnPropertyChanged("Band6");
                }
            }
        }

        public float Band7
        {
            get => bands[6].Gain;
            set
            {
                if (bands[6].Gain != value)
                {
                    bands[6].Gain = value;
                    equalizer?.Update();
                    //OnPropertyChanged("Band7");
                }
            }
        }

        public float Band8
        {
            get => bands[7].Gain;
            set
            {
                if (bands[7].Gain != value)
                {
                    bands[7].Gain = value;
                   // OnPropertyChanged("Band8");
                }
            }
        }

        public float Band9
        {
            get => bands[8].Gain;
            set
            {
                if (bands[8].Gain != value)
                {
                    bands[8].Gain = value;
                    //OnPropertyChanged("Band9");
                }
            }
        }

        #endregion

        private void level_odt1_ValueChanged(object sender, EventArgs e)
        {
            if (player1.WavePlayer != null)
            {
                player1.SetVolumeDelegate((float)level_odt1.Value);
            }
        }

        private void level_odt2_ValueChanged(object sender, EventArgs e)
        {
            if (player2.WavePlayer != null)
            {
                player2.SetVolumeDelegate((float)level_odt2.Value);
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

        private void high_odt1_ValueChanged(object sender, EventArgs e)
        {
            Band1 = (float)high_odt1.Value;
            Band2 = (float)high_odt1.Value;
            Band3 = (float)high_odt1.Value;

        }

        private void mid_odt1_ValueChanged(object sender, EventArgs e)
        {
            Band4 = (float)mid_odt1.Value;
            Band5 = (float)mid_odt1.Value;
            Band6 = (float)mid_odt1.Value;
        }

        private void low_odt1_ValueChanged(object sender, EventArgs e)
        {
            Band7 = (float)low_odt1.Value;
            Band8 = (float)low_odt1.Value;
            Band9 = (float)low_odt1.Value;
        }
    }
}
