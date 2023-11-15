using Logger.Utilities;
using System;

namespace Logger.Services
{
    public class LoggerService : ILogger
    {
        // Define a delegate for the log event
        public delegate void LogEventHandler(object sender, LogEventArgs e);



        // Define the event for logging
        public event EventHandler<LogEventArgs> LogEvent;

        // Method to log a message
        public void Log(LogType logType, string message)
        {
            // Create a LogEventArgs instance with log information
            var logEventArgs = new LogEventArgs
            {
                Timestamp = DateTime.Now,
                LogType = logType,
                Message = message
            };

            // Raise the LogEvent
            OnLogEvent(logEventArgs);
        }

        // Helper method to raise the LogEvent
        protected virtual void OnLogEvent(LogEventArgs e)
        {
            LogEvent?.Invoke(this, e);
        }

        public void Debug(string message)
        {
            Log(LogType.Debug, message);
        }

        public void Information(string message)
        {
            Log(LogType.Info, message);
        }

        public void Warning(string message)
        {
            Log(LogType.Warning, message);
        }

        public void Error(Exception exception)
        {
            Log(LogType.Error, exception.Message);
        }
    }
}
