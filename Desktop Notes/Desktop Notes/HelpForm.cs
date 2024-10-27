using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            productName.Text = Application.ProductName;
            versionLabel.Text = "Version " + Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("mailto:" + linkLabel1.Text); }
            catch { } 
        }
    }
}
