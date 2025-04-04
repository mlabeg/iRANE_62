﻿using iRANE_62.Models;
using iRANE_62.SampleProviderExtensions;
using NAudio.Extras;
using System.ComponentModel;

namespace iRANE_62.Handlers
{
    public class EqSectionHandler
    {
        public Equalizer Equalizer;
        public EqualizerBand[] Bands { get; }
        public StereoPanningSampleProvider PanningProvider { get; set; }
        public FilterSampleProvider FilterSampleProvider { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public EqSectionHandler()
        {
            Bands = CreateBands();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        public void UpdateEqSection(EqSectionHolder holder)
        {
            Band1 = holder.Low;
            Band2 = holder.Low;
            Band3 = holder.Low;
            Band4 = holder.Mid;
            Band5 = holder.Mid;
            Band6 = holder.Mid;
            Band7 = holder.High;
            Band8 = holder.High;
            Band9 = holder.High;
            Equalizer.Update();

            PanningProvider.Pan = holder.Pan;
            FilterSampleProvider.FilterValue = holder.HighLowPassFilter;
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
