using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Loggers;

namespace EvenLib.Tests
{
    [TestClass]
    public class EvenLibTests
    {
        private Mock<IConsoleLogger> _mockConsoleLogger;


        [TestInitialize]
        public void Initialize() {
            //Setup before running each test
            _mockConsoleLogger = new Mock<IConsoleLogger>();
        }

        public EvenLibTests(){
            //One-time initializations can be done here too
        }

        [TestMethod]
        public void ShouldLogInfoWhenInputIsEmpty()
        {
            //Initialize the class under test using mocked dependency (console logger)
            var evenLib = new WorkshopRunner.EvenLib(_mockConsoleLogger.Object);
            var inputArray = new string[]{};

            evenLib.GetEvenLength(inputArray);
           

            _mockConsoleLogger.Verify(mockConsole => mockConsole.Info(It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenInputIsNull()
        {
            var evenLib = new WorkshopRunner.EvenLib(_mockConsoleLogger.Object);
           
            Assert.ThrowsException<ArgumentNullException>(() => evenLib.GetEvenLength(null));
        }


        [TestCleanup]
        public void Cleanup(){
            //Cleanup after running each test here
        }
    }
}
