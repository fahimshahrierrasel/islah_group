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
        ExpenditureLogic expenditureLogic;
        InvestLogic investLogic;
        DataTable usersTable, userTypeTable, expnTypeTable, investTypeTable;
        public Management()
        {
            iGUserLogic = new IGUserLogic();
            expenditureLogic = new ExpenditureLogic();
            investLogic = new InvestLogic();
            usersTable = new DataTable();
            userTypeTable = new DataTable();
            expnTypeTable = new DataTable();
            investTypeTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateUserTable();
            PopulateUserTypeTable();
            PopulateExpnTypeTable();
            PopulateInvestTypeTable();

            PopulateUserTypeDL();
        }
        private void PopulateUserTable()
        {
            usersTable.Clear();
            usersTable = iGUserLogic.GetAllIGUser();
            RepeaterIGUserList.DataSource = usersTable;
            RepeaterIGUserList.DataBind();
        }

        private void PopulateInvestTypeTable()
        {
            investTypeTable.Clear();
            investTypeTable = investLogic.GetInvestType();
            RepeaterInvestTypes.DataSource = investTypeTable;
            RepeaterInvestTypes.DataBind();
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
                iGUserLogic.RegisterNewIGUser(newUser);
            }
            else
            {
                Response.Write("<script>alert('Password and Confirm Password is not matched!!');</script>");
            }
            Response.Write("<script>console.log('Button Clicked');</script>");
        }

        protected void ButtonAddUserType_Click(object sender, EventArgs e)
        {
            string userType = TextBoxUserType.Text;
            if (String.IsNullOrEmpty(userType))
            {
                Dictionary<string, string> newType = new Dictionary<string, string>()
                {
                    { "Type", userType }
                };
                if (iGUserLogic.AddNewUserType(newType))
                {
                    Response.Redirect(Request.RawUrl);
                }
            }

        }

        protected void ButtonAddExpnType_Click(object sender, EventArgs e)
        {
            string expnType = TextBoxInvestType.Text;
            if (String.IsNullOrEmpty(expnType))
            {
                Dictionary<string, string> newType = new Dictionary<string, string>()
                {
                    { "Type", expnType }
                };
                if (expenditureLogic.NewExpenditureType(newType))
                {
                    Response.Redirect(Request.RawUrl);
                }
            }
        }

        protected void ButtonAddInvestType_Click(object sender, EventArgs e)
        {
            string investType = TextBoxInvestType.Text;
            if(String.IsNullOrEmpty(investType))
            { 
                Dictionary<string, string> newType = new Dictionary<string, string>()
                {
                    { "Type", investType }
                };
                if (investLogic.AddNewInvestType(newType))
                {
                    Response.Redirect(Request.RawUrl);
                }
            }
        }
        private void PopulateUserTypeTable()
        {
            userTypeTable.Clear();
            userTypeTable = iGUserLogic.GetUserTypes();
            RepeaterUserTypes.DataSource = userTypeTable;
            RepeaterUserTypes.DataBind();
        }
        private void PopulateExpnTypeTable()
        {
            expnTypeTable.Clear();
            expnTypeTable = expenditureLogic.ExpenditureTypes();
            RepeaterExpnTypes.DataSource = expnTypeTable;
            RepeaterExpnTypes.DataBind();
        }

        public void PopulateUserTypeDL()
        {
            foreach (DataRow item in userTypeTable.Rows)
            {
                string type = item["Type"].ToString();
                DropDownListUserType.Items.Add(new ListItem(type, type));
            }
        }
    }
}