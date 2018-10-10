using System;
using Microsoft.Extensions.Logging;
using System.Linq;
using Loggers;

namespace WorkshopRunner
{
    public class EvenLib : IEvenLib
    {
        private readonly IConsoleLogger _logger;
        public EvenLib(IConsoleLogger logger) {
            _logger = logger;
        }

        public string[] GetEvenLength(string[] input) {
            if (input == null) {
                throw new ArgumentNullException(nameof(input));
            }

            if (input.Length == 0) {
                _logger.Info("Empty array provided");
                return new string[] { };
            }

            var evenElements = input.Where((element) => element.Length % 2 == 0).ToArray<string>();

            _logger.Info($"Total even elements: {evenElements.Length}");


            return evenElements;
        }

    }
}
