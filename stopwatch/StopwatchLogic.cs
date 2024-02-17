using System;

namespace StopwatchApplication
{
    public class StopwatchLogic
    {
        private bool _isRunning = false;
        private TimeSpan _elapsed = TimeSpan.Zero;
        private DateTime _startTime;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Pause()
        {
            if (!_isRunning)
                return;

            _elapsed += DateTime.Now - _startTime;
            _isRunning = false;
        }

        public void Resume()
        {
            if (_isRunning)
                return;

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Reset()
        {
            _elapsed = TimeSpan.Zero;
            _isRunning = false;
        }

        public void Stop()
        {
            if (_isRunning)
            {
                _elapsed += DateTime.Now - _startTime;
                _isRunning = false;
            }
        }

        public string GetCurrentTime()
        {
            if (_isRunning)
            {
                return (_elapsed + (DateTime.Now - _startTime)).ToString(@"hh\:mm\:ss");
            }
            else
            {
                return _elapsed.ToString(@"hh\:mm\:ss");
            }
        }
    }
}
