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
    public partial class RawMaterialControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        public RawMaterialControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }

        private void InitializeRawMaterialGridView()
        {
        }
        private void ButtonAddRawMaterial_Click(object sender, EventArgs e)
        {
            string materialCode = textBoxIRMCode.Text;
            string materialName = textBoxIRMName.Text;
            string materialDesc = textBoxIRMDesc.Text;
            string reorderPoint = textBoxIRMRPoint.Text;
            string materialStock = textBoxIRMStock.Text;

            dbContext.RawProducts.InsertOnSubmit(new RawProduct()
            {
                RPCode = materialCode,
                RPName = materialName,
                Description = materialDesc,
                ReOrderPoint = Convert.ToInt16(reorderPoint),
                Stock = Convert.ToInt32(materialStock),
                Active = true,
                Branch_BranchId = 1
            });
            dbContext.SubmitChanges();
            InitializeRawMaterialGridView();
        }

        private void ButtonRMULoad_Click(object sender, EventArgs e)
        {
            string rawMaterialCode = textBoxRMUCode.Text;
            var rawMaterial = dbContext.RawProducts.SingleOrDefault(p => p.RPCode == rawMaterialCode);
            if (rawMaterial != null)
            {
                textBoxRMUName.Text = rawMaterial.RPName;
                textBoxRMUDesc.Text = rawMaterial.Description;
                textBoxRMURPoint.Text = rawMaterial.ReOrderPoint.ToString();
                textBoxRMUStock.Text = rawMaterial.Stock.ToString();
                checkBoxRMUActive.Checked = rawMaterial.Active;

                buttonRMU.Enabled = true;
            }
        }

        private void ButtonRMU_Click(object sender, EventArgs e)
        {

            // TODO: Raw Material Input Validation
            string rawMaterialCode = textBoxRMUCode.Text;
            var rawMaterial = dbContext.RawProducts.SingleOrDefault(p => p.RPCode == rawMaterialCode);

            rawMaterial.RPName = textBoxRMUName.Text;
            rawMaterial.Description = textBoxRMUDesc.Text;
            rawMaterial.ReOrderPoint = Convert.ToInt16(textBoxRMURPoint.Text);
            rawMaterial.Stock = Convert.ToInt32(textBoxRMUStock.Text);
            rawMaterial.Active = checkBoxRMUActive.Checked;

            dbContext.SubmitChanges();
            InitializeRawMaterialGridView();
        }

        private void ButtonRMUStockLoad_Click(object sender, EventArgs e)
        {
            string rawMaterialCode = textBoxRMSUCode.Text;
            var rawMaterial = dbContext.RawProducts.SingleOrDefault(p => p.RPCode == rawMaterialCode);
            if (rawMaterial != null)
            {
                textBoxRMSUCtock.Text = rawMaterial.Stock.ToString();

                buttonRMSUAddStock.Enabled = true;
            }
        }

        private void ButtonRMSUAddStock_Click(object sender, EventArgs e)
        {
            string rawMaterialCode = textBoxRMSUCode.Text;
            var rawMaterial = dbContext.RawProducts.SingleOrDefault(p => p.RPCode == rawMaterialCode);
            rawMaterial.Stock = rawMaterial.Stock + Convert.ToInt32(textBoxRMSUAStock.Text);
            dbContext.SubmitChanges();
            InitializeRawMaterialGridView();
        }
    }
}
