using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class Component1 : Component
    {
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(IntPtr hWnd);

        public Component1()
        {
            InitializeComponent();

            this.showall_menu.Click += showall_menu_Click;
            this.hideall_menu.Click += hideall_menu_Click;
            this.newnote_menu.Click += newnote_menu_Click;
            this.help_menu.Click += help_menu_Click;
            this.exit_menu.Click += exit_menu_Click;
            this.start_windows.Checked = REGISTRY.StartWithWindows;
            this.start_windows.CheckedChanged += start_windows_CheckedChanged;
            this.noteManager_form.Click += noteManager_form_Click;
        }

        public Component1(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        //start with windows
        void start_windows_CheckedChanged(object sender, EventArgs e)
        {
            REGISTRY.StartWithWindows = start_windows.Checked;
        }

        //notify icon
        public void SetIconVisible()
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
        }
        
        public static NoteManager noteManager;
        void noteManager_form_Click(object sender, System.EventArgs e)
        {
            if (noteManager == null || noteManager.IsDisposed)
                noteManager = new NoteManager();
            noteManager.Show();
        }

        void newnote_menu_Click(object sender, System.EventArgs e)
        {
            Program.AddNewNote();
        }        

        void hideall_menu_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MainForm)) continue;
                f.Hide();
            }
        }

        void showall_menu_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MainForm)) continue;
                f.Show();
                SetForegroundWindow(f.Handle);
            }
        }

        void help_menu_Click(object sender, EventArgs e)
        {
            HelpForm hp = new HelpForm();
            hp.Show();
        }

        void exit_menu_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void context1_Opening(object sender, CancelEventArgs e)
        {
            while (context1.Items[0].Tag != null)
                context1.Items.RemoveAt(0);

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MainForm)) continue;
                ToolStripMenuItem menu = new ToolStripMenuItem();
                menu.Text = ((MainForm)f).Title;
                menu.Tag = f;
                menu.Click += showhide_Click;
                context1.Items.Insert(0, menu);
                if (f.Visible)
                {
                    menu.Image = null;
                }
                else
                {
                    menu.Image = Properties.Resources.show;
                    menu.Text = "[" + menu.Text + "]";
                }
            }
        }

        void showhide_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem menu = (ToolStripMenuItem)sender;
                MainForm f = (MainForm)menu.Tag;
                if (!f.Visible) f.Visible = true;
                else f.BringToFront();
                context1.Items.Remove(menu);
            }
            catch { }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() != typeof(MainForm)) continue;
                    if (f.Visible) SetForegroundWindow(f.Handle);
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                noteManager_form_Click(null, EventArgs.Empty);                
            }
        }

    }
}