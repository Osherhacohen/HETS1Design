using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design
{
    [TestClass]
    public class CodeCheckerTest
    {
        /******************************/
        //Standalone Unit Tests
        /******************************/

        [TestMethod]
        public void CompileCode_ReturnsOutput()
        {
            //Arrange
            var filePath = @"..\..\..\Assets\CodeToCheck\Source.c";
            //Act
            var results = CodeChecker.CompileCode(filePath);
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void RunEXE_ReturnsOutput()
        {
            //Arrange
            var filePath = @"..\..\..\Assets\CodeToCheck\Source.exe";
            var input = "2 3";
            //Act
            var results = CodeChecker.RunEXE(filePath, input);
            Assert.IsNotNull(results);
        }

        /******************************/
        //Combined Integration Tests
        /******************************/
    }
}
