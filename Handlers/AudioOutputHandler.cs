using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;

namespace iRANE_62.Handlers
{
    public class AudioOutputHandler : IDisposable
    {
        private readonly WaveOutEvent mainOutput;
        private readonly MixingSampleProvider mainMixer;
        private readonly Dictionary<object, ISampleProvider> activeSources;

        public AudioOutputHandler()
        {
            try
            {
                mainMixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(44100, 2))
                {
                    ReadFully = true
                };
                activeSources = new Dictionary<object, ISampleProvider>();
                mainOutput = new WaveOutEvent();
                mainOutput.Init(mainMixer);
                mainOutput.Play();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Błąd inicjalizacji źródła audio.", ex);
            }
        }

        public void AddSource(object key, ISampleProvider source)
        {
            lock (activeSources)
            {
                if (!activeSources.ContainsKey(key))
                {
                    activeSources[key] = source;
                    mainMixer.AddMixerInput(source);
                }
            }
        }

        public void RemoveSource(object key)
        {
            lock (activeSources)
            {
                if (activeSources.TryGetValue(key, out var source))
                {
                    mainMixer.RemoveMixerInput(source);
                    activeSources.Remove(key);
                }
            }
        }

        public void Dispose()
        {
            mainOutput?.Stop();
            mainOutput?.Dispose();
            activeSources.Clear();
        }
    }
}