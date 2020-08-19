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
        public static void CompileCode()//string codeFilePath)  //We'll need to pass a path into this function (Including file name).
        {
            string compilerPath = "..\\..\\..\\Assets\\tcc\\tcc.exe"; //We'll need to make sure this is the right directory later on build.

            string codeFilePath = "..\\..\\..\\Assets\\CodeToCheck\\Source.c"; //Just for now, it'll eventualy be passed to the function.

            string cFileName = Path.GetFileName(codeFilePath);
            string directoryName = Path.GetDirectoryName(codeFilePath);


            ProcessStartInfo psi = new ProcessStartInfo(compilerPath, cFileName); 
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.RedirectStandardError = true;
            psi.WorkingDirectory = directoryName; //Set process' working directory.

            Process p = new Process();
            p.StartInfo = psi;            
            p.Start();

            string compilerOutput;
            using (StreamReader sr = p.StandardError)
            {
                if (sr.BaseStream.CanRead)
                {
                    compilerOutput = sr.ReadToEnd();
                    MessageBox.Show(compilerOutput); //Example in a text box. We'll be comparing the results to the output file.                    
                }
            }
        }

      
        public static void RunEXE()//string exeFilePath, SingleTestCase inputTestCase) //We'll need to get a path and a test case in here.
        {


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



    }
}
