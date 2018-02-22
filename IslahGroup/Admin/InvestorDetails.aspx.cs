using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class InvestorDetails : System.Web.UI.Page
    {
        public int investorId;
        InvestLogic investLogic;
        InvestorLogic investorLogic;
        DataTable investorInfo;
        DataSet investInfo;
        DataTable investTable;
        DataTable investTypeTable;
        public InvestorDetails()
        {
            investLogic = new InvestLogic();
            investorLogic = new InvestorLogic();
            investorInfo = new DataTable();
            investTable = new DataTable();
            investInfo = new DataSet();
            investTypeTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlAuthorization();
            investorId = Convert.ToInt32(Request.QueryString["InvId"]);
            LoadInvestor(investorId);
            PopulateInvestorInformation();
            PopulateInvestType();
        }
        public void ControlAuthorization()
        {
            if (Session["UserType"].ToString() == "Admin" || Session["UserType"].ToString() == "Director")
            {
                add_modal.Visible = true;
                ActionHead.Visible = true;
                ActionFoot.Visible = true;
            }
            else
            {
                add_modal.Visible = false;
                ActionHead.Visible = false;
                ActionFoot.Visible = false;
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
            PopulateInvestInfo(investorInformation);
        }
        public void PopulateInvestType()
        {
            investTypeTable.Clear();
            investTypeTable = investLogic.GetInvestType();
            foreach (DataRow item in investTypeTable.Rows)
            {
                string type = item["Type"].ToString();
                DropDownListInvestType.Items.Add(new ListItem(type, type));
            }
        }
        private void PopulateInvestorInvests(Dictionary<string, int> investorInformation)
        {
            investTable.Clear();
            investTable = investLogic.GetInvestsByInvestor(investorInformation);
            RepeaterInvestorInvests.DataSource = investTable;
            RepeaterInvestorInvests.DataBind();
        }
        private void PopulateInvestInfo(Dictionary<string, int> investorInformation)
        {
            investInfo.Clear();
            investInfo = investLogic.GetInvestInfoByInvestor(investorInformation);

            double due = 0d, capital = 0d, product=0d, returned = 0d;
            
            double.TryParse(investInfo.Tables[0].Rows[0]["Total"].ToString() ?? "0", out capital);
            double.TryParse(investInfo.Tables[1].Rows[0]["Total"].ToString() ?? "0", out product);
            double.TryParse(investInfo.Tables[2].Rows[0]["Total"].ToString() ?? "0", out returned);

            double invest = capital + product;
            due = invest - returned;
            LabelDue.Text = due.ToString();
            LabelAmount.Text = invest.ToString();
            LabelReturned.Text = returned.ToString();
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
            }
        }
        protected void ButtonAddInvest_Click(object sender, EventArgs e)
        {
            string amount = TextBoxIAmount.Text;
            string date = TextBoxIDate.Text;
            string type = DropDownListInvestType.Text;
            string note = TextBoxINote.Text;
            string profit = TextBoxIProfit.Text;
            string userId = Session["UserId"].ToString();
            Dictionary<string, string> invest = new Dictionary<string, string>()
            {
                { "InvestorId", investorId.ToString() },
                { "UserId", userId },
                { "InvestDate", date },
                { "Amount", amount },
                { "Profit", profit },
                { "Note", note },
                { "Type", type }
            };

            investLogic.InsertNewInvest(invest);
            Response.Redirect(Request.RawUrl);
        }
    }
}