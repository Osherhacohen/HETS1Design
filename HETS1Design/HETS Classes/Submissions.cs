using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HETS1Design
{
    public static class Submissions
    {
        public static List<SingleSubmission> submissions = new List<SingleSubmission>(); //List of submissions from students.
        public static int codeWeight = -1, exeWeight = -1, correctResultsWeight = -1;
        public static bool checkCode = true; //Default at start.
        public static bool checkExe = true;

        //Activates compilation for all submissions.
        public static bool ActivateCompilation()
        {
            foreach (SingleSubmission sub in submissions)
                sub.CompileSubmittedCode();
            return true;
        }


        //Activates all the .exe files in the submissions.
        public static bool ActivateExecution()
        {
            foreach (SingleSubmission sub in submissions)
            {
                sub.RunSubmittedProgram();
                sub.CompareResultsToDesiredResults();
            }
            return true;
        }

        //Activates grading for all of the submissions.
        public static void ActivateGrading()
        {
            if (codeWeight != -1) //It can be -1 only when grading is turned off.
            {
                foreach (SingleSubmission sub in submissions)
                {
                    sub.CalculateFinalGrade(codeWeight,exeWeight, correctResultsWeight);
                }
            }
        }

        //Clears the submissions list.
        public static void ResetSubmissions()
        {
            submissions.Clear();
        }
        
        
        //Returns a text with the detailed results.
        public static string GetAllSubmissionsResults() //We may turn this into the final csv file at some point.
        {

            string createText = "Compiler version: 64Bit\r\n\r\n";
            if (CodeChecker.use32bitCompiler)
                createText = "Compiler version: 32Bit\r\n\r\n";


            int i = 0;
            foreach (SingleSubmission sub in Submissions.submissions)
            {
                ActivateGrading();

                createText += i.ToString() + ". ID: " + sub.submitID + "\r\n"
                    + "Code path: " + sub.codePath + "\r\n"
                    + "Exe path: " + sub.exePath + "\r\n"
                    + "Code exists: " + sub.codeExists + "\r\n"
                    + "Exe exists: " + sub.exeExists + "\r\n"
                    + "Compiler output: " + sub.compilerOutput + "\r\n"
                    + "Compiled Exe path: " + sub.compiledExePath + "\r\n\r\n";
                    createText += "Results: " + "\r\n" + sub.GetAllSingleSubmissionResults() + "\r\n";                
                createText+= "\r\nSuccess rate of: " + sub.CorrectResultsPercentage();
                if (sub.possibleCheating)
                    createText += " with POSSIBLE CHEATING!\r\n\r\n";
                else
                    createText += "\r\n\r\n";
                createText += "Grade: " + sub.finalGrade.ToString()+"\r\n\r\n";

                i++;
                
            }



            return createText;
        }

        //Saves the .csv table in the desired location.
        public static DataTable GetResultsTable()
        {
            ActivateGrading();

            string compiler = "Compiler version is 64Bit";
            if (CodeChecker.use32bitCompiler)
                compiler = "Compiler version is 32Bit";
            DataTable rdt=new DataTable("Submissions Results ("+compiler+"):");


            //Name the headers.
            rdt.Columns.Add("ID");
            rdt.Columns.Add(".c File Submitted");
            rdt.Columns.Add(".c File Compiled");
            rdt.Columns.Add(".exe File Submitted");
            rdt.Columns.Add("Success Rate");
            rdt.Columns.Add("Grade");
            rdt.Columns.Add("Possible Cheating");



            int i = 0;
            foreach (SingleSubmission sub in Submissions.submissions)
            {
                DataRow submissionRow = rdt.NewRow();
                string whatToWrite="";

                submissionRow["ID"] = sub.submitID;

                if (sub.codeExists)
                    whatToWrite ="Yes";
                else
                    whatToWrite = "No";
                submissionRow[".c File Submitted"] = whatToWrite;


                if (sub.compiledExePath != null) //Making sure there's a correct path in compiled .exe path (there's no path <2).
                    whatToWrite = "Yes";
                else
                    whatToWrite = "No";
                submissionRow[".c File Compiled"] = whatToWrite;



                if (sub.exePath != null) //Making sure there's a correct path in submitted .exe path (there's no path <2).
                    whatToWrite = "Yes";
                else
                    whatToWrite = "No";
                submissionRow[".exe File Submitted"] = whatToWrite;


                
                submissionRow["Success Rate"] = sub.CorrectResultsPercentage();


                if (codeWeight == -1)
                    whatToWrite = "N/A";
                else
                    whatToWrite = sub.finalGrade.ToString();
                submissionRow["Grade"] = whatToWrite;


                if (sub.possibleCheating)
                    whatToWrite = "Yes";
                else
                    whatToWrite = "";
                submissionRow["Possible Cheating"] = whatToWrite;                



                rdt.Rows.Add(submissionRow);
            }

            return rdt;
        }

        //Creates a new folder with a detailed text file for each submissions.
        public static void SaveDetailedResults(string zipPath)
        {       
            //Do not use this yet.
            //File.WriteAllText(Path.GetDirectoryName(zipPath)+@"\info.txt", createText); 
        }
    }
}
