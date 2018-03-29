using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace POS.ViewControls
{
    public partial class IslahViewControl : DevExpress.XtraEditors.XtraUserControl
    {
        POSDataClassesDataContext db;
        public IslahViewControl()
        {
            db = new POSDataClassesDataContext();
            InitializeComponent(); 
        }
        private void IslahViewControl_Load(object sender, EventArgs e)
        {
            LoadProductCategoryGridControl();
            LoadPaymentTypeGridControl();
            LoadServiceTypeGridControl();
            LoadLedgerGridControl();
            LedgerDateDateEdit.DateTime = DateTime.Now;
            SetTodaysSale();
        }
        private void SetTodaysSale()
        {
            decimal sale = 0M;
            var todaySale = db.GetTotalSale(LedgerDateDateEdit.DateTime.Date).SingleOrDefault();
            if(todaySale != null)
            {
                sale = (decimal) todaySale.Paid; 
            }
            TotalSaleTextedit.EditValue = sale;
            SetLeftOver();
        }
        private void SetLeftOver()
        {
            decimal totalSale = Convert.ToDecimal(TotalSaleTextedit.EditValue);
            decimal takenAmount = Convert.ToDecimal(TakenTextEdit.EditValue);

            decimal leftOver = totalSale - takenAmount;
            if (leftOver >= 0)
                LeftOverTextEdit.EditValue = leftOver;
            else
                LeftOverTextEdit.EditValue = 0M;
        }

        private void LoadLedgerGridControl()
        {
            ledgersBindingSource.DataSource = new POS.POSDataClassesDataContext().Ledgers;
            LedgerGridControl.RefreshDataSource();
        }
        private void LoadProductCategoryGridControl()
        {
            categoriesBindingSource.DataSource = new POSDataClassesDataContext().Categories;
            ProductCategoryGridControl.RefreshDataSource();
        }

        private void LoadPaymentTypeGridControl()
        {
            paymentTypesBindingSource.DataSource = new POSDataClassesDataContext().PaymentTypes;
            PaymentTypeGridControl.RefreshDataSource();
        }

        private void LoadServiceTypeGridControl()
        {
            serviceTypesBindingSource.DataSource = new POSDataClassesDataContext().ServiceTypes;
            ServiceTypeGridControl.RefreshDataSource();
        }

        private void AddPCButton_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryNameTextEdit.Text;
            if(!String.IsNullOrEmpty(categoryName))
            {
                db.Categories.InsertOnSubmit(new Category()
                {
                    CategoryName = categoryName
                });
                db.SubmitChanges();
                CategoryNameTextEdit.Text = String.Empty;
                LoadProductCategoryGridControl();
            }
        }

        private void AddPTButton_Click(object sender, EventArgs e)
        {
            string paymentTypeName = PaymentTypeTextEdit.Text;
            if (!String.IsNullOrEmpty(paymentTypeName))
            {
                db.PaymentTypes.InsertOnSubmit(new PaymentType()
                {
                    PType = paymentTypeName
                });
                db.SubmitChanges();
                PaymentTypeTextEdit.Text = String.Empty;
                LoadPaymentTypeGridControl();
            }
        }

        private void AddSTButton_Click(object sender, EventArgs e)
        {
            string serviceTypeName = ServiceTypeNameTextEdit.Text;
            if(!String.IsNullOrEmpty(serviceTypeName))
            {
                db.ServiceTypes.InsertOnSubmit(new ServiceType()
                {
                    Name = serviceTypeName
                });
                db.SubmitChanges();
                ServiceTypeNameTextEdit.Text = String.Empty;
                LoadServiceTypeGridControl();
            }
        }

        private void LedgerDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            SetTodaysSale();
        }

        private void TakenTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            SetLeftOver();
        }

        private void SubmitLedgerButton_Click(object sender, EventArgs e)
        {
            DateTime ledgerDate = LedgerDateDateEdit.DateTime;
            decimal leftOver = Convert.ToDecimal(LeftOverTextEdit.EditValue);
            decimal amountTaken = Convert.ToDecimal(TakenTextEdit.EditValue);
            string givenBy = GivenByTextEdit.EditValue.ToString();
            string takenBy = TakenByTextEdit.EditValue.ToString();

            db.Ledgers.InsertOnSubmit(new Ledger()
            {
                LedgerDate = ledgerDate,
                LeftOver = leftOver,
                Taken = amountTaken,
                TakenBy = takenBy,
                GivenBy = givenBy,
                Branch_BranchId = BranchInfo.BranchId
            });

            db.SubmitChanges();
            LoadLedgerGridControl();
        }
    }
}
