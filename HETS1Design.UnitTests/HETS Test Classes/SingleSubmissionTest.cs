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
            s1.AddCode(@"..\..\..\Assets\Test Required FIles\SingleSubmissionTest\Source.c");

            //s1.AddExe(@"..\..\..\Assets\Test Required FIles\SingleSubmissionTest\Source.exe");

            //s1.CompileSubmittedCode();
            //s1.RunSubmittedProgram();            
            //s1.CalculateFinalGrade(33, 33, 34);
            //decimal currentGrade = (decimal)s1.finalGrade;

            //decimal desiredGrade = 33 + 33 + 0;
            //Assert.AreEqual(currentGrade, desiredGrade);



            bool isTC = false; // TNC
            string input = "Check input"; // This is a TNC and we know these vakues are incorrect output
            string output = "check output"; // So we know the result will be true
            TestCases.OnAddTestCase(input, output, isTC); // We want the submisstion at least one currect result
            TestCases.OnAddTestCase(input, output, isTC); // We want the submisstion at least one currect result
            var tcount = TestCases.testCases.Count;

            s1.RunSubmittedProgram();
            s1.CalculateFinalGrade(33, 33, 34);
            decimal newdesiredGrade = 67;
            decimal newcurrentGrade = (decimal)s1.finalGrade;
            newcurrentGrade=s1.Grading(33, 33, 34);
            Assert.AreEqual(newcurrentGrade, newdesiredGrade);
        }

        [TestMethod]
        public void ResultsVsCorrectResults_Test()
        {
            
        }

    }
}
