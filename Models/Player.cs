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
        public IWavePlayer wavePlayer { get; set; }
        public AudioFileReader audioFileReader { get; set; }
        public string fileName { get; set; }
        public List<Song> Playlist { get; set; } = new List<Song>();

        public Player(int id)
        {
            this.Id = id;
        }
    }
    
}
