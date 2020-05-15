using System;

namespace Stopwatch
{
    class Stopwatch
    {
        private DateTime _startTime;

        private DateTime _stopTime;

        private TimeSpan _elapsedTime;

        private bool _running = false;

        private bool _validRun = true;

        public void Start()
        {
            try
            {
                if (_running)
                {   
                    throw new InvalidOperationException();
                }
                _running = true;
                _startTime = DateTime.Now;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Cannot start Stopwatch twice.");
            }
        }

        public void Stop()
        {
            try
            {
                if (!_running)
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException)
            {
                _validRun = false;
                Console.WriteLine("Cannot stop a timer that is not running");
            }

            _running = false;
            this._stopTime = DateTime.Now;
        }

        public void ElapsedTime()
        {
            try
            {
                if (!_validRun)
                    throw new InvalidOperationException();
                else
                {
                    _validRun = true;
                    _elapsedTime = _stopTime - _startTime;
                    Console.WriteLine($"Elapsed time is: {_elapsedTime}");
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("The last timer run was not valid, so there's no elapsed time");
            }
        }
    }
}
