using IslahGroup.DotNet.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace IslahGroup.Admin
{
    public partial class UpdateExpenditure : System.Web.UI.Page
    {
        int expnId;
        DataTable expnTable;
        ExpenditureLogic expenditureLogic;
        public UpdateExpenditure()
        {
            expnId = 0;
            expenditureLogic = new ExpenditureLogic();
            expnTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            expnId = int.Parse(Request.QueryString["ExpnId"]);
            if(!IsPostBack)
            {
                GetExpenditureInfo(expnId);
                PopulateExpenditureFields();
            }
        }

        private void GetExpenditureInfo(int expnId)
        {
            Dictionary<string, int> expnInfo = new Dictionary<string, int>()
            {
                { "ExpnId", expnId }
            };
            expnTable = expenditureLogic.GetAExpenditure(expnInfo);
        }

        private void PopulateExpenditureFields()
        {
            if (expnTable.Rows.Count == 1)
            {
                DataRow dr = expnTable.Rows[0];
                TextBoxEDate.Text = DateTime.Parse(dr["ExpnDate"].ToString()).ToString("dd-MM-yyyy");
                TextBoxEInfo.Text = dr["ExpnNote"].ToString();
                TextBoxEType.Text = dr["ExpnType"].ToString();
                TextBoxEAmount.Text = dr["ExpnAmount"].ToString();
            }
        }
        protected void ButtonUpdateExpenditure_Click(object sender, EventArgs e)
        {
            string eNote = TextBoxEInfo.Text;
            string eType = TextBoxEType.Text;
            string amount = TextBoxEAmount.Text;
            Dictionary<string, string> expnDict = new Dictionary<string, string>
            {
                { "ExpnNote", eNote },
                { "ExpnAmount", amount },
                { "ExpnType", eType },
                { "ExpnId", Convert.ToString(expnId) }
            };

            if (expenditureLogic.UpdateAExpenditure(expnDict))
            {
                Response.Redirect("Expenditure.aspx");
            }
        }
    }
}