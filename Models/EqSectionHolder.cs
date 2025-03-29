using NAudio.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class EqSectionHolder
    {
        private Pot high;
        private Pot mid;
        private Pot low;
        private PanSlider pan;
        private Pot highLowPassFilter;

        public float High => (float)high.Value;
        public float Mid => (float)mid.Value;
        public float Low => (float)low.Value;
        public float Pan => pan.Pan;
        public float HighLowPassFilter => (float)highLowPassFilter.Value;

        public EqSectionHolder(Pot high, Pot mid, Pot low, PanSlider pan, Pot highLowPassFilter)
        {
            this.high = high;
            this.mid = mid;
            this.low = low;
            this.pan = pan;
            this.highLowPassFilter = highLowPassFilter;
        }
    }
}
