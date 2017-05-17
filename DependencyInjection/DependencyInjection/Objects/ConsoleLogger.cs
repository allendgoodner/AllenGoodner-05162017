using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Objects
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Log(object messageObject)
        {
            Console.WriteLine(messageObject.ToString());
        }

        public void Log(string message, int severity)
        {
            Console.WriteLine($"Error Message: {message}:: Error Severity: {severity} ");
        }
    }
}
