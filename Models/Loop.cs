using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Models
{
    public class Loop
    {
        public TimeSpan LoopIn { get; set; }
        public TimeSpan LoopOut { get; set; }

        public bool LoopActive = true;

        public Loop()
        {
            CleanLoop();
        }

        public void SetLoopIn(TimeSpan time)
        {
            LoopIn = time;
        }

        public void SetLoopOut(TimeSpan time)
        {
            LoopOut = time;
        }

        public void CleanLoop()
        {
            LoopIn = TimeSpan.Zero;
            LoopOut = TimeSpan.Zero;
        }
    }
}
