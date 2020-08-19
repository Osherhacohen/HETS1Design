using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HETS1Design
{
    class SingleSubmission
    {

        public string submitID { get; private set; } //We'll take the number from the foldername (may add name in possible, not sure since it's in Hebrew)
        public string codePath { get;  set; } //Each submission will have either both .c or .exe file or just one of them.
        public bool codeExists { get; private set; } //Does code exist?
        public string exePath { get;  set; } //Each submission will have either both .c or .exe file or just one of them. 
        public bool exeExists { get; private set; } //Does execution file exist?
        List<string> resultOutput; //Output per test case.         
        double grade; //We'll grade it by percentage

        public SingleSubmission(string submitID) //For when we have none of the files. (Grade =0);
        {
            //Run compilation/running/grading functions.
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
                //Grading function for later
        }

    }
}
