using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using CrackSoft.Utility;

namespace CrackSoft.RegexTestBed
{
    public partial class MainForm : Form
    {
        Regex regx;
        int lastMatch; // to keep track of last index in incremental search
        Properties.Settings settings;
        string currentFile;
        bool fileModified;
        const string fileFilter = "Text Documents (*.txt)|*.txt|All Files|*.*";
        const string msgFileChanged = "Do you want to save the changes?";
        bool searchRestarted; // to clear matches on search restart
        Stopwatch watch;

        public MainForm()
        {
            InitializeComponent();
            settings = Properties.Settings.Default;
            currentFile = String.Empty;
            watch = new Stopwatch();
        }

        #region Form Events
        private void txtPattern_TextChanged(object sender, EventArgs e)
        {            
            if (chkAutoFind.Checked)
            {
                if (realTimeToolStripMenuItem.Checked)
                    FindMatch(false);
                else
                {
                    timerAutoFind.Stop();
                    timerAutoFind.Start();
                }
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            // only reset the highlights if user edits texts
            if (txtData.Focused)
            {
                FileModified = true;
                ResetSearch();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chkSingleLine.Checked = settings.MatchNewline;
            chkIgnoreCase.Checked = settings.IgnorCase;
            chkIncSearch.Checked = settings.IncSearch;
            chkAutoFind.Checked = settings.AutoFind;
            chkHighlightMatch.Checked = settings.HighlightMatch;
            realTimeToolStripMenuItem.Checked = !settings.AutoFindDelayed;
            delayedToolStripMenuItem.Checked = settings.AutoFindDelayed;
            Width = settings.Width;
            Height = settings.Height;
            panel1.Height = settings.PanelHeight;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                settings.Width = Width;
                settings.Height = Height;
                settings.PanelHeight = panel1.Height;
            }
            settings.MatchNewline = chkSingleLine.Checked;
            settings.IgnorCase = chkIgnoreCase.Checked;
            settings.IncSearch = chkIncSearch.Checked;
            settings.AutoFind = chkAutoFind.Checked;
            settings.HighlightMatch = chkHighlightMatch.Checked;
            settings.AutoFindDelayed = delayedToolStripMenuItem.Checked;
            settings.Save();
        }
        #endregion

        #region Actions
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindMatch(true);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                ResetSearch();
                SetupRegEx();
                
                txtData.SelectAll();
                if (!chkIncSearch.Checked)
                    txtData.SelectedText = regx.Replace(txtData.Text, txtReplace.Text);
                else
                {
                    txtData.SelectedText = regx.Replace(txtData.Text, txtReplace.Text, 1);
                    FindMatch(false);
                }
                txtData.DeselectAll();

                FileModified = true;
                UpdateStatus(String.Empty);
            }
            catch (Exception exp)
            {
                UpdateStatus(exp.Message);
            }
        }
        #endregion

