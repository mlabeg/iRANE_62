using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.SampleProviderExtensions.EffectsSampleExtensions
{
    public interface IEffectSampleProvider : ISampleProvider
    {
        void EffectUpdate(float effectGain, bool effectEnabled);

        bool Enabled { get; set; }
        float EffectGain { get; set; }
    }
}

