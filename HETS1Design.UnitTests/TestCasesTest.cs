using System;
using System.IO;
using System.Collections.Generic;
using HETS1Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design.UnitTests
{
    [TestClass]
    public class TestCasesTest
    {
        //Global variable used for testing
        string fileToCheck;
        TestCases t1;

        //Works in a similar manner to "Before" in JUnit
        [TestInitialize]
        public void Initialize()
        {
            t1 = new TestCases();
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

        [TestMethod]
        public void TC_or_TNC_ContainsEither()
        {
            //Arrange
            //Act
            var result1 = t1.TC_or_TNC("__[TC]\r\n4 5 6");
            var result2 = t1.TC_or_TNC("__[TNC]\r\n7");
            //Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void TestCasesSeparator_Seperates()
        {
            //Arrange
            //Act
            var result = t1.TestCasesSeparator(@"C:\Users\CHAOSEnKrojerk\Source\Repos\Osherhacohen\HETS1Design\HETS1Design.UnitTests\TestCasesExample.txt");
            //Assert
            string[] contents = { "__[TC]\r\n9 5\r\n", "__[TNC]\r\n3 4\r\n1\r\n__[Bound] 5 9\r\n10\r\n", "__[TNC]\r\n7 3\r\n" , "__[TC] 19\r\n77" };
            List<string> expected = new List<string>(contents);
            Assert.AreEqual(expected, result);
        }
    }
}
