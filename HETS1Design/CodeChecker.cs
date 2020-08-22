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
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
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

            p.Close();
            return compilerOutput;
        }

      
        public static string RunEXE(string exeFilePath, string input) //We'll need to get a path and a test case in here.
        {
            string exeFileName = Path.GetFileName(exeFilePath);
            string directoryName = Path.GetDirectoryName(exeFilePath);

            ProcessStartInfo psi = new ProcessStartInfo(exeFilePath);
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            psi.WorkingDirectory = directoryName; //Set process' working directory.

            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            string results="";
            using (StreamWriter sw = p.StandardInput)
            {

                if (sw.BaseStream.CanWrite)
                {
                    sw.Write(input);
                }
            }

            using (StreamReader sr = p.StandardError)
            {
                if (sr.BaseStream.CanRead)
                {
                    results += sr.ReadToEnd();                    
                }
            }

            if (results == "")
            {
                using (StreamReader sr = p.StandardOutput)
                {
                    if (sr.BaseStream.CanRead)
                    {
                        results = sr.ReadToEnd();
                    }
                }
            }
            p.Close();
            return results;
        }



    }
}
