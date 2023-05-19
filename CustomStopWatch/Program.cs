namespace CustomStopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStopWatch sw = new CustomStopWatch();
            sw.Start();
            string test = "";
            for(int i=0; i<10000; i++) 
            {
                test += "|test|";
            }
            sw.Stop();
            
            Console.WriteLine(sw.GetTime().TotalMilliseconds.ToString());
        }

        class CustomStopWatch
        {
            private DateTime StartTime { get; set; }

            private TimeSpan TimeScore { get; set; }


            public void Start()
            {
                TimeScore = default;
                StartTime = DateTime.Now;
            }

            public void Stop()
            {
                if (StartTime == default)
                {
                    throw new Exception("Time Error");
                }
                TimeScore = DateTime.Now - StartTime;
                StartTime = default;
            }

            public TimeSpan GetTime()
            {

                if (TimeScore == default)
                {
                    throw new Exception("Time Error");
                }
                return TimeScore;

            }
        }
    }
}