using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        IGUserLogic iGUserLogic;
        DataTable userTable, userTypeTable;
        int userId;
        public UpdateUser()
        {
            iGUserLogic = new IGUserLogic();
            userTable = new DataTable();
            userTypeTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(Request.QueryString["UID"]);
            if (!IsPostBack)
            {
                PopulateUserTypeDL();
                PopulateUserTable();
            }
        }
        private void PopulateUserTable()
        {
            userTable.Clear();
            Dictionary<string, int> user = new Dictionary<string, int>()
            {
                { "UserId", userId }
            };
            userTable = iGUserLogic.GetSingleUserById(user);
            if (userTable.Rows.Count == 1)
            {
                DataRow dr = userTable.Rows[0];
                TextBoxFullName.Text = dr["AName"].ToString();
                TextBoxUsername.Text = dr["AUsername"].ToString();
                TextBoxEmail.Text = dr["Email"].ToString();
                TextBoxPass.Text = dr["APassword"].ToString();
                DropDownListUserType.Text = dr["UserType"].ToString();
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

        protected void ButtonUpdateUser_Click(object sender, EventArgs e)
        {
            string fullName = TextBoxFullName.Text;
            string username = TextBoxUsername.Text;
            string email = TextBoxEmail.Text;
            string password = TextBoxPass.Text;
            string userType = DropDownListUserType.Text;

            Dictionary<string, string> newUser = new Dictionary<string, string>()
            {
                { "UserId", userId.ToString() },
                { "FullName", fullName },
                { "Username", username },
                { "Email", email },
                { "Password", password },
                { "Type", userType }
            };
            iGUserLogic.UpdateIGUser(newUser);

            Response.Redirect("Management.aspx");
        }
    }
}