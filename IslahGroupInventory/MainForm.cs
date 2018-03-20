using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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
        private int BRANCH_ID = 0;
        private string BRANCH_CODE = "BRANCH0000";
        private int USER_ID = 0;
        private string USERNAME = "Username";

        InventoryDataClassesDataContext dbContext;

        public MainForm(int userId, string aUsername, int branchId, string branchCode)
        {
            USER_ID = userId;
            BRANCH_ID = branchId;
            BRANCH_CODE = branchCode;
            USERNAME = aUsername;

            dbContext = new InventoryDataClassesDataContext();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tsslUsername.Text = USERNAME;
            tsslBranchCode.Text = BRANCH_CODE;
            //LoadRawMaterialTabPage();
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            TabPage selectedPage = tabControlMain.SelectedTab;
            if (selectedPage == tabPageRawMaterial)
            {
                //LoadRawMaterialTabPage();
            }
            if (selectedPage == tabPageProducts)
            {
                //LoadProductsPage();
            }
            else if (selectedPage == tabPageStocks)
            {
                //LoadStocksPage();
            }
            else if (selectedPage == tabPagePurchase)
            {
                //LoadPurchasePage();
            }
            else if (selectedPage == tabPageSale)
            {
                //LoadSaleTabPage();
            }
            else if (selectedPage == tabPageVocher)
            {

            }
            else if (selectedPage == tabPageCustomer)
            {
                //LoadCustomerPage();
            }
            else if (selectedPage == tabPageSupplier)
            {
                //LoadSuppliersPage();
            }
            else if (selectedPage == tabPageUser)
            {

            }
            else if (selectedPage == tabPageBarcode)
            {
                //LoadBarcodePage();
            }
        }

    }
}
