using System;
using System.Windows.Forms;

namespace IslahGroupInventory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tsslUsername.Text = BranchInfo.Username;
            tsslBranchCode.Text = BranchInfo.BranchCode;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
