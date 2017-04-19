using System;
using System.Windows.Forms;
using System.IO;
using CrackSoft.RegexTestBed.Exporters;

namespace CrackSoft.RegexTestBed
{
    public partial class ExportForm : Form
    {
        //parameters
        string pattern;
        ListView matchList;

        public ExportForm(string pattern, ListView matchList)
        {
            InitializeComponent();
            this.pattern = pattern;
            this.matchList = matchList;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtFile.Text = saveFileDialog1.FileName;
                btnSave.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DisableControls();
            
            bool error = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(txtFile.Text))
                {
                    ExportOption exportOption;
                    MatchExporter exporter;

                    if (rButtonMatchesOnly.Checked)
                        exportOption = ExportOption.MatchesOnly;
                    else if (rButtonGroupsOnly.Checked)
                        exportOption = ExportOption.GroupsOnly;
                    else
                        exportOption = ExportOption.Both;

                    ExportParams exportParams = new ExportParams() { Pattern = pattern, MatchList = matchList, ExportOption = exportOption };

                    if (saveFileDialog1.FilterIndex == 1)
                        exporter = new CsvMatchExporter(exportParams);
                    else
                        exporter = new XmlMatchExporter(exportParams);

                    exporter.Export(writer);
                }
            }
            catch (IOException)
            {
                error = true;
                MessageBox.Show("Could not open the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                error = true;
                MessageBox.Show("There was an error saving the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            EnableControls();
            
            if (!error)
            {
                MessageBox.Show("Export completed", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void EnableControls()
        {
            btnSave.Text = "&Save";
            this.Enabled = true;
        }

        private void DisableControls()
        {
            this.Enabled = false;
            btnSave.Text = "Working...";
        }

        private void ExportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}