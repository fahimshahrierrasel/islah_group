using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace IslahGroupInventory.ViewControls
{
    public partial class ProductsControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        public ProductsControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }
        private void ProductsControl_Load(object sender, EventArgs e)
        {
            LoadProductsGridView();
            LoadProductCategory();
        }
        private void ProductsControl_VisibleChanged(object sender, EventArgs e)
        {
            LoadProductsGridView();
            LoadProductCategory();
        }

        private void LoadProductCategory()
        {
            var subCategory = from sCategory in dbContext.SubCategories
                              select sCategory.Name;
            comboBoxCategory.DataSource = subCategory;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Name";

            comboBoxUPCategory.DataSource = subCategory;
            comboBoxUPCategory.DisplayMember = "Name";
            comboBoxUPCategory.ValueMember = "Name";
        }

        private void LoadProductsGridView()
        {
            var products = from product in dbContext.Products
                           where product.Branch_BranchId == BranchInfo.BranchId
                           select product;

            productsBindingSource.DataSource = products;
            gridControlProducts.RefreshDataSource();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            string prodCode = textBoxProdCode.Text;
            string prodName = textBoxName.Text;
            string desc = textBoxDescription.Text;
            string category = comboBoxCategory.Text;
            string sellPrice = textBoxSPrice.Text;
            string rp = textBoxRPoint.Text;
            string discount = textBoxDiscount.Text;
            string stock = textBoxStock.Text;

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Product newProduct = new Product()
                {
                    ProdCode = prodCode,
                    ProdName = prodName,
                    Description = desc,
                    SubCategory_Name = category,
                    Active = true,
                    SellingPrice = Convert.ToDecimal(sellPrice),
                    ReOrderPoint = Convert.ToInt16(rp),
                    Discount = Convert.ToDecimal(discount),
                    Stock = Convert.ToInt32(stock),
                    Branch_BranchId = BranchInfo.BranchId
                };
                dbContext.Products.InsertOnSubmit(newProduct);
                dbContext.SubmitChanges();
                LoadProductsGridView();
                ClearProductAddInputFields();
            }
        }

        private void ClearProductAddInputFields()
        {
            string empty = String.Empty;
            textBoxProdCode.Text = empty;
            textBoxName.Text = empty;
            textBoxDescription.Text = empty;
            comboBoxCategory.Text = empty;
            textBoxSPrice.Text = empty;
            textBoxRPoint.Text = empty;
            textBoxDiscount.Text = empty;
            textBoxStock.Text = empty;
        }

        private void ButtonUpdateProduct_Click(object sender, EventArgs e)
        {
            string productCode = textBoxUPCode.Text;
            var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == productCode);
            product.ProdName = textBoxUPName.Text;
            product.Description = textBoxUPDescription.Text;
            product.SubCategory_Name = comboBoxUPCategory.Text;
            product.SellingPrice = Convert.ToDecimal(textBoxUPSPrice.Text);
            product.ReOrderPoint = Convert.ToInt16(textBoxUPRPoint.Text);
            product.Discount = Convert.ToDecimal(textBoxUPDiscount.Text);

            dbContext.SubmitChanges();
            LoadProductsGridView();
            ClearProductUpdateInputFields();
            XtraMessageBox.Show("Product Updated!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonUPLoad_Click(object sender, EventArgs e)
        {
            string productCode = textBoxUPCode.Text;
            var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == productCode);
            if (product != null)
            {
                textBoxUPName.Text = product.ProdName;
                textBoxUPDescription.Text = product.Description;
                comboBoxUPCategory.Text = product.SubCategory_Name;
                textBoxUPSPrice.Text = product.SellingPrice.ToString();
                textBoxUPRPoint.Text = product.ReOrderPoint.ToString();
                textBoxUPDiscount.Text = product.Discount.ToString();
                textBoxUPStock.Text = product.Stock.ToString();
                buttonUpdateProduct.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("No product found!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearProductUpdateInputFields()
        {
            string empty = String.Empty;
            textBoxUPCode.Text = empty;
            textBoxUPName.Text = empty;
            textBoxUPDescription.Text = empty;
            comboBoxUPCategory.Text = empty;
            textBoxUPSPrice.Text = empty;
            textBoxUPRPoint.Text = empty;
            textBoxUPDiscount.Text = empty;
            textBoxUPStock.Text = empty;
        }

        private void ButtonProductDelete_Click(object sender, EventArgs e)
        {
            string productCode = textBoxDPCode.Text;
            var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == productCode);

            if (product != null)
            {
                dbContext.Products.DeleteOnSubmit(product);
                dbContext.SubmitChanges();
                LoadProductsGridView();
                XtraMessageBox.Show("Product Removed!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("No product found!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GridViewProducts_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            if (view.IsValidRowHandle(e.RowHandle))
            {
                int.TryParse(view.GetRowCellValue(e.RowHandle, "ReOrderPoint").ToString(), out int order);
                int.TryParse(view.GetRowCellValue(e.RowHandle, "Stock").ToString(), out int stock);
                if (stock <= order)
                    e.Appearance.BackColor = Color.Tomato;
            }
        }

        private void CheckNullorEmpty(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                ProductsErrorProvider.SetError(textBox, "This field can not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                ProductsErrorProvider.SetError(textBox, null);
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
