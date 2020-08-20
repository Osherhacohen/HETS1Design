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
        public string codePath { get;  set; } //.c file.
        public bool codeExists { get; private set; } 
        public string exePath { get;  set; } //.exe file.
        public string compiledExePath { get; set; } //.exe file made by our compiler.
        public bool exeExists { get; private set; } 
        List<string> resultOutput; //Program output per test case.          
        double grade; //Final grade.

        //Every submission must have an ID, paths will be added only if an ID exists.
        public SingleSubmission(string submitID) 
        {
            //Run compilation/running/grading functions.
            this.submitID = Path.GetFileName(submitID);
        }



        //Run this function from construct. Compile the .c code.
        public void CompileSubmittedCode()
        {
            if (codeExists)
            {
                //Compiles the submitted code from codePath. Inserts exe file path to exePath after that.
            }
        }


        //Run this function from construct. Run the .exe file.
        public void RunSubmittedProgram()
        {
            if (exeExists)
            {
                //Runs the submitted/sompiled .exe from exePath.
            }
        }

        public void CompareResults()
        {
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
