using IslahGroup.DotNet.BusinessLogicLayer;
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
            if(Session["UserType"].ToString().Equals("Admin") || Session["UserType"].ToString().Equals("Director"))
            { }
            else
            {
                RegisterOwnerArea.Visible = false;
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