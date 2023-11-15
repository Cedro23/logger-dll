using Logger.Utilities;
using System;
using System.Windows.Input;

namespace Logger.Models
{

    public class Log
    {
        private DateTime _timestamp;
        private LogType _type;
        private string _message;

        public DateTime Timestamp { get => _timestamp; set => _timestamp = value; }
        public LogType Type { get => _type; set => _type = value; }
        public string Message { get => _message; set => _message = value; }

        public Log(DateTime timestamp, LogType type, string message)
        {
            _timestamp = timestamp;
            _type = type;
            _message = message;
        }
    }
}
