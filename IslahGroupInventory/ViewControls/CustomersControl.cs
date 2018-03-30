using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

/* Todo
 *  Clear customer input fields
 *  validate customer input fields
 */

namespace IslahGroupInventory.ViewControls
{
    public partial class CustomersControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        public CustomersControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }
        private void CustomersControl_Load(object sender, EventArgs e)
        {
            LoadNewCustomerCode();
            LoadTotalCustomerCounter();
            LoadCustomersGridView();
        }
        private void LoadNewCustomerCode()
        {
            textBoxICCode.Text = String.Format("CUST{0:D6}", dbContext.GetNextCustomerCode());
        }

        private void LoadTotalCustomerCounter()
        {
            var totalCustomer = dbContext.Customers.Count();
            labelTotalCustomers.Text = totalCustomer.ToString();
        }

        private void LoadCustomersGridView()
        {
            customersBindingSource.DataSource = new InventoryDataClassesDataContext().Customers
                .Where(c => c.Branch_BranchId == BranchInfo.BranchId);
            gridControlCustomers.RefreshDataSource();
        }

        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            // TODO: Customer add validation

            dbContext.Customers.InsertOnSubmit(new Customer()
            {
                CustCode = textBoxICCode.Text,
                CustName = textBoxICName.Text,
                Address = textBoxICAddress.Text,
                ContactNo = textBoxICContactNo.Text,
                Email = textBoxICEmail.Text,
                Remark = textBoxICRemarks.Text,
                Branch_BranchId = BranchInfo.BranchId
            });

            dbContext.SubmitChanges();
            LoadNewCustomerCode();
            LoadCustomersGridView();
        }

        private void GridViewCustomer_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(e.RowHandle);
            string custCode = view.GetRowCellValue(e.RowHandle, "CustCode").ToString();

            var customer = dbContext.Customers.SingleOrDefault(c => c.CustCode == custCode);
            var rowCustomer = row as Customer;

            customer.CustName = rowCustomer.CustName;
            customer.Address = rowCustomer.Address;
            customer.ContactNo = rowCustomer.ContactNo;
            customer.Email = rowCustomer.Email;
            customer.Remark = rowCustomer.Remark;

            dbContext.SubmitChanges();
            LoadCustomersGridView();
        }
    }
}
