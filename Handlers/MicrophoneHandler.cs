using iRANE_62.Models;
using NAudio.Extras;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace iRANE_62.Handlers
{
    public class MicrophoneHandler : IDisposable
    {
        private WaveInEvent microphoneInput;
        private BufferedWaveProvider micBuffer;
        private VolumeSampleProvider volumeProvider;
        private MeteringSampleProvider meteringProvider;
        private EqualizerWithBands equalizer;

        private readonly AudioOutputHandler audioOutputHandler;

        private bool isActive;
        private bool isMicOverActive;

        private float micLeftLevel;
        private float micRightLevel;
        private float volume = 0.5f;

        public EffectsHandler EffectsHandler;

        public event EventHandler<StreamVolumeEventArgs> VolumeIndicator;
        public event Action<bool> IsActiveChanged;

        public MicrophoneHandler(AudioOutputHandler outputHandler)
        {
            audioOutputHandler = outputHandler;
        }

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

        public bool IsActive
        {
            get => isActive;
            set
            {
                if (value != isActive)
                {
                    if (value)
                    {

                        EnableMicrophone();
                        audioOutputHandler.AddSource(this, meteringProvider);
                    }
                    else
                    {
                        DisableMicrophone();
                        audioOutputHandler?.RemoveSource(this);
                        UpdateMicLevels(0, 0);
                    }

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
        }

        public float MicRightLevel
        {
            get => micRightLevel;
        }

        public EqualizerWithBands Equalizer => equalizer;


        public MeteringSampleProvider GetMeteringSampleProvider()
        {
            return meteringProvider;
        }

        private void EnableMicrophone()
        {
            if (microphoneInput != null)
            {
                return;
            }

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

            equalizer = new EqualizerWithBands();
            equalizer.Equalizer = new Equalizer(volumeProvider, equalizer.Bands);

            EffectsHandler = new EffectsHandler(equalizer.Equalizer);

            meteringProvider = new MeteringSampleProvider(EffectsHandler.GetOutputProvider());
            meteringProvider.StreamVolume += (s, e) => VolumeIndicator?.Invoke(this, e);

            microphoneInput.DataAvailable += MicrophoneDataAvailable;
            microphoneInput.StartRecording();
        }

        private void DisableMicrophone()
        {
            if (microphoneInput == null)
            {
                return;
            }

            microphoneInput.StopRecording();
            microphoneInput.Dispose();
            microphoneInput = null;
            micBuffer = null;
            meteringProvider = null;
        }

        private void MicrophoneDataAvailable(object sender, WaveInEventArgs e)
        {
            micBuffer?.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public void UpdateMicLevels(float leftChannelLevel, float rightChannelLevel)
        {
            micLeftLevel = leftChannelLevel;
            micRightLevel = rightChannelLevel;
        }

        public void Dispose()
        {
            if (isActive)
            {
                DisableMicrophone();
            }
        }
    }
}