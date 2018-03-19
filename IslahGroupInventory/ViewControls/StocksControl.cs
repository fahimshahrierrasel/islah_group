using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LoadTotalProductCounter();
        }

        private void LoadTotalProductCounter()
        {
            var totalProduct = dbContext.Products.Count();
            labelTotalProduct.Text = totalProduct.ToString();
        }

    }
}
