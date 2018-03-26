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
    public partial class CustomerViewControl : DevExpress.XtraEditors.XtraUserControl
    {
        POSDataClassesDataContext dbContext;
        public CustomerViewControl()
        {
            dbContext = new POSDataClassesDataContext();
            InitializeComponent();
        }

        private void CustomerViewControl_Load(object sender, EventArgs e)
        {
            LoadCustomersGridView();
            ResetInputControls();
        }

        private void LoadCustomersGridView()
        {
            customersBindingSource.DataSource = new POS.POSDataClassesDataContext().Customers;
            CustomerGridControl.RefreshDataSource();
        }
        private void ButtonRegisterCustomer_Click(object sender, EventArgs e)
        {
            string customerCode = CustCodeTextEdit.Text;
            string customerName = CustNameTextEdit.Text;
            string contactNo = ContactNoTextEdit.Text;
            string email = EmailTextEdit.Text;
            string address = AddressMemoEdit.Text;
            string remark = RemarkMemoEdit.Text;

            dbContext.Customers.InsertOnSubmit(new Customer()
            {
                CustCode = customerCode,
                CustName = customerName,
                ContactNo = contactNo,
                Email = email,
                Address = address,
                Remark = remark,
                Branch_BranchId = BranchInfo.BranchId
            });

            dbContext.SubmitChanges();
            LoadCustomersGridView();
            ResetInputControls();
        }

        private void ButtonDiscard_Click(object sender, EventArgs e)
        {
            ResetInputControls();
        }

        private void ResetInputControls()
        {
            CustCodeTextEdit.Text = String.Empty;
            CustNameTextEdit.Text = String.Empty;
            ContactNoTextEdit.Text = String.Empty;
            EmailTextEdit.Text = String.Empty;
            AddressMemoEdit.Text = String.Empty;
            RemarkMemoEdit.Text = String.Empty;
        }
    }
}
