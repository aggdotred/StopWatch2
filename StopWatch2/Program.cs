using System;


namespace StopWatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            System.Threading.Thread.Sleep(1000);
            sw.getTime();
            System.Threading.Thread.Sleep(2000);
            sw.Stop();

            sw.getTime();
        }
    }
}
