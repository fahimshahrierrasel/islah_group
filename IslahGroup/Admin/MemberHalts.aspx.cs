using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace IslahGroup.Admin
{
    public partial class MemberHalts : System.Web.UI.Page
    {
        MemberLogic memberLogic;
        DataTable memberTable;
        public MemberHalts()
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
                { "Status", "HALT" }
            };
            memberTable = memberLogic.GetAllMemberByActiveStatus(filter);
            RepeaterMemberHalts.DataSource = memberTable;
            RepeaterMemberHalts.DataBind();
        }
    }
}