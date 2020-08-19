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
        so that means __[TCslkdjvhlksjdhv] is also a legal TC name, for the convenience of the user)*/

        public TestCases(string inputFileContent, string outputFileContent)
        {
            //Separation to Test Cases will be done here
        }

        List<SingleTestCase> testCases; //List of test cases. We'll add the separated test cases here and it'll be possible to add to it with Append.

        public int CountTestCases(string fileToCheck)
        {
            /*This function should count and return the amount of special characters in each of the files.
             We'll then use it in the construct to make sure the files have the same amount of test cases
             like this: if(CountTestCases(inputFileContent)==CountTestCases(outputFileContent)) then continue...
             We'll also use it to decide the left index size of testCases 2D array.*/
            return 0;
        }

        public int BoundaryAndEquivalencePartitionining(string inputFile)
        {
            /*This function needs to be used before  */
            return 0;
        }

        public string[] TestCasesSeparator()
        {
            /*This function will separate each */
            return null;
        }

        
    }
}