        #region Regex Options
        private void chkIgnoreCase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoFind.Checked)
                FindMatch(false);
            txtPattern.Focus();
        }

        private void chkSingleLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoFind.Checked)
                FindMatch(false);
            txtPattern.Focus();
        }

        private void chkIncSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoFind.Checked)
                FindMatch(false);
            txtPattern.Focus();
        }

        private void chkAutoFind_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoFind.Checked)
                FindMatch(false);
            txtPattern.Focus();
        }

        private void chkHighlightMatch_CheckedChanged(object sender, EventArgs e)
        {
            txtPattern.Focus();
        }
        #endregion

        #region Menus
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData.Redo();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData.Copy();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData.Focus();
            txtData.SelectAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = fileFilter;

                /* Moving focus to pattern textbox because if the file is loaded while
                 * the txtData has focus then txtData_TextChanged will asume that user
                 * changed the data besides that's where the focus should be after the 
                 * file is loaded anyway. */
                txtPattern.Focus();

                if (openDialog.ShowDialog(this) == DialogResult.OK)
                    if (CloseFile())
                        OpenFile(openDialog.FileName);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFile = String.Empty;
            SaveFile();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = new AboutBox();
            aboutForm.ShowDialog(this);
        }

        private void crackSoftWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellUtility.OpenWebPage("http://www.cracksoft.net");
        }
        #endregion

        private void timerAutoFind_Tick(object sender, EventArgs e)
        {
            timerAutoFind.Stop();
            if (chkAutoFind.Checked)
                FindMatch(false);                
        }

        #region File operations
        bool FileModified
        {
            get
            {
                return fileModified;
            }
            set
            {
                fileModified = value;
                if (!fileModified)
                    saveAsToolStripMenuItem.Enabled = false;
                else if (currentFile != String.Empty)
                    saveAsToolStripMenuItem.Enabled = true;
            }
        }

        void SaveFile()
        {
            if (currentFile != String.Empty)
                txtData.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = fileFilter;
                if (saveDialog.ShowDialog(this) == DialogResult.OK)
                {
                    currentFile = saveDialog.FileName;
                    txtData.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
                    closeToolStripMenuItem.Enabled = true;
                }
            }
            FileModified = false;
        }

        void ResetFile()
        {
            currentFile = String.Empty;
            txtData.Text = String.Empty;
            FileModified = false;
            ResetSearch();
            closeToolStripMenuItem.Enabled = false;
        }

        bool CloseFile()
        {
            if (fileModified)
            {
                DialogResult result = MessageBox.Show(this, msgFileChanged, this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    SaveFile();

                if (result == DialogResult.Cancel)
                    return false;
                else
                {
                    ResetFile();
                    return true;
                }
            }
            ResetFile();
            return true;
        }

        void OpenFile(string fileName)
        {
            currentFile = fileName;
            txtData.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
            closeToolStripMenuItem.Enabled = true;
        }
        #endregion

        #region Text search

        void ResetSearch() { ResetSearch(true); }
        void ResetSearch(bool clearMatches)
        {
            ClearHighlight();
            lastMatch = 0;
            if (clearMatches)
                lstMatches.Items.Clear();
        }

        void FindMatch(bool continueSearch)
        {
            /* Im doing this before ClearHighlight because worker 
             * still might be highlighting items */
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
            /* Im not calling reset search here because 
             * besides clearing highlight it also sets last match
             * equals to 0 which could disturb the incremental search */
            ClearHighlight();

            if (txtData.Text != String.Empty && txtPattern.Text != String.Empty)
            {
                try
                {
                    if (!chkIncSearch.Checked)
                        SetupRegEx();
                    if (searchRestarted)
                        lstMatches.Items.Clear();
                    searchRestarted = false;
                    /* if this is first the time then 
                     * we create the regx object */
                    if (!(bool)continueSearch || regx == null)
                    {
                        ResetSearch();
                        SetupRegEx();
                    }

                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Visible = true;
                    UpdateStatus("Searching...");
                    Application.DoEvents();
                    backgroundWorker1.RunWorkerAsync(
                        new SearchParams()
                                {
                                    IncrementalSearch = chkIncSearch.Checked, 
                                    ContinueSearch = continueSearch,
                                    InputText = txtData.Text
                                });
                }
                catch (Exception exp)
                {
                    toolStripProgressBar1.Visible = false;
                    UpdateStatus(exp.Message);
                }
            }
            else
                lstMatches.Clear();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SearchParams searchParams = (SearchParams)e.Argument;
            int matchCount = 0;
            List<ListViewItem> listItems = null;
            TimeSpan searchTime = TimeSpan.Zero;

            if (!searchParams.IncrementalSearch)
            {
                StartTimer();
                MatchCollection matches = regx.Matches(searchParams.InputText);
                searchTime = StopTimer();

                matchCount = matches.Count;
                listItems = new List<ListViewItem>(matchCount);
                float i = 1;

                foreach (Match mch in matches)
                {
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    listItems.Add(SearchUtility.CreateListItem(mch));
                    backgroundWorker1.ReportProgress((int)((i++ / matchCount) * 100), mch);
                }
            }
            else
            {
                /* if last match included the last char
                 * of the text then lastMatch variable
                 * will have value +1 greater than length
                 * of text so it will raise an error so
                 * to avoid that we will put a check here */
                if (lastMatch < searchParams.InputText.Length)
                {
                    StartTimer();
                    Match mch = regx.Match(searchParams.InputText, lastMatch);
                    searchTime = StopTimer();

                    if (mch.Success)
                    {
                        listItems = new List<ListViewItem>();
                        listItems.Add(SearchUtility.CreateListItem(mch));
                        lastMatch = mch.Index + mch.Length;
                        backgroundWorker1.ReportProgress(100, mch);
                        matchCount = 1;
                    }
                }
            }

            e.Result = new SearchResult()
                            {
                                MatchCount = matchCount,
                                SearchTime = searchTime,
                                SearchParams = searchParams,
                                ListItems = listItems
                            };
        }

        private TimeSpan StopTimer()
        {
            watch.Stop();
            return watch.Elapsed;
        }

        private void StartTimer()
        {
            watch.Reset();
            watch.Start();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > toolStripProgressBar1.Value)
                toolStripProgressBar1.Value = e.ProgressPercentage;
            if (chkHighlightMatch.Checked)
                SearchUtility.HighlightMatch(ref txtData, (Match)e.UserState, chkIncSearch.Checked);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Visible = false;
            if (e.Error != null)
                UpdateStatus(e.Error.Message);
            else if (e.Cancelled)
                UpdateStatus(String.Empty);
            else
            {
                SearchResult result = (SearchResult)e.Result;
                if (result.MatchCount > 0)
                {
                    lstMatches.Items.AddRange(result.ListItems.ToArray());
                    string searchText;
                    if (result.SearchTime.TotalSeconds > 1)
                        searchText = result.SearchTime.TotalSeconds + " second(s)";
                    else
                        searchText = result.SearchTime.TotalMilliseconds + " milisecond(s)";
                    UpdateStatus(String.Format("Found {0} match(es) in {1}", result.MatchCount, searchText));
                }
                else
                {
                    /* if we reach the end of the text searching
                     * for the pattern then we re-start the search
                     * but only if there was any result previously
                     * found */
                    if (result.SearchParams.ContinueSearch && lastMatch > 0)
                    {
                        ResetSearch(false);
                        searchRestarted = true;
                    }
                    /* updating status in the end because
                     * resetsearch clears status */
                    UpdateStatus("Match not found!");
                }
            }
        }
        #endregion

        public void SetupRegEx()
        {
            lstMatches.Clear();
            regx = SearchUtility.GetRegExObject(txtPattern.Text, chkSingleLine.Checked, chkIgnoreCase.Checked);

            string[] groupNames = regx.GetGroupNames();
            int colCount = groupNames.Length;
            int maxWidth = lstMatches.Width - 20;

            ColumnHeader column;
            column = lstMatches.Columns.Add("Match");
            column.Width = maxWidth / colCount;

            for (int i = 1; i < groupNames.Length; i++)
            {
                string groupName = groupNames[i];
                /* If its a named group show its name
                 * otherwise add the Group prefix to its number */
                if (groupName != i.ToString())
                    column = lstMatches.Columns.Add(groupName);
                else
                    column = lstMatches.Columns.Add("Group_" + i);
                column.Width = maxWidth / groupNames.Length;
            }
        }

        void UpdateStatus(string status)
        {
            toolStripStatusLabel1.Text = status;
        }

        void ClearHighlight()
        {
            UpdateStatus(String.Empty);
            SearchUtility.ClearHighlight(txtData);
        }

        private void exportMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm(txtPattern.Text, lstMatches);
            exportForm.ShowDialog(this);
        }

        private void realTimeToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            delayedToolStripMenuItem.Checked = !realTimeToolStripMenuItem.Checked;
        }

        private void delayedToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            realTimeToolStripMenuItem.Checked = !delayedToolStripMenuItem.Checked;
        }
    }
}