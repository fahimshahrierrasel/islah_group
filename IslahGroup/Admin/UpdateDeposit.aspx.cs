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
    public partial class UpdateDeposit : System.Web.UI.Page
    {
        public int memberId;
        public int depositId;
        MemberDepositLogic memberDepositLogic;
        DataTable depositTable;
        public UpdateDeposit()
        {
            memberDepositLogic = new MemberDepositLogic();
            depositTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            memberId = Convert.ToInt32(Request.QueryString["MemId"]);
            depositId = Convert.ToInt32(Request.QueryString["DepId"]);
            HyperLinkCancel.NavigateUrl = "OwnerDetails.aspx?MemId=" + memberId;
            if(!IsPostBack)
            {
                GetDepositInfo();
                PopulateData();
            }
        }
        private void GetDepositInfo()
        {
            Dictionary<string, int> deposit = new Dictionary<string, int>()
            {
                { "DepositId", depositId }
            };

            depositTable = memberDepositLogic.GetADeposit(deposit);
        }
        private void PopulateData()
        {
            if(depositTable.Rows.Count == 1)
            {
                DataRow dr = depositTable.Rows[0];
                TextBoxDAmount.Text = dr["Amount"].ToString();
                LabelDDate.Text = Convert.ToDateTime(dr["DepositDate"]).ToString("dd-MM-yyyy");
                TextBoxDDate.Text = Convert.ToDateTime(dr["DepositDate"]).ToString("dd-MM-yyyy");
                TextBoxDNote.Text = dr["Note"].ToString();
            }
        }
        protected void ButtonUpdateDeposit_Click(object sender, EventArgs e)
        {
            string depositAmount = TextBoxDAmount.Text;
            string depositDate = TextBoxDDate.Text;
            string depositNote = TextBoxDNote.Text;

            Dictionary<string, string> memberDepositInfo = new Dictionary<string, string>
            {
                { "DepositDate", depositDate},
                { "Amount", depositAmount },
                { "Note", depositNote },
                { "DepositId", depositId.ToString() },
                { "MemberId", memberId.ToString() }
            };
            memberDepositLogic.UpdateDeposit(memberDepositInfo);
            Response.Redirect("OwnerDetails.aspx?MemId=" + memberId);
        }
    }
}