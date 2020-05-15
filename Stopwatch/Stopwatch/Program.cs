using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            Console.WriteLine("Elapsed time is: {0}", stopwatch.ElapsedTime());

            stopwatch.Start();
            stopwatch.Start();
            System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time is: {0}", stopwatch.ElapsedTime());
        }
    }
}
