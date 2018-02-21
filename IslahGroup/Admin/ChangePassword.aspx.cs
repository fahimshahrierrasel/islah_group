using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace IslahGroup.Admin
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        IGUserLogic iGUserLogic;
        DataTable userTypeTable;
        DataTable userTable;
        int userId;
        public ChangePassword()
        {
            iGUserLogic = new IGUserLogic();
            userTypeTable = new DataTable();
            userTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(Session["UserId"].ToString());
            PopulateUserData();
        }
        private void PopulateUserData()
        {
            userTable.Clear();
            Dictionary<string, int> user = new Dictionary<string, int>()
            {
                { "UserId", userId }
            };
            userTable = iGUserLogic.GetSingleUserById(user);
        }

        protected void ButtonUpdateUser_Click(object sender, EventArgs e)
        {
            string password = TextBoxPass.Text;
            string currentPassword = TextBoxCurrentPass.Text;
            string confirmPass = TextBoxConfPass.Text;

            if (currentPassword.Equals(userTable.Rows[0]["APassword"].ToString()))
            {
                if (password == confirmPass)
                {
                    Dictionary<string, string> newUser = new Dictionary<string, string>()
                    {
                        { "UserId", userId.ToString() },
                        { "Password", password }
                    };
                    if (iGUserLogic.ChangePassword(newUser))
                    {
                        Response.Write("<script>alert('Password Changed!!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Password and Confirm Password is not matched!!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Current password is not matched!!');</script>");
            }

        }
    }
}