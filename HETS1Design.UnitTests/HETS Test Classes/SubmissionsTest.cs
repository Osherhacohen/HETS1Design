using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design
{
    [TestClass]
    public class SubmissionsTest
    {
        [TestMethod]
        public void ActivateCompilation_Finished()
        {
            var result = Submissions.ActivateCompilation();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ActivateExecution_Finished()
        {
            var result = Submissions.ActivateExecution();
            Assert.IsTrue(result);
        }

    }
}
