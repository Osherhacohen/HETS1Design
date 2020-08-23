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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            this.menuCodeWeight.Enabled = false;
            this.menuExeWeight.Enabled = false;
            this.menuResultsWeight.Enabled = false;
        }

        private void MainScreen_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("File I/O:\n\nUse :case: before every case of I/O\nUse :notcase: if you want the program output to NOT match the text output.\n\nGUI Textbox I/O:\n\nYou are also able to append test cases to your I/O files, this will create a new file with the new use cases.\n\nIn addition, you may use boundary test cases in the GUI append function:\n\nUse :boundary: <Minimum value> <Maximum value> (They must be different)\nbefore an input line to add boundary test cases. \nEvery line with :boundary: will create 7 additional test cases in the new file; 3 for Min boundary, 3 for Max boundary and 1 for Opt case.\nYou must make sure that cases lower than min or higher than max have different value than input", "User guide");
            //This is probably recursion, careful here. IF NEEDED LIMIT BOUNDARY TO ONE PER CASE.
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            string validateOk = FormValidate();
            if (validateOk.CompareTo("OK") != 0)
                MessageBox.Show(validateOk, "Error");

            this.btnCompile.Text = "Working on compilation...";
            this.btnCompile.Update();
           
            if (Submissions.ActivateCompilation()) //Both run and check that it finished running.
                this.btnCompile.Text = "Compile Programs";

        }


        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            string validateOk = FormValidate();
            if (validateOk.CompareTo("OK") != 0)
                MessageBox.Show(validateOk, "Error");

            this.btnRunProgram.Text = "Running programs...";
            this.btnRunProgram.Update();

            if (Submissions.ActivateExecution()) //Both run and check that it finished running.
                this.btnRunProgram.Text = "Run Programs";
        }


        private void btnResults_Click(object sender, EventArgs e)
        {
            GetAllSubmissions(this.txtArchivePath.Text); //This will be used to get the results table.
        }

        private void btnDetailedResults_Click(object sender, EventArgs e)
        {
            //TODO: Per submission test case results (Input/Output/Desired Output/Matching?)
            //Add it in another folder called "Detailed Results"
        }

        private string FormValidate()
        {
            if (txtArchivePath.Text == "")
                return "Choose archive file to continue!";
            //if (txtInputPath.Text == "")
                //return "Choose input test case file to continue!";
            //if (txtOutputPath.Text == "")
                //return "Choose output test case file to continue!";
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

            //try
            //{
                string zipFile = openArchiveDialog.FileName;
                this.txtArchivePath.Text = zipFile;
                ZipArchiveHandler.GetSubmissionData(zipFile, true); //Extract submissions data.
                //some_buttons.Enabled = true; //Do this later******************************************************

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }



        private void openInputDialog_FileOk(object sender, CancelEventArgs e)
        {
            //try
            //{
                string inputTextFile = openInputDialog.FileName;
                this.txtInputPath.Text = openInputDialog.FileName;
                if (this.txtInputPath.Text != "" && this.txtOutputPath.Text != "")
                TestCases.ExtractTestCasesFromText(this.txtInputPath.Text, this.txtOutputPath.Text);

            //some_buttons.Enabled = true; //Do this later

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void openOutputDialog_FileOk(object sender, CancelEventArgs e)
        {
            //try
            //{
                string outputTextFile = openOutputDialog.FileName;
                this.txtOutputPath.Text = openOutputDialog.FileName;
                if (this.txtInputPath.Text != "" && this.txtOutputPath.Text != "")
                TestCases.ExtractTestCasesFromText(this.txtInputPath.Text, this.txtOutputPath.Text);
            //some_buttons.Enabled = true; //Do this later

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }


        private void LimitWeightsChange()
        {
            this.menuCodeWeight.Maximum = 100 - (this.menuExeWeight.Value + this.menuResultsWeight.Value);
            this.menuExeWeight.Maximum = 100 - (this.menuCodeWeight.Value + this.menuResultsWeight.Value);
            this.menuResultsWeight.Maximum = 100 - (this.menuExeWeight.Value + this.menuCodeWeight.Value);
        }

        private void menuCodeWeight_ValueChanged(object sender, EventArgs e)
        {
            LimitWeightsChange();
        }

        private void menuExeGrade_ValueChanged(object sender, EventArgs e)
        {
            LimitWeightsChange();
        }

        private void menuResultsGrade_ValueChanged(object sender, EventArgs e)
        {
            LimitWeightsChange();
        }

        private void checkBoxEnableGrading_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnableGrading.Checked)
            {
                this.menuCodeWeight.Enabled = true;
                this.menuExeWeight.Enabled = true;
                this.menuResultsWeight.Enabled = true;
            }
            else
            {
                this.menuCodeWeight.Enabled = false;
                this.menuExeWeight.Enabled = false;
                this.menuResultsWeight.Enabled = false;
            }
        }

        private void radioButton64BitCompiler_CheckedChanged(object sender, EventArgs e)
        {
            CodeChecker.use32bitCompiler = false; //Default is 64
        }

        private void radioButton32BitCompiler_CheckedChanged(object sender, EventArgs e)
        {
            CodeChecker.use32bitCompiler = true;
        }


        private void timeoutNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            CodeChecker.timeoutSeconds = (int)timeoutNumUpDown.Value;
        }


        /************************************************************/
        //Non-event functions.
        /************************************************************/
        public void AppendInputTXT(string input) //FOR DEBUGGING, DELETE THIS LATER***************
        {
            txtInputAppend.Text += input;
        }
        public void AppendOutputTXT(string output) //FOR DEBUGGING, DELETE THIS LATER****************
        {
            txtOutputAppend.Text += output;
        }



        public bool GetAllSubmissions(string zipPath) //We may turn this into the final csv file at some point.
        {
            string createText = "Compiler version: 64Bit\r\n\r\n";
            if (CodeChecker.use32bitCompiler)
                createText = "Compiler version: 32Bit\r\n\r\n";


            int i = 0;
            this.textBoxTEMPORARY.Text = "";

            foreach (SingleSubmission sub in Submissions.submissions)
            {
                createText += i.ToString() + ". ID: " + sub.submitID + "\r\n"
                    + "Code path: " + sub.codePath + "\r\n"
                    + "Exe path: " + sub.exePath + "\r\n"
                    + "Code exists: " + sub.codeExists + "\r\n"
                    + "Exe exists: " + sub.exeExists + "\r\n"
                    + "Compiler output: " + sub.compilerOutput +"\r\n" 
                    + "Compiled Exe path: " + sub.compiledExePath + "\r\n\r\n";
                if (sub.submittedProgramOutputs.Count != 0)
                    createText += "Submitted Exe result (first one): " + "\r\n" + sub.submittedProgramOutputs.Last().GetResultOutput + "\r\n"
                    + "Success rate of: " + ((sub.ResultsVsCorrectResults()*100).ToString())+"\r\n\r\n";
                if (sub.compiledProgramOutputs.Count != 0)
                    createText += "Compiled Exe result (first one): " + "\r\n" + sub.compiledProgramOutputs.Last().GetResultOutput + "\r\n"
                    + "Success rate of: " + ((sub.ResultsVsCorrectResults() * 100).ToString()) + "\r\n\r\n\r\n";
                i++;
            }

            this.textBoxTEMPORARY.Text += createText;
            //File.WriteAllText(Path.GetDirectoryName(zipPath)+@"\info.txt", createText);

            return true;
        }



        /************************************************************/
        //DEBUGGING PURPOSES ONLY - DELETE THIS LATER
        /************************************************************/
    }
}
