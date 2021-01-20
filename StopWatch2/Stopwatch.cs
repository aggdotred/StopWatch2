using System;


namespace StopWatch2
{
    class Stopwatch
    {
        TimeSpan duration = TimeSpan.Zero;
        DateTime startTime;
        DateTime stopTime;
        bool isRunning;

        public void Start()
        {
            if (isRunning == false)
            {
                startTime = DateTime.Now;
                duration = TimeSpan.Zero;
                isRunning = true;
            } else
            {
                throw new InvalidOperationException("The stopwatch is already running.");
            }

        }
        public void Stop()
        {
            if (isRunning == true)
            {
                stopTime = DateTime.Now;
                duration = stopTime - startTime;
            } else
            {
                throw new InvalidOperationException("The stopwatch is not running.");
            }
        }

        public void getTime()
        {
            if (isRunning == true)
            {
                Console.WriteLine("Stopwatch time is: " + (DateTime.Now - startTime));
            } else
            {
                Console.WriteLine(duration);
            }
        }


    }
}
