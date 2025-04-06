namespace iRANE_62.Models
{
    public class Loop
    {
        private TimeSpan loopIn = TimeSpan.Zero;
        private TimeSpan loopOut = TimeSpan.Zero;
        private bool loopActive = true;

        public bool LoopActive
        {
            get => loopActive;
            set => loopActive = value;
        }


        public TimeSpan LoopIn
        {
            get => loopIn;
            set
            {
                loopIn = value;
                loopActive = true;
            }
        }

        public TimeSpan LoopOut
        {
            get => loopOut;
            set
            {
                if (loopOut != value)
                {
                    loopOut = value;
                    LoopOutChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler LoopOutChanged;

        public Loop() { }

        public void SetLoopIn(TimeSpan time)
        {
            LoopIn = time;
        }

        public void SetLoopOut(TimeSpan time)
        {
            LoopOut = time;
        }

        public void ExitLoop()
        {
            LoopActive = false;
            LoopIn = TimeSpan.Zero;
            loopOut = TimeSpan.Zero;
        }
    }
}
