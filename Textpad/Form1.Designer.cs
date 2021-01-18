namespace Textpadc
{
    partial class TextPadUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextPadUI));
            this.mnuEditor = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDarkModeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redText = new System.Windows.Forms.RichTextBox();
            this.pnlAdvancedEditor = new System.Windows.Forms.FlowLayoutPanel();
            this.tlsEditor = new System.Windows.Forms.ToolStrip();
            this.tsbNewFile = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFontStyle = new System.Windows.Forms.ToolStripButton();
            this.cbxFonts = new System.Windows.Forms.ToolStripComboBox();
            this.ctsbColor = new ColorPicker.ColorToolStripDropDownButton();
            this.tsbFontSize = new System.Windows.Forms.ToolStripButton();
            this.cbxFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHeading1 = new System.Windows.Forms.ToolStripButton();
            this.tsbHeading2 = new System.Windows.Forms.ToolStripButton();
            this.tsbHeading3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tsbItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBulletList = new System.Windows.Forms.ToolStripButton();
            this.tsbNumberedList = new System.Windows.Forms.ToolStripDropDownButton();
            this.dbtnAlpha = new System.Windows.Forms.ToolStripMenuItem();
            this.dbtnNumbered = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTheme = new System.Windows.Forms.ToolStripButton();
            this.mnuEditor.SuspendLayout();
            this.pnlAdvancedEditor.SuspendLayout();
            this.tlsEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuEditor
            // 
            this.mnuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnuEditor.Location = new System.Drawing.Point(0, 0);
            this.mnuEditor.Name = "mnuEditor";
            this.mnuEditor.Size = new System.Drawing.Size(880, 24);
            this.mnuEditor.TabIndex = 0;
            this.mnuEditor.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableDarkModeToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // enableDarkModeToolStripMenuItem1
            // 
            this.enableDarkModeToolStripMenuItem1.CheckOnClick = true;
            this.enableDarkModeToolStripMenuItem1.Name = "enableDarkModeToolStripMenuItem1";
            this.enableDarkModeToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.enableDarkModeToolStripMenuItem1.Text = "Enable Dark Mode";
            this.enableDarkModeToolStripMenuItem1.CheckStateChanged += new System.EventHandler(this.enableDarkModeToolStripMenuItem1_CheckStateChanged);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem1,
            this.wordWrapToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.preferencesToolStripMenuItem1.Text = "Styles...";
            this.preferencesToolStripMenuItem1.Click += new System.EventHandler(this.preferencesToolStripMenuItem1_Click);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Checked = true;
            this.wordWrapToolStripMenuItem.CheckOnClick = true;
            this.wordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.wordWrapToolStripMenuItem_CheckStateChanged);
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // redText
            // 
            this.redText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redText.BackColor = System.Drawing.SystemColors.Window;
            this.redText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redText.ForeColor = System.Drawing.Color.White;
            this.redText.Location = new System.Drawing.Point(0, 65);
            this.redText.Name = "redText";
            this.redText.Size = new System.Drawing.Size(880, 335);
            this.redText.TabIndex = 1;
            this.redText.Text = "";
            this.redText.SelectionChanged += new System.EventHandler(this.redText_SelectionChanged);
            this.redText.TextChanged += new System.EventHandler(this.redText_TextChanged);
            // 
            // pnlAdvancedEditor
            // 
            this.pnlAdvancedEditor.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAdvancedEditor.Controls.Add(this.tlsEditor);
            this.pnlAdvancedEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdvancedEditor.Location = new System.Drawing.Point(0, 24);
            this.pnlAdvancedEditor.Name = "pnlAdvancedEditor";
            this.pnlAdvancedEditor.Size = new System.Drawing.Size(880, 35);
            this.pnlAdvancedEditor.TabIndex = 2;
            // 
            // tlsEditor
            // 
            this.tlsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewFile,
            this.tsbOpenFile,
            this.tsbSaveFile,
            this.toolStripSeparator4,
            this.tsbFontStyle,
            this.cbxFonts,
            this.ctsbColor,
            this.tsbFontSize,
            this.cbxFontSize,
            this.toolStripSeparator1,
            this.tsbHeading1,
            this.tsbHeading2,
            this.tsbHeading3,
            this.toolStripSeparator2,
            this.tsbBold,
            this.tsbItalic,
            this.tsbUnderline,
            this.toolStripSeparator3,
            this.tsbImage,
            this.toolStripSeparator5,
            this.tsbBulletList,
            this.tsbNumberedList,
            this.toolStripSeparator6,
            this.tsbAlignLeft,
            this.tsbAlignCenter,
            this.tsbAlignRight,
            this.toolStripSeparator7,
            this.tsbUndo,
            this.tsbRedo,
            this.toolStripSeparator8,
            this.tsbTheme});
            this.tlsEditor.Location = new System.Drawing.Point(0, 0);
            this.tlsEditor.Name = "tlsEditor";
            this.tlsEditor.Padding = new System.Windows.Forms.Padding(0);
            this.tlsEditor.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlsEditor.Size = new System.Drawing.Size(833, 29);
            this.tlsEditor.Stretch = true;
            this.tlsEditor.TabIndex = 0;
            this.tlsEditor.Text = "toolStrip1";
            // 
            // tsbNewFile
            // 
            this.tsbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewFile.Image")));
            this.tsbNewFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewFile.Name = "tsbNewFile";
            this.tsbNewFile.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbNewFile.Size = new System.Drawing.Size(32, 26);
            this.tsbNewFile.Text = "New File";
            this.tsbNewFile.Click += new System.EventHandler(this.tsbNewFile_Click);
            // 
            // tsbOpenFile
            // 
            this.tsbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenFile.Image")));
            this.tsbOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenFile.Name = "tsbOpenFile";
            this.tsbOpenFile.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbOpenFile.Size = new System.Drawing.Size(32, 26);
            this.tsbOpenFile.Text = "Open File";
            this.tsbOpenFile.Click += new System.EventHandler(this.tsbOpenFile_Click);
            // 
            // tsbSaveFile
            // 
            this.tsbSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveFile.Image")));
            this.tsbSaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveFile.Name = "tsbSaveFile";
            this.tsbSaveFile.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbSaveFile.Size = new System.Drawing.Size(32, 26);
            this.tsbSaveFile.Text = "Save File";
            this.tsbSaveFile.Click += new System.EventHandler(this.tsbSaveFile_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbFontStyle
            // 
            this.tsbFontStyle.CheckOnClick = true;
            this.tsbFontStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFontStyle.Image = ((System.Drawing.Image)(resources.GetObject("tsbFontStyle.Image")));
            this.tsbFontStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontStyle.Name = "tsbFontStyle";
            this.tsbFontStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tsbFontStyle.Size = new System.Drawing.Size(30, 26);
            this.tsbFontStyle.Text = "Open Fonts";
            this.tsbFontStyle.Click += new System.EventHandler(this.tsbFontStyle_Click);
            // 
            // cbxFonts
            // 
            this.cbxFonts.BackColor = System.Drawing.SystemColors.Window;
            this.cbxFonts.Name = "cbxFonts";
            this.cbxFonts.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cbxFonts.Size = new System.Drawing.Size(75, 29);
            this.cbxFonts.Sorted = true;
            this.cbxFonts.SelectedIndexChanged += new System.EventHandler(this.cbxFonts_Click);
            // 
            // ctsbColor
            // 
            this.ctsbColor.BackColor = System.Drawing.SystemColors.Control;
            this.ctsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ctsbColor.Image = ((System.Drawing.Image)(resources.GetObject("ctsbColor.Image")));
            this.ctsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctsbColor.Name = "ctsbColor";
            this.ctsbColor.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ctsbColor.Size = new System.Drawing.Size(34, 26);
            this.ctsbColor.Text = "Pick Color";
            this.ctsbColor.Value = System.Drawing.Color.White;
            this.ctsbColor.Click += new ColorPicker.ColorToolStripDropDownButton.ColorPaletteEventHandler(this.ctsbColor_Click);
            // 
            // tsbFontSize
            // 
            this.tsbFontSize.CheckOnClick = true;
            this.tsbFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFontSize.Image = ((System.Drawing.Image)(resources.GetObject("tsbFontSize.Image")));
            this.tsbFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontSize.Name = "tsbFontSize";
            this.tsbFontSize.Size = new System.Drawing.Size(23, 26);
            this.tsbFontSize.Text = "Increase Font Size";
            this.tsbFontSize.Click += new System.EventHandler(this.tsbFontSize_Click);
            // 
            // cbxFontSize
            // 
            this.cbxFontSize.AutoSize = false;
            this.cbxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontSize.DropDownWidth = 40;
            this.cbxFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbxFontSize.Name = "cbxFontSize";
            this.cbxFontSize.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cbxFontSize.Size = new System.Drawing.Size(30, 23);
            this.cbxFontSize.SelectedIndexChanged += new System.EventHandler(this.cbxFontSize_Click);
            this.cbxFontSize.TextChanged += new System.EventHandler(this.cbxFontSize_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbHeading1
            // 
            this.tsbHeading1.CheckOnClick = true;
            this.tsbHeading1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHeading1.Image = ((System.Drawing.Image)(resources.GetObject("tsbHeading1.Image")));
            this.tsbHeading1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHeading1.Name = "tsbHeading1";
            this.tsbHeading1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tsbHeading1.Size = new System.Drawing.Size(30, 26);
            this.tsbHeading1.Text = "Heading 1 ";
            this.tsbHeading1.Click += new System.EventHandler(this.tsbHeading1_Click);
            // 
            // tsbHeading2
            // 
            this.tsbHeading2.CheckOnClick = true;
            this.tsbHeading2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHeading2.Image = ((System.Drawing.Image)(resources.GetObject("tsbHeading2.Image")));
            this.tsbHeading2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHeading2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHeading2.Name = "tsbHeading2";
            this.tsbHeading2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tsbHeading2.Size = new System.Drawing.Size(32, 26);
            this.tsbHeading2.Text = "Heading 2";
            this.tsbHeading2.Click += new System.EventHandler(this.tsbHeading2_Click);
            // 
            // tsbHeading3
            // 
            this.tsbHeading3.CheckOnClick = true;
            this.tsbHeading3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHeading3.Image = ((System.Drawing.Image)(resources.GetObject("tsbHeading3.Image")));
            this.tsbHeading3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHeading3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHeading3.Name = "tsbHeading3";
            this.tsbHeading3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tsbHeading3.Size = new System.Drawing.Size(34, 26);
            this.tsbHeading3.Text = "Heading 3";
            this.tsbHeading3.Click += new System.EventHandler(this.tsbHeading3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbBold
            // 
            this.tsbBold.CheckOnClick = true;
            this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBold.DoubleClickEnabled = true;
            this.tsbBold.Image = ((System.Drawing.Image)(resources.GetObject("tsbBold.Image")));
            this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBold.Name = "tsbBold";
            this.tsbBold.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbBold.Size = new System.Drawing.Size(30, 26);
            this.tsbBold.Text = "Bold Font";
            this.tsbBold.CheckStateChanged += new System.EventHandler(this.tsbBold_CheckStateChanged);
            // 
            // tsbItalic
            // 
            this.tsbItalic.CheckOnClick = true;
            this.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalic.DoubleClickEnabled = true;
            this.tsbItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsbItalic.Image")));
            this.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalic.Name = "tsbItalic";
            this.tsbItalic.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbItalic.Size = new System.Drawing.Size(30, 26);
            this.tsbItalic.Text = "Italic Text";
            this.tsbItalic.CheckStateChanged += new System.EventHandler(this.tsbItalic_CheckStateChanged);
            // 
            // tsbUnderline
            // 
            this.tsbUnderline.CheckOnClick = true;
            this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnderline.DoubleClickEnabled = true;
            this.tsbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnderline.Image")));
            this.tsbUnderline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnderline.Name = "tsbUnderline";
            this.tsbUnderline.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbUnderline.Size = new System.Drawing.Size(36, 26);
            this.tsbUnderline.Text = "Underline Text";
            this.tsbUnderline.CheckStateChanged += new System.EventHandler(this.tsbUnderline_CheckStateChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbImage
            // 
            this.tsbImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbImage.Image")));
            this.tsbImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImage.Name = "tsbImage";
            this.tsbImage.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.tsbImage.Size = new System.Drawing.Size(39, 26);
            this.tsbImage.Text = "Insert Image";
            this.tsbImage.Click += new System.EventHandler(this.tsbImage_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbBulletList
            // 
            this.tsbBulletList.CheckOnClick = true;
            this.tsbBulletList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBulletList.Image = ((System.Drawing.Image)(resources.GetObject("tsbBulletList.Image")));
            this.tsbBulletList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBulletList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBulletList.Name = "tsbBulletList";
            this.tsbBulletList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tsbBulletList.Size = new System.Drawing.Size(32, 26);
            this.tsbBulletList.Text = "Add Bullet List";
            this.tsbBulletList.Click += new System.EventHandler(this.tsbBulletList_Click);
            // 
            // tsbNumberedList
            // 
            this.tsbNumberedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNumberedList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbtnAlpha,
            this.dbtnNumbered});
            this.tsbNumberedList.Image = ((System.Drawing.Image)(resources.GetObject("tsbNumberedList.Image")));
            this.tsbNumberedList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNumberedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNumberedList.Name = "tsbNumberedList";
            this.tsbNumberedList.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsbNumberedList.Size = new System.Drawing.Size(41, 26);
            this.tsbNumberedList.Text = "Add Numbered List";
            // 
            // dbtnAlpha
            // 
            this.dbtnAlpha.CheckOnClick = true;
            this.dbtnAlpha.Name = "dbtnAlpha";
            this.dbtnAlpha.Size = new System.Drawing.Size(122, 22);
            this.dbtnAlpha.Text = "List A-Z";
            this.dbtnAlpha.Click += new System.EventHandler(this.dbtnAlpha_Click);
            // 
            // dbtnNumbered
            // 
            this.dbtnNumbered.CheckOnClick = true;
            this.dbtnNumbered.Name = "dbtnNumbered";
            this.dbtnNumbered.Size = new System.Drawing.Size(122, 22);
            this.dbtnNumbered.Text = "List 123...";
            this.dbtnNumbered.Click += new System.EventHandler(this.dbtnNumbered_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbAlignLeft
            // 
            this.tsbAlignLeft.CheckOnClick = true;
            this.tsbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlignLeft.Image")));
            this.tsbAlignLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlignLeft.Name = "tsbAlignLeft";
            this.tsbAlignLeft.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbAlignLeft.Size = new System.Drawing.Size(34, 26);
            this.tsbAlignLeft.Text = "toolStripButton4";
            this.tsbAlignLeft.Click += new System.EventHandler(this.tsbAlignLeft_Click);
            // 
            // tsbAlignCenter
            // 
            this.tsbAlignCenter.CheckOnClick = true;
            this.tsbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlignCenter.Image")));
            this.tsbAlignCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlignCenter.Name = "tsbAlignCenter";
            this.tsbAlignCenter.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbAlignCenter.Size = new System.Drawing.Size(34, 26);
            this.tsbAlignCenter.Text = "toolStripButton5";
            this.tsbAlignCenter.Click += new System.EventHandler(this.tsbAlignCenter_Click);
            // 
            // tsbAlignRight
            // 
            this.tsbAlignRight.CheckOnClick = true;
            this.tsbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlignRight.Image")));
            this.tsbAlignRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlignRight.Name = "tsbAlignRight";
            this.tsbAlignRight.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbAlignRight.Size = new System.Drawing.Size(34, 26);
            this.tsbAlignRight.Text = "toolStripButton6";
            this.tsbAlignRight.Click += new System.EventHandler(this.tsbAlignRight_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbUndo
            // 
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUndo.Image")));
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbUndo.Size = new System.Drawing.Size(30, 26);
            this.tsbUndo.Click += new System.EventHandler(this.tsbUndo_Click);
            // 
            // tsbRedo
            // 
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRedo.Image")));
            this.tsbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedo.Name = "tsbRedo";
            this.tsbRedo.Size = new System.Drawing.Size(23, 26);
            this.tsbRedo.Text = "toolStripButton2";
            this.tsbRedo.Click += new System.EventHandler(this.tsbRedo_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbTheme
            // 
            this.tsbTheme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTheme.Image = ((System.Drawing.Image)(resources.GetObject("tsbTheme.Image")));
            this.tsbTheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTheme.Name = "tsbTheme";
            this.tsbTheme.Size = new System.Drawing.Size(23, 26);
            this.tsbTheme.ToolTipText = "Change Background Theme";
            this.tsbTheme.Click += new System.EventHandler(this.tsbTheme_Click);
            // 
            // TextPadUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 400);
            this.Controls.Add(this.pnlAdvancedEditor);
            this.Controls.Add(this.redText);
            this.Controls.Add(this.mnuEditor);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuEditor;
            this.Name = "TextPadUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-Unnamed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainTextpad_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainTextpad_FormClosed);
            this.Load += new System.EventHandler(this.frmMainTextpad_Load);
            this.mnuEditor.ResumeLayout(false);
            this.mnuEditor.PerformLayout();
            this.pnlAdvancedEditor.ResumeLayout(false);
            this.pnlAdvancedEditor.PerformLayout();
            this.tlsEditor.ResumeLayout(false);
            this.tlsEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem1;
        public System.Windows.Forms.RichTextBox redText;
        private System.Windows.Forms.ToolStripButton tsbHeading1;
        private System.Windows.Forms.ToolStripButton tsbHeading2;
        private System.Windows.Forms.ToolStripButton tsbHeading3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBulletList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbImage;
        private System.Windows.Forms.ToolStripMenuItem enableDarkModeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox cbxFonts;
        private System.Windows.Forms.ToolStripButton tsbSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbNewFile;
        private System.Windows.Forms.ToolStripButton tsbOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbAlignLeft;
        private System.Windows.Forms.ToolStripButton tsbAlignCenter;
        private System.Windows.Forms.ToolStripButton tsbAlignRight;
        private System.Windows.Forms.ToolStripComboBox cbxFontSize;
        private System.Windows.Forms.ToolStripDropDownButton tsbNumberedList;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        public System.Windows.Forms.FlowLayoutPanel pnlAdvancedEditor;
        public System.Windows.Forms.ToolStrip tlsEditor;
        public System.Windows.Forms.MenuStrip mnuEditor;
        public System.Windows.Forms.ToolStripButton tsbFontStyle;
        public System.Windows.Forms.ToolStripButton tsbFontSize;
        public System.Windows.Forms.ToolStripButton tsbItalic;
        public System.Windows.Forms.ToolStripButton tsbBold;
        public System.Windows.Forms.ToolStripButton tsbUnderline;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dbtnAlpha;
        public System.Windows.Forms.ToolStripMenuItem dbtnNumbered;
        public ColorPicker.ColorToolStripDropDownButton ctsbColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripButton tsbRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbTheme;
    }
}

