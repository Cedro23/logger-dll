using Logger.Utilities;
using System;

namespace Logger.Services
{
    // Define the LogEventArgs class to hold log information
    public class LogEventArgs : EventArgs
    {
        public LogType LogType { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
    public interface ILogger
    {
        event EventHandler<LogEventArgs> LogEvent;

        void Debug(string message);
        void Information(string message);
        void Warning(string message);
        void Error(Exception exception);
    }
}
