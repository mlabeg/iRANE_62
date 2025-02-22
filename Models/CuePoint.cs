using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class CuePoint
    {
        public TimeSpan StartTime { get; set; }

        public CuePoint()
        {
            StartTime = new TimeSpan(1).Negate();
        }

        
    }
}
