﻿using DevExpress.XtraGrid.Views.Base;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void RawMaterialControl_Load(object sender, EventArgs e)
        {
            InitializeRawMaterialGridView();
            SetNextRawProductCode();
        }
        private void RawMaterialControl_VisibleChanged(object sender, EventArgs e)
        {
            InitializeRawMaterialGridView();
        }
        private void InitializeRawMaterialGridView()
        {
            var rawProducts = from rawProduct in dbContext.RawProducts
                              where rawProduct.Branch_BranchId == BranchInfo.BranchId
                              select rawProduct;

            rawProductsBindingSource.DataSource = rawProducts;
            rawMaterialGridControl.RefreshDataSource();
        }

        private void SetNextRawProductCode()
        {
            // Code Prefix: RAWPRD
            textBoxIRMCode.Text = String.Format("RWPRD{0:D5}", dbContext.GetNextRawProductCode());
        }

        private void ButtonAddRawMaterial_Click(object sender, EventArgs e)
        {
            string materialCode = textBoxIRMCode.Text;
            string materialName = textBoxIRMName.Text;
            string materialDesc = textBoxIRMDesc.Text;
            Int16.TryParse(textBoxIRMRPoint.Text, out Int16 reorderPoint);
            Int32.TryParse(textBoxIRMStock.Text, out int materialStock);

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                dbContext.RawProducts.InsertOnSubmit(new RawProduct()
                {
                    RPCode = materialCode,
                    RPName = materialName,
                    Description = materialDesc,
                    ReOrderPoint = reorderPoint,
                    Stock = materialStock,
                    Active = true,
                    Branch_BranchId = BranchInfo.BranchId
                });
                dbContext.SubmitChanges();
                SetNextRawProductCode();
                InitializeRawMaterialGridView();
                ClearMaterialAddInputFields();
            }
        }

        private void ClearMaterialAddInputFields()
        {
            String empty = String.Empty;
            textBoxIRMName.Text = empty;
            textBoxIRMDesc.Text = empty;
            textBoxIRMRPoint.Text = empty;
            textBoxIRMStock.Text = empty;
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

        private void ClearMaterialUpdateInputFields()
        {
            String empty = String.Empty;
            textBoxRMUCode.Text = empty;
            textBoxRMUName.Text = empty;
            textBoxRMUDesc.Text = empty;
            textBoxRMURPoint.Text = empty;
            textBoxRMUStock.Text = empty;
            checkBoxRMUActive.Checked = false;
        }

        private void ButtonRMU_Click(object sender, EventArgs e)
        {
            string rawMaterialCode = textBoxRMUCode.Text;
            var rawMaterial = dbContext.RawProducts.SingleOrDefault(p => p.RPCode == rawMaterialCode);
            
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                rawMaterial.RPName = textBoxRMUName.Text;
                rawMaterial.Description = textBoxRMUDesc.Text;
                rawMaterial.ReOrderPoint = Convert.ToInt16(textBoxRMURPoint.Text);
                rawMaterial.Stock = Convert.ToInt32(textBoxRMUStock.Text);
                rawMaterial.Active = checkBoxRMUActive.Checked;

                dbContext.SubmitChanges();
                InitializeRawMaterialGridView();
                ClearMaterialUpdateInputFields();
            }
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

        private void GridViewRawMaterial_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
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

        private void CheckNullorEmptyforAdd(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                AddMaterialErrorProvider.SetError(textBox, "This field can not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                AddMaterialErrorProvider.SetError(textBox, null);
            }
        }

        private void CheckWholeNumber(object sender, KeyPressEventArgs e)
        {
            // Whole Number Check
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
