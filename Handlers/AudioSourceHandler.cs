using iRANE_62.Controls;
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

        private EventHandler<StreamVolumeEventArgs> volumeMeteredHandlers;

        public int Id { get; set; }
        public AudioFileReader AudioFileReader { get; private set; }
        public string FileName { get; private set; }
        public Song? Song { get; set; }
        public EqSectionHandler Equalizer { get; set; }
        public Loop Loop { get; set; }
        public int CurrentPlaybackPosition { get; set; } = 0;
        public EffectsHandler EffectsHandler { get; private set; }

        public Action<float> VolumeUpdateDelegate;
        public Action<float, bool> EffectUpdateDelegate;
        public Action<EqSectionHolder> EqualizerUpdateDelegate;

        public AudioSourceHandler(int id)
        {
            Id = id;
            Loop = new Loop();
            Equalizer = new EqSectionHandler();
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
            outputManager.RemoveSource(this);
            AudioFileReader.Position = 0;
            isPlaying = false;
            leftChanelVolumeLevel = 0f;
            rightChanelVolumeLevel = 0f;
            AudioFileReader.Dispose();
            LoadFile(FileName);
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
            
            Equalizer.FilterSampleProvider = new FilterSampleProvider(sampleChannel, AudioFileReader.WaveFormat.SampleRate);
            Equalizer.PanningProvider = new StereoPanningSampleProvider(Equalizer.FilterSampleProvider);
            Equalizer.Equalizer = new Equalizer(Equalizer.PanningProvider, Equalizer.Bands);
            EqualizerUpdateDelegate = Equalizer.UpdateEqSection;

            EffectsHandler = new EffectsHandler(Equalizer.Equalizer);

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