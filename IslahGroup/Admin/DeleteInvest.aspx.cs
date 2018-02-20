using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class DeleteInvest : System.Web.UI.Page
    {
        int investId;
        int investorId;
        InvestLogic investLogic;
        public DeleteInvest()
        {
            investLogic = new InvestLogic();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            investId = Convert.ToInt32(Request.QueryString["InvsId"]);
            investorId = Convert.ToInt32(Request.QueryString["InvrId"]);
            Dictionary<string, int> invest = new Dictionary<string, int>()
            {
                { "InvestId", investId }
            };
            investLogic.DeleteInvest(invest);
            Response.Redirect("InvestorDetails.aspx?InvId=" + investorId);
        }
    }
}