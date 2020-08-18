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
        public static void CompileCode()//string codeFilePath)
        {
            //Path from bin to tcc: ..\\..\\..\\Assets\\tcc\\tcc.exe


            //string codeName = "Source"; 
            //string codePath = "..\\..\\..\\Assets\\CodeToCheck";
            //string command = "cd " + codePath+"&"+"..\\tcc\\tcc.exe "+codeName+".c"; //This is with CMD usage
            //ProcessStartInfo psi = new ProcessStartInfo("cmd", " /k "+ command); // This is with CMD usage


            ProcessStartInfo psi = new ProcessStartInfo("..\\..\\..\\Assets\\tcc\\tcc.exe","Source.c");
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.WorkingDirectory = "..\\..\\..\\Assets\\CodeToCheck";

            Process p = new Process();
            p.StartInfo = psi;
            
            p.Start();


            //return codePath + "\\" + codeName + ".exe";

        }

        /*Trying to run the EXE file with i/o doesn't work yet*/
        public static void RunEXE()//string codeFilePath, string inFilePath)
        {

            //string codeName = "Source";
            //string codePath = "..\\..\\..\\Assets\\CodeToCheck";
            //string command = "cd " + codePath;// + "&" + codeName + ".exe";
            //ProcessStartInfo psi = new ProcessStartInfo("cmd", " /k " + command);


            ProcessStartInfo psi = new ProcessStartInfo("..\\..\\..\\Assets\\CodeToCheck\\Source.exe");
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.WorkingDirectory = "..\\..\\..\\Assets\\CodeToCheck\\";

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
    }
}
