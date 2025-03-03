using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;

namespace iRANE_62.Handlers
{
    public class HeadphonesOutputHandler : IDisposable
    {
        private readonly WaveOutEvent headphonesOutput;
        private readonly MixingSampleProvider headphonesSampleProvider;
        private readonly Dictionary<object, VolumeSampleProvider> activeSources;

        public HeadphonesOutputHandler()
        {
            try
            {
                headphonesSampleProvider = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(44100, 2))
                {
                    ReadFully = true
                };
                activeSources = new Dictionary<object, VolumeSampleProvider>();
                headphonesOutput = new WaveOutEvent();
                headphonesOutput.Init(headphonesSampleProvider);
                headphonesOutput.Play();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to initialize headphones output.", ex);
            }
        }

        public void AddSource(object key, ISampleProvider source, float initialVolume = 0.5f)
        {
            lock (activeSources)
            {
                if (!activeSources.ContainsKey(key))
                {
                    var volumeProvider = new VolumeSampleProvider(source) { Volume = initialVolume };
                    activeSources[key] = volumeProvider;
                    headphonesSampleProvider.AddMixerInput(volumeProvider);
                }
            }
        }

        public void RemoveSource(object key)
        {
            lock (activeSources)
            {
                if (activeSources.TryGetValue(key, out var volumeProvider))
                {
                    headphonesSampleProvider.RemoveMixerInput(volumeProvider);
                    activeSources.Remove(key);
                }
            }
        }

        public void SetVolume(object key, float volume)
        {
            lock (activeSources)
            {
                if (activeSources.TryGetValue(key, out var volumeProvider))
                {
                    volumeProvider.Volume = volume;
                }
            }
        }

        public void Dispose()
        {
            headphonesOutput?.Stop();
            headphonesOutput?.Dispose();
            activeSources.Clear();
        }
    }
}