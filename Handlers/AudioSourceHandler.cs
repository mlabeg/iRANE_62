﻿using iRANE_62.Controls;
using iRANE_62.Models;
using iRANE_62.SampleProviderExtensions;
using NAudio.Extras;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace iRANE_62.Handlers
{
    public class AudioSourceHandler
    {
        private bool isPlaying;
        private float leftChanelVolumeLevel;
        private float rightChanelVolumeLevel;
        private ISampleProvider outputProvider;
        private ChannelVolumeHandler channelVolumeHandler;
        private readonly AudioOutputHandler audioOutputHandler;

        private EventHandler<StreamVolumeEventArgs> volumeMeteredHandlers;

        public int Id { get; set; }
        public AudioFileReader AudioFileReader { get; private set; }
        public string FileName { get; private set; }
        public Song? Song { get; set; }
        public EqSectionHandler EqSectionHandler { get; set; }
        public Loop Loop { get; set; }
        public int CurrentPlaybackPosition { get; set; } = 0;
        public EffectsHandler EffectsHandler { get; private set; }

        public Action<float> VolumeUpdateDelegate;
        public Action<float, bool> EffectUpdateDelegate;
        public Action<EqSectionHolder> EqualizerUpdateDelegate;

        public AudioSourceHandler(int id, AudioOutputHandler audioOutputHandler)
        {
            Id = id;
            Loop = new Loop();
            Loop.LoopOutChanged += OnLoopOutChanged;
            EqSectionHandler = new EqSectionHandler();
            this.audioOutputHandler = audioOutputHandler;
        }

        public bool IsPlaying => isPlaying;
        public float LeftChanelVolumeLevel => leftChanelVolumeLevel;
        public float RightChanelVolumeLevel => rightChanelVolumeLevel;
        public ChannelVolumeHandler ChannelVolumeHandler => channelVolumeHandler;

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

        public void LoadFile(string fileName)
        {
            FileName = fileName;
            Song = new Song(FileName);
            Load();
        }

        private void Load()
        {
            RemovePlayback();
            AudioFileReader = new AudioFileReader(FileName);
            SetupAudioChain();
        }

        public void Play()
        {
            if (AudioFileReader == null) throw new InvalidOperationException("Brak wybranego pliku do odtworzenia.");
            if (!isPlaying)
            {
                audioOutputHandler.AddSource(this, outputProvider);
                isPlaying = true;
            }
        }

        public void Pause()
        {
            if (isPlaying)
            {
                audioOutputHandler.RemoveSource(this);
                isPlaying = false;
            }
        }

        public void Stop()
        {
            Load();
        }

        private void RemovePlayback()
        {
            audioOutputHandler.RemoveSource(this);
            isPlaying = false;
            AudioFileReader?.Dispose();
        }

        public void UpdateChannelVolumeHandler(Pot gainPot, VerticalVolumeSlider fader, Pot mainVolumePot)
        {
            channelVolumeHandler = new ChannelVolumeHandler(this, gainPot, fader, mainVolumePot);
        }

        public void UpdateVolume(float volume)
        {
            VolumeUpdateDelegate?.Invoke(volume);
        }

        public void UpdateEffect(float gain, bool enabled)
        {
            EffectUpdateDelegate?.Invoke(gain, enabled);
        }

        public void UpdateEqualizer(EqSectionHolder eqSectionHolder)
        {
            EqualizerUpdateDelegate?.Invoke(eqSectionHolder);
        }

        private void SetupAudioChain()
        {
            if (AudioFileReader == null) return;

            var resampler = ResampleSource();

            var sampleChannel = new SampleChannel(resampler, true);
            VolumeUpdateDelegate = vol => sampleChannel.Volume = vol;

            EqSectionHandler = new EqSectionHandler(sampleChannel, AudioFileReader.WaveFormat.SampleRate);
            EqualizerUpdateDelegate = EqSectionHandler.UpdateEqSection;

            EffectsHandler = new EffectsHandler(EqSectionHandler.GetOutputProvider());

            outputProvider = new MeteringSampleProvider(EffectsHandler.GetOutputProvider());

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

        private MediaFoundationResampler ResampleSource()
        {
            var targetWaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(44100, 2);
            var resampler = new MediaFoundationResampler(AudioFileReader, targetWaveFormat)
            {
                ResamplerQuality = 60
            };

            return resampler;
        }

        public void LoopLogic()
        {
            if (Loop.LoopActive && Loop.LoopOut != TimeSpan.Zero && Loop.LoopIn != TimeSpan.Zero)
            {
                if (AudioFileReader.CurrentTime >= Loop.LoopOut)
                {
                    AudioFileReader.CurrentTime = Loop.LoopIn;
                }
            }
        }

        public void OnLoopOutChanged(object sender, EventArgs e)
        {
            if (Loop.LoopIn != TimeSpan.Zero)
            {
                AudioFileReader.CurrentTime = Loop.LoopIn;
            }
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