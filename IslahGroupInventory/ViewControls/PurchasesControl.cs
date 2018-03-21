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
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }

        private void PurchasesControl_Load(object sender, EventArgs e)
        {
            InitializePurchaseItemGridView();
            InitializeSupplierComboBox();
            InitializePaymentComboBox();
            SetNextPurchaseCode();
        }

        private void TabControlPurchases_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControlPurchases.SelectedTab == tabPagePurchaseList)
            {
                LoadPurchasesList();
            }
        }

        private void LoadPurchasesList()
        {
            purchasesBindingSource.DataSource = new InventoryDataClassesDataContext().Purchases
                .Where(p => p.Branch_BranchId == BranchInfo.BranchId);
            gridControlPurchases.RefreshDataSource();
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

        private void SetNextPurchaseCode()
        {
            textBoxPurchaseCode.Text = String.Format("PURCH{0:D5}", dbContext.GetNextSupplierCode());
        }

        private void InitializeSupplierComboBox()
        {
            var suppliers = from supplier in dbContext.Suppliers
                            where supplier.Branch_BranchId == BranchInfo.BranchId
                            select new { supplier.SuppName, supplier.SuppId };
            comboBoxPSupplier.DataSource = suppliers;
            comboBoxPSupplier.DisplayMember = "SuppName";
            comboBoxPSupplier.ValueMember = "SuppId";
        }

        private void InitializePaymentComboBox()
        {
            var paymentType = from payType in dbContext.PaymentTypes
                              select payType.PType;

            comboBoxPaymentType.DataSource = paymentType;
            comboBoxPaymentType.DisplayMember = "PType";
            comboBoxPaymentType.ValueMember = "PType";
        }

        private void ButtonAddPurchaseProduct_Click(object sender, EventArgs e)
        {
            string pName = textBoxPPName.Text;
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

        private void GridViewPurchaseItem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
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

        private void GridViewPurchaseItem_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            double summaryValue = Convert.ToDouble(summary.SummaryValue);
            string summaryText = String.Format("{0:#.##}", summaryValue);
            textBoxPTotal.Text = summaryText;
            double due = summaryValue - Convert.ToDouble(textBoxPAmount.Text);
            textBoxPDue.Text = String.Format("{0:#.##}", due);
        }

        private void ButtonPSubmit_Click(object sender, EventArgs e)
        {
            string pCode = textBoxPurchaseCode.Text;
            DateTime pDate = dtpPurchaseTime.Value;
            int supplierId = Convert.ToInt32(comboBoxPSupplier.SelectedValue);
            string paymentType = comboBoxPaymentType.SelectedValue.ToString();
            DateTime payDate = dtpPaymentDate.Value;
            string purchaser = textBoxPurchaser.Text;
            decimal.TryParse(textBoxPTotal.Text, out decimal totalAmount);
            decimal.TryParse(textBoxPAmount.Text, out decimal paidAmount);
            decimal.TryParse(textBoxPDue.Text, out decimal due);

            Purchase purchase = new Purchase()
            {
                PurcCode = pCode,
                PurcDate = pDate,
                Supplier_SuppId = supplierId,
                PaymentType_PType = paymentType,
                PaymentDate = payDate,
                Purchaser = purchaser,
                Amount = paidAmount,
                Due = due,
                Branch_BranchId = BranchInfo.BranchId
            };

            dbContext.Purchases.InsertOnSubmit(purchase);
            dbContext.SubmitChanges();

            List<PurchaseItem> items = new List<PurchaseItem>();

            foreach (DataRow item in purchaseItems.Rows)
            {
                PurchaseItem pItem = new PurchaseItem()
                {
                    ItemName = item[0].ToString(),
                    UnitPrice = Convert.ToDecimal(item[1]),
                    Quantity = Convert.ToInt32(item[2]),
                    Price = Convert.ToDecimal(item[3].ToString().Replace("$", String.Empty).Replace(",", String.Empty)),
                    Purchase_PurcId = purchase.PurcId
                };
                items.Add(pItem);
            }
            dbContext.PurchaseItems.InsertAllOnSubmit(items);
            dbContext.SubmitChanges();
            SetNextPurchaseCode();
        }

        private void TextBoxPAmount_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxPTotal.Text, out decimal total);
            decimal.TryParse(textBoxPAmount.Text, out decimal amount);
            //decimal.TryParse(textBoxPDue.Text, out decimal due);
            textBoxPDue.Text = String.Format("{0:#.##}", (total - amount));
        }
    }
}
