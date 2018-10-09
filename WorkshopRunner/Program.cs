using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Loggers;

namespace WorkshopRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IEvenLib, EvenLib>()
                .AddSingleton<IConsoleLogger, ConsoleLogger>()
                .BuildServiceProvider();
                
                
              
            var testArray = new string[]
            {
                "one", "two", "three", "four", 
                "five", "six", "seven", "eight",
                "nine", "ten"
            };

            var evenLibrary = serviceProvider.GetService<IEvenLib>();
            evenLibrary.GetEvenLength(testArray);

            serviceProvider.Dispose();
        }
    }
}
