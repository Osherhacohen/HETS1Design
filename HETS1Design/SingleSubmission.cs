using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HETS1Design
{
    class SingleSubmission
    {
        string submissionPath; 
        string submitID; //We'll take the number from the foldername (may add name in possible, not sure since it's in Hebrew)
        bool codeExists;
        string codePath { get; set; } //Each submission will have either both .c or .exe file or just one of them.
        bool exeExists;
        string exePath;  
        string[] resultOutput; //Output per test case.    
        

        double grade; //?? maybe, may do per correct output line.


    }
}
