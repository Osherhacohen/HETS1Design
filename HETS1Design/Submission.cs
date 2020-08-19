using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HETS1Design
{
    class Submission
    {
        string submissionPath; 
        string submitID; //We'll take the number from the foldername (may add name in possible, not sure since it's in Hebrew)
        string codePath; //Each submission will have either both .c or .exe file or just one of them.
        string exePath;  
        string[] resultOutput; //Output per test case.        

        double grade; //?? maybe, may do per correct output line.
    }
}
