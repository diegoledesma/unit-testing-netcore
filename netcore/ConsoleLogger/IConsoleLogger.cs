using System;
namespace Loggers
{
    public interface IConsoleLogger
    {
        void Info(string message);
        void Error(string message);
    }
}
