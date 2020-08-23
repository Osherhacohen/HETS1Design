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
        

        public static bool ActivateCompilation()
        {
            foreach (SingleSubmission sub in submissions)
                sub.CompileSubmittedCode();
            return true;
        }


        public static bool ActivateExecution()
        {
            foreach (SingleSubmission sub in submissions)
            {
                sub.RunSubmittedProgram(); 
                sub.CompareResultsToDesiredResults();
            }
            return true;
        }

        public static void SaveResults()
        { }

        public static void SaveDetailedResults()
        { }
    }
}
