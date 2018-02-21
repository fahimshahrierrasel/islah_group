using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Data;

namespace IslahGroup
{
    public partial class About : System.Web.UI.Page
    {
        CMSLogic cmsLogic;
        DataTable ownersTable;
        public About()
        {
            cmsLogic = new CMSLogic();
            ownersTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ownersTable.Clear();
                ownersTable = cmsLogic.GetOwnersShortBio();
                RepeaterOwners.DataSource = ownersTable;
                RepeaterOwners.DataBind();
            }
        }
    }
}