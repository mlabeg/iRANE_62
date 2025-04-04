﻿using NAudio.Extras;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Xml.Linq;

namespace iRANE_62.Handlers
{
    public class MicrophoneHandler : IDisposable
    {
        private WaveInEvent microphoneInput;
        private BufferedWaveProvider micBuffer;
        private WaveOutEvent micOutput;
        private MixingSampleProvider mixerProvider;
        private MeteringSampleProvider meteringProvider;
        private VolumeSampleProvider volumeProvider;
        private EqSectionHandler equalizer;

        private bool isActive;
        private bool isMicOverActive;

        private float micLeftLevel;
        private float micRightLevel;
        
        public EffectsHandler EffectsHandler;

        public event EventHandler<StreamVolumeEventArgs> VolumeIndicator;
        public event Action<bool> IsActiveChanged;

        public MicrophoneHandler()
        {
            Initialize();
        }

        private void Initialize()
        {
            mixerProvider = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(44100, 2))
            {
                ReadFully = true
            };

            micOutput = new WaveOutEvent();
            micOutput.Init(mixerProvider);
            micOutput.Play();
        }

        public bool IsActive
        {
            get => isActive;
            set
            {
                if (value != isActive)
                {
                    ToggleMicrophone(value);
                    isActive = value;
                    IsActiveChanged?.Invoke(isActive);
                }
            }
        }
        public bool IsMicOverActive
        {
            get => isMicOverActive;
            set => isMicOverActive = value;
        }


        public float MicLeftLevel
        {
            get => micLeftLevel;
            set => micLeftLevel = value;
        }

        public float MicRightLevel
        {
            get => micRightLevel;
            set => micRightLevel = value;
        }


        private float volume { get; set; } = 0.5f;

        public float Volume
        {
            get => volume;
            set
            {
                volume = value;
                if (volumeProvider != null)
                {
                    volumeProvider.Volume = volume;
                }
            }
        }

        public EqSectionHandler Equalizer => equalizer;

        public MeteringSampleProvider GetMeteringSampleProvider()
        {
            return meteringProvider;
        }

        private void ToggleMicrophone(bool enable)
        {
            if (enable)
            {
                if (microphoneInput == null)
                {
                    microphoneInput = new WaveInEvent
                    {
                        WaveFormat = new WaveFormat(44100, 2),
                        BufferMilliseconds = 20
                    };

                    micBuffer = new BufferedWaveProvider(microphoneInput.WaveFormat)
                    {
                        DiscardOnBufferOverflow = true
                    };

                    var sampleProvider = new WaveInProvider(microphoneInput);
                    volumeProvider = new VolumeSampleProvider(sampleProvider.ToSampleProvider())
                    {
                        Volume = Volume
                    };

                    equalizer = new EqSectionHandler();
                    equalizer.Equalizer = new Equalizer(volumeProvider, equalizer.Bands);

                    EffectsHandler = new EffectsHandler(equalizer.Equalizer);

                    meteringProvider = new MeteringSampleProvider(EffectsHandler.GetOutputProvider());
                    meteringProvider.StreamVolume += (s, e) => VolumeIndicator?.Invoke(this, e);

                    mixerProvider.AddMixerInput(meteringProvider);
                    microphoneInput.DataAvailable += MicrophoneDataAvailable;
                    microphoneInput.StartRecording();
                }
            }
            else
            {
                if (microphoneInput != null)
                {
                    microphoneInput.StopRecording();
                    microphoneInput.Dispose();
                    microphoneInput = null;
                    micBuffer = null;
                    meteringProvider = null;
                    mixerProvider.RemoveAllMixerInputs();
                }
            }
        }

        private void MicrophoneDataAvailable(object sender, WaveInEventArgs e)
        {
            micBuffer?.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public void Dispose()
        {
            if (isActive)
            {
                ToggleMicrophone(false);
            }
            micOutput?.Stop();
            micOutput?.Dispose();
        }
    }
}