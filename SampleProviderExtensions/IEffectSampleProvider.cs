using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.SampleProviderExtensions
{
    public interface IEffectSampleProvider : ISampleProvider
    {
        void EffectUpdate(float effectGain, bool effectEnabled);
    }
}
