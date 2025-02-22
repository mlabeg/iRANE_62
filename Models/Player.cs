﻿using NAudio.Dsp;
using NAudio.Extras;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
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
        public Song? Song { get; set; }

        public Action<float> SetVolumeDelegate;
        public Eq Equalizer { get; set; }
        public Loop Loop { get; set; }

        public int currentPlaybackPosition = 0; 

        public Player(int id)
        {
            this.Id = id;
            Equalizer = new Eq();
            Loop = new Loop();
        }
    }

}
