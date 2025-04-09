using NAudio.Extras;
using System.ComponentModel;


namespace iRANE_62.Models
{
    public class EqualizerWithBands
    {
        public Equalizer Equalizer;
        public EqualizerBand[] Bands { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public EqualizerWithBands()
        {
            Bands = CreateBands();
        }

        private EqualizerBand[] CreateBands()
        {
            return new[]
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
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void UpdateEqHigh(float value)
        {
            Band7 = value;
            Band9 = value;
            Band8 = value;
            Equalizer.Update();
        }

        public void UpdateEqMid(float value)
        {
            Band4 = value;
            Band5 = value;
            Band6 = value;
            Equalizer.Update();
        }

        public void UpdateEqLow(float value)
        {
            Band1 = value;
            Band2 = value;
            Band3 = value;
            Equalizer.Update();
        }

        #region Bands
        public float Band1
        {
            get => Bands[0].Gain;
            set
            {
                if (Bands[0].Gain != value)
                {
                    Bands[0].Gain = value;
                }
                OnPropertyChanged(nameof(Band1));
            }
        }

        public float Band2
        {
            get => Bands[1].Gain;
            set
            {
                if (Bands[1].Gain != value)
                {
                    Bands[1].Gain = value;
                }
                OnPropertyChanged(nameof(Band2));
            }
        }

        public float Band3
        {
            get => Bands[2].Gain;
            set
            {
                if (Bands[2].Gain != value)
                {
                    Bands[2].Gain = value;
                }
                OnPropertyChanged(nameof(Band3));
            }
        }

        public float Band4
        {
            get => Bands[3].Gain;
            set
            {
                if (Bands[3].Gain != value)
                {
                    Bands[3].Gain = value;
                }
                OnPropertyChanged(nameof(Band4));
            }
        }

        public float Band5
        {
            get => Bands[4].Gain;
            set
            {
                if (Bands[4].Gain != value)
                {
                    Bands[4].Gain = value;
                }
                OnPropertyChanged(nameof(Band5));
            }
        }

        public float Band6
        {
            get => Bands[5].Gain;
            set
            {
                if (Bands[5].Gain != value)
                {
                    Bands[5].Gain = value;
                }
                OnPropertyChanged(nameof(Band6));
            }
        }

        public float Band7
        {
            get => Bands[6].Gain;
            set
            {
                if (Bands[6].Gain != value)
                {
                    Bands[6].Gain = value;
                }
                OnPropertyChanged(nameof(Band7));
            }
        }

        public float Band8
        {
            get => Bands[7].Gain;
            set
            {
                if (Bands[7].Gain != value)
                {
                    Bands[7].Gain = value;
                }
                OnPropertyChanged(nameof(Band8));
            }
        }

        public float Band9
        {
            get => Bands[8].Gain;
            set
            {
                if (Bands[8].Gain != value)
                {
                    Bands[8].Gain = value;
                }
                OnPropertyChanged(nameof(Band9));
            }
        }
        #endregion
    }
}

