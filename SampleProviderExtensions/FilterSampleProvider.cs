using NAudio.Dsp;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Runtime.CompilerServices;

namespace iRANE_62.SampleProviderExtensions
{
    public class FilterSampleProvider :ISampleProvider
    {
        private readonly ISampleProvider source;
        private readonly BiQuadFilter lowPassFilter;
        private readonly BiQuadFilter highPassFilter;
        private float filterValue = 0.0f;

        public FilterSampleProvider(ISampleProvider source, int sampleRate)
        {
            this.source = source ?? throw new ArgumentNullException(nameof(source));
            if (source.WaveFormat.Channels != 2)
            {
                throw new ArgumentException("Źródło musi być stereo (2 kanały)");
            }

            lowPassFilter = BiQuadFilter.LowPassFilter(sampleRate, 20000, 1.0f);
            highPassFilter = BiQuadFilter.HighPassFilter(sampleRate, 20, 1.0f);
        }

        public float FilterValue
        {
            get => filterValue;
            set
            {
                filterValue = Math.Clamp(value, -1.0f, 1.0f);
                UpdateFilters();
            }
        }

        public WaveFormat WaveFormat => source.WaveFormat;

        private void UpdateFilters()
        {
            int sampleRate = source.WaveFormat.SampleRate;

            if (filterValue < 0)
            {
                float minFreq = 200f;
                float maxFreq = 20000f;
                float cutoff = (float)(minFreq * Math.Pow(maxFreq / minFreq, (1 + filterValue)));
                lowPassFilter.SetLowPassFilter(sampleRate, cutoff, 1.0f);
            }
            else
            {
                float minFreq = 20f;
                float maxFreq = 5000f;
                float cutoff = (float)(minFreq * Math.Pow(maxFreq / minFreq, filterValue));
                highPassFilter.SetHighPassFilter(sampleRate, cutoff, 1.0f);
            }


        }

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = source.Read(buffer, offset, count);


            for (int i = 0; i < samplesRead; i += 2)
            {
                float left = buffer[offset + i];
                float right = buffer[offset + i + 1];

                if (filterValue < 0)
                {
                    left = lowPassFilter.Transform(left);
                    right = lowPassFilter.Transform(right);
                }
                else if (filterValue > 0)
                {
                    left = highPassFilter.Transform(left);
                    right = highPassFilter.Transform(right);
                }

                buffer[offset + i] = left;
                buffer[offset + i + 1] = right;
            }


            return samplesRead;
        }
    }
}