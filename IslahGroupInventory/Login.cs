using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslahGroupInventory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            bindingSourceBranch.DataSource = new InventoryDataClassesDataContext().Branches;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
