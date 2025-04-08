using iRANE_62.Controls;
using NAudio.Gui;

namespace iRANE_62.Handlers
{
    public class ChannelVolumeHandler
    {
        private readonly AudioSourceHandler audioSource;
        private readonly VerticalVolumeSlider upfader;
        private readonly Pot mainVolumePot;
        private readonly Pot gainPot;

        private readonly float micOverFactor = 0.1f;
        private float crossfaderBalance;
        private float originalVolume;
        private bool isMicOverActive;
        private float systemVolume;
        private float faderVolume;
        private float gain;

        public ChannelVolumeHandler(
            AudioSourceHandler audioSource,
            Pot gainPot,
            VerticalVolumeSlider fader,
            Pot mainVolumePot)
        {
            this.audioSource = audioSource;
            this.gainPot = gainPot;
            this.upfader = fader;
            this.mainVolumePot = mainVolumePot;

            SetupControls();
            UpdateVolume();
        }

        private void InitializeVolume()
        {
            gain = (float)gainPot.Value;
            faderVolume = upfader.Volume;
            crossfaderBalance = 0.5f;
            systemVolume = (float)mainVolumePot.Value;
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
                        audioSource?.UpdateVolume(originalVolume*micOverFactor);
                    }
                    else
                    {
                        audioSource?.UpdateVolume(originalVolume);
                    }
                }
            }
        }

        private float CalculateEffectiveVolume()
        {
            return gain * faderVolume * systemVolume * crossfaderBalance;
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

        public void UpdateVolume()
        {
            if (audioSource?.AudioFileReader != null)
            {
                float effectiveVolume = gain * faderVolume * systemVolume * crossfaderBalance;
                if(isMicOverActive) effectiveVolume*=micOverFactor;
                audioSource.UpdateVolume(effectiveVolume);
                if (!isMicOverActive) originalVolume = effectiveVolume;
            }
        }

        private void SetupControls()
        {
            gainPot.ValueChanged += (s, e) =>
            {
                gain = (float)gainPot.Value;
                UpdateVolume();
            };
            upfader.VolumeChanged += (s, e) =>
            {
                faderVolume = upfader.Volume;
                UpdateVolume();
            };
            mainVolumePot.ValueChanged += (s, e) =>
            {
                systemVolume = (float)mainVolumePot.Value;
                UpdateVolume();
            };

            InitializeVolume();
        }


      
    }
}