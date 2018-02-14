using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace IslahGroup.Admin
{
    public partial class MemberRequests : System.Web.UI.Page
    {
        MemberLogic memberLogic;
        DataTable memberTable;
        public MemberRequests()
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
                { "Status", "REQ" }
            };
            memberTable = memberLogic.GetAllMemberByActiveStatus(filter);
            RepeaterMemberRequests.DataSource = memberTable;
            RepeaterMemberRequests.DataBind();
        }
    }
}