using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HETS1Design
{
    public static class Submissions
    {
        public static List<SingleSubmission> submissions = new List<SingleSubmission>(); //List of submissions from students.

        public static void ActivateCompilation()
        {
            foreach (SingleSubmission sub in submissions)
                sub.CompileSubmittedCode();
        }

        public static void ActivateExecution()
        {
            TestCases.testCases.Add(new SingleTestCase("2 9", "7", true));
            foreach (SingleSubmission sub in submissions)
            {
                sub.RunSubmittedProgram(); //This is temporary, the Run function will receive a SingleTestCase.
                sub.CompareResults();
            }
        }
    }
}
