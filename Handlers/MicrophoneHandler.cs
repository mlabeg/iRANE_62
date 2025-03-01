using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;

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
        private bool isActive;

        private float micLeftLevel;
        private float micRightLevel;

        public event EventHandler<StreamVolumeEventArgs> VolumeIndicator;
        public event Action<bool> IsActiveChanged;

        public MicrophoneHandler()
        {
            InitializeAudio();
        }

        private void InitializeAudio()
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

        public MeteringSampleProvider GetMeteringSampleProvider()
        {
            return meteringProvider;
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

        private void ToggleMicrophone(bool enable)
        {
            if (enable)
            {
                if (microphoneInput == null)
                {
                    microphoneInput = new WaveInEvent
                    {
                        WaveFormat = new WaveFormat(44100, 2),
                        BufferMilliseconds = 10
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

                    meteringProvider = new MeteringSampleProvider(volumeProvider);
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