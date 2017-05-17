using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Objects
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;
        private readonly string _fileName;
        private const string Seperator = "====================";

        public FileLogger(string path, string fileName)
        {
            _filePath = path;
            _fileName = fileName;
        }

        public void Log(string message)
        {
            WriteMessage(message);
        }

        public void Log(object messageObject)
        {
            WriteMessage(messageObject.ToString());
        }

        public void Log(string message, int severity)
        {
            WriteMessage($"Error Message: {message}:: Error Severity: {severity}");
        }

        private void WriteMessage(string message)
        {
            using (FileStream fw = new FileStream(Path.Combine(_filePath, _fileName), FileMode.OpenOrCreate))
            {
                string messageString = formatMessage(message);

                var messageBytes = Encoding.UTF8.GetBytes(messageString);

                fw.Write(messageBytes, 0, messageBytes.Length);
            }
        }

        private string formatMessage(string message)
        {
            string dateTimeStamp = DateTime.Now.ToString("O");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Seperator);
            sb.AppendLine(dateTimeStamp);
            sb.AppendLine(message);
            sb.AppendLine(Seperator);
            return sb.ToString();
        }
    }
}
