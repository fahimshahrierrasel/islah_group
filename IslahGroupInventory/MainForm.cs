using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using IslahGroupInventory.ViewControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslahGroupInventory
{
    public partial class MainForm : Form
    {
        public static InventoryDataClassesDataContext dbContext;

        public MainForm()
        {
            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tsslUsername.Text = BranchInfo.Username;
            tsslBranchCode.Text = BranchInfo.BranchCode;
            
        }
    }
}
