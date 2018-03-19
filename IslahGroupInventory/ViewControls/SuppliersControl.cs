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

namespace IslahGroupInventory.ViewControls
{
    public partial class SuppliersControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;

        public SuppliersControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }

        private void SuppliersControl_Load(object sender, EventArgs e)
        {
            LoadTotalSupplierCounter();
        }

        private void LoadTotalSupplierCounter()
        {
            var totalSuppliers = dbContext.Suppliers.Count();
            labelTotalSuppliers.Text = totalSuppliers.ToString();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            // TODO: Add Supplier Validation

            dbContext.Suppliers.InsertOnSubmit(new Supplier()
            {
                SuppCode = textBoxISCode.Text,
                SuppName = textBoxISName.Text,
                Address = textBoxISAddress.Text,
                ContactPerson = textBoxISCPerson.Text,
                ContactNo = textBoxISContactNo.Text,
                Email = textBoxISEmail.Text,
                Remark = textBoxISRemarks.Text,
                Branch_BranchId = 2
            });
            dbContext.SubmitChanges();

            
        }

        private void gridViewSuppliers_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(e.RowHandle);
            string suppCode = view.GetRowCellValue(e.RowHandle, "SuppCode").ToString();

            var supplier = dbContext.Suppliers.SingleOrDefault(s => s.SuppCode == suppCode);
            var rowSupplier = row as Supplier;

            supplier.SuppName = rowSupplier.SuppName;
            supplier.Address = rowSupplier.Address;
            supplier.ContactPerson = rowSupplier.ContactPerson;
            supplier.ContactNo = rowSupplier.ContactNo;
            supplier.Email = rowSupplier.Email;
            supplier.Remark = rowSupplier.Remark;

            dbContext.SubmitChanges();
        }

    }
}
