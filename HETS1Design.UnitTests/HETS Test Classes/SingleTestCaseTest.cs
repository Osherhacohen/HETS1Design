using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design
{
    [TestClass]
    public class SingleTestCaseTest
    {
        SingleTestCase s1, s2, s3;

        [TestInitialize]
        public void Initialize()
        {
            s1 = new SingleTestCase("7 6", "12", true);
            s2 = new SingleTestCase("__[Bound]3 5 10", "10", true);
            s3 = new SingleTestCase("__[EP]3 9 17", "19", true);
        }

        [TestMethod]
        public void SingleTestCase_CreatedSuccessfully()
        {
            Assert.IsNotNull(s1);
            Assert.IsNotNull(s2);
            Assert.IsNotNull(s3);
            Assert.IsTrue(s2.hasBoundInText);
            Assert.IsTrue(s3.hasEPInText);
        }

        [TestMethod]
        public void AppendTestCase_Appended()
        {
            //TODO
        }

        [TestMethod]
        public void CompareOutput_IsTrue()
        {
            var resultOutput = "12";
            var result = s1.CompareOutput(resultOutput);
            Assert.IsTrue(result);
        }

        //[TestMethod]
        //public void BoundaryScan_HasBound()
        //{
        //    It's a private method
        //}

        //[TestMethod]
        //public void EPScan_HasEP()
        //{
        //    It's a private method
        //}

        [TestMethod]
        public void ReturnBoundaryTestCases_Test()
        {
            //TODO
        }

        [TestMethod]
        public void ReturnEPTestCases_Test()
        {
            //TODO
        }
    }
}
