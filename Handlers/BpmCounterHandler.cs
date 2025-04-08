namespace iRANE_62.Handlers
{
    internal class BpmCounterHandler
    {
        private readonly List<DateTime> tapTimestamps;
        private readonly int maxSamples;
        private int bpm;

        public BpmCounterHandler(int maxSamples = 20)
        {
            this.maxSamples = maxSamples;
            this.tapTimestamps = new List<DateTime>(maxSamples);
            this.bpm = 0;
        }

        public int Bpm
        {
            get => bpm;
            private set
            {
                if (bpm != value)
                {
                    bpm = value;
                }
            }
        }

        public void AddTap()
        {
            DateTime now = DateTime.Now;

            if (tapTimestamps.Count > 0 && (now - tapTimestamps.Last()).TotalSeconds > 2)
            {
                tapTimestamps.Clear();
            }

            tapTimestamps.Add(now);

            if (tapTimestamps.Count > maxSamples)
            {
                tapTimestamps.RemoveAt(0);
            }

            CalculateBpm();
        }

        private void CalculateBpm()
        {
            if (tapTimestamps.Count < 2)
            {
                return;
            }

            double totalMilliseconds = 0;
            for (int i = 1; i < tapTimestamps.Count; i++)
            {
                TimeSpan diff = tapTimestamps[i] - tapTimestamps[i - 1];
                totalMilliseconds += diff.TotalMilliseconds;
            }

            double averageMilliseconds = totalMilliseconds / (tapTimestamps.Count - 1);

            double calculatedBpm = 60000 / averageMilliseconds;

            Bpm = (int)Math.Round(calculatedBpm);
        }
    }
}
