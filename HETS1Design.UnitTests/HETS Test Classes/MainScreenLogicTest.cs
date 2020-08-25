using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Windows.Forms;

namespace HETS1Design.UnitTests
{
    [TestClass]
    public class MainScreenLogicTest
    {
        TextBox txtArchivePath;
        Button btnBrowseArchive;
        Button btnSaveIO;
        RadioButton radioTNC;
        RadioButton radioTC;
        TextBox txtOutputAppend;
        TextBox txtInputAppend;
        Button btnAddTestCase;
        TextBox txtOutputPath;
        Button btnBrowseOutput;
        Button btnBrowseInput;
        TextBox txtInputPath;
        GroupBox groupBox3;
        RadioButton radioBtnExecutable;
        RadioButton radioBtnCode;
        RadioButton radioBtnBothExeAndCode;
        RadioButton radioButton32BitCompiler;
        RadioButton radioButton64BitCompiler;
        Button btnCompile;
        Button btnResults;
        TextBox textBoxTEMPORARY;
        Button btnExportCSV;
        OpenFileDialog openArchiveDialog;
        OpenFileDialog openInputDialog;
        OpenFileDialog openOutputDialog;
        SaveFileDialog saveCSVFile;
        CheckBox checkBoxEnableGrading;
        NumericUpDown menuResultsWeight;
        NumericUpDown menuExeWeight;
        NumericUpDown menuCodeWeight;
        NumericUpDown timeoutNumUpDown;
        Button btnRunProgram;
        Button btnDetailedResults;
        DataGridView dataGridResults;
        [TestInitialize]
        public void TestInit()
        {
            txtArchivePath = new System.Windows.Forms.TextBox();
            btnBrowseArchive = new System.Windows.Forms.Button();
            btnSaveIO = new System.Windows.Forms.Button();
            radioTNC = new System.Windows.Forms.RadioButton();
            radioTC = new System.Windows.Forms.RadioButton();
            txtOutputAppend = new System.Windows.Forms.TextBox();
            txtInputAppend = new System.Windows.Forms.TextBox();
            btnAddTestCase = new System.Windows.Forms.Button();
            txtOutputPath = new System.Windows.Forms.TextBox();
            btnBrowseOutput = new System.Windows.Forms.Button();
            btnBrowseInput = new System.Windows.Forms.Button();
            txtInputPath = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            radioBtnExecutable = new System.Windows.Forms.RadioButton();
            radioBtnCode = new System.Windows.Forms.RadioButton();
            radioBtnBothExeAndCode = new System.Windows.Forms.RadioButton();
            radioButton32BitCompiler = new System.Windows.Forms.RadioButton();
            radioButton64BitCompiler = new System.Windows.Forms.RadioButton();
            btnCompile = new System.Windows.Forms.Button();
            btnResults = new System.Windows.Forms.Button();
            textBoxTEMPORARY = new System.Windows.Forms.TextBox();
            btnExportCSV = new System.Windows.Forms.Button();
            openArchiveDialog = new System.Windows.Forms.OpenFileDialog();
            openInputDialog = new System.Windows.Forms.OpenFileDialog();
            openOutputDialog = new System.Windows.Forms.OpenFileDialog();
            saveCSVFile = new System.Windows.Forms.SaveFileDialog();
            checkBoxEnableGrading = new System.Windows.Forms.CheckBox();
            menuResultsWeight = new System.Windows.Forms.NumericUpDown();
            menuExeWeight = new System.Windows.Forms.NumericUpDown();
            menuCodeWeight = new System.Windows.Forms.NumericUpDown();
            timeoutNumUpDown = new System.Windows.Forms.NumericUpDown();
            btnRunProgram = new System.Windows.Forms.Button();
            btnDetailedResults = new System.Windows.Forms.Button();
            dataGridResults = new System.Windows.Forms.DataGridView();
        }

        [TestMethod]
        public void OnButtonAddTestCaseClickTest()
        {
            


            
            radioTC.Checked = true;
            radioTNC.Checked = false;

          //  MainScreenLogic.OnButtonAddTestCaseClick(radioTC, radioTNC, input, output);
        }
    }
}
