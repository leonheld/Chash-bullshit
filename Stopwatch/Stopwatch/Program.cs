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

            stopwatch.ElapsedTime();

            stopwatch.Stop();
            stopwatch.ElapsedTime();
        }
    }
}
