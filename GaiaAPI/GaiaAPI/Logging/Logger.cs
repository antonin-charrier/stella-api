using System;
using NLog;
using ILogger = ourakoz.GaiaAPI.Models.Logging.ILogger;
using LogLevel = ourakoz.GaiaAPI.Models.Logging.LogLevel;

namespace ourakoz.GaiaAPI.Logging
{
    public class Logger : ILogger
    {
        private static readonly NLog.Logger NLogger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Writes a message to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="level">A LogLevel value of the level of this message</param>
        /// <param name="message">A String of the message to write to the log</param>
        private static void WriteMessage(string category, LogLevel level, string message)
        {
            NLog.LogLevel nlogLevel;
            switch (level)
            {
                case LogLevel.Fatal:
                    nlogLevel = NLog.LogLevel.Fatal;
                    break;
                case LogLevel.Error:
                    nlogLevel = NLog.LogLevel.Error;
                    break;
                case LogLevel.Warn:
                    nlogLevel = NLog.LogLevel.Warn;
                    break;
                case LogLevel.Info:
                    nlogLevel = NLog.LogLevel.Info;
                    break;
                case LogLevel.Debug:
                    nlogLevel = NLog.LogLevel.Debug;
                    break;
                default:
                    nlogLevel = NLog.LogLevel.Trace;
                    break;
            }
            NLogger.Log(nlogLevel, $"{category} : {message}");
        }

        /// <summary>
        /// Writes a message to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="level">A LogLevel value of the level of this message</param>
        /// <param name="e">The Exception thrown during the error</param>
        /// <param name="message">A String of the message to write to the log</param>
        private static void WriteMessage(string category, LogLevel level, Exception e, string message)
        {
            NLog.LogLevel nlogLevel;
            switch (level)
            {
                case LogLevel.Fatal:
                    nlogLevel = NLog.LogLevel.Fatal;
                    break;
                case LogLevel.Error:
                    nlogLevel = NLog.LogLevel.Error;
                    break;
                case LogLevel.Warn:
                    nlogLevel = NLog.LogLevel.Warn;
                    break;
                case LogLevel.Info:
                    nlogLevel = NLog.LogLevel.Info;
                    break;
                case LogLevel.Debug:
                    nlogLevel = NLog.LogLevel.Debug;
                    break;
                default:
                    nlogLevel = NLog.LogLevel.Trace;
                    break;
            }
            NLogger.Log(nlogLevel, e, $"{category.ToUpper()} : {message}");
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Writes a fatal error to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        public void Fatal(string category, string message) => WriteMessage(category, LogLevel.Fatal, message);

        /// <summary>
        /// Writes a fatal error to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="e">The Exception thrown during the fatal error</param>
        /// <param name="message">A String of the message to write to the log</param>
        public static void Fatal(string category, Exception e, string message) => WriteMessage(category, LogLevel.Fatal, e, message);
        
        /// <inheritdoc />
        /// <summary>
        /// Writes an error to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        public void Error(string category, string message) => WriteMessage(category, LogLevel.Error, message);

        /// <inheritdoc />
        /// <summary>
        /// Writes an error to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="e">The Exception thrown during the error</param>
        /// <param name="message">A String of the message to write to the log</param>
        public static void Error(string category, Exception e, string message) => WriteMessage(category, LogLevel.Error, e, message);
        
        /// <inheritdoc />
        /// <summary>
        /// Writes a warn to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        public void Warn(string category, string message) => WriteMessage(category, LogLevel.Warn, message);

        /// <inheritdoc />
        /// <summary>
        /// Writes an info to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        public void Info(string category, string message) => WriteMessage(category, LogLevel.Info, message);

        /// <inheritdoc />
        /// <summary>
        /// Writes a verbose to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        public void Debug(string category, string message) => WriteMessage(category, LogLevel.Debug, message);
    }
}
