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
    public partial class Expenditure : System.Web.UI.Page
    {
        ExpenditureLogic expenditureLogic;
        DataTable expenditureTable;
        DataTable expnTypeTable;
        DataTable expnInfo;
        public Expenditure()
        {
            expenditureLogic = new ExpenditureLogic();
            expenditureTable = new DataTable();
            expnTypeTable = new DataTable();
            expnInfo = new DataTable();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                PopulateExpnType();
            }
            PopulateExpenditureTable();
            PopulateInfo();
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
            expnInfo.Clear();
            expnInfo = expenditureLogic.ExpenditureInfo();

            LabelTotalEarn.Text = expnInfo.Rows[0][1].ToString() == null ? "0.00": expnInfo.Rows[0][1].ToString();
            LabelTotalInvestment.Text = expnInfo.Rows[1][1].ToString() == null ? "0.00" : expnInfo.Rows[1][1].ToString();
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

            
            if(expenditureLogic.NewExpenditure(expnDict))
            {
                Response.Redirect(Request.RawUrl);
            }
        }


    }
}