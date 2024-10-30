using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class MainForm : Form
    {
        public MainForm(int id, FormData dat = null)
        {
            InitializeComponent();

            FORM_ID = id;
            CustomTheme = new Theme();
            CustomStyle = new Style();

            loadThemes();
            loadStyles();
            this.AllowTransparency = true;
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.Manual;

            LoadData(dat);
            this.DateTimeLabel.Text = CreationTime.ToString();

            //set sure dialog
            Bitmap image = new Bitmap(sureDialog.Width, sureDialog.Height);
            Graphics g = Graphics.FromImage(image);
            Brush brush = new HatchBrush(HatchStyle.OutlinedDiamond, Color.Turquoise, Color.LightBlue);
            g.FillRectangle(brush, 0, 0, sureDialog.Width, sureDialog.Height);
            sureDialog.BackgroundImage = image;
            sureDialog.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LoadData(FormData dat = null)
        {
            //load defaults
            this.Opacity = 0.95;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.CreationTime = DateTime.Now;
            if (string.IsNullOrEmpty(Title))
            {
                Title = string.Format("Note {0:##}", FORM_ID);
            }
            if (Program.Themes.Count > 1)
            {
                Random rand = new Random();
                CurrentTheme = rand.Next(Program.Themes.Count - 1) + 1;
            }
            if (Program.Styles.Count > 1)
            {
                CurrentStyle = 1;
            }
            if (dat == null)
            {
                this.Show();
                return;
            }

            //load others
            this.SuspendLayout();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = dat.Location;
            this.Size = dat.FormSize;
            this.notebox1.Rtf = dat.data;
            this.Opacity = dat.opacity;
            this.Title = dat.title;
            if (dat.customTheme != null) { this.CustomTheme = dat.customTheme; }
            this.CurrentTheme = dat.theme;
            if (dat.customStyle != null) { this.CustomStyle = dat.customStyle; }
            this.CurrentStyle = dat.currentStyle;
            if (dat.creationTime > new DateTime(2014, 1, 1)) { this.CreationTime = dat.creationTime; }
            this.ResumeLayout(true);

            this.Show();
            if (dat.hidden) this.Hide();
        }

        //
        // Properties and Variables
        //
        public DateTime CreationTime { get; set; }
        public int FORM_ID { get; set; }
        public string Title
        {
            get { return titlebar.Text; }
            set { titlebar.Text = value; Save(); }
        }
        public Theme CustomTheme { get; set; }
        public Style CustomStyle { get; set; }

        private int _theme = 0;
        public int CurrentTheme
        {
            get { return _theme; }
            set
            {
                if (value >= Program.Themes.Count)
                    value = Program.Themes.Count - 1;
                if (value < 0) value = 0;

                if (_theme != value)
                {
                    _theme = value;
                    Save();
                }
                ReloadTheme();
            }
        }

        private int _style = 0;
        public int CurrentStyle
        {
            get { return _style; }
            set
            {
                if (value >= Program.Styles.Count)
                    value = Program.Styles.Count - 1;
                if (value < 0) value = 0;

                if (_style != value)
                {
                    _style = value;
                    Save();
                }
                ReloadStyle();
            }
        }

        public void ReloadTheme()
        {
            Theme th = Program.Themes[_theme];
            if (th.Name == "Custom") th = CustomTheme;
            this.notebox1.BackColor = th.BackColor;
            this.notebox1.ForeColor = th.TextColor;
            this.TopBar.BackColor = th.TopBarColor;
            this.titlebar.BackColor = th.TopBarColor;
            this.addNote.BackColor = th.TopBarColor;
            this.deleteNote.BackColor = th.TopBarColor;
            this.hideNote.BackColor = th.TopBarColor;
            this.bottomPanel.BackColor = th.TopBarColor;
            this.BackColor = th.BackColor;
        }
        public void ReloadStyle()
        {
            Style th = Program.Styles[_style];
            if (th.Name == "Custom") th = CustomStyle;
            this.notebox1.Font = th.GetFont();
        }

        //
        //Drag form using Topbar
        //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam); //use INT for 32bit and LONG for 64bit

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, long Msg, long wParam, long lParam); //use INT for 32bit and LONG for 64bit
        [DllImportAttribute("user32.dll")]
        public static extern int ReleaseCapture();

        private void TopBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();                                   
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);                
            }
        }

        //
        // save and load data
        // 
        public bool Save()
        {
            try
            {
                REGISTRY.SetData(FORM_ID.ToString(), new FormData(this));
                return true;
            }
            catch { return false; }
        }

        private void property_Changed(object sender, EventArgs e)
        {
            Save();
        }

        //
        // Themes and Styles
        //
        void loadThemes()
        {
            themeContext.Items.Clear();
            for (int i = 0; i < Program.Themes.Count; ++i)
            {
                ToolStripMenuItem ti = new ToolStripMenuItem();
                ti.Text = Program.Themes[i].Name;
                ti.Tag = i;
                ti.Click += delegate(object sender, EventArgs e)
                {
                    CurrentTheme = (int)((ToolStripItem)sender).Tag;
                };
                themeContext.Items.Add(ti);
            }
        }

        void loadStyles()
        {
            styleContext.Items.Clear();
            for (int i = 0; i < Program.Styles.Count; ++i)
            {
                ToolStripMenuItem ti = new ToolStripMenuItem();
                ti.Text = Program.Styles[i].Name;
                ti.Tag = i;
                ti.Click += delegate(object sender, EventArgs e)
                {
                    CurrentStyle = (int)((ToolStripItem)sender).Tag;
                };
                styleContext.Items.Add(ti);
            }
        }

        //
        // Topbar icons
        //
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool edit = (sender.Equals(notebox1));
            cutToolStripMenuItem.Visible = edit;
            copyToolStripMenuItem.Visible = edit;
            pasteToolStripMenuItem.Visible = edit;
            toolStripSeparator1.Visible = edit;
            stayOnTopToolStripMenuItem.Checked = this.TopMost;
        }
        private void themeContext_Opening(object sender, CancelEventArgs e)
        {
            foreach (ToolStripMenuItem tmi in themeContext.Items)
            {
                tmi.Checked = ((int)tmi.Tag == CurrentTheme);
            }
        }

        private void styleContext_Opening(object sender, CancelEventArgs e)
        {
            foreach (ToolStripMenuItem tmi in styleContext.Items)
            {
                tmi.Checked = ((int)tmi.Tag == CurrentStyle);
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            notebox1.Cut();
        }
        private void copy_Click(object sender, EventArgs e)
        {
            notebox1.Copy();
        }
        private void paste_Click(object sender, EventArgs e)
        {
            notebox1.Paste();
        }
        private void stayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stayOnTopToolStripMenuItem.Checked = !stayOnTopToolStripMenuItem.Checked;
            this.TopMost = stayOnTopToolStripMenuItem.Checked;
            Save();
        }

        private void hideNote_Click(object sender, EventArgs e)
        {
            notebox1.Focus();
            this.Hide();
        }
        private void addNote_Click(object sender, EventArgs e)
        {
            notebox1.Focus();
            Program.AddNewNote();
        }
        private void deleteNote_Click(object sender, EventArgs e)
        {
            // 切换 notebox1 的 ReadOnly 属性
            notebox1.ReadOnly = !notebox1.ReadOnly;

            // 显示当前状态
            if (notebox1.ReadOnly)
            {
                MessageBox.Show("已设置为只读模式");
            }
            else
            {
                MessageBox.Show("已设置为可编辑模式");
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm(this);
            setting.ShowDialog(this);
        }
        private void SettingsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settings_Click(null, EventArgs.Empty);
        }


        //
        // Sure Dialog
        //
        private void yesButton_Click(object sender, EventArgs e)
        {
            REGISTRY.Delete(FORM_ID.ToString());
            Program.EmptySlots.Enqueue(FORM_ID);
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            sureDialog.Visible = false;
            this.TopMost = false;
        }

        //
        // Button Style
        //
        private void addButton_Enter(object sender, EventArgs e)
        {
            addNote.Image = Properties.Resources.add;
        }

        private void addButton_Leave(object sender, EventArgs e)
        {
            addNote.Image = Properties.Resources.add_gray;
        }

        private void hideButton_Enter(object sender, EventArgs e)
        {
            hideNote.Image = Properties.Resources.hide;
        }

        private void hideButton_Leave(object sender, EventArgs e)
        {
            hideNote.Image = Properties.Resources.hide_gray;
        }

        private void deleteButton_Enter(object sender, EventArgs e)
        {
            deleteNote.Image = Properties.Resources.delete;
        }

        private void deleteButton_Leave(object sender, EventArgs e)
        {
            deleteNote.Image = Properties.Resources.delete_gray;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All Files | *.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Title = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                    string ext = System.IO.Path.GetExtension(ofd.FileName);
                    if(ext.ToLower() == ".rtf")
                        this.notebox1.Rtf = System.IO.File.ReadAllText(ofd.FileName);
                    else 
                        this.notebox1.Text = System.IO.File.ReadAllText(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "All Files | *.*";
                sfd.FileName = Title + ".rtf";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    if (ext.ToLower() == ".rtf")
                        this.notebox1.SaveFile(sfd.FileName);
                    else                        
                        System.IO.File.WriteAllText(sfd.FileName, notebox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
