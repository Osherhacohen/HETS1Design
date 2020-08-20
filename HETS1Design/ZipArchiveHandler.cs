using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HETS1Design
{
    static class ZipArchiveHandler
    {
        public static void GetSubmissionData(string zipFile)
        {
            //Open ZIP Archive with Hebrew encoding.
            ZipArchive zip = new ZipArchive(File.OpenRead(zipFile), ZipArchiveMode.Read, false, Encoding.GetEncoding("cp862"));

            string ctcFolder = Path.GetDirectoryName(zipFile) + "\\CodesToCheck";

            //Make sure there's no conflict of existing CTC folder
            if (Directory.Exists(ctcFolder))
            {
                Directory.Delete(ctcFolder, true);
            }
                        
            Directory.CreateDirectory(ctcFolder); //Create CodesToCheck Folder

            foreach (ZipArchiveEntry zipEntry in zip.Entries) //This extracts the ZIP entries into directories in CodesToCheck Folder.
            {
                string newDirectory = ctcFolder + "\\" + Path.GetDirectoryName(zipEntry.FullName); //To avoid unassigned error.

                if (!(Directory.Exists(ctcFolder + "\\" + Path.GetDirectoryName(zipEntry.FullName)))) //If path isn't taken
                {
                    newDirectory = ctcFolder + "\\" + Path.GetDirectoryName(zipEntry.FullName);
                    Directory.CreateDirectory(newDirectory);    //Create a directory for a submission. Its name will serve as ID.

                    Submissions.submissions.Add(new SingleSubmission(newDirectory)); //New directory = new submission.
                }

                if (zipEntry.FullName.Substring(Math.Max(0, zipEntry.FullName.Length - 2)) == ".c") //If extension is .c
                {
                    string codePath = newDirectory + "\\" + Path.GetFileName(zipEntry.FullName);
                    zipEntry.ExtractToFile(codePath);

                    Submissions.submissions[Submissions.submissions.Count - 1].codePath = codePath; //Always edit the newest Submission entry.
                }

                if (zipEntry.FullName.Substring(Math.Max(0, zipEntry.FullName.Length - 4)) == ".exe") //If extension is .exe
                {
                    string exePath = newDirectory + "\\" + Path.GetFileName(zipEntry.FullName);
                    zipEntry.ExtractToFile(exePath);

                    Submissions.submissions[Submissions.submissions.Count - 1].exePath = exePath;  //Always edit the newest Submission entry.
                }


            }

            zip.Dispose(); //Dispose once our data is in place.

        }

}
    
}
