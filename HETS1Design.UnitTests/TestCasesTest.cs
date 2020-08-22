using System;
using HETS1Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design.UnitTests
{
    [TestClass]
    public class TestCasesTest
    {
        [TestMethod]
        public void CountTestCases_Test()
        {
            //Arrange
            var fileToCheck = "TestCasesExample.txt";

            //Act
            var result = TestCases.CountTestCases(fileToCheck);

            //Assert
            Assert.AreEqual(4, result);

            //Failed - עמית לא כתב כמו שצריך!
        }
    }
}
