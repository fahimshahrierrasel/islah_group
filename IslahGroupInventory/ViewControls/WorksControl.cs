using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IslahGroupInventory.ViewControls
{
    public partial class WorksControl : UserControl
    {
        InventoryDataClassesDataContext dbContext;
        public WorksControl()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }
        
        private void WorksControl_Load(object sender, EventArgs e)
        {
            workTypesBindingSource.DataSource = new InventoryDataClassesDataContext().WorkTypes;
            LoadOperatorWorkGridView();
        }

        private void LoadOperatorWorkGridView()
        {
            bindingSourceSelectOperator.DataSource = new InventoryDataClassesDataContext().Operators
                .Where(op => op.Branch_BranchId == BranchInfo.BranchId);

            operatorsBindingSource.DataSource = new InventoryDataClassesDataContext().Operators
                .Where(op => op.Branch_BranchId == BranchInfo.BranchId);
        }

        private void ButtonAddWork_Click(object sender, EventArgs e)
        {
            int worker = Convert.ToInt32(comboBoxWorker.SelectedValue.ToString());
            string workType = comboBoxWorkType.Text.ToString();
            DateTime workDay = dtpWorkingDay.Value;
            int quantity = Convert.ToInt32(textBoxWorkQuantity.Text);

            dbContext.OperatorWorks.InsertOnSubmit(new OperatorWork()
            {
                Operator_OId = worker,
                WorkType_Type = workType,
                Quantity = quantity,
                Date = workDay
            });

            dbContext.SubmitChanges();
            LoadOperatorWorkGridView();
        }

    }
}
