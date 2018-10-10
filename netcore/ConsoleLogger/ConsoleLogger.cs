using System;
namespace Loggers
{
    public class ConsoleLogger: IConsoleLogger
    {
        public ConsoleLogger()
        {
        }

        public void Info(string message) {
            Console.WriteLine($"Info: {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }
    }
}
