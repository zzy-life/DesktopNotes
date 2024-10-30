namespace Desktop_Notes
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.styleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.hideNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notebox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sureDialog = new System.Windows.Forms.Panel();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.LinkLabel();
            this.TopBar = new System.Windows.Forms.TableLayoutPanel();
            this.hideNote = new System.Windows.Forms.Button();
            this.addNote = new System.Windows.Forms.Button();
            this.deleteNote = new System.Windows.Forms.Button();
            this.titlebar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.sureDialog.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stayOnTopToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.toolStripSeparator2,
            this.newNoteToolStripMenuItem,
            this.toolStripSeparator3,
            this.hideNoteToolStripMenuItem,
            this.toolStripSeparator4,
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 176);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // stayOnTopToolStripMenuItem
            // 
            this.stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            this.stayOnTopToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.stayOnTopToolStripMenuItem.Text = "始终置顶";
            this.stayOnTopToolStripMenuItem.Click += new System.EventHandler(this.stayOnTopToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDown = this.styleContext;
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.styleToolStripMenuItem.Text = "字体样式";
            // 
            // styleContext
            // 
            this.styleContext.Name = "themeContext";
            this.styleContext.OwnerItem = this.styleToolStripMenuItem;
            this.styleContext.Size = new System.Drawing.Size(61, 4);
            this.styleContext.Opening += new System.ComponentModel.CancelEventHandler(this.styleContext_Opening);
            // 
            // styleToolStripMenuItem1
            // 
            this.styleToolStripMenuItem1.DropDown = this.styleContext;
            this.styleToolStripMenuItem1.Name = "styleToolStripMenuItem1";
            this.styleToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.styleToolStripMenuItem1.Text = "字体样式";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDown = this.themeContext;
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.themeToolStripMenuItem.Text = "主题";
            // 
            // themeContext
            // 
            this.themeContext.Name = "themeContext";
            this.themeContext.OwnerItem = this.themeToolStripMenuItem;
            this.themeContext.Size = new System.Drawing.Size(61, 4);
            this.themeContext.Opening += new System.ComponentModel.CancelEventHandler(this.themeContext_Opening);
            // 
            // themeToolStripMenuItem1
            // 
            this.themeToolStripMenuItem1.DropDown = this.themeContext;
            this.themeToolStripMenuItem1.Name = "themeToolStripMenuItem1";
            this.themeToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.themeToolStripMenuItem1.Text = "主题";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Image = global::Desktop_Notes.Properties.Resources.add;
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newNoteToolStripMenuItem.Text = "新建笔记";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.addNote_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // hideNoteToolStripMenuItem
            // 
            this.hideNoteToolStripMenuItem.Image = global::Desktop_Notes.Properties.Resources.hide;
            this.hideNoteToolStripMenuItem.Name = "hideNoteToolStripMenuItem";
            this.hideNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hideNoteToolStripMenuItem.Text = "隐藏笔记";
            this.hideNoteToolStripMenuItem.Click += new System.EventHandler(this.hideNote_Click);
          
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Desktop_Notes.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.settingsToolStripMenuItem.Text = "设置";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settings_Click);
            // 
            // notebox1
            // 
            this.notebox1.AcceptsTab = true;
            this.notebox1.AutoWordSelection = true;
            this.notebox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.notebox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notebox1.ContextMenuStrip = this.contextMenuStrip2;
            this.notebox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notebox1.EnableAutoDragDrop = true;
            this.notebox1.ForeColor = System.Drawing.Color.Black;
            this.notebox1.Location = new System.Drawing.Point(0, 26);
            this.notebox1.Name = "notebox1";
            this.notebox1.ShowSelectionMargin = true;
            this.notebox1.Size = new System.Drawing.Size(204, 222);
            this.notebox1.TabIndex = 1;
            this.notebox1.Text = "";
            this.notebox1.TextChanged += new System.EventHandler(this.property_Changed);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.openFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.toolStripSeparator8,
            this.styleToolStripMenuItem1,
            this.themeToolStripMenuItem1,
            this.toolStripSeparator7,
            this.settingsToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(132, 198);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cutToolStripMenuItem.Text = "剪切";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.copyToolStripMenuItem.Text = "复制";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pasteToolStripMenuItem.Text = "粘贴";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.paste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.openFileToolStripMenuItem.Text = "打开文件";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveToFileToolStripMenuItem.Text = "保存到文件";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(128, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(128, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Image = global::Desktop_Notes.Properties.Resources.settings;
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.settingsToolStripMenuItem1.Text = "设置";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settings_Click);
            // 
            // sureDialog
            // 
            this.sureDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sureDialog.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sureDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sureDialog.Controls.Add(this.noButton);
            this.sureDialog.Controls.Add(this.yesButton);
            this.sureDialog.Controls.Add(this.label1);
            this.sureDialog.Location = new System.Drawing.Point(14, 95);
            this.sureDialog.Name = "sureDialog";
            this.sureDialog.Size = new System.Drawing.Size(175, 90);
            this.sureDialog.TabIndex = 3;
            this.sureDialog.Visible = false;
            // 
            // noButton
            // 
            this.noButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noButton.Location = new System.Drawing.Point(92, 59);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 24);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yesButton.Location = new System.Drawing.Point(6, 59);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 24);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "您确定要删除此笔记吗？";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.ColumnCount = 2;
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomPanel.Controls.Add(this.DateTimeLabel, 1, 0);
            this.bottomPanel.Controls.Add(this.SettingsLabel, 0, 0);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 248);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.RowCount = 1;
            this.bottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomPanel.Size = new System.Drawing.Size(204, 16);
            this.bottomPanel.TabIndex = 4;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimeLabel.Location = new System.Drawing.Point(105, 1);
            this.DateTimeLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(96, 14);
            this.DateTimeLabel.TabIndex = 0;
            this.DateTimeLabel.Text = "日期和时间";
            this.DateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLabel.Location = new System.Drawing.Point(3, 1);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(96, 14);
            this.SettingsLabel.TabIndex = 1;
            this.SettingsLabel.TabStop = true;
            this.SettingsLabel.Text = "设置";
            this.SettingsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SettingsLabel_LinkClicked);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.TopBar.ColumnCount = 4;
            this.TopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TopBar.Controls.Add(this.hideNote, 3, 0);
            this.TopBar.Controls.Add(this.addNote, 0, 0);
            this.TopBar.Controls.Add(this.deleteNote, 2, 0);
            this.TopBar.Controls.Add(this.titlebar, 1, 0);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.RowCount = 1;
            this.TopBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopBar.Size = new System.Drawing.Size(204, 26);
            this.TopBar.TabIndex = 6;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // hideNote
            // 
            this.hideNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hideNote.FlatAppearance.BorderSize = 0;
            this.hideNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.hideNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this.hideNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideNote.Image = global::Desktop_Notes.Properties.Resources.hide_gray;
            this.hideNote.Location = new System.Drawing.Point(177, 1);
            this.hideNote.Margin = new System.Windows.Forms.Padding(1);
            this.hideNote.Name = "hideNote";
            this.hideNote.Size = new System.Drawing.Size(26, 24);
            this.hideNote.TabIndex = 2;
            this.hideNote.UseVisualStyleBackColor = true;
            this.hideNote.Click += new System.EventHandler(this.hideNote_Click);
            this.hideNote.Enter += new System.EventHandler(this.hideButton_Enter);
            this.hideNote.Leave += new System.EventHandler(this.hideButton_Leave);
            this.hideNote.MouseEnter += new System.EventHandler(this.hideButton_Enter);
            this.hideNote.MouseLeave += new System.EventHandler(this.hideButton_Leave);
            // 
            // addNote
            // 
            this.addNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNote.FlatAppearance.BorderSize = 0;
            this.addNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.addNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this.addNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNote.Image = global::Desktop_Notes.Properties.Resources.add_gray;
            this.addNote.Location = new System.Drawing.Point(1, 1);
            this.addNote.Margin = new System.Windows.Forms.Padding(1);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(26, 24);
            this.addNote.TabIndex = 0;
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            this.addNote.Enter += new System.EventHandler(this.addButton_Enter);
            this.addNote.Leave += new System.EventHandler(this.addButton_Leave);
            this.addNote.MouseEnter += new System.EventHandler(this.addButton_Enter);
            this.addNote.MouseLeave += new System.EventHandler(this.addButton_Leave);
            // 
            // deleteNote
            // 
            this.deleteNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteNote.FlatAppearance.BorderSize = 0;
            this.deleteNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.deleteNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cornsilk;
            this.deleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNote.Image = global::Desktop_Notes.Properties.Resources.edit_gray;
            this.deleteNote.Location =  new System.Drawing.Point(149, 1);
            this.deleteNote.Margin = new System.Windows.Forms.Padding(1);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(26, 24);
            this.deleteNote.TabIndex = 1;
            this.deleteNote.UseVisualStyleBackColor = true;
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            this.deleteNote.Enter += new System.EventHandler(this.deleteButton_Enter);
            this.deleteNote.Leave += new System.EventHandler(this.deleteButton_Leave);
            this.deleteNote.MouseEnter += new System.EventHandler(this.deleteButton_Enter);
            this.deleteNote.MouseLeave += new System.EventHandler(this.deleteButton_Leave);
            // 
            // titlebar
            // 
            this.titlebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.titlebar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titlebar.ContextMenuStrip = this.contextMenuStrip1;
            this.titlebar.Cursor = System.Windows.Forms.Cursors.Default;
            this.titlebar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebar.Location = new System.Drawing.Point(31, 4);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(114, 18);
            this.titlebar.TabIndex = 3;
            this.titlebar.TextChanged += new System.EventHandler(this.property_Changed);
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(204, 264);
            this.ControlBox = false;
            this.Controls.Add(this.notebox1);
            this.Controls.Add(this.sureDialog);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.TopBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.LocationChanged += new System.EventHandler(this.property_Changed);
            this.SizeChanged += new System.EventHandler(this.property_Changed);
            this.VisibleChanged += new System.EventHandler(this.property_Changed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.sureDialog.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem; 
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.RichTextBox notebox1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip themeContext;
        private System.Windows.Forms.ToolStripMenuItem hideNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel sureDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.ToolStripMenuItem stayOnTopToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.LinkLabel SettingsLabel;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip styleContext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.TableLayoutPanel TopBar;
        private System.Windows.Forms.Button hideNote;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Button deleteNote;
        private System.Windows.Forms.TextBox titlebar;

    }
}

