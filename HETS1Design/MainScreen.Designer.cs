namespace HETS1Design
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtArchivePath = new System.Windows.Forms.TextBox();
            this.btnBrowseArchive = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutputAppend = new System.Windows.Forms.TextBox();
            this.txtInputAppend = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCaseAppend = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioCheckByComp = new System.Windows.Forms.RadioButton();
            this.radioCompileNo = new System.Windows.Forms.RadioButton();
            this.radioCompileYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.openArchiveDialog = new System.Windows.Forms.OpenFileDialog();
            this.openInputDialog = new System.Windows.Forms.OpenFileDialog();
            this.openOutputDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveCSVFile = new System.Windows.Forms.SaveFileDialog();
            this.testCOMP = new System.Windows.Forms.Button();
            this.exeOutputBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuResultsGrade = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuExeGrade = new System.Windows.Forms.NumericUpDown();
            this.menuCodeWeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuResultsGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuExeGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCodeWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose archive file to check:";
            // 
            // txtArchivePath
            // 
            this.txtArchivePath.Location = new System.Drawing.Point(158, 16);
            this.txtArchivePath.Name = "txtArchivePath";
            this.txtArchivePath.ReadOnly = true;
            this.txtArchivePath.Size = new System.Drawing.Size(530, 20);
            this.txtArchivePath.TabIndex = 2;
            // 
            // btnBrowseArchive
            // 
            this.btnBrowseArchive.Location = new System.Drawing.Point(694, 13);
            this.btnBrowseArchive.Name = "btnBrowseArchive";
            this.btnBrowseArchive.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseArchive.TabIndex = 3;
            this.btnBrowseArchive.Text = "Browse...";
            this.btnBrowseArchive.UseVisualStyleBackColor = true;
            this.btnBrowseArchive.Click += new System.EventHandler(this.btnBrowseArchive_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowseArchive);
            this.groupBox1.Controls.Add(this.txtArchivePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files for checking";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutputAppend);
            this.groupBox2.Controls.Add(this.txtInputAppend);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnCaseAppend);
            this.groupBox2.Controls.Add(this.txtOutputPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBrowseOutput);
            this.groupBox2.Controls.Add(this.btnBrowseInput);
            this.groupBox2.Controls.Add(this.txtInputPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 189);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input/Output case files";
            // 
            // txtOutputAppend
            // 
            this.txtOutputAppend.Location = new System.Drawing.Point(397, 64);
            this.txtOutputAppend.Multiline = true;
            this.txtOutputAppend.Name = "txtOutputAppend";
            this.txtOutputAppend.Size = new System.Drawing.Size(372, 96);
            this.txtOutputAppend.TabIndex = 10;
            // 
            // txtInputAppend
            // 
            this.txtInputAppend.Location = new System.Drawing.Point(13, 64);
            this.txtInputAppend.Multiline = true;
            this.txtInputAppend.Name = "txtInputAppend";
            this.txtInputAppend.Size = new System.Drawing.Size(361, 96);
            this.txtInputAppend.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Output file additional test cases:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Input file additional test cases:";
            // 
            // btnCaseAppend
            // 
            this.btnCaseAppend.Location = new System.Drawing.Point(274, 166);
            this.btnCaseAppend.Name = "btnCaseAppend";
            this.btnCaseAppend.Size = new System.Drawing.Size(234, 23);
            this.btnCaseAppend.TabIndex = 6;
            this.btnCaseAppend.Text = "Append Test Cases for I/O Files...";
            this.btnCaseAppend.UseVisualStyleBackColor = true;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(458, 17);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(230, 20);
            this.txtOutputPath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output file:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(694, 15);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 3;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(299, 15);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 2;
            this.btnBrowseInput.Text = "Browse...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtInputPath
            // 
            this.txtInputPath.Location = new System.Drawing.Point(63, 17);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.ReadOnly = true;
            this.txtInputPath.Size = new System.Drawing.Size(230, 20);
            this.txtInputPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input file:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioCheckByComp);
            this.groupBox3.Controls.Add(this.radioCompileNo);
            this.groupBox3.Controls.Add(this.radioCompileYes);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(13, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 67);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Validation options";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(356, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(334, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Both (select only if you choose to compile AND create executable";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(285, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Runtime";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioCheckByComp
            // 
            this.radioCheckByComp.AutoSize = true;
            this.radioCheckByComp.Location = new System.Drawing.Point(165, 42);
            this.radioCheckByComp.Name = "radioCheckByComp";
            this.radioCheckByComp.Size = new System.Drawing.Size(113, 17);
            this.radioCheckByComp.TabIndex = 9;
            this.radioCheckByComp.TabStop = true;
            this.radioCheckByComp.Text = "Compilation (.c file)";
            this.radioCheckByComp.UseVisualStyleBackColor = true;
            // 
            // radioCompileNo
            // 
            this.radioCompileNo.AutoSize = true;
            this.radioCompileNo.Location = new System.Drawing.Point(215, 18);
            this.radioCompileNo.Name = "radioCompileNo";
            this.radioCompileNo.Size = new System.Drawing.Size(39, 17);
            this.radioCompileNo.TabIndex = 5;
            this.radioCompileNo.TabStop = true;
            this.radioCompileNo.Text = "No";
            this.radioCompileNo.UseVisualStyleBackColor = true;
            // 
            // radioCompileYes
            // 
            this.radioCompileYes.AutoSize = true;
            this.radioCompileYes.Location = new System.Drawing.Point(165, 18);
            this.radioCompileYes.Name = "radioCompileYes";
            this.radioCompileYes.Size = new System.Drawing.Size(43, 17);
            this.radioCompileYes.TabIndex = 4;
            this.radioCompileYes.TabStop = true;
            this.radioCompileYes.Text = "Yes";
            this.radioCompileYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Check I/O by:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Compile code? (check .c files)";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(13, 385);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(159, 30);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Start Validation Process";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(629, 385);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(159, 30);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridResults);
            this.groupBox4.Location = new System.Drawing.Point(13, 421);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 255);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results Table";
            // 
            // dataGridResults
            // 
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResults.Location = new System.Drawing.Point(3, 16);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.Size = new System.Drawing.Size(769, 236);
            this.dataGridResults.TabIndex = 0;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(322, 682);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(113, 26);
            this.btnExportCSV.TabIndex = 10;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            // 
            // openArchiveDialog
            // 
            this.openArchiveDialog.FileName = "openArchiveDialog";
            this.openArchiveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openArchiveDialog_FileOk);
            // 
            // openInputDialog
            // 
            this.openInputDialog.FileName = "openInputDialog";
            this.openInputDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openInputDialog_FileOk);
            // 
            // openOutputDialog
            // 
            this.openOutputDialog.FileName = "openOutputDialog";
            this.openOutputDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openOutputDialog_FileOk);
            // 
            // testCOMP
            // 
            this.testCOMP.Location = new System.Drawing.Point(287, 392);
            this.testCOMP.Name = "testCOMP";
            this.testCOMP.Size = new System.Drawing.Size(131, 23);
            this.testCOMP.TabIndex = 11;
            this.testCOMP.Text = "TEST COMPILATION";
            this.testCOMP.UseVisualStyleBackColor = true;
            this.testCOMP.Click += new System.EventHandler(this.testCOMP_Click);
            // 
            // exeOutputBtn
            // 
            this.exeOutputBtn.Location = new System.Drawing.Point(424, 392);
            this.exeOutputBtn.Name = "exeOutputBtn";
            this.exeOutputBtn.Size = new System.Drawing.Size(75, 23);
            this.exeOutputBtn.TabIndex = 12;
            this.exeOutputBtn.Text = "Exe/Output";
            this.exeOutputBtn.UseVisualStyleBackColor = true;
            this.exeOutputBtn.Click += new System.EventHandler(this.exeOutputBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.menuResultsGrade);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.menuExeGrade);
            this.groupBox5.Controls.Add(this.menuCodeWeight);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(13, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(775, 46);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grading";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "%";
            // 
            // menuResultsGrade
            // 
            this.menuResultsGrade.Location = new System.Drawing.Point(434, 18);
            this.menuResultsGrade.Name = "menuResultsGrade";
            this.menuResultsGrade.Size = new System.Drawing.Size(52, 20);
            this.menuResultsGrade.TabIndex = 8;
            this.menuResultsGrade.ValueChanged += new System.EventHandler(this.menuResultsGrade_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Correct results:";
            // 
            // menuExeGrade
            // 
            this.menuExeGrade.Location = new System.Drawing.Point(229, 17);
            this.menuExeGrade.Name = "menuExeGrade";
            this.menuExeGrade.Size = new System.Drawing.Size(52, 20);
            this.menuExeGrade.TabIndex = 4;
            this.menuExeGrade.ValueChanged += new System.EventHandler(this.menuExeGrade_ValueChanged);
            // 
            // menuCodeWeight
            // 
            this.menuCodeWeight.Location = new System.Drawing.Point(51, 17);
            this.menuCodeWeight.Name = "menuCodeWeight";
            this.menuCodeWeight.Size = new System.Drawing.Size(52, 20);
            this.menuCodeWeight.TabIndex = 3;
            this.menuCodeWeight.ValueChanged += new System.EventHandler(this.menuCodeWeight_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Executable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Code:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 717);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.exeOutputBtn);
            this.Controls.Add(this.testCOMP);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainScreen_HelpButtonClicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuResultsGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuExeGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCodeWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArchivePath;
        private System.Windows.Forms.Button btnBrowseArchive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioCheckByComp;
        private System.Windows.Forms.RadioButton radioCompileNo;
        private System.Windows.Forms.RadioButton radioCompileYes;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.TextBox txtOutputAppend;
        private System.Windows.Forms.TextBox txtInputAppend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCaseAppend;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.OpenFileDialog openArchiveDialog;
        private System.Windows.Forms.OpenFileDialog openInputDialog;
        private System.Windows.Forms.OpenFileDialog openOutputDialog;
        private System.Windows.Forms.SaveFileDialog saveCSVFile;
        private System.Windows.Forms.Button testCOMP;
        private System.Windows.Forms.Button exeOutputBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown menuExeGrade;
        private System.Windows.Forms.NumericUpDown menuCodeWeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown menuResultsGrade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

