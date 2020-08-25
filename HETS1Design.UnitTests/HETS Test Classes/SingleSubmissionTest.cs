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
            s1.AddCode(@"..\..\..\Assets\CodeToCheck\Source.c");

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
            s1.AddExe(@"..\..\..\Assets\Test Required FIles\SingleSubmissionTest\Source.exe");
            s1.AddCode(@"..\..\..\Assets\Test Required FIles\SingleSubmissionTest\Source.c");

            s1.CompileSubmittedCode();
            s1.RunSubmittedProgram();            
            s1.CalculateFinalGrade(33, 33, 34);
            decimal currentGrade = (decimal)s1.finalGrade;
            decimal x=0;

            decimal desiredGrade = 33 + 33 + 0;
            Assert.AreEqual(currentGrade, desiredGrade);
        }

        [TestMethod]
        public void ResultsVsCorrectResults_Test()
        {
            
        }

    }
}
