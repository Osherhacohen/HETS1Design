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
    /*We are excluding this from code coverage since we'll be testing these functions in
     MainScreenLogic class.*/
    [ExcludeFromCodeCoverage]
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            MainScreenLogic.OnMainScreenLoad(this.menuCodeWeight, this.menuExeWeight, this.menuResultsWeight);
        }

        private void MainScreen_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MainScreenLogic.DisplayGuideHelpBox();
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


        private void btnSaveIO_Click(object sender, EventArgs e)
        {
            MainScreenLogic.OnButtonSaveIOClick(this.txtInputPath, this.txtOutputPath);
            
        }

        private void btnAddTestCase_Click(object sender, EventArgs e)
        {
            MainScreenLogic.OnButtonAddTestCaseClick(this.radioTC, this.radioTNC, this.txtInputAppend, this.txtOutputAppend);
        }


            private void btnBrowseArchive_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareFileDialog("ZIP Archive files (*.zip)|*.zip|All files (*.*)|*.*", openArchiveDialog);
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareFileDialog("Text files (*.txt)|*.txt|All files (*.*)|*.*", openInputDialog);
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            MainScreenLogic.PrepareFileDialog("Text files (*.txt)|*.txt|All files (*.*)|*.*", openOutputDialog);
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
    }
}
