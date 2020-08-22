using System;
using HETS1Design;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design.UnitTests
{
    [TestClass]
    public class TestCasesTest
    {
        //Global variable used for testing
        string fileToCheck;

        //Works in a similar manner to "Before" in JUnit
        [TestInitialize]
        public void Initialize()
        {
            fileToCheck = File.ReadAllText(@"C:\Users\CHAOSEnKrojerk\Source\Repos\Osherhacohen\HETS1Design\HETS1Design.UnitTests\TestCasesExample.txt");
        }

        [TestMethod]
        public void CountTestCases_Test()
        {
            //Arrange
            //Act
            var result = TestCases.CountTestCases(fileToCheck);
            //Assert
            Assert.AreEqual(4, result);
            Assert.AreNotEqual(3, result);
            Assert.AreNotEqual(5, result);
        }
    }
}
