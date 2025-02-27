using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class CuePoint
    {
        public TimeSpan StartTime { get; set; }
        public Color Color { get; set; }

        public CuePoint()
        {
            StartTime = new TimeSpan(1).Negate();
        }

        public CuePoint(Color color):this()
        {
            this.Color = color;
        }

        public CuePoint(Color color, TimeSpan time)
        {
            this.StartTime = time;
            this.Color = color;
        }
    }
}
