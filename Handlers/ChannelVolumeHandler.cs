// ChannelVolumeController.cs
using iRANE_62.Controls;
using NAudio.Gui;

namespace iRANE_62.Handlers
{
    public class ChannelVolumeHandler
    {
        private readonly AudioSourceHandler audioSource;
        private readonly Pot gainPot;
        private readonly VerticalVolumeSlider fader;
        private readonly Pot mainVolumePot;

        private float gain;
        private float faderVolume;
        private float mainVolume;
        private float crossfaderBalance;
        private float originalVolume;
        private bool isMicOverActive;

        public ChannelVolumeHandler(
            AudioSourceHandler audioSource,
            Pot gainPot,
            VerticalVolumeSlider fader,
            Pot mainVolumePot)
        {
            this.audioSource = audioSource;
            this.gainPot = gainPot;
            this.fader = fader;
            this.mainVolumePot = mainVolumePot;

            SetupControls();
            UpdateVolume();
        }

        public float OriginalVolume => originalVolume;

        public bool IsMicOverActive
        {
            get => isMicOverActive;
            set
            {
                if (isMicOverActive != value)
                {
                    isMicOverActive = value;
                    if (isMicOverActive)
                    {
                        originalVolume = CalculateEffectiveVolume();
                        audioSource?.SetVolume(0.1f);
                    }
                    else
                    {
                        audioSource?.SetVolume(originalVolume);
                    }
                }
            }
        }

        public void SetCrossfadeBalance(float balance)
        {
            if (audioSource.Id == 1)
            {
                crossfaderBalance = balance <= 0.5f ? 0.75f : 0.75f * (2 - 2 * balance);
            }
            else
            {
                crossfaderBalance = balance <= 0.5f ? 1.5f * balance : 0.75f;
            }
            UpdateVolume();
        }

        private void SetupControls()
        {
            gainPot.ValueChanged += (s, e) =>
            {
                gain = (float)gainPot.Value;
                UpdateVolume();
            };
            fader.VolumeChanged += (s, e) =>
            {
                faderVolume = fader.Volume;
                UpdateVolume();
            };
            mainVolumePot.ValueChanged += (s, e) =>
            {
                mainVolume = (float)mainVolumePot.Value;
                UpdateVolume();
            };

            gainPot.Value = 0.5f;
            fader.Volume = 0.5f;
            crossfaderBalance = 0.5f;
        }

        private void UpdateVolume()
        {
            if (audioSource?.AudioFileReader != null)
            {
                float effectiveVolume = isMicOverActive ? 0.1f : gain * faderVolume * mainVolume * crossfaderBalance;
                audioSource.SetVolume(effectiveVolume);
                if (!isMicOverActive) originalVolume = effectiveVolume;
            }
        }

        private float CalculateEffectiveVolume()
        {
            return gain * faderVolume * mainVolume * crossfaderBalance;
        }
    }
}