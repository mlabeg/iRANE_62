using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.SampleProviderExtensions
{
    internal class EchoEffectSampleProvider : IEffectSampleProvider
    {
        private readonly ISampleProvider source;
        private int echoDelayInSamples;
        private float echoGain;
        private float delay;
        private float[] delayBuffer;
        private int position;

        private bool enabled;
        private int enabledFactor;

        public bool Enabled
        {
            get => enabled;
            set
            {
                enabled = value;
                enabledFactor = value ? 1 : 0;
            }
        }

        public float EchoGain
        {
            get => echoGain;
            set => echoGain = value;
        }

        public EchoEffectSampleProvider(ISampleProvider source)
        {
            this.source = source;
            int echoDelayInMilliseconds = 825;
            echoDelayInSamples = (int)(source.WaveFormat.SampleRate * echoDelayInMilliseconds / 1000.0);
            echoGain = 0.25f;
            delay = 1;
            enabledFactor = 0;
            this.delayBuffer = new float[echoDelayInSamples];
        }

        public EchoEffectSampleProvider(ISampleProvider source, int echoDelayInMilliseconds, float echoGain, float delay)
        {
            this.source = source;
            this.echoDelayInSamples = (int)(source.WaveFormat.SampleRate * echoDelayInMilliseconds / 1000.0);
            this.echoGain = echoGain;
            this.delay = delay;
            this.delayBuffer = new float[echoDelayInSamples];
        }

        public void EffectUpdate(float effectGain, bool effectEnabled)
        {
            Enabled = effectEnabled;
            EchoGain = (float)effectGain;
        }

        public int EchoInSamples
        {
            get => echoDelayInSamples;
            set => echoDelayInSamples = value;
        }

        public void EchoDelayInBpm(int bpm)
        {
            //TODO do implementacji
        }

        public WaveFormat WaveFormat => source.WaveFormat;

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = source.Read(buffer, offset, count);

            for (int i = 0; i < samplesRead; i++)
            {
                float inputSample = buffer[offset + i];

                float echoSample = delayBuffer[position];
                delayBuffer[position] = inputSample + echoSample * echoGain * enabledFactor;
                buffer[offset + i] = echoSample;

                delayBuffer[position] *= delay;


                position++;
                if (position >= echoDelayInSamples)
                {
                    position = 0;
                }
            }

            return samplesRead;
        }
    }
}

