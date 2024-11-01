using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class Song
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Album { get; set; }
        public List<CuePoint> CuePoints { get; set; } = new List<CuePoint>();
        public TimeSpan SongSpan { get; set; }

    }
}
