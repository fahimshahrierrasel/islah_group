using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IslahGroupInventory
{
    public partial class Login : Form
    {
        private int branchId;
        private string branchCode;
        InventoryDataClassesDataContext dbContext;

        public Login()
        {
            InitializeComponent();
            LoadConfig();
            dbContext = new InventoryDataClassesDataContext();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string pass = tbPassword.Text;
            var iGUser = dbContext.IGUsers.SingleOrDefault(user => 
                user.Branch_BranchId == branchId &&
                user.Email == email &&
                user.APassword == pass);

            if(iGUser != null)
            {
                var mainForm = new MainForm();
                BranchInfo.SetBranchInfo(branchId, branchCode, iGUser.UserId, iGUser.AUsername);
                mainForm.Show();
                Close();
            }
            else
            {
                XtraMessageBox.Show("User not found! Please contact with the adminstrator.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadConfig()
        {
            XmlDocument config = new XmlDocument();

            try
            {
                config.Load("config.xml");
                XmlNodeList nodeList = config.DocumentElement.SelectNodes("/config/branch");

                branchId = Convert.ToInt32(nodeList[0].SelectSingleNode("id").InnerText);
                branchCode = nodeList[0].SelectSingleNode("code").InnerText.ToString();
            }
            catch (FileNotFoundException)
            {
                XtraMessageBox.Show("configuration file not found!! Please contact with the developer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
        }
    }
}
