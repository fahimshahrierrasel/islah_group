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
    public partial class PurchasesControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        DataTable purchaseItems;

        public PurchasesControl()
        {
            InitializeComponent();
        }

        private void PurchasesControl_Load(object sender, EventArgs e)
        {
            InitializePurchaseItemGridView();
        }

        private void InitializePurchaseItemGridView()
        {
            purchaseItems = new DataTable();
            purchaseItems.Columns.Add("ProductCode", typeof(string));
            purchaseItems.Columns.Add("UnitPrice", typeof(decimal));
            purchaseItems.Columns.Add("Quantity", typeof(decimal));
            purchaseItems.Columns.Add("TotalPrice", typeof(decimal));
            gridControlPurchaseItems.DataSource = purchaseItems;
        }

        private void InitializeSupplierComboBox()
        {
            //suppliersBindingSource.DataSource = new InventoryDataClassesDataContext().Suppliers;
            //comboBoxPSupplier.DataSource = suppliersBindingSource;
            comboBoxPSupplier.DisplayMember = "SuppName";
            comboBoxPSupplier.ValueMember = "SuppId";
        }

        private void buttonAddPurchaseProduct_Click(object sender, EventArgs e)
        {
            string pName = textBoxPPName.Text;
            //int.TryParse(textBoxPPQuantity.Text, out int quantity);
            if (Decimal.TryParse(textBoxPPUPrice.Text, out decimal price) &
                int.TryParse(textBoxPPQuantity.Text, out int quantity))
            {

                DataRow dr = purchaseItems.NewRow();
                dr[0] = pName;
                dr[1] = price;
                dr[2] = quantity;
                dr[3] = price * quantity;
                purchaseItems.Rows.Add(dr);
                gridControlPurchaseItems.RefreshDataSource();
            }
            else
            {
                XtraMessageBox.Show("Qunatity should be number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void gridViewPurchaseItem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(e.RowHandle);
            Decimal.TryParse(view.GetRowCellValue(e.RowHandle, "Quantity").ToString(), out decimal quantity);

            if (quantity >= 1)
            {
                string unitPrice = view.GetRowCellValue(e.RowHandle, "UnitPrice").ToString();
                decimal totalPricee = Convert.ToDecimal(quantity) * Convert.ToDecimal(unitPrice);

                view.SetRowCellValue(e.RowHandle, "TotalPrice", totalPricee);
            }
            else
            {
                e.Valid = false;
                e.ErrorText = "Quantity should be positive or at least 1";
            }
        }

        private void gridViewPurchaseItem_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            double summaryValue = Convert.ToDouble(summary.SummaryValue);
            string summaryText = String.Format("{0:#.##}", summaryValue);
            textBoxPTotal.Text = summaryText;
            double due = summaryValue - Convert.ToDouble(textBoxPAmount.Text);
            textBoxPDue.Text = String.Format("{0:#.##}", due);
        }

        private void buttonPSubmit_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in purchaseItems.Rows)
            {
                Console.WriteLine(item[1]);
            }
        }

        private void textBoxPAmount_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxPTotal.Text, out decimal total);
            decimal.TryParse(textBoxPAmount.Text, out decimal amount);
            //decimal.TryParse(textBoxPDue.Text, out decimal due);
            textBoxPDue.Text = String.Format("{0:#.##}", (total - amount));
        }


        // Purchase Tab Method End
    }
}
