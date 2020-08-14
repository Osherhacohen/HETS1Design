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

namespace HETS1Design
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();            
        }
       // #region GUI
        private void MainScreen_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("File I/O:\n\nUse :case: before every case of I/O\nUse :notcase: if you want the program output to NOT match the text output.\n\nGUI Textbox I/O:\n\nYou are also able to append test cases to your I/O files, this will create a new file with the new use cases.\n\nIn addition, you may use boundary test cases in the GUI append function:\n\nUse :boundary: <Minimum value> <Maximum value> (They must be different)\nbefore an input line to add boundary test cases. \nEvery line with :boundary: will create 7 additional test cases in the new file; 3 for Min boundary, 3 for Max boundary and 1 for Opt case.\nYou must make sure that cases lower than min or higher than max have different value than input", "User guide");
            //This is probably recursion, careful here. IF NEEDED LIMIT BOUNDARY TO ONE PER CASE.
        }

        //CHANGE BUTTUB NAME
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string validateOk = FormValidate();
            if (validateOk.CompareTo("OK") != 0)
                MessageBox.Show(validateOk, "Error");
        }
       // #endregion
        private string FormValidate()
        {
            if (txtArchivePath.Text == "")
                return "Choose archive file to continue!";
            if (txtInputPath.Text == "") 
                return "Choose input test case file to continue!";
            if (txtOutputPath.Text == "")
                return "Choose output test case file to continue!";
            /*TODO: Radio button logics*/
            return "OK";
        }
        

        private void btnBrowseArchive_Click(object sender, EventArgs e)
        {
            openArchiveDialog.Filter = "ZIP Archive files (*.zip)|*.zip|All files (*.*)|*.*";
            openArchiveDialog.ShowDialog();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            openInputDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openInputDialog.ShowDialog();
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            openOutputDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openOutputDialog.ShowDialog();
        }

        
        private void openArchiveDialog_FileOk(object sender, CancelEventArgs e)
        {

            try
            {

                string zipFile = openArchiveDialog.FileName;
                this.txtArchivePath.Text = openArchiveDialog.FileName;
                //ZipArchive zip=ZipFile.OpenRead(zipFile);

                //Had to open with correct Hebrew encoding so we won't get Gibbreish
                ZipArchive zip = new ZipArchive(File.OpenRead(zipFile), ZipArchiveMode.Read, false, Encoding.GetEncoding("cp862"));
                
                //var cCodeArray; //Array of code files. Maybe not needed?
                //var exeArray; //Array of exe files. Maybe not needed?


                { //This is just to test the zip entries
                    this.txtInputAppend.Text = "";
                    foreach (ZipArchiveEntry zipEntry in zip.Entries)
                        this.txtInputAppend.Text += zipEntry.FullName + "\n";
                } //************************************


                //Put all the things in classes and then do:
                //zipFile.Dispose();


                //some_buttons.Enabled = true; //Do this later

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void openInputDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string inputTextFile = openInputDialog.FileName;
                this.txtInputPath.Text = openInputDialog.FileName;
                //some_buttons.Enabled = true; //Do this later

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void openOutputDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string outputTextFile = openOutputDialog.FileName;
                this.txtOutputPath.Text = openOutputDialog.FileName;
                //some_buttons.Enabled = true; //Do this later

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
