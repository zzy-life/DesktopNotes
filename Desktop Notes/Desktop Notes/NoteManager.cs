using System;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class NoteManager : Form
    {
        public NoteManager()
        {
            InitializeComponent();
            LoadAllNotes();
            Program.newNoteAddedEvent += Program_newNoteAddedEvent;
        }

        public void LoadAllNotes()
        {
            listView1.Items.Clear();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(MainForm)) continue;
                MainForm form = (MainForm)f;
                ListViewItem litm = new ListViewItem(form.Title);
                litm.Tag = form;
                if (form.Visible)
                {
                    litm.SubItems.Add("可见");
                }
                else
                {
                    litm.SubItems.Add("隐藏");
                    litm.Text = "[" + litm.Text + "]";
                }
                listView1.Items.Add(litm);
            }
        }

        void Program_newNoteAddedEvent(object sender, EventArgs e)
        {
            LoadAllNotes();
        }
        
        //
        // Buttons
        //
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newNote_Click(object sender, EventArgs e)
        {
            Program.AddNewNote();
        }
        
        private void showSelected_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems == null) return;
            foreach(ListViewItem litm in listView1.CheckedItems)
            {
                MainForm form = (MainForm)litm.Tag;
                form.Show();
                Component1.SetForegroundWindow(form.Handle);
            }
            LoadAllNotes();
        }

        private void hideSelected_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems == null) return;
            foreach (ListViewItem litm in listView1.CheckedItems)
            {
                MainForm form = (MainForm)litm.Tag;
                form.Hide(); 
            }
            LoadAllNotes();
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems == null) return;

            if (MessageBox.Show("您确定删除所有选定的笔记吗?", "全部删除?",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) return;

            foreach (ListViewItem litm in listView1.CheckedItems)
            {
                MainForm form = (MainForm)litm.Tag;
                REGISTRY.Delete(form.FORM_ID.ToString());
                Program.EmptySlots.Enqueue(form.FORM_ID);
                form.Close();
            }
            LoadAllNotes();
        }

        //
        //context menu strip
        //
        private void checkSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null) return;
            foreach(ListViewItem litm in listView1.SelectedItems)
            {
                litm.Checked = true;
            }
        }

        private void uncheckSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems == null) return;
            foreach (ListViewItem litm in listView1.SelectedItems)
            {
                litm.Checked = false;
            }
        }

        private void inverseCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem litm in listView1.Items)
            {
                litm.Checked = !litm.Checked;
            }
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem litm in listView1.Items)
            {
                litm.Checked = true;
            }
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem litm in listView1.Items)
            {
                litm.Checked = false;
            }
        }
        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllNotes();
        }
    }
}
