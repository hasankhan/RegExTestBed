namespace CrackSoft.RegexTestBed
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delayedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crackSoftWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripEditBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.chkSingleLine = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.chkIncSearch = new System.Windows.Forms.CheckBox();
            this.chkAutoFind = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.chkHighlightMatch = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lstMatches = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerAutoFind = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStripEditBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(666, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(160, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(125, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(125, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoFindToolStripMenuItem,
            this.exportMatchesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // autoFindToolStripMenuItem
            // 
            this.autoFindToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realTimeToolStripMenuItem,
            this.delayedToolStripMenuItem});
            this.autoFindToolStripMenuItem.Name = "autoFindToolStripMenuItem";
            this.autoFindToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.autoFindToolStripMenuItem.Text = "&Auto Find";
            // 
            // realTimeToolStripMenuItem
            // 
            this.realTimeToolStripMenuItem.CheckOnClick = true;
            this.realTimeToolStripMenuItem.Name = "realTimeToolStripMenuItem";
            this.realTimeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.realTimeToolStripMenuItem.Text = "&Real Time";
            this.realTimeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.realTimeToolStripMenuItem_CheckedChanged);
            // 
            // delayedToolStripMenuItem
            // 
            this.delayedToolStripMenuItem.CheckOnClick = true;
            this.delayedToolStripMenuItem.Name = "delayedToolStripMenuItem";
            this.delayedToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.delayedToolStripMenuItem.Text = "&Delayed";
            this.delayedToolStripMenuItem.CheckedChanged += new System.EventHandler(this.delayedToolStripMenuItem_CheckedChanged);
            // 
            // exportMatchesToolStripMenuItem
            // 
            this.exportMatchesToolStripMenuItem.Name = "exportMatchesToolStripMenuItem";
            this.exportMatchesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exportMatchesToolStripMenuItem.Text = "&Export Matches...";
            this.exportMatchesToolStripMenuItem.Click += new System.EventHandler(this.exportMatchesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crackSoftWebsiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // crackSoftWebsiteToolStripMenuItem
            // 
            this.crackSoftWebsiteToolStripMenuItem.Name = "crackSoftWebsiteToolStripMenuItem";
            this.crackSoftWebsiteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.crackSoftWebsiteToolStripMenuItem.Text = "CrackSoft &Website";
            this.crackSoftWebsiteToolStripMenuItem.Click += new System.EventHandler(this.crackSoftWebsiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutToolStripMenuItem.Text = "&About RegEx TestBed";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MinimumSize = new System.Drawing.Size(656, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 275);
            this.panel1.TabIndex = 18;
            // 
            // txtData
            // 
            this.txtData.AutoWordSelection = true;
            this.txtData.ContextMenuStrip = this.contextMenuStripEditBox;
            this.txtData.DetectUrls = false;
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(0, 0);
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtData.Size = new System.Drawing.Size(666, 152);
            this.txtData.TabIndex = 9;
            this.txtData.Text = "";
            this.txtData.WordWrap = false;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // contextMenuStripEditBox
            // 
            this.contextMenuStripEditBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator5,
            this.toolStripMenuItem6});
            this.contextMenuStripEditBox.Name = "menuStripEditBox";
            this.contextMenuStripEditBox.Size = new System.Drawing.Size(129, 148);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem1.Text = "&Undo";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem2.Text = "&Redo";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem3.Text = "Cu&t";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem4.Text = "&Copy";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem5.Text = "&Paste";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem6.Text = "Select &All";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtReplace, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkSingleLine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPattern, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkIgnoreCase, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkIncSearch, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkAutoFind, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFind, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReplace, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkHighlightMatch, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 123);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 50);
            this.label2.TabIndex = 15;
            this.label2.Text = "Replace";
            // 
            // txtReplace
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtReplace, 5);
            this.txtReplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReplace.Location = new System.Drawing.Point(57, 76);
            this.txtReplace.Multiline = true;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplace.Size = new System.Drawing.Size(525, 44);
            this.txtReplace.TabIndex = 1;
            // 
            // chkSingleLine
            // 
            this.chkSingleLine.AutoSize = true;
            this.chkSingleLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkSingleLine.Location = new System.Drawing.Point(57, 3);
            this.chkSingleLine.Name = "chkSingleLine";
            this.chkSingleLine.Size = new System.Drawing.Size(125, 17);
            this.chkSingleLine.TabIndex = 4;
            this.chkSingleLine.Text = "D&ot matches newline";
            this.chkSingleLine.UseVisualStyleBackColor = true;
            this.chkSingleLine.CheckedChanged += new System.EventHandler(this.chkSingleLine_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pattern";
            // 
            // txtPattern
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPattern, 5);
            this.txtPattern.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPattern.Location = new System.Drawing.Point(57, 26);
            this.txtPattern.Multiline = true;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPattern.Size = new System.Drawing.Size(525, 44);
            this.txtPattern.TabIndex = 0;
            this.txtPattern.TextChanged += new System.EventHandler(this.txtPattern_TextChanged);
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkIgnoreCase.Location = new System.Drawing.Point(188, 3);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(82, 17);
            this.chkIgnoreCase.TabIndex = 5;
            this.chkIgnoreCase.Text = "Ignore &case";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            this.chkIgnoreCase.CheckedChanged += new System.EventHandler(this.chkIgnoreCase_CheckedChanged);
            // 
            // chkIncSearch
            // 
            this.chkIncSearch.AutoSize = true;
            this.chkIncSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkIncSearch.Location = new System.Drawing.Point(276, 3);
            this.chkIncSearch.Name = "chkIncSearch";
            this.chkIncSearch.Size = new System.Drawing.Size(116, 17);
            this.chkIncSearch.TabIndex = 6;
            this.chkIncSearch.Text = "Incremental &search";
            this.chkIncSearch.UseVisualStyleBackColor = true;
            this.chkIncSearch.CheckedChanged += new System.EventHandler(this.chkIncSearch_CheckedChanged);
            // 
            // chkAutoFind
            // 
            this.chkAutoFind.AutoSize = true;
            this.chkAutoFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkAutoFind.Location = new System.Drawing.Point(398, 3);
            this.chkAutoFind.Name = "chkAutoFind";
            this.chkAutoFind.Size = new System.Drawing.Size(68, 17);
            this.chkAutoFind.TabIndex = 7;
            this.chkAutoFind.Text = "&Auto find";
            this.chkAutoFind.UseVisualStyleBackColor = true;
            this.chkAutoFind.CheckedChanged += new System.EventHandler(this.chkAutoFind_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(588, 26);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(69, 44);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "F&ind";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(588, 76);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(69, 44);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // chkHighlightMatch
            // 
            this.chkHighlightMatch.AutoSize = true;
            this.chkHighlightMatch.Location = new System.Drawing.Point(478, 3);
            this.chkHighlightMatch.Name = "chkHighlightMatch";
            this.chkHighlightMatch.Size = new System.Drawing.Size(99, 17);
            this.chkHighlightMatch.TabIndex = 16;
            this.chkHighlightMatch.Text = "Highlight &match";
            this.chkHighlightMatch.UseVisualStyleBackColor = true;
            this.chkHighlightMatch.CheckedChanged += new System.EventHandler(this.chkHighlightMatch_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 299);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(666, 3);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // lstMatches
            // 
            this.lstMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMatches.FullRowSelect = true;
            this.lstMatches.GridLines = true;
            this.lstMatches.LabelWrap = false;
            this.lstMatches.Location = new System.Drawing.Point(0, 302);
            this.lstMatches.MultiSelect = false;
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(666, 97);
            this.lstMatches.TabIndex = 20;
            this.lstMatches.TabStop = false;
            this.lstMatches.UseCompatibleStateImageBehavior = false;
            this.lstMatches.View = System.Windows.Forms.View.Details;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // timerAutoFind
            // 
            this.timerAutoFind.Interval = 500;
            this.timerAutoFind.Tick += new System.EventHandler(this.timerAutoFind_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 421);
            this.Controls.Add(this.lstMatches);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(664, 320);
            this.Name = "MainForm";
            this.Text = "RegEx TestBed";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStripEditBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crackSoftWebsiteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.CheckBox chkSingleLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.CheckBox chkIncSearch;
        private System.Windows.Forms.CheckBox chkAutoFind;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lstMatches;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMatchesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEditBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timerAutoFind;
        private System.Windows.Forms.CheckBox chkHighlightMatch;
        private System.Windows.Forms.ToolStripMenuItem autoFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delayedToolStripMenuItem;
    }
}

