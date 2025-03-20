using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace iRANE_62.Models
{
    public class Song : IEquatable<Song>
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public TimeSpan SongSpan { get; set; }

        public CuePoint[] CuePoints = new CuePoint[5];


        public override string ToString()
        {
            return Name;
        }

        public Song(string path)
        {
            Path = path;
            Name = Path.Split('\\').Last().ToString();
            SongSpan = GetAudioDuration(path);

            InitializeCuePoints();
        }
        
        private void InitializeCuePoints()
        {
            for (int i = 0; i < CuePoints.Length; i++)
            {
                CuePoints[i] = new CuePoint(CuePointsColors.Colors[i]);
            }
        }

        public TimeSpan GetAudioDuration(string filePath)
        {
            try
            {
                using (var reader = new MediaFoundationReader(filePath))
                {
                    return reader.TotalTime;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Błąd odczytu pliku: {ex.Message}");
                return TimeSpan.Zero;
            }
        }

        public override bool Equals(object? obj) => Equals(obj as Song);    

        public bool Equals(Song? other)
        {
            if (other == null) return false;
            return Name == other.Name;
        }

    }
}
