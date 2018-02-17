using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class Management : System.Web.UI.Page
    {
        IGUserLogic iGUserLogic;
        DataTable usersTable, userTypeTable;
        public Management()
        {
            iGUserLogic = new IGUserLogic();
            usersTable = new DataTable();
            userTypeTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateUserTable();

            PopulateUserTypeDL();
        }
        private void PopulateUserTable()
        {
            usersTable.Clear();
            usersTable = iGUserLogic.GetAllIGUser();
            RepeaterIGUserList.DataSource = usersTable;
            RepeaterIGUserList.DataBind();
        }
        protected void ButtonAddNewUser_Click(object sender, EventArgs e)
        {
            string fullName = TextBoxFullName.Text;
            string username = TextBoxUsername.Text;
            string email = TextBoxEmail.Text;
            string password = TextBoxPass.Text;
            string confirmPass = TextBoxConfPass.Text;
            string userType = DropDownListUserType.Text;

            if (password == confirmPass)
            {
                Dictionary<string, string> newUser = new Dictionary<string, string>()
                {
                    { "Name", fullName },
                    { "Username", username },
                    { "Email", email },
                    { "Password", password },
                    { "Type", userType }
                };
                if (iGUserLogic.RegisterNewIGUser(newUser))
                {
                    Response.Redirect("Management.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Password and Confirm Password is not matched!!');</script>");
            }
        }
        public void PopulateUserTypeDL()
        {
            userTypeTable.Clear();
            userTypeTable = iGUserLogic.GetUserTypes();
            foreach (DataRow item in userTypeTable.Rows)
            {
                string type = item["Type"].ToString();
                DropDownListUserType.Items.Add(new ListItem(type, type));
            }
        }
    }
}