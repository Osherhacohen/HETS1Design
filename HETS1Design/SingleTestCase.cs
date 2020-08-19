using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HETS1Design
{
    class SingleTestCase
    {
        private string input { set; get; } //Input for test case.
        private string output { set; get; } //Output for test case given input.
        private bool equal { set; get; } //Whether the output needs to be equal or NOT equal given the input.  
        private bool hasBoundInText { set; get; }
        private bool hasEQPartInText { set; get; }


        public SingleTestCase(string input, string output, bool equal)
        {
            this.input = input;
            this.output = output;
            this.equal = equal;
            if (BoundaryScan(input))
                hasBoundInText = true;
            else
                hasBoundInText = false;

            if (EQPartScan(input))
                hasEQPartInText = true;
            else
                hasEQPartInText = false;
        }

        bool CompareOutput(string resultOutput)
        {
            if (this.output == resultOutput)
                return this.equal && true; //Returns true only if it's both equal AND it supposed to be equal.

            else return !this.equal; //Returns true when it's NOT supposed to be equal and false where it's supposed to be but isn't.            
        }

        private bool BoundaryScan(string input) //scans if there are Boundary values
        {
            //Write this
            return false;
        }

        private bool EQPartScan(string input) //scans if there are Boundary values
        {
            //Write this
            return false;
        }

        private List<SingleTestCase> ReturnBoundaryTestCases(string input)
        {
            //Takes one (the first to scan) boundary syntax and multiply the test case by 5 with the boundary input range. (5 __[TC])
            //Multiplies the rest of the text including other boundary syntax and returns a list of 5 test cases with same output
            //but input according to boundary range. (lower limit, 1 above lower limit, middle, one below upper limit, upper limit)
            return null;
        }

        private List<SingleTestCase> ReturnEQPartTestCases(string input)
        {
            //Takes one (the first to scan) boundary syntax and multiply the test case by 7 with the boundary input range. (2_ [TNC], 5 __[TC])
            //Multiplies the rest of the text including other boundary syntax and returns a list of 7 test cases with same output
            //but input according to boundary range. (TC: lower limit, 1 above lower limit, middle, one below upper limit, upper limit)
            //(TNC: 1 below lower limit, 1 above upper limit):
            return null;
        }


    }
}
