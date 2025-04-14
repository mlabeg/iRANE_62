using iRANE_62.Models;

namespace iRANE_62.Handlers
{
    public class CueButtonHandler
    {
        public Action<AudioSourceHandler, TimeSpan, Color> CuePointAdded;

        public void CueButtonClick(AudioSourceHandler audioSource, int cue, Button cueButton)
        {
            TimeSpan currentTime = audioSource.AudioFileReader.CurrentTime;

            var cuePoint = audioSource.Song.CuePoints[cue];

            if (cuePoint.StartTime.HasValue)
            {
                audioSource.AudioFileReader.CurrentTime = (TimeSpan)cuePoint.StartTime;
            }
            else
            {
                cuePoint.StartTime = currentTime - TimeSpan.FromMilliseconds(1430);
                cueButton.BackColor = CuePointsColors.Colors[cue];

                CuePointAdded.Invoke(audioSource, (TimeSpan)cuePoint.StartTime, cuePoint.Color);
            }
        }
    }
}
