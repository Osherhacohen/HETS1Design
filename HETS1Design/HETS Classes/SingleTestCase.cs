using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HETS1Design
{
    public class SingleTestCase
    {
        public string input { private set; get; } //Input for test case.
        public string output { private set; get; } //Desired output for test case given input.
        public bool equal { private set; get; } //Whether the result output must be equal or NOT equal to desired output. (TC/TNC).
        public bool hasBoundInText { private set;  get; } 
        public bool hasEPInText { private set;  get; }


        //A single test case containts input, desired output and whether is TC ot TNC.
        public SingleTestCase(string input, string output, bool equal)
        {
            this.input = input;
            this.output = output;
            this.equal = equal;

            if (BoundaryScan(input)) //Check for special keywords.
                hasBoundInText = true;
            else
                hasBoundInText = false;

            if (EPScan(input))
                hasEPInText = true;
            else
                hasEPInText = false;
        }

        //Compares TC (desired) output to actual program output.
        public bool CompareOutput(string resultOutput)
        {
            if (this.output == resultOutput)
                return this.equal && true; //Returns true only if it's both equal AND it supposed to be equal.

            else return !this.equal; //Returns true when it's NOT supposed to be equal and false where it's supposed to be but isn't.            
        }

        //Scans if there are Boundary Values keywords
        private bool BoundaryScan(string input)
        {
            using (StringReader sr = new StringReader(input))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("__[Bound]"))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        //Scans if there are Equivalence Partitioning keywords
        private bool EPScan(string input) 
        {
            using (StringReader sr = new StringReader(input))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("__[EP]")) 
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        //***************************TODO AT SOME POINT

        //Leave this headache functions for later

        //***************************TODO AT SOME POINT

        public List<SingleTestCase> ReturnBoundaryTestCases() 
        {
            //Takes one (the first to scan) boundary syntax and multiply the test case by 5 with the boundary input range. (5 __[TC])  
            //or (5 __[TNC]) is it was originally TNC.
            //Multiplies the rest of the text including other boundary syntax and returns a list of 5 test cases with same output
            //but input according to boundary range. (lower limit, 1 above lower limit, middle, one below upper limit, upper limit)
            return null;
        }

        public List<SingleTestCase> ReturnEPTestCases()
        {
            //Takes one (the first to scan) boundary syntax and multiply the test case by 7 with the boundary input range. (2 __[TNC], 5 __[TC]) 
            //or if this current case was already TNC then (2 __[TC], 5 __[TNC]).
            //Multiplies the rest of the text including other boundary syntax and returns a list of 7 test cases with same output
            //but input according to boundary range. (TC: lower limit, 1 above lower limit, middle, one below upper limit, upper limit)
            //(TNC: 1 below lower limit, 1 above upper limit):

            //We can use ReturnBoundaryTestCases for this to create the middle 5 Test Cases and create 2 other cases.
            return null;
        }


    }
}
