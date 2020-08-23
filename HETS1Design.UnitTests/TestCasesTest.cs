using System;
using System.IO;
using System.Collections.Generic;
using HETS1Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace HETS1Design.UnitTests
{
    [TestClass]
    public class TestCasesTest
    {
        //Global variable used for testing
        string fileToCheckContent;

       //Works in a similar manner to "Before" in JUnit
        [TestInitialize]
        public void Initialize()
        {
            fileToCheckContent = File.ReadAllText(@"..\..\..\Assets\IOToCheck\TestCasesExample.txt");
        }

        [TestMethod]
        public void CountTestCases_Test()
        {
            //Arrange
            //Act
            var result = TestCases.CountTestCases(fileToCheckContent);
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
            var result1 = TestCases.TC_or_TNC("__[TC]\r\n4 5 6");
            var result2 = TestCases.TC_or_TNC("__[TNC]\r\n7");
            //Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void TestCasesSeparator_Seperates()
        {
            //Arrange
            //Act
            string res = "";
            var result = TestCases.TestCasesSeparator(fileToCheckContent);           

            //Assert
            string[] expected = { "__[TC]\r\n9 5", "__[TNC]\r\n3 4\r\n1\r\n__[Bound] 5 9\r\n10", "__[TNC]\r\n7 3", "__[TC] 19\r\n" };
            List<string> expectedList = new List<string>(expected);

            CollectionAssert.AreEqual(expectedList, result);
        }
    }
}
