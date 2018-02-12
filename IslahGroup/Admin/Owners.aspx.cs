using IslahGroup.DotNet.BusinessLogicLayer;
using IslahGroup.DotNet.DataAccessLayer;
using System;
using System.Data;

namespace IslahGroup.Admin
{
    public partial class Owners : System.Web.UI.Page
    {
        DataTable userDataTable;
        OwnerLogic od;
        protected void Page_Load(object sender, EventArgs e)
        {
            userDataTable = new DataTable();
            od = new OwnerLogic();
            if(!IsPostBack)
            {
                PopulateUserTable();
            }
        }


        private void PopulateUserTable()
        {
            userDataTable.Clear();
            userDataTable = od.GetAllOwners();
            Repeater1.DataSource = userDataTable;
            Repeater1.DataBind();
        }
    }
}