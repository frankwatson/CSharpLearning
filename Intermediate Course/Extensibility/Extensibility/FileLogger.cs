using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            // Need to put into using statement to remove from memory
            //// bc streamwriter is not apart of CLR (Common Lang Runtime)
            //// so it is not automatically disposed of in memory

            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);

                // If you use using statement this is automatically added.
                // streamWriter.Dispose();
            }
        }
    }
}