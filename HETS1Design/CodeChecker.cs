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
    static class CodeChecker //Prototype of C code compilation.
    {
        static string compilerPath64 = @"..\..\..\Assets\tcc\tcc.exe"; //We'll need to make sure this is the right directory later on build.        
        static string compilerPath32 = @"..\..\..\Assets\tcc\i386-win32-tcc.exe";

        public static string CompileCode(string codeFilePath)  //We'll need to pass a path into this function (Including file name).
        {
            string cFileName = Path.GetFileName(codeFilePath);
            string directoryName = Path.GetDirectoryName(codeFilePath);
            string compilerPath=compilerPath64;

            if (Submissions.use32bitCompiler) //If tester chose the 32 bit version of the compiler.
            {
                compilerPath = compilerPath32;
            }

            ProcessStartInfo psi = new ProcessStartInfo(compilerPath, cFileName);
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.RedirectStandardError = true;
            psi.WorkingDirectory = directoryName; //Set process' working directory.

            Process p = new Process();
            p.StartInfo = psi;            
            p.Start();

            string compilerOutput = "No errors or warnings detected."; //If compiler doesn't have anything to complain about.
            using (StreamReader sr = p.StandardError)
            {
                if (sr.BaseStream.CanRead)
                {
                    compilerOutput = sr.ReadToEnd();
                }
            }
                return compilerOutput;
        }

      
        public static void RunEXE()//string exeFilePath, SingleTestCase inputTestCase) //We'll need to get a path and a test case in here.
        {


            ProcessStartInfo psi = new ProcessStartInfo(@"..\..\..\Assets\CodeToCheck\Source.exe");
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.WorkingDirectory = @"..\..\..\Assets\CodeToCheck";

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
