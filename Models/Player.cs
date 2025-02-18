using NAudio.Extras;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class Player
    {
        public int Id { get; set; }
        public IWavePlayer WavePlayer { get; set; }
        public AudioFileReader AudioFileReader { get; set; }
        public string FileName { get; set; }

        public Action<float> SetVolumeDelegate;

        public Eq Eq { get; set; }

        public Player(int id)
        {
            this.Id = id;
            Eq = new Eq();
        }
    }
    
}
