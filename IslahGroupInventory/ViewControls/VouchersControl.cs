using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace IslahGroupInventory.ViewControls
{
    public partial class VouchersControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        DataTable voucherItems;
        public VouchersControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }
        private void VouchersControl_Load(object sender, EventArgs e)
        {
            InitializeVoucherItemGridView();
            SetNextVoucherNo();
            LoadVouchersGridView();
        }
        private void LoadVouchersGridView()
        {
            vouchersBindingSource.DataSource = new InventoryDataClassesDataContext().Vouchers
                .Where(v => v.Branch_BranchId == BranchInfo.BranchId);
        }

        private void InitializeVoucherItemGridView()
        {
            voucherItems = new DataTable();
            voucherItems.Columns.Add("VItemName", typeof(string));
            voucherItems.Columns.Add("VDetails", typeof(string));
            voucherItems.Columns.Add("VAmount", typeof(decimal));
            gridControlVoucherItem.DataSource = voucherItems;
        }
        private void SetNextVoucherNo()
        {
            textBoxVoucherCode.Text = String.Format("VCHR{0:D6}", dbContext.GetNextSupplierCode());
        }
        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            string itemName = textBoxItemName.Text;
            string details = textBoxItemDetails.Text;
            decimal amount = Convert.ToDecimal(textBoxItemAmount.Text);

            DataRow dr = voucherItems.NewRow();
            dr[0] = itemName;
            dr[1] = details;
            dr[2] = amount.ToString();
            voucherItems.Rows.Add(dr);
            gridControlVoucherItem.RefreshDataSource();
        }
        private void GridViewVoucherItem_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            double summaryValue = Convert.ToDouble(summary.SummaryValue);
            string summaryText = String.Format("{0:#.##}", summaryValue);
            textBoxTotalAmount.Text = summaryText;
        }
        private void ButtonSaveVoucher_Click(object sender, EventArgs e)
        {
            string voucherCode = textBoxVoucherCode.Text;
            DateTime voucherDate = dtpVoucherDate.Value;
            string submittedBy = textBoxSubmittedBy.Text;
            string reference = textBoxReferenceNo.Text;
            string details = textBoxDetails.Text;
            decimal total = Convert.ToDecimal(textBoxTotalAmount.Text);

            Voucher voucher = new Voucher()
            {
                VoucCode = voucherCode,
                VoucDate = voucherDate,
                Name = submittedBy,
                ReferenceNo = reference,
                Details = details,
                Branch_BranchId = BranchInfo.BranchId
            };

            dbContext.Vouchers.InsertOnSubmit(voucher);
            dbContext.SubmitChanges();

            List<VoucherItem> items = new List<VoucherItem>();

            foreach (DataRow item in voucherItems.Rows)
            {
                VoucherItem voucherItem = new VoucherItem()
                {
                    Voucher_VoucId = voucher.VoucId,
                    ItemName = item["VItemName"].ToString(),
                    Details = item["VDetails"].ToString(),
                    Amount = Convert.ToDecimal(item["VAmount"])
                };
                items.Add(voucherItem);
            }
            dbContext.VoucherItems.InsertAllOnSubmit(items);
            dbContext.SubmitChanges();
            LoadVouchersGridView();
        }
    }
}
