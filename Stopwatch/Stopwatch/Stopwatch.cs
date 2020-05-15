using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    class Stopwatch
    {
        private DateTime StartTime;

        private DateTime StopTime;

        private int _timerStartCode = 1;

        public void Start()
        {
            try
            {
                if (_timerStartCode == -1)
                {   

                    throw new InvalidOperationException();
                }
                _timerStartCode = -1;
                StartTime = DateTime.Now;

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Cannot start Stopwatch twice.");
            }
        }

        public void Stop()
        {
            this.StopTime = DateTime.Now;
        }

        public TimeSpan ElapsedTime()
        {
            return StopTime - StartTime;

        }

    }
}
