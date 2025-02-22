using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace iRANE_62.Models
{
    public class Song
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Album { get; set; }

        public TimeSpan[] CuePoints = new TimeSpan[5];
        public TimeSpan SongSpan { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public Song(string path)
        {
            Path = path;
            Name = Path.Split('\\').Last().ToString();
            SongSpan=GetAudioDuration(path);

            InitializeCuePoints();
        }

        private void InitializeCuePoints()
        {
            for (int i = 0; i < CuePoints.Length; i++)
            {
                CuePoints[i] = new TimeSpan(1).Negate();
            }
        }

        public TimeSpan GetAudioDuration(string filePath)
        {
            using (var reader = new MediaFoundationReader(filePath))
            {
                return reader.TotalTime;
            }
        }
       
    }
}
