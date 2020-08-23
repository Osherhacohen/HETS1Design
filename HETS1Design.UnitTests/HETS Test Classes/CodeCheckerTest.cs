using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design
{
    [TestClass]
    public class CodeCheckerTest
    {
        [TestMethod]
        public void CompileCode_ReturnsOutput()
        {
            //Arrange
            var filePath = @"C:\Users\CHAOSEnKrojerk\Source\Repos\Osherhacohen\HETS1Design\Assets\CodeToCheck\Source.c";
            //Act
            var results = CodeChecker.CompileCode(filePath);
            Assert.IsNotNull(results);
        }
    }
}
