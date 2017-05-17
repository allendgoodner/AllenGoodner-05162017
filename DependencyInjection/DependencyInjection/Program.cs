using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Objects;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger(@"C:\Temp", "DependencyInjectionLogging.txt");
            ConsoleLogger consoleLogger = new ConsoleLogger();

            Console.WriteLine("Instatiating Admin with File Logging");
            Admin adminWithFileLogging = new Admin(fileLogger);
            adminWithFileLogging.AddUser("TK421", 1);
            Console.WriteLine("Log Entry Created");
            Console.WriteLine();

            Console.WriteLine("Instantiating Admin with Console Logging");
            Admin adminWithConsoleLogging = new Admin(consoleLogger);
            adminWithConsoleLogging.AddUser("TK421", 1, "TK421 is not at his post");
            Console.WriteLine("Entry Logged.");
            Console.ReadLine();
        }
    }
}
