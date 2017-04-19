namespace CrackSoft.RegexTestBed
{
    partial class ExportForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButtonMatchesOnly = new System.Windows.Forms.RadioButton();
            this.rButtonGroupsOnly = new System.Windows.Forms.RadioButton();
            this.rButtonBoth = new System.Windows.Forms.RadioButton();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Export";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(205, 38);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(205, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV (Comma Delimited) (*.csv)|*.csv|XML (*.xml)|*.xml";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButtonMatchesOnly);
            this.groupBox1.Controls.Add(this.rButtonGroupsOnly);
            this.groupBox1.Controls.Add(this.rButtonBoth);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export options";
            // 
            // rButtonMatchesOnly
            // 
            this.rButtonMatchesOnly.AutoSize = true;
            this.rButtonMatchesOnly.Location = new System.Drawing.Point(6, 19);
            this.rButtonMatchesOnly.Name = "rButtonMatchesOnly";
            this.rButtonMatchesOnly.Size = new System.Drawing.Size(90, 17);
            this.rButtonMatchesOnly.TabIndex = 2;
            this.rButtonMatchesOnly.TabStop = true;
            this.rButtonMatchesOnly.Text = "&Matches Only";
            this.rButtonMatchesOnly.UseVisualStyleBackColor = true;
            // 
            // rButtonGroupsOnly
            // 
            this.rButtonGroupsOnly.AutoSize = true;
            this.rButtonGroupsOnly.Location = new System.Drawing.Point(6, 42);
            this.rButtonGroupsOnly.Name = "rButtonGroupsOnly";
            this.rButtonGroupsOnly.Size = new System.Drawing.Size(83, 17);
            this.rButtonGroupsOnly.TabIndex = 3;
            this.rButtonGroupsOnly.TabStop = true;
            this.rButtonGroupsOnly.Text = "&Groups Only";
            this.rButtonGroupsOnly.UseVisualStyleBackColor = true;
            // 
            // rButtonBoth
            // 
            this.rButtonBoth.AutoSize = true;
            this.rButtonBoth.Checked = true;
            this.rButtonBoth.Location = new System.Drawing.Point(6, 65);
            this.rButtonBoth.Name = "rButtonBoth";
            this.rButtonBoth.Size = new System.Drawing.Size(47, 17);
            this.rButtonBoth.TabIndex = 4;
            this.rButtonBoth.TabStop = true;
            this.rButtonBoth.Text = "B&oth";
            this.rButtonBoth.UseVisualStyleBackColor = true;
            // 
            // txtFile
            // 
            this.txtFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFile.Location = new System.Drawing.Point(44, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFile.Size = new System.Drawing.Size(236, 20);
            this.txtFile.TabIndex = 7;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 212);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Matches";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExportForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rButtonMatchesOnly;
        private System.Windows.Forms.RadioButton rButtonGroupsOnly;
        private System.Windows.Forms.RadioButton rButtonBoth;
        private System.Windows.Forms.TextBox txtFile;
    }
}