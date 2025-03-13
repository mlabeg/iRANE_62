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

        public EchoEffectSampleProvider(ISampleProvider source, int echoDelayInMilliseconds, float echoGain, float delay)
        {
            this.source = source;
            this.echoDelayInSamples = (int)(source.WaveFormat.SampleRate * echoDelayInMilliseconds / 1000.0);
            this.echoGain = echoGain;
            this.delay = delay;
            this.delayBuffer = new float[echoDelayInSamples];
        }

        public int EchoInSamples
        {
            get => this.echoDelayInSamples;
            set=> this.echoDelayInSamples=value;
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

                // Apply echo effect with decay
                float echoSample = delayBuffer[position];
                delayBuffer[position] = inputSample + echoSample * echoGain;
                buffer[offset + i] += echoSample;

                // Apply decay to echoed sample
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

