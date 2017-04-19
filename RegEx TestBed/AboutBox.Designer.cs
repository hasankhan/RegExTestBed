namespace CrackSoft.RegexTestBed
{
    partial class AboutBox
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
            this.btnOK = new System.Windows.Forms.Button();
            this.aboutCtrl1 = new CrackSoft.UI.Controls.AboutCtrl();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(231, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // aboutCtrl1
            // 
            this.aboutCtrl1.AutoSize = true;
            this.aboutCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.aboutCtrl1.CopyrightSince = 2007;
            this.aboutCtrl1.Location = new System.Drawing.Point(13, 13);
            this.aboutCtrl1.Name = "aboutCtrl1";
            this.aboutCtrl1.Size = new System.Drawing.Size(204, 91);
            this.aboutCtrl1.TabIndex = 1;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(318, 156);
            this.Controls.Add(this.aboutCtrl1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About RegEx TestBed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private CrackSoft.UI.Controls.AboutCtrl aboutCtrl1;
    }
}