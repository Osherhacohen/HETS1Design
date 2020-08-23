using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HETS1Design
{
    [TestClass]
    public class SingleSubmissionTest
    {
        SingleSubmission s1;
        [TestInitialize]
        public void Initialize()
        {
            s1 = new SingleSubmission("21325");
        }

        [TestMethod]
        public void SingleSubmission_Creates()
        {
            Assert.IsNotNull(s1);
            Assert.IsNotNull(s1.submitID);
        }

        [TestMethod]
        public void AddCode_Success()
        {
            s1.AddCode(@"..\..\..\Assets\CodeToCheck\Source.c");
            Assert.AreEqual(@"..\..\..\Assets\CodeToCheck\Source.c", s1.codePath);
            Assert.IsTrue(s1.codeExists);
        }

        [TestMethod]
        public void AddExe_Success()
        {
            s1.AddExe(@"..\..\..\Assets\CodeToCheck\Source.exe");
            Assert.AreEqual(@"..\..\..\Assets\CodeToCheck\Source.exe", s1.exePath);
            Assert.IsTrue(s1.exeExists);
        }

        [TestMethod]
        public void RunSubmittedProgram_AddedTestCasesToList()
        {
            //TODO
        }

        [TestMethod]
        public void CompareResultsToDesiredResults_Test()
        {
            //TODO, Also name of the method needs to be changed!
        }

        [TestMethod]
        public void CompareBothLists_CheckEqual()
        {
            Assert.IsTrue(s1.CompareBothLists());
        }

        [TestMethod]
        public void Grading_Test()
        {
            s1.CompileSubmittedCode();
            s1.RunSubmittedProgram();
            s1.Grading(34, 30, 36);
            double currentGrade = s1.grade;
            double x = s1.ResultsVsCorrectResults();
            double desiredGrade = 34 * 1 / 100 + 30 * 1 / 100 + 36 * x / 100;
            Assert.Equals(currentGrade, desiredGrade);
            //TODO
        }

    }
}
