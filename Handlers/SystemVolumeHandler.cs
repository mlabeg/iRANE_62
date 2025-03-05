// SystemVolumeController.cs
using NAudio.CoreAudioApi;
using System;

namespace iRANE_62.Handlers
{
    public class SystemVolumeHandler : IDisposable
    {
        private readonly MMDeviceEnumerator deviceEnumerator;
        private readonly MMDevice defaultDevice;
        private readonly MMDevice headphones;
        private readonly MMDevice speakers;
        private readonly AudioEndpointVolume speakersVolume;
        private readonly AudioEndpointVolume headphonesVolume;


        public SystemVolumeHandler()
        {
            try
            {
                deviceEnumerator = new MMDeviceEnumerator();
               
                var mmDeviceCollection= deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render,DeviceState.Active);
                headphones = deviceEnumerator.GetDevice(mmDeviceCollection[0].ID);
                speakers = deviceEnumerator.GetDevice(mmDeviceCollection[1].ID);

                headphonesVolume = headphones.AudioEndpointVolume;
                speakersVolume= speakers.AudioEndpointVolume;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to initialize system volume control.", ex);
                //TODO zaprogramować przypadke, kiedy słuchawki nie są podłączone:
                // - powiadomić  użytkownika, że nie ma słuchawek i niech je lepiej podłączy, albo to nie bedzie działać i puścić to przez DefaultDevice
                // - zablokowac pokrętło pot_headphones_gain
            }
        }

        public float SpeakersVolume
        {
            get => speakersVolume.MasterVolumeLevelScalar;
            set
            {
                if (value < 0.0f || value > 1.0f)
                    throw new ArgumentOutOfRangeException(nameof(value), "Volume must be between 0.0 and 1.0.");
                speakersVolume.MasterVolumeLevelScalar = value;
            }
        }

        public float HeadphonesVolume
        {
            get => headphonesVolume.MasterVolumeLevelScalar;
            set
            {
                if (value < 0.0f || value > 1.0f)
                    throw new ArgumentOutOfRangeException(nameof(value), "Volume must be between 0.0 and 1.0.");
                headphonesVolume.MasterVolumeLevelScalar = value;
            }
        }


        public bool AreMutedHeadphones
        {
            get => headphonesVolume.Mute;
            set => headphonesVolume.Mute = value;
        }
        public bool AreMutedSpeakers
        {
            get => speakersVolume.Mute;
            set => speakersVolume.Mute = value;
        }

        public void Dispose()
        {
            speakersVolume?.Dispose();
            headphonesVolume?.Dispose();
            headphones?.Dispose();
            speakers?.Dispose();
            deviceEnumerator?.Dispose();
        }
    }
}