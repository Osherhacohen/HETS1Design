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
        string submitID;
        string codePath; //It's either both .c/exe or 
        string exePath; //just one of them.
        string[] output; //Output per test case.

        double grade; //?? maybe, may do per correct output line.
    }
}
