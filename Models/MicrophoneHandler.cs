using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;

namespace iRANE_62.Models
{
    public class MicrophoneHandler : IDisposable
    {
        private WaveInEvent microphoneInput;
        private BufferedWaveProvider micBuffer;
        private WaveOutEvent micOutput;
        private MixingSampleProvider mixerProvider;
        private MeteringSampleProvider meteringProvider;
        private bool isActive;

        public event EventHandler<StreamVolumeEventArgs> VolumeIndicator;

        public MicrophoneHandler()
        {
            InitializeAudio();
        }

        private void InitializeAudio()
        {
            Volume = 0.5f;

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
                }
            }
        }

        public float Volume { get; set; } 

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
                    var volumeProvider = new VolumeSampleProvider(sampleProvider.ToSampleProvider())
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