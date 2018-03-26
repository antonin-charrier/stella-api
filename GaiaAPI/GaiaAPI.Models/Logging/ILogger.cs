namespace ourakoz.GaiaAPI.Models.Logging
{
    /// <summary>
    /// Defines the common logging interface specification
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes a message to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="level">A LogLevel value of the level of this message</param>
        /// <param name="message">A String of the message to write to the log</param>
        void WriteMessage(string category, LogLevel level, string message);

        /// <summary>
        /// Writes a fatal error to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        void Fatal(string category, string message);

        /// <summary>
        /// Writes an error to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        void Error(string category, string message);

        /// <summary>
        /// Writes a warn to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        void Warn(string category, string message);

        /// <summary>
        /// Writes an info to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        void Info(string category, string message);

        /// <summary>
        /// Writes a verbose to the log
        /// </summary>
        /// <param name="category">A String of the category to write to the log</param>
        /// <param name="message">A String of the message to write to the log</param>
        void Verbose(string category, string message);

    }
}
