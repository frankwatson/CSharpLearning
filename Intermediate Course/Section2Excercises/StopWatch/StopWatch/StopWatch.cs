using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace StopWatch
{
    public class StopWatch
    {
        private TimeSpan _startTime;
        private TimeSpan _endTime;
        private TimeSpan _timeDuration;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch has already started.");
            }
            else
            {
                _isRunning = true;
                _startTime = DateTime.Now.TimeOfDay;
            }
        }

        public TimeSpan Stop()
        {
            _isRunning = false;
            _endTime = DateTime.Now.TimeOfDay;
            _timeDuration += _endTime - _startTime;
            return _timeDuration.Duration();
        }
    }
}