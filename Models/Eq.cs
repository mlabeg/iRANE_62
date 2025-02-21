using iRANE_62.Extensions;
using NAudio.Extras;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class Eq
    {
        public Equalizer equalizer;

        public EqualizerBand[] bands { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public StereoPanningSampleProvider PanningProvider { get; set; }

        public FilterSampleProvider FilterSampleProvider { get; set; }



        public Eq()
        {
            bands = CreateBands();

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private EqualizerBand[] CreateBands()
        {
            var bands = new EqualizerBand[]
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

            return bands;
        }
        private EqualizerBand[] CreateBands2()
        {//nie wiem jak sterowane powinny być te ustawioenia od strony GUI, CreateBands lepiej działa i reaguje na zmiany
            var bands = new EqualizerBand[]
                {
                    new EqualizerBand {Bandwidth =0.4f, Frequency = 100, Gain = -20},
                    new EqualizerBand {Bandwidth =0.4f, Frequency = 200, Gain = -10},
                    new EqualizerBand {Bandwidth =0.4f, Frequency = 400, Gain = -10},
                    new EqualizerBand {Bandwidth =0.4f, Frequency = 800, Gain = 10},
                    new EqualizerBand {Bandwidth =0.4f, Frequency = 1200, Gain = 10},
                    new EqualizerBand {Bandwidth =0.4f, Frequency = 2400, Gain = 10},
                    new EqualizerBand {Bandwidth =0.4f, Frequency = 4800, Gain = -25},
                    new EqualizerBand {Bandwidth =0.4f, Frequency = 9600, Gain = -30},
                    new EqualizerBand { Frequency = 16000, Gain = -30f, Bandwidth = 0.4f } // Air
                };

            return bands;
        }

        #region Bands
        public float Band1
        {
            get => bands[0].Gain;
            set
            {
                if (bands[0].Gain != value)
                {
                    bands[0].Gain = value;
                }
                OnPropertyChanged(nameof(Band1));
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
                }
                OnPropertyChanged(nameof(Band2));
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
                }
                OnPropertyChanged(nameof(Band3));
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
                }
                OnPropertyChanged(nameof(Band4));
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
                }
                OnPropertyChanged(nameof(Band5));
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
                }
                OnPropertyChanged(nameof(Band6));
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
                }
                OnPropertyChanged(nameof(Band7));
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
                }
                OnPropertyChanged(nameof(Band8));
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
                }
                OnPropertyChanged(nameof(Band9));
            }
        }
        #endregion
    }
}
