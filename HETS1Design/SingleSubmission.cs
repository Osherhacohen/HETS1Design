using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HETS1Design
{
    class SingleSubmission
    {

        public string submitID { get; private set; } //Submission folder name. 
        public string codePath { get; private set; } //.c file.
        public bool codeExists { get; private set; } 
        public string compilerOutput { get; private set; } //Errors/Warnings from the compiler.
        public string exePath { get; private set; } //.exe file.
        public string compiledExePath { get; private set; } //.exe file made by our compiler.
        public bool exeExists { get; private set; }
        List<string> resultOutput; //Program output per test case.          
        List<string> resultCompiledExeOPutput; //In case we have 2 exe files, compiled one and attached one
        double grade; //Final grade.

        /*Every submission must have an ID, paths will be added only if an ID exists. 
        (On a new submission creation there's no code/exe files yet)*/
        public SingleSubmission(string submitID) 
        {
            this.submitID = Path.GetFileName(submitID);
            codeExists = false;
            exeExists = false;
        }

        public void AddCode(string codePath)
        {
            this.codePath = codePath;
            if (codePath != null)
                codeExists = true;
        }

        public void AddExe(string exePath)
        {
            this.exePath = exePath;
            if (exePath != null)
                exeExists = true;
        }

        //Run this function from construct. Compile the .c code.
        //We don't pass an argument here since SingleSubmission it supposed to be contained in Submissions and it has the list.
        public void CompileSubmittedCode()
        {
            if (codeExists)
            {
                this.compilerOutput = CodeChecker.CompileCode(codePath);
                //If it succeeds, the new .exe file path should be this (replace ".c" with ".exe"):
                this.compiledExePath = codePath.Substring(0, codePath.Length - 2) + ".exe";
            }

            if (File.Exists(compiledExePath))
                this.exeExists = true; //If it works, then we have a code.
            else
                this.compiledExePath = null; //If the path doesn't exist (compilation failed), remove it from saved .exe path.
        }


        //Run this function from construct. Run the .exe file.
        /*We're passing a list argument here since we don't want the two types (Submissions/TestCases) to be dependent.
        This way, if this class is used in another program, it's always possible to pass a string list instead for example.*/
        public void RunSubmittedProgram(List<SingleTestCase> testCase) 
        {
            if (exeExists)
            {
                //Runs the submitted/compiled .exe from exePath, adds to results list.
            }
        }

        public void CompareResults()
        {

        }


        //Check possible cheating
        public bool CompareBothLists()
        {
            if (this.resultOutput.SequenceEqual<string>(this.resultCompiledExeOPutput))
                return true;
            return false;

            //Just in case
            /*IEnumerable<string> difference = a1.Except(a2);
            if (!difference.Any()) { }*/
        }


        //This is a grading function that goes by weight. First two 
        public void Grading(int codeWeight, int exeWeight, int correctResultsWeight) 
        {
            if (!(codeExists || exeExists))
            {
                grade = 0;
            }
            else
            {
                //Compute grade by wieghts.

            }
        }

    }
}
