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
    public partial class Investors : System.Web.UI.Page
    {
        DataTable investorDataTable;
        InvestorLogic investorLogic;

        public Investors()
        {
            investorLogic = new InvestorLogic();
            investorDataTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateInvestorTable();
            }
        }
        private void PopulateInvestorTable()
        {
            investorDataTable.Clear();
            investorDataTable = investorLogic.GetAllInvestor();
            RepeaterAllInvestors.DataSource = investorDataTable;
            RepeaterAllInvestors.DataBind();
        }
    }
}