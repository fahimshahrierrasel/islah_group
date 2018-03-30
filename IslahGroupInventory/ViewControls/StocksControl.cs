using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace IslahGroupInventory.ViewControls
{
    public partial class StocksControl : UserControl
    {
        private InventoryDataClassesDataContext dbContext;
        public StocksControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }

        private void StocksControl_Load(object sender, EventArgs e)
        {
            LoadStockProductGridView();
            LoadTotalProductCounter();
        }

        private void LoadStockProductGridView()
        {
            var products = from product in dbContext.Products
                           where product.Branch_BranchId == BranchInfo.BranchId
                           select product; ;

            productsBindingSource.DataSource = products;
            gridControlStockProductList.RefreshDataSource();
        }

        private void LoadTotalProductCounter()
        {
            var totalProduct = dbContext.Products.Count();
            labelTotalProduct.Text = totalProduct.ToString();
        }

        private void ButtonLoadStock_Click(object sender, EventArgs e)
        {
            string productCode = tbsProductCode.Text;
            var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == productCode);
            if (product != null)
            {
                tbsCurrentStock.Text = product.Stock.ToString();
                ButtonAddStock.Enabled = true;
            }
        }

        private void ButtonAddStock_Click(object sender, EventArgs e)
        {
            string productCode = tbsProductCode.Text;
            var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == productCode);
            Int32.TryParse(tbsAddStock.Text, out int numberOfAddItem);
            product.Stock = Convert.ToInt32(tbsCurrentStock.Text) + numberOfAddItem;
            dbContext.SubmitChanges();
            LoadStockProductGridView();
        }

        private void ButtonUpdateLoadStock_Click(object sender, EventArgs e)
        {
            string productCode = tbusProductCode.Text;
            var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == productCode);
            if (product != null)
            {
                tbusCurrentStock.Text = product.Stock.ToString();
                ButtonUpdateStock.Enabled = true;
            }
        }

        private void ButtonUpdateStock_Click(object sender, EventArgs e)
        {
            string productCode = tbusProductCode.Text;
            var product = dbContext.Products.SingleOrDefault(p => p.ProdCode == productCode);
            Int32.TryParse(tbusNewStock.Text, out int numberOfItem);
            product.Stock = numberOfItem;
            dbContext.SubmitChanges();
            LoadStockProductGridView();
        }

        private void GridViewStockProducts_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
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
    }
}
