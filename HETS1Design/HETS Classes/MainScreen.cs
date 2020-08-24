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
using System.Diagnostics.CodeAnalysis;

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
            string validateOk = MainScreenLogic.FormValidate(this.txtArchivePath);
            if (validateOk.CompareTo("OK") != 0)
                MessageBox.Show(validateOk, "Error");

            MainScreenLogic.CompileHelper(btnCompile);


            if (Submissions.ActivateCompilation()) //Both run and check that it finished running.
                this.btnCompile.Text = "Compile Programs";
        }


        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            string validateOk = MainScreenLogic.FormValidate(this.txtArchivePath);
            if (validateOk.CompareTo("OK") != 0)
                MessageBox.Show(validateOk, "Error");

            MainScreenLogic.RunHelper(btnRunProgram);

            if (Submissions.ActivateExecution()) //Both run and check that it finished running.
                this.btnRunProgram.Text = "Run Programs";
        }


        private void btnResults_Click(object sender, EventArgs e)
        {
            MainScreenLogic.ShowResults(textBoxTEMPORARY, txtArchivePath);
        }

        private void btnDetailedResults_Click(object sender, EventArgs e)
        {
            //TODO: Per submission test case results (Input/Output/Desired Output/Matching?)
            //Add it in another folder called "Detailed Results"
        }




        private void btnBrowseArchive_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareDialog("ZIP Archive files (*.zip)|*.zip|All files (*.*)|*.*", openArchiveDialog);
            //openArchiveDialog.Filter = "ZIP Archive files (*.zip)|*.zip|All files (*.*)|*.*";
            //openArchiveDialog.ShowDialog();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareDialog("Text files (*.txt)|*.txt|All files (*.*)|*.*", openInputDialog);
            //openInputDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //openInputDialog.ShowDialog();
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareDialog("Text files (*.txt)|*.txt|All files (*.*)|*.*", openOutputDialog);
            //openOutputDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //openOutputDialog.ShowDialog();
        }


        private void openArchiveDialog_FileOk(object sender, CancelEventArgs e)
        {
            MainScreenLogic.OpenArchiveFile(openArchiveDialog, txtArchivePath);
        }



        private void openInputDialog_FileOk(object sender, CancelEventArgs e)
        {
            MainScreenLogic.OpenInputFile(this.openInputDialog, this.txtInputPath, this.txtOutputPath);
        }

        private void openOutputDialog_FileOk(object sender, CancelEventArgs e)
        {
            MainScreenLogic.OpenOutputFile(this.openOutputDialog, this.txtOutputPath, this.txtInputPath);
        }



        private void menuCodeWeight_ValueChanged(object sender, EventArgs e)
        {
            MainScreenLogic.LimitWeightsChange(this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight);
        }

        private void menuExeGrade_ValueChanged(object sender, EventArgs e)
        {
            MainScreenLogic.LimitWeightsChange(this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight);
        }

        private void menuResultsGrade_ValueChanged(object sender, EventArgs e)
        {
            MainScreenLogic.LimitWeightsChange(this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight);
        }

        private void checkBoxEnableGrading_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.EnableGradingCheckedChange(this.checkBoxEnableGrading, this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight);
        }

        private void radioButton64BitCompiler_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.Option64BitCompilerChange();
        }

        private void radioButton32BitCompiler_CheckedChanged(object sender, EventArgs e)
        {
            MainScreenLogic.Option32BitCompilerChange();
        }


        private void timeoutNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            MainScreenLogic.TimeoutValueChange(timeoutNumUpDown);
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







        /************************************************************/
        //DEBUGGING PURPOSES ONLY - DELETE THIS LATER
        /************************************************************/
    }
}
