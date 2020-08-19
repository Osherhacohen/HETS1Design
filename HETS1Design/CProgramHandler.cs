using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HETS1Design
{
    static class CProgramHandler //Prototype of C code compilation.
    {
        public static void CompileCode()//string codeFilePath)  //We'll need to get a path into this function (Including file name).
        {
            //Path from bin to tcc: ..\\..\\..\\Assets\\tcc\\tcc.exe


            //string codeName = "Source"; 
            //string codePath = "..\\..\\..\\Assets\\CodeToCheck";
            //string command = "cd " + codePath+"&"+"..\\tcc\\tcc.exe "+codeName+".c"; //This is with CMD usage
            //ProcessStartInfo psi = new ProcessStartInfo("cmd", " /k "+ command); // This is with CMD usage


            ProcessStartInfo psi = new ProcessStartInfo("..\\..\\..\\Assets\\tcc\\tcc.exe", "mtla3.c"); //tcc path will stay, file and current directory will change.
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.WorkingDirectory = "..\\..\\..\\Assets\\CodeToCheck";

            Process p = new Process();
            p.StartInfo = psi;
            
            p.Start();

            string compilerOutput;
            using (StreamReader sr = p.StandardOutput)
            {
                if (sr.BaseStream.CanRead)
                {
                    compilerOutput = sr.ReadToEnd();
                    //if (compilerOutput=="")
                   // MessageBox.Show("OK"); //Example in a text box. We'll be comparing the results to the output file.
                   // else
                    MessageBox.Show(compilerOutput); //Example in a text box. We'll be comparing the results to the output file.

                }
            }


            //return codePath + "\\" + codeName + ".exe";

        }

      
        public static void RunEXE()//string exeFilePath, SingleTestCase inputTestCase) //We'll need to get a path and a test case in here.
        {

            //string codeName = "Source";
            //string codePath = "..\\..\\..\\Assets\\CodeToCheck";
            //string command = "cd " + codePath;// + "&" + codeName + ".exe";
            //ProcessStartInfo psi = new ProcessStartInfo("cmd", " /k " + command);


            ProcessStartInfo psi = new ProcessStartInfo("..\\..\\..\\Assets\\CodeToCheck\\Source.exe");
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.WorkingDirectory = "..\\..\\..\\Assets\\CodeToCheck";

            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            string results;
            using (StreamWriter sw = p.StandardInput)
            {

                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("2 9"); //Example, we'll be directing a file into stream writer
                }
            }
            using (StreamReader sr = p.StandardOutput)
            {
                if (sr.BaseStream.CanRead)
                {
                    results = sr.ReadToEnd();
                    MessageBox.Show(results); //Example in a text box. We'll be comparing the results to the output file.
                }
            }

        }

        private static string GetCodeNameFromPath() //We'll use this in the above functions to get .c file name.
        {
            return null;

        }

        private static string GetDirectoryNameFromPath() //We'll use this in the above functions to get the path for code directory.
        {
            return null;
        }


    }
}
