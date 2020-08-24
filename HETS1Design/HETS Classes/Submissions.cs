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

        public static void ResetSubmissions()
        {
            submissions.Clear();
        }
        

        public static string GetAllSubmissionsResults(string zipPath) //We may turn this into the final csv file at some point.
        {
            string createText = "Compiler version: 64Bit\r\n\r\n";
            if (CodeChecker.use32bitCompiler)
                createText = "Compiler version: 32Bit\r\n\r\n";


            int i = 0;

            foreach (SingleSubmission sub in Submissions.submissions)
            {
                createText += i.ToString() + ". ID: " + sub.submitID + "\r\n"
                    + "Code path: " + sub.codePath + "\r\n"
                    + "Exe path: " + sub.exePath + "\r\n"
                    + "Code exists: " + sub.codeExists + "\r\n"
                    + "Exe exists: " + sub.exeExists + "\r\n"
                    + "Compiler output: " + sub.compilerOutput + "\r\n"
                    + "Compiled Exe path: " + sub.compiledExePath + "\r\n\r\n";
                    createText += "Results: " + "\r\n" + sub.GetAllSingleSubmissionResults() + "\r\n\r\n";

                
                createText+= "Success rate of: " + sub.CorrectResultsPercentage();
                if (sub.possibleCheating)
                    createText += " with POSSIBLE CHEATING!\r\n\r\n\r\n";
                else
                    createText += "\r\n\r\n\r\n";
                i++;
            }


            //File.WriteAllText(Path.GetDirectoryName(zipPath)+@"\info.txt", createText);

            return createText;
        }

        public static void SaveResults()
        { }

        public static void SaveDetailedResults()
        { }
    }
}
