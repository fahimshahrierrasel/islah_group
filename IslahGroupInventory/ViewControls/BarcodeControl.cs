using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;

namespace IslahGroupInventory.ViewControls
{
    public partial class BarcodeControl : UserControl
    {
        public BarcodeControl()
        {
            InitializeComponent();
        }

        // Barcode Print Tab Start
        private void LoadBarcodePage()
        {
            InitializeBarcodeCategoryComboBox();
        }
        private void InitializeBarcodeCategoryComboBox()
        {
            //productCategoryBindingSource.DataSource = new InventoryDataClassesDataContext().SubCategories;
            //comboBoxProductBarcodeCategory.DataSource = productCategoryBindingSource;
            comboBoxProductBarcodeCategory.DisplayMember = "Name";
            comboBoxProductBarcodeCategory.ValueMember = "Code";
        }
        private void buttonPrintBarcode_Click(object sender, EventArgs e)
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
        private void comboBoxProductBarcodeCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxBPCCode.Text = comboBoxProductBarcodeCategory.SelectedValue.ToString();
            textBoxBPCode.Text = textBoxBPCCode.Text + textBoxBCSuffix.Text;
        }
        private void textBoxBCSuffix_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxBPCode.Text = textBoxBPCCode.Text + textBoxBCSuffix.Text;
        }
        // Barcode Print Tab End
    }
}
