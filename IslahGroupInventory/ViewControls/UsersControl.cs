using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IslahGroupInventory.ViewControls
{
    public partial class UsersControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        public UsersControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedIndex = 0;
            InitializeComboBoxUserType();
            LoadUserGridView();
        }

        private void InitializeComboBoxUserType()
        {
            bindingSourceUsertype.DataSource = new InventoryDataClassesDataContext().UserTypes
                .Where(ut => ut.UsrType != "Admin");
        }

        private void LoadUserGridView()
        {
            iGUsersBindingSource.DataSource = new InventoryDataClassesDataContext().IGUsers
                .Where(u => u.Branch_BranchId == BranchInfo.BranchId && u.UserType_UsrType != "Admin");
        }

        private void ButtonRegisterUser_Click(object sender, EventArgs e)
        {
            string name = textBoxFullName.Text;
            string email = textBoxEmail.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPass.Text;
            string confPass = textBoxConfPass.Text;
            string userType = comboBoxUserType.Text.ToString();
            string status = comboBoxStatus.SelectedItem.ToString();
            if (password == confPass)
            {
                IGUser user = new IGUser()
                {
                    AName = name,
                    Email = email,
                    AUsername = username,
                    APassword = password,
                    Status = status,
                    UserType_UsrType = userType,
                    Branch_BranchId = BranchInfo.BranchId
                };

                dbContext.IGUsers.InsertOnSubmit(user);
                dbContext.SubmitChanges();

                LoadUserGridView();
            }
            else
            {
                XtraMessageBox.Show("Passwords not matched!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

