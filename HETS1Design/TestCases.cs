using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HETS1Design
{
    class TestCases
    {
        /*We obtain 2 files for i/o testing we'll need to make sure they have the same
        amount of test cases. We'll need special uncommon string that will separate test cases 
        for example: __[TC] (In this case anything that starts with __[TC will delete the whole 
        line and take the next lines as a input for a test case until the end of file or until next __[TC
        so that means __[TCslkdjvhlksjdhv] is also a legal TC name, for the convenience of the user).
        We'll also have __[TNC] for test cases where the result needs to be DIFFERENT than what's written
        on the output file.*/

        List<SingleTestCase> testCases; //List of test cases. We'll add the separated test cases here and it'll be possible to add to it with Append.


        public TestCases(string inputFileContent, string outputFileContent)
        {
            //Separation to Test Cases will be done here
        }


        /********************We need to think of the order in which we'll use these functions in the construct********************/


        public int CountTestCases(string fileToCheck)
        {
            /*This function should count and return the amount of special characters in each of the files.
             We'll then use it in the construct to make sure the files have the same amount of test cases
             like this: if(CountTestCases(inputFileContent)==CountTestCases(outputFileContent)) then continue...
             Counts both __[TC] and __[TNC]*/
            return 0;
        }
        

        public List<SingleTestCase> TestCasesSeparator(string inoroutFile)
        {
            /*This function will separate each */
            return null;
        }

        public void MultiplyTestCasesByBoundary(List<SingleTestCase> tc)
        {
            /*This goes over the list in a while loop as long as there's a test case with a TRUE value in 
            hasBoundInText If a test case has a TRUE in this, it will call ReturnBoundaryTestCases.
            Once it receives a list of the 5 test cases, it will add them to the list (AddRange) and remove the original
            test case that had the EQpartition=true, notice that SingleTestCase checks for that value*/
        }


        public void MultiplyTestCasesByEQPart(List<SingleTestCase> tc)
        {
            /*This goes over the list in a while loop as long as there's a test case with a TRUE value in  
            hasEQPartInText. If a test case has a TRUE in this, it will call ReturnEQPartTestCases.
            Once it receives a list of the 7 test cases, it will add them to the list (AddRange) and remove the original
            test case that had the EQpartition=true, notice that SingleTestCase checks for that value*/
        }





    }
}
