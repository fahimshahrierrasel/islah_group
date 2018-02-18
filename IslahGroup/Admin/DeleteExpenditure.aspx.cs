using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;

namespace IslahGroup.Admin
{
    public partial class DeleteExpenditure : System.Web.UI.Page
    {
        ExpenditureLogic expenditureLogic;
        public DeleteExpenditure()
        {
            expenditureLogic = new ExpenditureLogic();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int expnId = int.Parse(Request.QueryString["ExpnId"]);
            Dictionary<string, int> expnInfo = new Dictionary<string, int>()
            {
                { "ExpnId", expnId }
            };
            expenditureLogic.DeleteAExpenditure(expnInfo);
            Response.Redirect("Expenditure.aspx");
        }
    }
}