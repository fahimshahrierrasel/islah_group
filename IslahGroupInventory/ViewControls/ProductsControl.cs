using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
            LoadNewProductCode();
            LoadProductCategory();
        }
        private void LoadNewProductCode()
        {
            textBoxProdCode.Text = String.Format("PRODT{0:D5}", dbContext.GetNextProductCode());
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
            // TODO: Validation of the Add Product
            string prodCode = textBoxProdCode.Text;
            string prodName = textBoxName.Text;
            string desc = textBoxDescription.Text;
            string category = comboBoxCategory.Text;
            string sellPrice = textBoxSPrice.Text;
            string rp = textBoxRPoint.Text;
            string discount = textBoxDiscount.Text;
            string stock = textBoxStock.Text;

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
            LoadNewProductCode();
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
    }
}
