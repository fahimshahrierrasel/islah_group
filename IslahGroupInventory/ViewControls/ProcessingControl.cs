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
            var rawProduct = dbContext.RawProducts.Single(rp => rp.RPId == materialId);
            if(int.TryParse(tbMaterialQuantity.Text, out int quantity))
            {
                if(rawProduct.Stock > quantity)
                {
                    DataRow dr = processingItems.NewRow();
                    dr["RMaterialId"] = materialId;
                    dr["RMaterialName"] = cbMaterialName.Text;
                    dr["RQuantity"] = quantity;
                    processingItems.Rows.Add(dr);
                    gridControlProcessingItem.RefreshDataSource();
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

        private void ButtonSaveProcessing_Click(object sender, EventArgs e)
        {
            DateTime processingDate = dtpProcessingDate.Value;
            string details = tbProcessingDetails.Text;

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
            LoadProcessingGridView();
        }

        //TODO: Remove Processed Items
    }
}
