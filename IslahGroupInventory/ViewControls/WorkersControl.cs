using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IslahGroupInventory.ViewControls
{
    public partial class WorkersControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        public WorkersControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }
        private void WorkersControl_Load(object sender, EventArgs e)
        {
            LoadWorkerCount();
            LoadWorkerGridView();
        }
        private void LoadWorkerGridView()
        {
            operatorsBindingSource.DataSource = new InventoryDataClassesDataContext().Operators
                .Where(w => w.Branch_BranchId == BranchInfo.BranchId);

            gridControlWorker.RefreshDataSource();
        }
        private void LoadWorkerCount()
        {
            int totalWorker = dbContext.Operators.Count();
            labelTotalWorker.Text = totalWorker.ToString();
        }

        private void ButtonAddWorker_Click(object sender, EventArgs e)
        {
            string workerName = textBoxName.Text;
            string workerType = textBoxWorkerType.Text;
            bool active = checkBoxActive.Checked;

            dbContext.Operators.InsertOnSubmit(new Operator()
            {
                Name = workerName,
                Field = workerType,
                Active = active,
                Branch_BranchId = BranchInfo.BranchId
            });

            dbContext.SubmitChanges();
            LoadWorkerGridView();
            LoadWorkerCount();
        }
    }
}
