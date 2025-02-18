using NAudio.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class Eq
    {
        public Equalizer equalizer;
        public EqualizerBand[] bands { get; }

        public Eq()
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
        }

        public float Band1
        {
            get => bands[0].Gain;
            set
            {
                if (bands[0].Gain != value)
                {
                    bands[0].Gain = value;
                    //equalizer?.Update();
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
                    //equalizer?.Update();
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
                    //equalizer?.Update();
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
                }
            }
        }
    }
}
