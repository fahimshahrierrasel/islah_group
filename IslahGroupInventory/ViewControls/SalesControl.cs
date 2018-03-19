using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace IslahGroupInventory.ViewControls
{
    public partial class SalesControl : UserControl
    {
        DataTable invoiceItems;
        InventoryDataClassesDataContext dbContext;

        public SalesControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }
        private void SalesControl_Load(object sender, EventArgs e)
        {
            InitializeInvoiceItemGridView();
        }

        private void InitializeInvoiceItemGridView()
        {
            invoiceItems = new DataTable();
            invoiceItems.Columns.Add("PProductId", typeof(string));
            invoiceItems.Columns.Add("PCode", typeof(string));
            invoiceItems.Columns.Add("PUPrice", typeof(decimal));
            invoiceItems.Columns.Add("PQuantity", typeof(decimal));
            invoiceItems.Columns.Add("PTotalPrice", typeof(decimal));
            gridControlSaleProducts.DataSource = invoiceItems;
        }

        private void buttonAddInvoiceItem_Click(object sender, EventArgs e)
        {
            string prodCode = comboBoxIProducts.SelectedValue.ToString();
            var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == prodCode);
            if (int.TryParse(textBoxIQuantity.Text, out int quantity))
            {

                DataRow dr = invoiceItems.NewRow();
                dr[0] = product.ProdId;
                dr[1] = prodCode;
                dr[2] = product.SellingPrice;
                dr[3] = quantity;
                dr[4] = product.SellingPrice * quantity;
                invoiceItems.Rows.Add(dr);
                gridControlSaleProducts.RefreshDataSource();
            }
            else
            {
                XtraMessageBox.Show("Qunatity should be number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridViewSaleProducts_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(e.RowHandle);
            Decimal.TryParse(view.GetRowCellValue(e.RowHandle, "PQuantity").ToString(), out decimal quantity);

            if (quantity >= 1)
            {
                string unitPrice = view.GetRowCellValue(e.RowHandle, "PUPrice").ToString();
                decimal totalPricee = Convert.ToDecimal(quantity) * Convert.ToDecimal(unitPrice);

                view.SetRowCellValue(e.RowHandle, "PTotalPrice", totalPricee);
            }
            else
            {
                e.Valid = false;
                e.ErrorText = "Quantity should be positive or at least 1";
            }
        }

        private void gridViewSaleProducts_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            double summaryValue = Convert.ToDouble(summary.SummaryValue);
            string summaryText = String.Format("{0:#.##}", summaryValue);
            textBoxITotal.Text = summaryText;
            double due = summaryValue - Convert.ToDouble(textBoxIAmount.Text);
            textBoxIDue.Text = String.Format("{0:#.##}", due);
        }
        
    }
}
