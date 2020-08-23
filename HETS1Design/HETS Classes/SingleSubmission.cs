using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HETS1Design
{
    public class SingleSubmission
    {

        public string submitID { get; private set; } //Submission folder name. 
        public string codePath { get; private set; } //.c file.
        public bool codeExists { get; private set; } 
        public string compilerOutput { get; private set; } //Errors/Warnings from the compiler.
        public string exePath { get; private set; } //.exe file.
        public string compiledExePath { get; private set; } //.exe file made by our compiler.
        public bool exeExists { get; private set; }
        public bool possibleCheating { get; private set; }
        public List<OutputResult> submittedProgramOutputs { get; private set; } //Program output per test case.          
        public List<OutputResult> compiledProgramOutputs { get; private set; } //In case we have 2 exe files, compiled one and attached one
        public double grade { get; private set; } //Final grade.

        /*Every submission must have an ID, paths will be added only if an ID exists. 
        (On a new submission creation there's no code/exe files yet)*/
        public SingleSubmission(string submitID) 
        {
            this.submitID = Path.GetFileName(submitID);
            codeExists = false;
            exeExists = false;
            possibleCheating = false;
            submittedProgramOutputs = new List<OutputResult>(); //Program output per test case.          
            compiledProgramOutputs = new List<OutputResult>();
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


        //Since RunExe returns the results string, we run it and right after add it to the result list.
        public void RunSubmittedProgram()
        {
            if (exeExists)
            {
                if(TestCases.testCases.Count!=0)
                foreach (SingleTestCase tc in TestCases.testCases)
                {
                        if (File.Exists(exePath))
                        {
                            string outputResults = CodeChecker.RunEXE(exePath, tc.input);
                            submittedProgramOutputs.Add(new OutputResult(outputResults));
                        }
                        if (File.Exists(compiledExePath))
                        {
                            string outputResults = CodeChecker.RunEXE(compiledExePath, tc.input);
                            compiledProgramOutputs.Add(new OutputResult(outputResults));
                        }
                }

                if (File.Exists(exePath) && File.Exists(compiledExePath))
                    possibleCheating = !CompareBothLists(); //If the 2 lists are different, there might be a possible cheating. Check manually.

            }
        }

        //Compares result to an output.
        public void CompareResultsToDesiredResults()
        {
            if (exeExists)
            {
                int i = 0;
                foreach (SingleTestCase tc in TestCases.testCases)
                {
                    //Compare the desired result output in test case to actual result.
                    if (submittedProgramOutputs.Count!=0)
                    {
                        if (tc.CompareOutput(submittedProgramOutputs[i].GetResultOutput)) //If the result matches the TC/TNC output.
                            submittedProgramOutputs[i].Match();
                        else
                            submittedProgramOutputs[i].Mismatch();
                    }
                    if (compiledProgramOutputs.Count != 0)
                    {
                        if (tc.CompareOutput(compiledProgramOutputs[i].GetResultOutput)) //If the result matches the TC/TNC output.
                            compiledProgramOutputs[i].Match();
                        else
                            compiledProgramOutputs[i].Mismatch();
                    }
                    i++;
                }
            }
        }

        

        //Check possible cheating when comparing submitted .exe results to compiled .exe results.
        public bool CompareBothLists()
        {
            if (submittedProgramOutputs.Count == compiledProgramOutputs.Count) 
            {
                for (int i = 0; i < submittedProgramOutputs.Count;i++)
                    if (submittedProgramOutputs[i].GetResultOutput != compiledProgramOutputs[i].GetResultOutput)
                    {
                        return false; //Lists are different (possible cheating).
                    } 
                return true; //Both lists are the same.
            }
            return false;
        }

        //Count the amount of matching results in the list.
        public double ResultsVsCorrectResults()
        {
            int count = 0;
            if (submittedProgramOutputs.Count > 0)
            {
                foreach (OutputResult result in submittedProgramOutputs)
                    if (result.DidItMatch)
                        count++;
                return count / submittedProgramOutputs.Count;
            }

            if (compiledProgramOutputs.Count > 0)
            {
                foreach (OutputResult result in compiledProgramOutputs)
                    if (result.DidItMatch)
                        count++;
                return count / compiledProgramOutputs.Count;
            }

            return count;

        }


        //NOT WORKING YET - FIX THIS 
        //**************************************
        //This is a grading function that goes by weight. First two 
        public void Grading(int codeWeight, int exeWeight, int correctResultsWeight) 
        {
            if ((!codeExists)&& (! exeExists))
            {
                grade = 0;
            }
            else
            {
                if (!possibleCheating) //We made sure that they're both the same list of results from .exe files.
                {
                    double resultGrade = (ResultsVsCorrectResults()) * (correctResultsWeight / 100);
                    double exeGrade =0;
                    double codeGrade =0;
                    if (codeExists)
                        codeGrade = codeWeight/100;
                    if (exeExists)
                        exeGrade = exeWeight/100;
                    grade = resultGrade + exeGrade + codeGrade;
                }

            }
        }

    }
}
