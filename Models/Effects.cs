using NAudio.Dmo.Effect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class Effects
    {
        public DmoWavesReverb ReverbEffect { get; set; }
        public DmoEcho EchoEffect { get; set; }
        public DmoFlanger FlangerEffect { get; set; }
        public DmoChorus ChorusEffect { get; set; }
        public DmoDistortion DistortionEffect { get; set; }
     
    }
}
