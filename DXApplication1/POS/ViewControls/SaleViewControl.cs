using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace POS.ViewControls
{
    public partial class SaleViewControl : DevExpress.XtraEditors.XtraUserControl
    {
        POSDataClassesDataContext dbContext;
        DataTable invoiceItems;
        int customerId = 0;
        List<Customer> allCustomers;
        public SaleViewControl()
        {
            dbContext = new POSDataClassesDataContext();
            InitializeComponent();
            allCustomers = dbContext.Customers.ToList();
            productsBindingSource.DataSource = new POS.POSDataClassesDataContext().Products;
            paymentTypesBindingSource.DataSource = new POS.POSDataClassesDataContext().PaymentTypes;
        }
        private void SaleViewControl_Load(object sender, EventArgs e)
        {
            SetDefaultValue();
            SetNextInvoiceNo();
            
        }
        private void SetDefaultValue()
        {
            InitializeInvoiceItemGridView();
            CustomerTextEdit.EditValue = "01234567890";
            InvoiceDateEdit.DateTime = DateTime.Now;
            PaymentLookUpEdit.EditValue = "Cash";
            DiscountTextEdit.Text = String.Empty;
            PaidTextEdit.Text = String.Empty;
            DueTextEdit.Text = String.Empty;
            PaidTextEdit.BackColor = Color.White;
            DueTextEdit.BackColor = Color.White;
            SetCustomerInfo("01234567890");
        }
        private void SetNextInvoiceNo()
        {
            InvoiceNoLabel.Text = String.Format("INVC{0:D9}", dbContext.GetNextInvoiceCode());
        }
        private void InitializeInvoiceItemGridView()
        {
            invoiceItems = new DataTable();
            invoiceItems.Columns.Add("ProductName", typeof(string));
            invoiceItems.Columns.Add("UnitPrice", typeof(decimal));
            invoiceItems.Columns.Add("Quantity", typeof(int));
            invoiceItems.Columns.Add("SubTotal", typeof(decimal));
            invoiceItems.Columns.Add("Id", typeof(string));
            invoiceItems.Columns.Add("Stock", typeof(int));

            invoiceItems.Clear();
            InvoiceItemGridControl.DataSource = invoiceItems;
        }
        private void ProductsTileView_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            string name = e.Item.Elements[6].Text;
            string price = e.Item.Elements[7].Text;
            string stock = e.Item.Elements[8].Text;
            string discount = e.Item.Elements[9].Text;
            string id = e.Item.Elements[10].Text;

            if (!CheckIfAlreadyExistsAndIncrement(id))
            {
                if (Convert.ToInt32(stock) > 0)
                {
                    DataRow dr = invoiceItems.NewRow();
                    dr["ProductName"] = name;
                    dr["UnitPrice"] = price;
                    dr["Quantity"] = 1;
                    dr["SubTotal"] = price;
                    dr["Id"] = id;
                    dr["Stock"] = stock;
                    invoiceItems.Rows.Add(dr);
                }
                else
                {
                    XtraMessageBox.Show("Not enough stock!!");
                }
            }

            InvoiceItemGridControl.RefreshDataSource();
        }
        private bool CheckIfAlreadyExistsAndIncrement(string ProductId)
        {
            foreach (DataRow item in invoiceItems.Rows)
            {
                if (ProductId.Equals(item["Id"]))
                {
                    int currentStock = Convert.ToInt32(item["Stock"]);
                    int updatedQty = Convert.ToInt32(item["Quantity"]) + 1;
                    if (updatedQty <= currentStock)
                    {
                        item["Quantity"] = updatedQty;
                        item["SubTotal"] = Convert.ToDecimal(item["UnitPrice"]) * Convert.ToDecimal(updatedQty);
                    }
                    else
                    {
                        XtraMessageBox.Show("Not enough stock!!");
                    }
                    return true;
                }
            }
            return false;
        }

        private void InvoiceItemGridView_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            decimal summaryValue = Convert.ToDecimal(summary.SummaryValue);
            string summaryText = String.Format("{0:#.##}", summaryValue);
            TotalTextEdit.Text = summaryText;
            decimal due = summaryValue - Convert.ToDecimal(PaidTextEdit.Text) - Convert.ToDecimal(DiscountTextEdit.Text);
            DueTextEdit.Text = String.Format("{0:#.##}", due);
        }

        private void PaidTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            CalculatePrice();
        }

        private void DiscountTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            decimal.TryParse(TotalTextEdit.Text, out decimal total);
            decimal.TryParse(PaidTextEdit.Text, out decimal paid);
            decimal.TryParse(DiscountTextEdit.Text, out decimal discount);

            decimal due = total - (paid + discount);
            if (due <= 0)
            {
                due = 0M;
                PaidTextEdit.BackColor = Color.LawnGreen;
                DueTextEdit.BackColor = Color.LawnGreen;
            }
            else
            {
                PaidTextEdit.BackColor = Color.White;
                DueTextEdit.BackColor = Color.White;
            }
            DueTextEdit.Text = String.Format("{0:#.##}", due);
        }

        private void InvoiceItemGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            var row = view.GetRow(e.RowHandle);
            int.TryParse(view.GetRowCellValue(e.RowHandle, "Quantity").ToString(), out int quantity);
            int.TryParse(view.GetRowCellValue(e.RowHandle, "Stock").ToString(), out int stock);

            if (quantity >= 1)
            {
                if (quantity < stock)
                {
                    string unitPrice = view.GetRowCellValue(e.RowHandle, "UnitPrice").ToString();
                    decimal totalPricee = Convert.ToDecimal(quantity) * Convert.ToDecimal(unitPrice);

                    view.SetRowCellValue(e.RowHandle, "SubTotal", totalPricee);
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

        private void SetCustomerId()
        {
            if (customerId == 0)
            {
                if (!String.IsNullOrEmpty(CustNameTextEdit.Text))
                {
                    Customer customer = new Customer()
                    {
                        CustCode = String.Format("CUST{0:D4}", dbContext.GetNextCustomerCode()),
                        CustName = CustNameTextEdit.Text,
                        ContactNo = CustomerTextEdit.Text,
                        Branch_BranchId = BranchInfo.BranchId
                    };

                    dbContext.Customers.InsertOnSubmit(customer);
                    dbContext.SubmitChanges();
                    customerId = customer.CustId;
                }
            }
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            string invoiceCode = InvoiceNoLabel.Text;
            DateTime date = InvoiceDateEdit.DateTime;
            string paymentType = PaymentLookUpEdit.EditValue.ToString();
            decimal total = Convert.ToDecimal(TotalTextEdit.Text);
            decimal paid = Convert.ToDecimal(PaidTextEdit.Text);
            decimal due = Convert.ToDecimal(DueTextEdit.Text);
            SetCustomerId();
            if (paid > 0M)
            {
                Invoice invoice = new Invoice()
                {
                    InvcCode = invoiceCode,
                    InvcDate = date,
                    PaymentDate = date,
                    Amount = total,
                    Paid = paid,
                    Due = due,
                    Customer_CustId = customerId,
                    PaymentType_PType = paymentType,
                    Branch_BranchId = BranchInfo.BranchId
                };

                dbContext.Invoices.InsertOnSubmit(invoice);
                dbContext.SubmitChanges();

                InsertInvoiceItems(invoice.InvcId);
                SetNextInvoiceNo();
                SetDefaultValue();
            }
            else
            {
                XtraMessageBox.Show("No Payment given! Ask for payment!");
            }

        }
        private void InsertInvoiceItems(long invcId)
        {
            List<InvoiceItem> items = new List<InvoiceItem>();

            foreach (DataRow item in invoiceItems.Rows)
            {
                InvoiceItem invItem = new InvoiceItem()
                {
                    Invoice_InvcId = invcId,
                    Product_ProdId = Convert.ToInt32(item["Id"]),
                    Quantity = Convert.ToInt16(item["Quantity"]),
                    Price = Convert.ToInt32(item["SubTotal"])
                };
                items.Add(invItem);

            }
            dbContext.InvoiceItems.InsertAllOnSubmit(items);
            dbContext.SubmitChanges();
            UpdateProductsStock(items);
        }
        private void UpdateProductsStock(List<InvoiceItem> items)
        {
            foreach (InvoiceItem item in items)
            {
                var product = dbContext.Products.Single(p => p.ProdId == item.Product_ProdId);
                product.Stock = product.Stock - Convert.ToInt32(item.Quantity);
                dbContext.SubmitChanges();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            SetDefaultValue();
        }

        private void CustomerTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            string phoneNumber = CustomerTextEdit.EditValue.ToString();
            SetCustomerInfo(phoneNumber);
        }
        
        private void SetCustomerInfo(string phoneNumber)
        {
            if (phoneNumber.Length == 11)
            {
                var customer = allCustomers.SingleOrDefault(p => p.ContactNo == phoneNumber);
                if (customer != null)
                {
                    customerId = customer.CustId;
                    CustNameTextEdit.EditValue = customer.CustName;
                }
                else
                {
                    customerId = 0;
                    CustNameTextEdit.EditValue = String.Empty;
                }
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(FindProductTextEdit.EditValue);
            var product = dbContext.Products.Single(p => p.ProdId == id);
            if (!CheckIfAlreadyExistsAndIncrement(id.ToString()))
            {
                if (Convert.ToInt32(product.Stock) > 0)
                {
                    DataRow dr = invoiceItems.NewRow();
                    dr["ProductName"] = product.ProdName;
                    dr["UnitPrice"] = product.SellingPrice;
                    dr["Quantity"] = 1;
                    dr["SubTotal"] = product.SellingPrice;
                    dr["Id"] = id;
                    dr["Stock"] = product.Stock;
                    invoiceItems.Rows.Add(dr);
                }
                else
                {
                    XtraMessageBox.Show("Not enough stock!!");
                }
            }

            InvoiceItemGridControl.RefreshDataSource();
        }
    }
}
