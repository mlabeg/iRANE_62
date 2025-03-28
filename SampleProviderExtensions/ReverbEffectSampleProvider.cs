using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.SampleProviderExtensions
{
    public class ReverbEffectSampleProvider : IEffectSampleProvider
    {
        private readonly ISampleProvider source;
        private readonly int delayBufferLength;
        private readonly float[] delayBuffer;
        private int delayBufferPosition;
        private readonly float decayFactor;
        private readonly float roomSize;
        private readonly float dampening;
        private float effectStrength;

        private bool enabled;
        private int enabledFactor;

        public ReverbEffectSampleProvider(ISampleProvider source)
        {
            this.source = source;
           

            delayBufferLength = (int)(0.15f * source.WaveFormat.SampleRate);
            decayFactor = CalculateDecayFactor(0.15f);
            roomSize = 7f;
            dampening = 0.9f;

            delayBufferPosition = 0;
            delayBuffer = new float[delayBufferLength];
            
            effectStrength = 0;
            enabled = false;
            enabledFactor = 0;
        }

        public ReverbEffectSampleProvider(ISampleProvider source, float decayTimeInSeconds, float roomSize, float dampening, float effectStrength)
        {
            this.source = source;
            delayBufferLength = (int)(decayTimeInSeconds * source.WaveFormat.SampleRate);
            delayBuffer = new float[delayBufferLength];
            delayBufferPosition = 0;
            decayFactor = CalculateDecayFactor(decayTimeInSeconds);
            this.roomSize = roomSize;
            this.dampening = dampening;
            this.effectStrength = effectStrength;

            enabled = false;
            enabledFactor = 0;
        }

        public WaveFormat WaveFormat => source.WaveFormat;

        public bool Enabled
        {
            get => enabled;
            set
            {
                enabled = value;
                enabledFactor = value ? 1 : 0;
            }
        }

        public float EffectGain
        {
            get => effectStrength;
            set => effectStrength = value;
        }

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = source.Read(buffer, offset, count);

            for (int i = 0; i < samplesRead; i++)
            {
                float inputSample = buffer[offset + i];

                float delayedSample = delayBuffer[delayBufferPosition];
                float reverbSample = roomSize * decayFactor * delayedSample * enabledFactor;

                reverbSample *= 1.0f - dampening;

                buffer[offset + i] += effectStrength * reverbSample;

                delayBuffer[delayBufferPosition] = inputSample + effectStrength * reverbSample;

                delayBufferPosition++;
                if (delayBufferPosition >= delayBufferLength)
                {
                    delayBufferPosition = 0;
                }
            }

            return samplesRead;
        }

        private float CalculateDecayFactor(float decayTimeInSeconds)
        {
            return (float)Math.Pow(10, -3.0 / (decayTimeInSeconds * source.WaveFormat.SampleRate));
        }

        public void EffectUpdate(float effectGain, bool effectEnabled)
        {
            Enabled = effectEnabled;
            EffectGain = effectGain;
        }
    }
}
