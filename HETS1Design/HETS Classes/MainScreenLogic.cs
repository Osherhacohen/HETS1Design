using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HETS1Design
{
    //This class will contain all the business logic for Main screen that is NOT an event type. 
    public static class MainScreenLogic
    {

        public static string FormValidate(TextBox txtArchivePath)
        {
            if (txtArchivePath.Text == "")
                return "Choose archive file to continue!";
            //if (txtInputPath.Text == "")
            //return "Choose input test case file to continue!";
            //if (txtOutputPath.Text == "")
            //return "Choose output test case file to continue!";
            return "OK";
        }
    }
}
