using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace IslahGroupInventory.ViewControls
{
    public partial class ProcessingControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        DataTable processingItems;
        public ProcessingControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
            LoadProcessingGridView();
        }

        private void ProcessingControl_Load(object sender, EventArgs e)
        {
            InitializeProcessingItemGridView();
            LoadRawMaterialDropdown();
        }

        private void LoadRawMaterialDropdown()
        {
            rawProductsBindingSource.DataSource = new InventoryDataClassesDataContext().RawProducts
                .Where(rp => rp.Branch_BranchId == BranchInfo.BranchId);
        }

        private void LoadProcessingGridView()
        {
            processingsBindingSource.DataSource = new InventoryDataClassesDataContext().Processings
                .Where(p => p.Branch_BranchId == BranchInfo.BranchId);
        }

        private void InitializeProcessingItemGridView()
        {
            processingItems = new DataTable();
            processingItems.Columns.Add("RMaterialId");
            processingItems.Columns.Add("RMaterialName");
            processingItems.Columns.Add("RQuantity");

            gridControlProcessingItem.DataSource = processingItems;

            gridViewProcessingItem.Columns[0].Visible = false;
            gridViewProcessingItem.Columns[1].Caption = "Material Name";
            gridViewProcessingItem.Columns[2].Caption = "Quantity";
        }

        private void ButtonAddMaterial_Click(object sender, EventArgs e)
        {
            int materialId = Convert.ToInt32(cbMaterialName.SelectedValue);
            if (!CheckIfAlreadyThere(materialId))
            {
                var rawProduct = dbContext.RawProducts.Single(rp => rp.RPId == materialId);
                if (int.TryParse(tbMaterialQuantity.Text, out int quantity))
                {
                    if (rawProduct.Stock > quantity)
                    {
                        DataRow dr = processingItems.NewRow();
                        dr["RMaterialId"] = materialId;
                        dr["RMaterialName"] = cbMaterialName.Text;
                        dr["RQuantity"] = quantity;
                        processingItems.Rows.Add(dr);
                        gridControlProcessingItem.RefreshDataSource();
                        tbMaterialQuantity.Text = String.Empty;
                    }
                    else
                    {
                        string msg = String.Format("Not enough stock. Current Stock: {0}", rawProduct.Stock);
                        XtraMessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Qunatity should be number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("This Material already add.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private bool CheckIfAlreadyThere(int materialId)
        {
            foreach (DataRow dr in processingItems.Rows)
            {
                int matId = Convert.ToInt32(dr["RMaterialId"]);
                if(materialId == matId)
                {
                    return true;
                }
            }
            return false;
        }

        private void ButtonSaveProcessing_Click(object sender, EventArgs e)
        {
            DateTime processingDate = dtpProcessingDate.Value;
            string details = tbProcessingDetails.Text;

            if (!String.IsNullOrEmpty(details) && processingItems.Rows.Count > 0)
            {
                Processing processing = new Processing()
                {
                    Date = processingDate,
                    Description = details,
                    Branch_BranchId = BranchInfo.BranchId
                };

                dbContext.Processings.InsertOnSubmit(processing);
                dbContext.SubmitChanges();

                List<ProcessingItem> items = new List<ProcessingItem>();

                foreach (DataRow dr in processingItems.Rows)
                {
                    ProcessingItem item = new ProcessingItem()
                    {
                        Processing_ProcessingID = processing.ProcessingID,
                        RawProduct_RPId = Convert.ToInt32(dr["RMaterialId"]),
                        Quantity = Convert.ToInt32(dr["RQuantity"])
                    };
                    items.Add(item);
                }
                dbContext.ProcessingItems.InsertAllOnSubmit(items);
                dbContext.SubmitChanges();
                UpdateRawProductStock(items);
                LoadProcessingGridView();
                LoadRawMaterialDropdown();
                ClearInputFields();
            }
            else
            {
                XtraMessageBox.Show("Please add processing details and add items for processing", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void UpdateRawProductStock(List<ProcessingItem> items)
        {
            foreach (ProcessingItem item in items)
            {
                var rawProduct = dbContext.RawProducts.Single(r => r.RPId == item.RawProduct_RPId);
                rawProduct.Stock = rawProduct.Stock - item.Quantity;
                dbContext.SubmitChanges();
            }
        }

        private void ClearInputFields()
        {
            tbProcessingDetails.Text = String.Empty;
            tbMaterialQuantity.Text = String.Empty;
            cbMaterialName.SelectedIndex = 0;
            InitializeProcessingItemGridView();
        }
    }
}
