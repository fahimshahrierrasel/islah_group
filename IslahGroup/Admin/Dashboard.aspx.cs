using IslahGroup.DotNet.BusinessLogicLayer;
using IslahGroup.DotNet.EntityLayer;
using System;

namespace IslahGroup.Admin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        ExpenditureLogic expenditureLogic;
        public Dashboard()
        {
            expenditureLogic = new ExpenditureLogic();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateInfo();
        }

        private void PopulateInfo()
        {
            CapitalSummery capitalSummery = expenditureLogic.ExpenditureInfo();
            LabelCurrentCapital.Text = capitalSummery.CurrentCapital;
            LabelTotalEarn.Text = capitalSummery.TotalEarn;
            LabelTotalInvestment.Text = capitalSummery.TotalInvest;
        }
    }
}