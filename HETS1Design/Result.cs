using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HETS1Design
{
    class Result
    {
        public string ResultOutput { get; private set; }
        public bool DidItMatch { get; private set; }
        private bool chosenAlready; //Can use Match or Mismatch only once.

        public Result(string resultOutput)
        {
            this.ResultOutput = resultOutput;
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
