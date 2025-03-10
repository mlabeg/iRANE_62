﻿using iRANE_62.Extensions;
using iRANE_62.Models;
using NAudio.Dsp;
using NAudio.Extras;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Handlers
{
    public class AudioSourceHandler
    {
        public int Id { get; set; }
        public AudioFileReader AudioFileReader { get; private set; }
        public string FileName { get; private set; }
        public Song? Song { get; set; }
        public Eq Equalizer { get; set; }
        public Loop Loop { get; set; }

        public int CurrentPlaybackPosition { get; set; }

        public Action<float> SetVolumeDelegate;

        private float leftChanelVolumeLevel;
        private float rightChanelVolumeLevel;

        private ISampleProvider outputProvider;
        private bool isPlaying;

        private EventHandler<StreamVolumeEventArgs> volumeMeteredHandlers;


        public AudioSourceHandler(int id)
        {
            Id = id;
            Equalizer = new Eq();
            Loop = new Loop();
            CurrentPlaybackPosition = 0;
        }

        public bool IsPlaying => isPlaying;
        public float LeftChanelVolumeLevel => leftChanelVolumeLevel;
        public float RightChanelVolumeLevel => rightChanelVolumeLevel;


        public event EventHandler<StreamVolumeEventArgs> VolumeMetered
        {
            add
            {
                volumeMeteredHandlers += value;
                if (outputProvider != null)
                {
                    ((MeteringSampleProvider)outputProvider).StreamVolume += value;
                }
            }
            remove
            {
                volumeMeteredHandlers -= value;
                if (outputProvider != null)
                {
                    ((MeteringSampleProvider)outputProvider).StreamVolume -= value;
                }
            }
        }

        public ISampleProvider OutputProvider => outputProvider;

        public void LoadFile(string fileName)
        {
            FileName = fileName;
            AudioFileReader = new AudioFileReader(fileName);
            Song = new Song(fileName);
            SetupAudioChain();
        }

        public void Play(AudioOutputHandler outputManager)
        {
            if (AudioFileReader == null) throw new InvalidOperationException("Brak wybranego pliku do odtworzenia.");
            if (!isPlaying)
            {
                outputManager.AddSource(this, outputProvider);
                isPlaying = true;
            }
        }

        public void Pause(AudioOutputHandler outputManager)
        {
            if (isPlaying)
            {
                outputManager.RemoveSource(this);
                isPlaying = false;
                leftChanelVolumeLevel = 0f;
                rightChanelVolumeLevel = 0f;
            }
        }

        public void Stop(AudioOutputHandler outputManager)
        {
            if (AudioFileReader != null)
            {
                outputManager.RemoveSource(this);
                AudioFileReader.Position = 0;
                isPlaying = false;
                leftChanelVolumeLevel = 0f;
                rightChanelVolumeLevel = 0f;
            }
        }

        public void SetVolume(float volume)
        {
            SetVolumeDelegate?.Invoke(volume);
        }

        private void SetupAudioChain()
        {
            var sampleChannel = new SampleChannel(AudioFileReader, true);
            SetVolumeDelegate = vol => sampleChannel.Volume = vol;

            Equalizer.FilterSampleProvider = new FilterSampleProvider(sampleChannel, AudioFileReader.WaveFormat.SampleRate);
            Equalizer.PanningProvider = new StereoPanningSampleProvider(Equalizer.FilterSampleProvider);
            Equalizer.equalizer = new Equalizer(Equalizer.PanningProvider, Equalizer.Bands);

            outputProvider = new MeteringSampleProvider(Equalizer.equalizer);

            if (volumeMeteredHandlers != null)
            {
                ((MeteringSampleProvider)outputProvider).StreamVolume += volumeMeteredHandlers;
            }
            ((MeteringSampleProvider)outputProvider).StreamVolume += (s, e) =>
            {
                leftChanelVolumeLevel = e.MaxSampleValues[0];
                rightChanelVolumeLevel = e.MaxSampleValues[1];
            };
        }

        public void Dispose()
        {
            if (outputProvider != null)
            {
                ((MeteringSampleProvider)outputProvider).StreamVolume -= volumeMeteredHandlers;
            }
            AudioFileReader?.Dispose();
            AudioFileReader = null;
        }
    }
}