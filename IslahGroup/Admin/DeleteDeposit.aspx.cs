using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;

namespace IslahGroup.Admin
{
    public partial class DeleteDeposit : System.Web.UI.Page
    {
        MemberDepositLogic memberDepositLogic;
        public DeleteDeposit()
        {
            memberDepositLogic = new MemberDepositLogic();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int memberId = -1, depositId = -1;
            int.TryParse(Request.QueryString["MemId"], out memberId);
            int.TryParse(Request.QueryString["DepId"], out depositId);
            Dictionary<string, int> deposit = new Dictionary<string, int>()
            {
                { "MemberId", memberId },
                { "DepositId", depositId }
            };
            memberDepositLogic.DeleteDeposit(deposit);
            Response.Redirect("OwnerDetails.aspx?MemId=" + memberId);
        }
    }
}