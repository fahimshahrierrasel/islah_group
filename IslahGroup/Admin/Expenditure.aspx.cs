using IslahGroup.DotNet.BusinessLogicLayer;
using IslahGroup.DotNet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace IslahGroup.Admin
{
    public partial class Expenditure : System.Web.UI.Page
    {
        ExpenditureLogic expenditureLogic;
        DataTable expenditureTable;
        DataTable expnTypeTable;
        public Expenditure()
        {
            expenditureLogic = new ExpenditureLogic();
            expenditureTable = new DataTable();
            expnTypeTable = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlAuthorization();
            if (!IsPostBack)
            {
                PopulateExpnType();
            }
            PopulateExpenditureTable();
            PopulateInfo();
        }

        public void ControlAuthorization()
        {
            if (Session["UserType"].ToString() == "Admin" || Session["UserType"].ToString() == "Director")
            {
                AddExpenditureBtn.Visible = true;
            }
            else
            {
                AddExpenditureBtn.Visible = false;
            }
        }

        public void PopulateExpenditureTable()
        {
            expenditureTable.Clear();
            expenditureTable = expenditureLogic.AllExpenditure();
            RepeaterExpenditures.DataSource = expenditureTable;
            RepeaterExpenditures.DataBind();
        }
        public void PopulateExpnType()
        {
            expnTypeTable.Clear();
            expnTypeTable = expenditureLogic.ExpenditureTypes();
            foreach (DataRow item in expnTypeTable.Rows)
            {
                string type = item["Type"].ToString();
                DropDownListEType.Items.Add(new ListItem(type, type));
            }
        }
        public void PopulateInfo()
        {
            CapitalSummery capitalSummery = expenditureLogic.ExpenditureDashboardInfo();
            LabelCurrentCapital.Text = capitalSummery.CurrentCapital;
            LabelTotalEarn.Text = capitalSummery.TotalEarn;
            LabelTotalInvestment.Text = capitalSummery.TotalInvest;
        }
        protected void ButtonAddExpenditure_Click(object sender, EventArgs e)
        {
            string eDate = TextBoxEDate.Text;
            string eNote = TextBoxEInfo.Text;
            string eType = DropDownListEType.Text;
            string amount = TextBoxEAmount.Text;
            string userId = Session["UserId"].ToString();
            Dictionary<string, string> expnDict = new Dictionary<string, string>
            {
                { "ExpnDate", eDate },
                { "ExpnNote", eNote },
                { "ExpnAmount", amount },
                { "ExpnType", eType },
                { "UserId", userId }
            };

            if (expenditureLogic.NewExpenditure(expnDict))
            {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}