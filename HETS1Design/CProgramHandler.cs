using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace HETS1Design
{
    static class CProgramHandler //Prototype of C code compilation.
    {
        public static void CompileCode()//string codeFilePath)
        {
            string codeName = "Source"; 
            string codePath = "..\\..\\..\\Assets\\CodeToCheck";

            //Path from bin to tcc: ..\\..\\..\\Assets\\tcc\\tcc.exe

            string command = "cd " + codePath+"&"+"..\\tcc\\tcc.exe "+codeName+".c";
            ProcessStartInfo psi = new ProcessStartInfo("cmd", " /k "+ command);

            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;


            Process p = new Process();
            p.StartInfo = psi;
            p.Start();


            //return codePath + "\\" + codeName + ".exe";

        }

        /*Trying to run the EXE file with i/o doesn't work yet*/
        public static void RunEXE()//string codeFilePath, string inFilePath)
            {

            string codeName = "Source";
            string codePath = "..\\..\\..\\Assets\\CodeToCheck";
            string command = "cd " + codePath;// + "&" + codeName + ".exe";
            ProcessStartInfo psi = new ProcessStartInfo("cmd", " /k " + command);

            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;


            Process p = new Process();
            p.StartInfo = psi;
            p.Start();


            using (StreamWriter sw = p.StandardInput)
            {

                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("3 2");
                }
            }

        }
    }
}
