using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Collections.Generic;

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
            SetNextInvoiceCode();
            LoadInvoicesGridView();
        }
        private void SalesControl_VisibleChanged(object sender, EventArgs e)
        {
            LoadSaleProperties();
        }

        private void LoadSaleProperties()
        {
            customersBindingSource.DataSource = new InventoryDataClassesDataContext().Customers;
            productsBindingSource.DataSource = new InventoryDataClassesDataContext().Products;
            paymentTypesBindingSource.DataSource = new InventoryDataClassesDataContext().PaymentTypes;
        }

        private void SetNextInvoiceCode()
        {
            textBoxInvoiceCode.Text = String.Format("INV{0:D7}", dbContext.GetNextInvoiceCode());
        }

        private void LoadInvoicesGridView()
        {
            invoicesBindingSource.DataSource = new InventoryDataClassesDataContext().Invoices
                .Where(i => i.Branch_BranchId == BranchInfo.BranchId);
            gridControlInvoiceList.RefreshDataSource();
        }

        private void InitializeInvoiceItemGridView()
        {
            invoiceItems = new DataTable();
            invoiceItems.Columns.Add("PProductId", typeof(string));
            invoiceItems.Columns.Add("PCode", typeof(string));
            invoiceItems.Columns.Add("PUPrice", typeof(decimal));
            invoiceItems.Columns.Add("PQuantity", typeof(int));
            invoiceItems.Columns.Add("PTotalPrice", typeof(decimal));
            invoiceItems.Columns.Add("PStock", typeof(int));
            gridControlSaleProducts.DataSource = invoiceItems;
        }

        private void ButtonAddInvoiceItem_Click(object sender, EventArgs e)
        {
            string prodCode = comboBoxIProducts.SelectedValue.ToString();
            
            if (!CheckIfAlreadyExists(prodCode.ToString()))
            {
                var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == prodCode);
                if (int.TryParse(textBoxIQuantity.Text, out int quantity))
                {
                    if (product.Stock > quantity)
                    {
                        DataRow dr = invoiceItems.NewRow();
                        dr[0] = product.ProdId;
                        dr[1] = prodCode;
                        dr[2] = product.SellingPrice;
                        dr[3] = quantity;
                        dr[4] = product.SellingPrice * quantity;
                        dr[5] = product.Stock;
                        invoiceItems.Rows.Add(dr);
                        gridControlSaleProducts.RefreshDataSource();
                        ResetAddItemInputFields();
                    }
                    else
                    {
                        string msg = String.Format("Not enough stock. Current Stock: {0}", product.Stock);
                        XtraMessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Quantity should be number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Product already add!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetAddItemInputFields()
        {
            comboBoxIProducts.SelectedIndex = 0;
            textBoxIQuantity.Text = String.Empty;
        }

        private bool CheckIfAlreadyExists(string productCode)
        {
            foreach (DataRow item in invoiceItems.Rows)
            {
                if (productCode.Equals(item["PCode"]))
                {
                    return true;
                }
            }
            return false;
        }
        private void GridViewSaleProducts_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(e.RowHandle);
            int.TryParse(view.GetRowCellValue(e.RowHandle, "PQuantity").ToString(), out int quantity);
            int.TryParse(view.GetRowCellValue(e.RowHandle, "PStock").ToString(), out int stock);

            if (quantity >= 1)
            {
                if (quantity < stock)
                {
                    string unitPrice = view.GetRowCellValue(e.RowHandle, "PUPrice").ToString();
                    decimal totalPricee = Convert.ToDecimal(quantity) * Convert.ToDecimal(unitPrice);

                    view.SetRowCellValue(e.RowHandle, "PTotalPrice", totalPricee);
                }
                else
                {
                    e.Valid = false;
                    e.ErrorText = "Not enough stock!!";
                    return;
                }
            }
            else
            {
                e.Valid = false;
                e.ErrorText = "Quantity should be positive or at least 1";
            }
        }

        private void GridViewSaleProducts_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            double summaryValue = Convert.ToDouble(summary.SummaryValue);
            string summaryText = String.Format("{0:#.##}", summaryValue);
            textBoxITotal.Text = summaryText;
            double due = summaryValue - Convert.ToDouble(textBoxIAmount.Text);
            textBoxIDue.Text = String.Format("{0:#.##}", due);
        }

        private void ButtonSaveInvoice_Click(object sender, EventArgs e)
        {
            string invCode = textBoxInvoiceCode.Text;
            DateTime invDate = dtpInvoiceDate.Value;
            DateTime payDay = dtpPaymentDate.Value;
            int customerId = Convert.ToInt32(comboBoxCustomer.SelectedValue);
            string paymentType = comboBoxPaymentType.SelectedValue.ToString();
            decimal amount = Convert.ToDecimal(textBoxIAmount.Text);
            decimal due = Convert.ToDecimal(textBoxIDue.Text);

            Invoice invoice = new Invoice()
            {
                InvcCode = invCode,
                InvcDate = invDate,
                PaymentDate = payDay,
                Amount = amount,
                Due = due,
                Customer_CustId = customerId,
                PaymentType_PType = paymentType,
                Branch_BranchId = BranchInfo.BranchId
            };

            dbContext.Invoices.InsertOnSubmit(invoice);
            dbContext.SubmitChanges();

            List<InvoiceItem> items = new List<InvoiceItem>();

            foreach (DataRow item in invoiceItems.Rows)
            {
                InvoiceItem invItem = new InvoiceItem()
                {
                    Invoice_InvcId = invoice.InvcId,
                    Product_ProdId = Convert.ToInt32(item["PProductId"]),
                    Quantity = Convert.ToInt32(item["PQuantity"]),
                    Price = Convert.ToInt32(item["PTotalPrice"])
                };
                items.Add(invItem);
            }
            dbContext.InvoiceItems.InsertAllOnSubmit(items);
            dbContext.SubmitChanges();
            UpdateProductsStock(items);
            SetNextInvoiceCode();
            LoadInvoicesGridView();
        }

        private void UpdateProductsStock(List<InvoiceItem> items)
        {
            foreach(InvoiceItem item in items)
            {
                var product = dbContext.Products.Single(p => p.ProdId == item.Product_ProdId);
                product.Stock = product.Stock - Convert.ToInt32(item.Quantity);
                dbContext.SubmitChanges();
            }
        }

        private void CheckNumber(object sender, KeyPressEventArgs e)
        {
            // Whole Number Check
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
