using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;

namespace IslahGroup.Admin
{
    public partial class MemberStatus : System.Web.UI.Page
    {
        private MemberLogic memberLogic;
        public MemberStatus()
        {
            memberLogic = new MemberLogic();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string memberId = Request.QueryString["MemId"].ToString();
            string status = Request.QueryString["Sts"].ToString();
            Dictionary<string, string> mStatus = new Dictionary<string, string>()
            {
                { "MemberId", memberId },
                { "Status", status }
            };
            memberLogic.ChangeMemberStatus(mStatus);
            Response.Redirect("MemberDetails.aspx?MemId=" + memberId);
        }
    }
}