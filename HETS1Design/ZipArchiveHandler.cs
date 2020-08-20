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
        //This funtion extracts .c, .h and .exe files from an archive file and saves their paths in a SingleSubmission. 
        //zipFile is the zip path.  isMasterZipDirectory indicates whether it's the master or inner (Zip in a zip) zip directory.
        public static void GetSubmissionData(string zipFile, bool isMasterZipDirectory)
        {
            //Open ZIP Archive with Hebrew encoding.
            ZipArchive zip = new ZipArchive(File.OpenRead(zipFile), ZipArchiveMode.Read, false, Encoding.GetEncoding("cp862"));


            string extractToFolderName; //The name of the folder that will hold our extracted files.

            //Names the folder to extract into. Master zip is Codes To Check and inner zip keeps its original name. 
            if (isMasterZipDirectory) 
                extractToFolderName = "\\Codes To Check"; 
            else
                extractToFolderName = "\\"+ Path.GetFileName(zipFile).Substring(0,Path.GetFileName(zipFile).Length-4); //Removes ".zip" from the name.


            string extractToFolder = Path.GetDirectoryName(zipFile) + extractToFolderName; //Full path of the folder/directory.


            //Makes sure there's no conflict with an existing folder.
            if (Directory.Exists(extractToFolder))
            {
                Directory.Delete(extractToFolder, true);
            }

            Directory.CreateDirectory(extractToFolder); //Creates the folder, this needs the full path.

            foreach (ZipArchiveEntry zipEntry in zip.Entries) //This extracts the ZIP entries into directories in CodesToCheck Folder.
            {
                string newDirectory = extractToFolder + "\\" + Path.GetDirectoryName(zipEntry.FullName); //To avoid unassigned error.
                
                if (!(Directory.Exists(extractToFolder + "\\" + Path.GetDirectoryName(zipEntry.FullName)))) //If that directory doesn't exist yet.
                {
                    newDirectory = extractToFolder + "\\" + Path.GetDirectoryName(zipEntry.FullName);
                    Directory.CreateDirectory(newDirectory);    //Create a directory for a submission. Its name will serve as ID.

                    Submissions.submissions.Add(new SingleSubmission(newDirectory)); //New directory = new submission.
                }

                string _2CharExtention = zipEntry.FullName.Substring(Math.Max(0, zipEntry.FullName.Length - 2)); //File extension.

                if (_2CharExtention == ".c"|| _2CharExtention == ".h") //If extension is .c (c code) or .h (c header).
                {
                    string codePath = newDirectory + "\\" + Path.GetFileName(zipEntry.FullName);
                    zipEntry.ExtractToFile(codePath);

                    Submissions.submissions[Submissions.submissions.Count - 1].codePath = codePath; //Always edit the newest Submission entry.
                }


                string _4CharExtension = zipEntry.FullName.Substring(Math.Max(0, zipEntry.FullName.Length - 4)); //File extension.

                if (_4CharExtension == ".exe") //If extension is .exe
                {
                    string exePath = newDirectory + "\\" + Path.GetFileName(zipEntry.FullName);
                    zipEntry.ExtractToFile(exePath);

                    Submissions.submissions[Submissions.submissions.Count - 1].exePath = exePath;  //Always edit the newest Submission entry.
                }

                if (_4CharExtension == ".zip") //If extension is .zip, unfortunately this may create a long path with a new CTC folder.
                {
                    string innerZipPath = newDirectory + "\\" + Path.GetFileName(zipEntry.FullName);
                    zipEntry.ExtractToFile(innerZipPath);
                    GetSubmissionData(innerZipPath, false); //Recursive call. This is an inner zip, we pass false here.
                    File.Delete(innerZipPath);                    
                }

            }

            zip.Dispose(); //Dispose once our data is in place.

        }

}
    
}
