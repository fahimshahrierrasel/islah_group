using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
namespace IslahGroup.Admin
{
    public partial class UpdateInvest : System.Web.UI.Page
    {
        InvestLogic investLogic;
        DataTable investData;
        int investId;
        int investorId;
        public UpdateInvest()
        {
            investLogic = new InvestLogic();
            investData = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            investId = Convert.ToInt32(Request.QueryString["InvsId"]);
            investorId = Convert.ToInt32(Request.QueryString["InvrId"]);
            HyperLinkCancel.NavigateUrl = "InvestorDetails.aspx?InvId=" + investorId;

            if (!IsPostBack)
            {
                GetInvestData(investId);
                PopulateInvestData();
            }
        }
        private void GetInvestData(int investId)
        {
            investData.Clear();
            Dictionary<string, int> invest = new Dictionary<string, int>()
            {
                { "InvestId", investId }
            };
            investData = investLogic.GetAInvest(invest);
        }
        private void PopulateInvestData()
        {
            if (investData.Rows.Count == 1)
            {
                DataRow dr = investData.Rows[0];
                TextBoxIDate.Text = Convert.ToDateTime(dr["InvestDate"]).ToString("dd-MM-yyyy");
                TextBoxIAmount.Text = dr["Amount"].ToString();
                TextBoxIProfit.Text = dr["Profit"].ToString();
                TextBoxINote.Text = dr["Note"].ToString();
                TextBoxInvestType.Text = dr["Type"].ToString();
            }
        }

        protected void ButtonUpdateInvest_Click(object sender, EventArgs e)
        {
            string amount = TextBoxIAmount.Text;
            string date = TextBoxIDate.Text;
            string note = TextBoxINote.Text;
            string profit = TextBoxIProfit.Text;
            Dictionary<string, string> invest = new Dictionary<string, string>()
            {
                { "InvestId", investId.ToString() },
                { "InvestDate", date },
                { "Amount", amount },
                { "Profit", profit },
                { "Note", note }
            };

            investLogic.UpdateInvest(invest);
            Response.Redirect("InvestorDetails.aspx?InvId=" + investorId);
        }
    }
}