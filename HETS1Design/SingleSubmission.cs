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
        List<Result> resultOutput = new List<Result>(); //Program output per test case.          
        List<Result> resultCompiledExeOutput=new List<Result>(); //In case we have 2 exe files, compiled one and attached one
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

        public List<Result> GetResultsSubmittedExe() //Temporary, we may return something else in another function instead
        { return resultOutput; } 
        public List<Result> GetResultsCompiledExe() //Temporary, we may return something else in another function instead
        { return resultCompiledExeOutput; }



        //Run this function from Start buttun. Compile the .c code.
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
        public void RunSubmittedProgram()//List<SingleTestCase> testCaseIn) //For now it's a string - we'll change later.
        {
            if (exeExists)
            {
                if(TestCases.testCases.Count!=0)
                foreach (SingleTestCase tc in TestCases.testCases)
                {
                    if (File.Exists(exePath))
                        resultOutput.Add(new Result(CodeChecker.RunEXE(exePath, tc.input)));
                    if (File.Exists(compiledExePath))
                        resultCompiledExeOutput.Add(new Result(CodeChecker.RunEXE(compiledExePath, tc.input)));
                }
            }
        }

        //Compares result to an output.
        public void CompareResults()
        {
            int i = 0;
            foreach (SingleTestCase tc in TestCases.testCases)
            {
                if (tc.CompareOutput(resultOutput[i].ResultOutput))
                    resultOutput[i].Match();
                else
                    resultOutput[i].Mismatch();
                i++;
            }
        }



        //Check possible cheating when comparing submitted .exe results to compiled .exe results.
        public bool CompareBothLists()
        {
            if (resultOutput.Count == resultCompiledExeOutput.Count) 
            {
                for (int i = 0; i < resultOutput.Count;i++)
                    if (resultOutput[i].ResultOutput != resultCompiledExeOutput[i].ResultOutput)
                    {
                        return false;
                    }
                return true;
            }
            return false;
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
