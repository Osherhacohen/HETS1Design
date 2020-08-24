using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace HETS1Design
{
    //This class will contain all the business logic for Main screen that is NOT an event type. 
    public static class MainScreenLogic
    {

        public static string FormValidate(TextBox txtArchivePath)
        {
            if (txtArchivePath.Text == "")
                return "Choose archive file to continue!";
            //if (txtInputPath.Text == "")
            //return "Choose input test case file to continue!";
            //if (txtOutputPath.Text == "")
            //return "Choose output test case file to continue!";
            return "OK";
        }

        public static void LimitWeightsChange(NumericUpDown menuCodeWeight, NumericUpDown menuExeWeight, NumericUpDown menuResultsWeight)
        {
            menuCodeWeight.Maximum = 100 - (menuExeWeight.Value + menuResultsWeight.Value);
            menuExeWeight.Maximum = 100 - (menuCodeWeight.Value + menuResultsWeight.Value);
            menuResultsWeight.Maximum = 100 - (menuExeWeight.Value + menuCodeWeight.Value);
        }

        public static void EnableGradingCheckedChange(CheckBox checkBoxEnableGrading, NumericUpDown menuCodeWeight, NumericUpDown menuExeWeight, NumericUpDown menuResultsWeight)
        {
            if (checkBoxEnableGrading.Checked)
            {
                menuCodeWeight.Enabled = true;
                menuExeWeight.Enabled = true;
                menuResultsWeight.Enabled = true;
            }
            else
            {
                menuCodeWeight.Enabled = false;
                menuExeWeight.Enabled = false;
                menuResultsWeight.Enabled = false;
            }

        }

        public static void CompileHelper(Button btnCompile)
        {
            btnCompile.Text = "Working on compilation...";
            btnCompile.Update();
        }

        public static void RunHelper(Button btnRunProgram)
        {
            btnRunProgram.Text = "Running programs...";
            btnRunProgram.Update();
        }

        public static void Option64BitCompilerChange()
        {
            CodeChecker.use32bitCompiler = false; //Default is 64
        }

        public static void Option32BitCompilerChange()
        {
            CodeChecker.use32bitCompiler = true;
        }

        public static void TimeoutValueChange(NumericUpDown timeoutNumUpDown)
        {
            CodeChecker.timeoutSeconds = (int)timeoutNumUpDown.Value;
        }

        public static void PrepareDialog(string conditions, OpenFileDialog openDialog)
        {
            openDialog.Filter = conditions;
            openDialog.ShowDialog();
        }

        public static void OpenArchiveFile(OpenFileDialog openArchiveDialog, TextBox txtArchivePath)
        {
            //try
            //{
            string zipFile = openArchiveDialog.FileName;
            txtArchivePath.Text = zipFile;
            ZipArchiveHandler.GetSubmissionData(zipFile, true); //Extract submissions data.
                                                                //some_buttons.Enabled = true; //Do this later******************************************************

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public static void OpenInputFile(OpenFileDialog openInputDialog, TextBox txtInputPath, TextBox txtOutputPath)
        {
            //try
            //{
            string inputTextFile = openInputDialog.FileName;
            txtInputPath.Text = openInputDialog.FileName;
            if (txtInputPath.Text != "" && txtOutputPath.Text != "")
            {
                TestCases.ResetTestCases();
                TestCases.ExtractTestCasesFromText(txtInputPath.Text, txtOutputPath.Text);
            }

            //some_buttons.Enabled = true; //Do this later

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public static void OpenOutputFile(OpenFileDialog openOutputDialog, TextBox txtOutputPath, TextBox txtInputPath)
        {
            //try
            //{
            string outputTextFile = openOutputDialog.FileName;
            txtOutputPath.Text = openOutputDialog.FileName;
            if (txtInputPath.Text != "" && txtOutputPath.Text != "")
            {
                TestCases.ResetTestCases();
                TestCases.ExtractTestCasesFromText(txtInputPath.Text, txtOutputPath.Text);
            }
            //some_buttons.Enabled = true; //Do this later

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public static void ShowResults(TextBox textBoxTEMPORARY, TextBox txtArchivePath)
        {
            textBoxTEMPORARY.Text = "";
            //This will be used to get the results table. (Currently string).
            textBoxTEMPORARY.Text += Submissions.GetAllSubmissionsResults(txtArchivePath.Text);

        }
    }
}
