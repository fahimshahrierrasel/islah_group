using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.Linq;

namespace IslahGroupInventory.ViewControls
{
    public partial class BarcodeControl : UserControl
    {
        public BarcodeControl()
        {
            InitializeComponent();
        }

        private void BarcodeControl_Load(object sender, EventArgs e)
        {
            InitializeBarcodeCategoryComboBox();
            InitializeProductsGridView();
        }
        private void InitializeProductsGridView()
        {
            productsBindingSource.DataSource = new InventoryDataClassesDataContext().Products.Where(p => p.Branch_BranchId == BranchInfo.BranchId);
        }
        private void InitializeBarcodeCategoryComboBox()
        {
            subCategoriesBindingSource.DataSource = new InventoryDataClassesDataContext().SubCategories;
        }
        private void ButtonPrintBarcode_Click(object sender, EventArgs e)
        {
            string productCode = textBoxBPCode.Text;
            int.TryParse(textBoxBCNumber.Text, out int totalBarcode);
            if (productCode.Length == 8 && Regex.IsMatch(productCode, @"^\d+$"))
            {
                new ReportPrintTool(new BarcodePrint(productCode, totalBarcode)).ShowPreview();
            }
            else
            {
                XtraMessageBox.Show("Product code should be 8 character long!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ComboBoxProductBarcodeCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxBPCCode.Text = comboBoxProductBarcodeCategory.SelectedValue.ToString();
            textBoxBPCode.Text = textBoxBPCCode.Text + textBoxBCSuffix.Text;
        }
        private void TextBoxBCSuffix_TextChanged(object sender, EventArgs e)
        {
            textBoxBPCode.Text = textBoxBPCCode.Text + textBoxBCSuffix.Text;
        }

    }
}
