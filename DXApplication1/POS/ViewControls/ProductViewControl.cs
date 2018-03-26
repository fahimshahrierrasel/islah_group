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
    public partial class ProductViewControl : DevExpress.XtraEditors.XtraUserControl
    {
        POSDataClassesDataContext dbContext;
        public ProductViewControl()
        {
            dbContext = new POSDataClassesDataContext();
            InitializeComponent();
            categoriesBindingSource.DataSource = new POS.POSDataClassesDataContext().Categories;
        }
        private void ProductViewControl_Load(object sender, EventArgs e)
        {
            ResetInputFields();
            LoadProductsDataSource();
        }
        private void LoadProductsDataSource()
        {
            productsBindingSource.DataSource = new POS.POSDataClassesDataContext().Products;
            ProductsGridControl.RefreshDataSource();
        }
        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            string productCode = ProdCodeTextEdit.Text;
            string productName = ProdNameTextEdit.Text;
            string description = DescriptionTextEdit.Text;
            string category = Category_CategoryNameLookUpEdit.Text;
            bool isActive = ActiveCheckEdit.Checked;
            int.TryParse(StockTextEdit.Text, out int openingStock);
            int.TryParse(ReOrderPointTextEdit.Text, out int reorderPoint);
            decimal.TryParse(SellingPriceTextEdit.Text, out decimal sellingPrice);
            decimal.TryParse(DiscountTextEdit.Text, out decimal discount);

            dbContext.Products.InsertOnSubmit(new Product() {
                ProdCode = productCode,
                ProdName = productName,
                Description = description,
                Category_CategoryName = category,
                Active = isActive,
                Stock = openingStock,
                ReOrderPoint = Convert.ToInt16(reorderPoint),
                SellingPrice = sellingPrice,
                Discount = discount,
                Branch_BranchId = BranchInfo.BranchId
            });

            dbContext.SubmitChanges();
            ResetInputFields();
            LoadProductsDataSource();
        }
        private void ResetInputFields()
        {
            string empty = String.Empty;
            ProdCodeTextEdit.Text = empty;
            ProdNameTextEdit.Text = empty;
            DescriptionTextEdit.Text = empty;
            ActiveCheckEdit.Checked = true;
            StockTextEdit.Text = "0";
            ReOrderPointTextEdit.Text = "0";
            SellingPriceTextEdit.Text = "0.00";
            DiscountTextEdit.Text = "0.00";
        }

        private void ButtonDiscard_Click(object sender, EventArgs e)
        {
            ResetInputFields();
        }
    }
}
