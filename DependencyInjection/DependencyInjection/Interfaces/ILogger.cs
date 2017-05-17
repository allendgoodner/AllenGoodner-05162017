using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Interfaces
{
    public interface ILogger
    {
        void Log(string message);
        void Log(object messageObject);
        void Log(string message, int severity);
    }
}
