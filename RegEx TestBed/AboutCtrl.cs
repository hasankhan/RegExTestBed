using System;
using System.Windows.Forms;

namespace CrackSoft.UI.Controls
{
    public partial class AboutCtrl : UserControl
    {
        const string COPYRIGHT_TEXT = "Copyright (C) {0} CrackSoft Corporation";
        int copyrightSince;

        public AboutCtrl()
        {
            InitializeComponent();
            
            lblAppName.Text = ProductName;
            lblVersion.Text = "Version " + ProductVersion;
            CopyrightSince = DateTime.Now.Year;
        }

        public int CopyrightSince
        {
            get { return copyrightSince; }
            set
            {
                copyrightSince = value;
                lblCopyright.Text = String.Format(COPYRIGHT_TEXT, copyrightSince);
            }
        }

        private void AboutCtrl_AutoSizeChanged(object sender, EventArgs e)
        {
            if (AutoSize)
            {
                int max = 0;
                foreach (Control control in Controls)
                {
                    if (control.Width > max)
                        max = control.Width;
                }
                Width = max;
                Height = lblRights.Top + lblRights.Height;
            }
        }
    }
}
