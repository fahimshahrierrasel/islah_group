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
    public partial class Members : System.Web.UI.Page
    {
        MemberLogic memberLogic;
        DataTable memberTable;
        public Members()
        {
            memberLogic = new MemberLogic();
            memberTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateMemberTable();
        }

        private void PopulateMemberTable()
        {
            memberTable.Clear();
            Dictionary<string, string> filter = new Dictionary<string, string>()
            {
                { "Status", "ACT"}
            };
            memberTable = memberLogic.GetAllMemberByActiveStatus(filter);
            RepeaterMemberLists.DataSource = memberTable;
            RepeaterMemberLists.DataBind();
        }
    }
}