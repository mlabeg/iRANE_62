// SystemVolumeController.cs
using NAudio.CoreAudioApi;
using System;

namespace iRANE_62.Handlers
{
    public class SystemVolumeHandler : IDisposable
    {
        private readonly MMDeviceEnumerator deviceEnumerator;
        private readonly MMDevice defaultDevice;
        private readonly AudioEndpointVolume endpointVolume;

        public SystemVolumeHandler()
        {
            try
            {
                deviceEnumerator = new MMDeviceEnumerator();
                defaultDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                endpointVolume = defaultDevice.AudioEndpointVolume;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to initialize system volume control.", ex);
            }
        }

        public float Volume
        {
            get => endpointVolume.MasterVolumeLevelScalar;
            set
            {
                if (value < 0.0f || value > 1.0f)
                    throw new ArgumentOutOfRangeException(nameof(value), "Volume must be between 0.0 and 1.0.");
                endpointVolume.MasterVolumeLevelScalar = value;
            }
        }

        public bool IsMuted
        {
            get => endpointVolume.Mute;
            set => endpointVolume.Mute = value;
        }

        public void Dispose()
        {
            endpointVolume?.Dispose();
            defaultDevice?.Dispose();
            deviceEnumerator?.Dispose();
        }
    }
}