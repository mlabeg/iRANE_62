using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Extensions
{
    public class StereoPanningSampleProvider : ISampleProvider
    {
        private readonly ISampleProvider source;
        private float pan = 0.0f;

        public StereoPanningSampleProvider(ISampleProvider source)
        {
            if (source.WaveFormat.Channels != 2)
            {
                throw new ArgumentException("Źródło musi być stereo (2 kanały)");
            }

            this.source = source;
        }

        public float Pan
        {
            get => pan;
            set
            {
                pan = Math.Clamp(value, -1.0f, 1.0f);
            }
        }

        public WaveFormat WaveFormat => source.WaveFormat;

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = source.Read(buffer, offset, count);

            for (int i = 0; i < samplesRead; i += 2)
            {
                float left = buffer[offset + i];
                float right = buffer[offset + i + 1];

                float leftVolume = (1.0f - pan) / 2.0f;
                float rightVolume = (1.0f + pan) / 2.0f;

                buffer[offset + i] = left * leftVolume;
                buffer[offset + i + 1] = right * rightVolume;
            }

            return samplesRead;
        }
    }
}
