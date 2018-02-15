using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class Management : System.Web.UI.Page
    {
        IGUserLogic iGUserLogic;
        ExpenditureLogic expenditureLogic;
        DataTable usersTable, userTypeTable, expnTypeTable;
        public Management()
        {
            iGUserLogic = new IGUserLogic();
            expenditureLogic = new ExpenditureLogic();
            usersTable = new DataTable();
            userTypeTable = new DataTable();
            expnTypeTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateUserTable();
            PopulateUserTypeTable();
            PopulateExpnTypeTable();
        }
        private void PopulateUserTable()
        {
            usersTable.Clear();
            usersTable = iGUserLogic.GetAllIGUser();
            RepeaterIGUserList.DataSource = usersTable;
            RepeaterIGUserList.DataBind();
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
    }
}