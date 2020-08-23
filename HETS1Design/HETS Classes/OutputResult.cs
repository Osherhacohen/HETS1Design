using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HETS1Design
{
    public class OutputResult
    {
        public string GetResultOutput { get; private set; }
        public bool DidItMatch { get; private set; }
        private bool chosenAlready; //Can use Match or Mismatch only once.

        public OutputResult(string resultOutput)
        {
            this.GetResultOutput = resultOutput;
            DidItMatch = false; //We didn't choose whether it matches or not yet.
        }

        public void Match()
        {
            if (!(chosenAlready))
            {
                this.DidItMatch = true;
                chosenAlready = true;
            }
        }

        public void Mismatch()
        {
            if (!(chosenAlready))
            {
                this.DidItMatch = false;
                chosenAlready = true;
            }

        }

    }
}
