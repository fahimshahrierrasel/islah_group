using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace IslahGroup.Admin
{
    public partial class InvestorDetails : System.Web.UI.Page
    {
        int investorId;
        InvestLogic investLogic;
        InvestorLogic investorLogic;
        DataTable investorInfo;
        DataTable investTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlAuthorization();
            investorId = Convert.ToInt32(Request.QueryString["InvId"]);
            investLogic = new InvestLogic();
            investorLogic = new InvestorLogic();
            investorInfo = new DataTable();
            investTable = new DataTable();
            LoadInvestor(investorId);
            PopulateInvestorInformation();
        }
        public void ControlAuthorization()
        {
            if (Session["UserType"].ToString() == "Admin" || Session["UserType"].ToString() == "Director")
            {
                add_modal.Visible = true;
            }
            else
            {
                add_modal.Visible = false;
            }
        }
        private void LoadInvestor(int investorId)
        {
            this.investorInfo.Clear();
            Dictionary<string, int> investorInformation = new Dictionary<string, int>
            {
                { "InvestorId", investorId }
            };

            this.investorInfo = investorLogic.GetSingleInvestor(investorInformation);
            PopulateInvestorInvests(investorInformation);
        }
        private void PopulateInvestorInvests(Dictionary<string, int> investorInformation)
        {
            investTable.Clear();
            investTable = investLogic.GetInvestsByInvestor(investorInformation);
            RepeaterInvestorInvests.DataSource = investTable;
            RepeaterInvestorInvests.DataBind();
        }
        private void PopulateInvestorInformation()
        {
            if(investorInfo.Rows.Count == 1)
            {
                DataRow dr = investorInfo.Rows[0];
                Page.Title = dr["InvFullName"].ToString();
                LabelInvestorName.Text = dr["InvFullName"].ToString();
                LabelFullName.Text = dr["InvFullName"].ToString();
                LabelNID.Text = dr["InvNID"].ToString();
                LabelFatherName.Text = dr["InvFatherName"].ToString();
                LabelMotherName.Text = dr["InvMotherName"].ToString();
                LabelHusbWifeName.Text = dr["InvHusbWifeName"].ToString();
                LabelPresentAddress.Text = dr["InvPresentAddress"].ToString();
                LabelParmanentAddress.Text = dr["InvParmanentAddress"].ToString();
                LabelDOB.Text = DateTime.Parse(dr["InvDateOfBirth"].ToString()).ToString("MMMM dd, yyyy");
                LabelGender.Text = dr["InvGender"].ToString();
                LabelProfession.Text = dr["InvProfession"].ToString();
                LabelMobileNo.Text = dr["InvMobileNo"].ToString();
                LabelAmount.Text = String.IsNullOrEmpty(dr["InvInvest"].ToString()) ? "0.00" : dr["InvInvest"].ToString();
            }
        }
        protected void ButtonAddInvest_Click(object sender, EventArgs e)
        {

        }
    }
}