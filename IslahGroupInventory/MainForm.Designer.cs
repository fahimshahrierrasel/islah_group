namespace IslahGroupInventory
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islahInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.islahGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treebricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBranchCode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageRawMaterial = new System.Windows.Forms.TabPage();
            this.rawMaterialControl1 = new IslahGroupInventory.ViewControls.RawMaterialControl();
            this.tabPageProcessing = new System.Windows.Forms.TabPage();
            this.processingControl1 = new IslahGroupInventory.ViewControls.ProcessingControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.productsControl1 = new IslahGroupInventory.ViewControls.ProductsControl();
            this.tabPageStocks = new System.Windows.Forms.TabPage();
            this.stocksControl1 = new IslahGroupInventory.ViewControls.StocksControl();
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.purchasesControl1 = new IslahGroupInventory.ViewControls.PurchasesControl();
            this.tabPageSale = new System.Windows.Forms.TabPage();
            this.salesControl1 = new IslahGroupInventory.ViewControls.SalesControl();
            this.tabPageVocher = new System.Windows.Forms.TabPage();
            this.vouchersControl1 = new IslahGroupInventory.ViewControls.VouchersControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.customersControl1 = new IslahGroupInventory.ViewControls.CustomersControl();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.tabPageBarcode = new System.Windows.Forms.TabPage();
            this.gridControlBarcodeProductControl = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProductBarcode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProdId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellingPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReOrderPoint1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCategory_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCategory1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBoxBCNumber = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBoxBPCode = new System.Windows.Forms.TextBox();
            this.buttonPrintBarcode = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBoxProductBarcodeCategory = new System.Windows.Forms.ComboBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBCSuffix = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBoxBPCCode = new System.Windows.Forms.TextBox();
            this.tabPageWorker = new System.Windows.Forms.TabPage();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.label87 = new System.Windows.Forms.Label();
            this.gridControlWorker = new DevExpress.XtraGrid.GridControl();
            this.gridViewWorker = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.tabPageWorks = new System.Windows.Forms.TabPage();
            this.gridControlWorks = new DevExpress.XtraGrid.GridControl();
            this.gridViewWorks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label100 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label97 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.usersControl1 = new IslahGroupInventory.ViewControls.UsersControl();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePurchaseItem = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersControl1 = new IslahGroupInventory.ViewControls.SuppliersControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageRawMaterial.SuspendLayout();
            this.tabPageProcessing.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.tabPageStocks.SuspendLayout();
            this.tabPagePurchase.SuspendLayout();
            this.tabPageSale.SuspendLayout();
            this.tabPageVocher.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.tabPageSupplier.SuspendLayout();
            this.tabPageBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarcodeProductControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductBarcode)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            this.tabPageWorker.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorker)).BeginInit();
            this.groupBox27.SuspendLayout();
            this.tabPageWorks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorks)).BeginInit();
            this.groupBox32.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurchaseItem)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islahInventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islahInventoryToolStripMenuItem
            // 
            this.islahInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.islahGroupToolStripMenuItem,
            this.treebricksToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.islahInventoryToolStripMenuItem.Name = "islahInventoryToolStripMenuItem";
            this.islahInventoryToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.islahInventoryToolStripMenuItem.Text = "Islah Inventory";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // islahGroupToolStripMenuItem
            // 
            this.islahGroupToolStripMenuItem.Name = "islahGroupToolStripMenuItem";
            this.islahGroupToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.islahGroupToolStripMenuItem.Text = "Islah Group";
            // 
            // treebricksToolStripMenuItem
            // 
            this.treebricksToolStripMenuItem.Name = "treebricksToolStripMenuItem";
            this.treebricksToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.treebricksToolStripMenuItem.Text = "Treebricks";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsername,
            this.tsslBranchCode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsername
            // 
            this.tsslUsername.Name = "tsslUsername";
            this.tsslUsername.Size = new System.Drawing.Size(60, 17);
            this.tsslUsername.Text = "Username";
            // 
            // tsslBranchCode
            // 
            this.tsslBranchCode.Name = "tsslBranchCode";
            this.tsslBranchCode.Size = new System.Drawing.Size(75, 17);
            this.tsslBranchCode.Text = "Branch Code";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageRawMaterial);
            this.tabControlMain.Controls.Add(this.tabPageProcessing);
            this.tabControlMain.Controls.Add(this.tabPageProducts);
            this.tabControlMain.Controls.Add(this.tabPageStocks);
            this.tabControlMain.Controls.Add(this.tabPagePurchase);
            this.tabControlMain.Controls.Add(this.tabPageSale);
            this.tabControlMain.Controls.Add(this.tabPageVocher);
            this.tabControlMain.Controls.Add(this.tabPageCustomer);
            this.tabControlMain.Controls.Add(this.tabPageSupplier);
            this.tabControlMain.Controls.Add(this.tabPageBarcode);
            this.tabControlMain.Controls.Add(this.tabPageWorker);
            this.tabControlMain.Controls.Add(this.tabPageWorks);
            this.tabControlMain.Controls.Add(this.tabPageUser);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ImageList = this.imageListTab;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1284, 665);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabPageRawMaterial
            // 
            this.tabPageRawMaterial.Controls.Add(this.rawMaterialControl1);
            this.tabPageRawMaterial.ImageKey = "raw.png";
            this.tabPageRawMaterial.Location = new System.Drawing.Point(4, 39);
            this.tabPageRawMaterial.Name = "tabPageRawMaterial";
            this.tabPageRawMaterial.Size = new System.Drawing.Size(1276, 622);
            this.tabPageRawMaterial.TabIndex = 9;
            this.tabPageRawMaterial.Text = "Raw Material";
            this.tabPageRawMaterial.UseVisualStyleBackColor = true;
            // 
            // rawMaterialControl1
            // 
            this.rawMaterialControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawMaterialControl1.Location = new System.Drawing.Point(0, 0);
            this.rawMaterialControl1.Margin = new System.Windows.Forms.Padding(6);
            this.rawMaterialControl1.Name = "rawMaterialControl1";
            this.rawMaterialControl1.Size = new System.Drawing.Size(1276, 622);
            this.rawMaterialControl1.TabIndex = 0;
            // 
            // tabPageProcessing
            // 
            this.tabPageProcessing.Controls.Add(this.processingControl1);
            this.tabPageProcessing.ImageKey = "processing.png";
            this.tabPageProcessing.Location = new System.Drawing.Point(4, 39);
            this.tabPageProcessing.Name = "tabPageProcessing";
            this.tabPageProcessing.Size = new System.Drawing.Size(1276, 622);
            this.tabPageProcessing.TabIndex = 10;
            this.tabPageProcessing.Text = "Processing";
            this.tabPageProcessing.UseVisualStyleBackColor = true;
            // 
            // processingControl1
            // 
            this.processingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processingControl1.Location = new System.Drawing.Point(0, 0);
            this.processingControl1.Name = "processingControl1";
            this.processingControl1.Size = new System.Drawing.Size(1276, 622);
            this.processingControl1.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.productsControl1);
            this.tabPageProducts.ImageKey = "box.png";
            this.tabPageProducts.Location = new System.Drawing.Point(4, 39);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(1276, 622);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // productsControl1
            // 
            this.productsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsControl1.Location = new System.Drawing.Point(3, 3);
            this.productsControl1.Name = "productsControl1";
            this.productsControl1.Size = new System.Drawing.Size(1270, 616);
            this.productsControl1.TabIndex = 0;
            // 
            // tabPageStocks
            // 
            this.tabPageStocks.Controls.Add(this.stocksControl1);
            this.tabPageStocks.ImageKey = "stocks.png";
            this.tabPageStocks.Location = new System.Drawing.Point(4, 39);
            this.tabPageStocks.Name = "tabPageStocks";
            this.tabPageStocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStocks.Size = new System.Drawing.Size(1276, 622);
            this.tabPageStocks.TabIndex = 1;
            this.tabPageStocks.Text = "Stocks";
            this.tabPageStocks.UseVisualStyleBackColor = true;
            // 
            // stocksControl1
            // 
            this.stocksControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stocksControl1.Location = new System.Drawing.Point(3, 3);
            this.stocksControl1.Name = "stocksControl1";
            this.stocksControl1.Size = new System.Drawing.Size(1270, 616);
            this.stocksControl1.TabIndex = 0;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Controls.Add(this.purchasesControl1);
            this.tabPagePurchase.ImageKey = "purchase.png";
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 39);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Size = new System.Drawing.Size(1276, 622);
            this.tabPagePurchase.TabIndex = 2;
            this.tabPagePurchase.Text = "Purchases";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // purchasesControl1
            // 
            this.purchasesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchasesControl1.Location = new System.Drawing.Point(0, 0);
            this.purchasesControl1.Name = "purchasesControl1";
            this.purchasesControl1.Size = new System.Drawing.Size(1276, 622);
            this.purchasesControl1.TabIndex = 0;
            // 
            // tabPageSale
            // 
            this.tabPageSale.Controls.Add(this.salesControl1);
            this.tabPageSale.ImageKey = "sales.png";
            this.tabPageSale.Location = new System.Drawing.Point(4, 39);
            this.tabPageSale.Name = "tabPageSale";
            this.tabPageSale.Size = new System.Drawing.Size(1276, 622);
            this.tabPageSale.TabIndex = 3;
            this.tabPageSale.Text = "Sales";
            this.tabPageSale.UseVisualStyleBackColor = true;
            // 
            // salesControl1
            // 
            this.salesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesControl1.Location = new System.Drawing.Point(0, 0);
            this.salesControl1.Margin = new System.Windows.Forms.Padding(6);
            this.salesControl1.Name = "salesControl1";
            this.salesControl1.Size = new System.Drawing.Size(1276, 622);
            this.salesControl1.TabIndex = 0;
            // 
            // tabPageVocher
            // 
            this.tabPageVocher.Controls.Add(this.vouchersControl1);
            this.tabPageVocher.ImageKey = "voucher.png";
            this.tabPageVocher.Location = new System.Drawing.Point(4, 39);
            this.tabPageVocher.Name = "tabPageVocher";
            this.tabPageVocher.Size = new System.Drawing.Size(1276, 622);
            this.tabPageVocher.TabIndex = 4;
            this.tabPageVocher.Text = "Vouchers";
            this.tabPageVocher.UseVisualStyleBackColor = true;
            // 
            // vouchersControl1
            // 
            this.vouchersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vouchersControl1.Location = new System.Drawing.Point(0, 0);
            this.vouchersControl1.Name = "vouchersControl1";
            this.vouchersControl1.Size = new System.Drawing.Size(1276, 622);
            this.vouchersControl1.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.customersControl1);
            this.tabPageCustomer.ImageKey = "customers.png";
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 39);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Size = new System.Drawing.Size(1276, 622);
            this.tabPageCustomer.TabIndex = 5;
            this.tabPageCustomer.Text = "Customers";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // customersControl1
            // 
            this.customersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersControl1.Location = new System.Drawing.Point(0, 0);
            this.customersControl1.Margin = new System.Windows.Forms.Padding(6);
            this.customersControl1.Name = "customersControl1";
            this.customersControl1.Size = new System.Drawing.Size(1276, 622);
            this.customersControl1.TabIndex = 0;
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.Controls.Add(this.suppliersControl1);
            this.tabPageSupplier.ImageKey = "supplier.png";
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 39);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Size = new System.Drawing.Size(1276, 622);
            this.tabPageSupplier.TabIndex = 6;
            this.tabPageSupplier.Text = "Suppliers";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // tabPageBarcode
            // 
            this.tabPageBarcode.Controls.Add(this.gridControlBarcodeProductControl);
            this.tabPageBarcode.Controls.Add(this.groupBox16);
            this.tabPageBarcode.ImageKey = "barcode.png";
            this.tabPageBarcode.Location = new System.Drawing.Point(4, 39);
            this.tabPageBarcode.Name = "tabPageBarcode";
            this.tabPageBarcode.Size = new System.Drawing.Size(1276, 622);
            this.tabPageBarcode.TabIndex = 8;
            this.tabPageBarcode.Text = "Barcode";
            this.tabPageBarcode.UseVisualStyleBackColor = true;
            // 
            // gridControlBarcodeProductControl
            // 
            this.gridControlBarcodeProductControl.DataSource = this.productsBindingSource;
            this.gridControlBarcodeProductControl.Location = new System.Drawing.Point(639, 3);
            this.gridControlBarcodeProductControl.MainView = this.gridViewProductBarcode;
            this.gridControlBarcodeProductControl.Name = "gridControlBarcodeProductControl";
            this.gridControlBarcodeProductControl.Size = new System.Drawing.Size(634, 616);
            this.gridControlBarcodeProductControl.TabIndex = 10;
            this.gridControlBarcodeProductControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductBarcode});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(IslahGroupInventory.Product);
            // 
            // gridViewProductBarcode
            // 
            this.gridViewProductBarcode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProdId1,
            this.colProdCode1,
            this.colProdName1,
            this.colDescription1,
            this.colSellingPrice1,
            this.colReOrderPoint1,
            this.colDiscount1,
            this.colStock1,
            this.colSubCategory_Name1,
            this.colBranch_BranchId3,
            this.colBranch3,
            this.colSubCategory1});
            this.gridViewProductBarcode.GridControl = this.gridControlBarcodeProductControl;
            this.gridViewProductBarcode.Name = "gridViewProductBarcode";
            // 
            // colProdId1
            // 
            this.colProdId1.FieldName = "ProdId";
            this.colProdId1.Name = "colProdId1";
            // 
            // colProdCode1
            // 
            this.colProdCode1.Caption = "Product Code";
            this.colProdCode1.FieldName = "Product Code";
            this.colProdCode1.Name = "colProdCode1";
            this.colProdCode1.Visible = true;
            this.colProdCode1.VisibleIndex = 0;
            this.colProdCode1.Width = 147;
            // 
            // colProdName1
            // 
            this.colProdName1.Caption = "Product Name";
            this.colProdName1.FieldName = "Product Name";
            this.colProdName1.Name = "colProdName1";
            this.colProdName1.Visible = true;
            this.colProdName1.VisibleIndex = 1;
            this.colProdName1.Width = 335;
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            // 
            // colSellingPrice1
            // 
            this.colSellingPrice1.FieldName = "SellingPrice";
            this.colSellingPrice1.Name = "colSellingPrice1";
            // 
            // colReOrderPoint1
            // 
            this.colReOrderPoint1.FieldName = "ReOrderPoint";
            this.colReOrderPoint1.Name = "colReOrderPoint1";
            // 
            // colDiscount1
            // 
            this.colDiscount1.FieldName = "Discount";
            this.colDiscount1.Name = "colDiscount1";
            // 
            // colStock1
            // 
            this.colStock1.FieldName = "Stock";
            this.colStock1.Name = "colStock1";
            // 
            // colSubCategory_Name1
            // 
            this.colSubCategory_Name1.Caption = "Sub Category";
            this.colSubCategory_Name1.FieldName = "Sub-Category";
            this.colSubCategory_Name1.Name = "colSubCategory_Name1";
            this.colSubCategory_Name1.Visible = true;
            this.colSubCategory_Name1.VisibleIndex = 2;
            this.colSubCategory_Name1.Width = 134;
            // 
            // colBranch_BranchId3
            // 
            this.colBranch_BranchId3.FieldName = "Branch_BranchId";
            this.colBranch_BranchId3.Name = "colBranch_BranchId3";
            // 
            // colBranch3
            // 
            this.colBranch3.FieldName = "Branch";
            this.colBranch3.Name = "colBranch3";
            // 
            // colSubCategory1
            // 
            this.colSubCategory1.FieldName = "SubCategory";
            this.colSubCategory1.Name = "colSubCategory1";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label53);
            this.groupBox16.Controls.Add(this.textBoxBCNumber);
            this.groupBox16.Controls.Add(this.label52);
            this.groupBox16.Controls.Add(this.label48);
            this.groupBox16.Controls.Add(this.textBoxBPCode);
            this.groupBox16.Controls.Add(this.buttonPrintBarcode);
            this.groupBox16.Controls.Add(this.label51);
            this.groupBox16.Controls.Add(this.comboBoxProductBarcodeCategory);
            this.groupBox16.Controls.Add(this.textBoxBCSuffix);
            this.groupBox16.Controls.Add(this.label49);
            this.groupBox16.Controls.Add(this.label50);
            this.groupBox16.Controls.Add(this.textBoxBPCCode);
            this.groupBox16.Location = new System.Drawing.Point(77, 105);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(488, 353);
            this.groupBox16.TabIndex = 9;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Barcode Generator";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(427, 229);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(36, 25);
            this.label53.TabIndex = 11;
            this.label53.Text = "x 3";
            // 
            // textBoxBCNumber
            // 
            this.textBoxBCNumber.Location = new System.Drawing.Point(231, 226);
            this.textBoxBCNumber.Name = "textBoxBCNumber";
            this.textBoxBCNumber.Size = new System.Drawing.Size(190, 33);
            this.textBoxBCNumber.TabIndex = 10;
            this.textBoxBCNumber.Text = "8";
            this.textBoxBCNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(50, 229);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(177, 25);
            this.label52.TabIndex = 9;
            this.label52.Text = "Number of Barcode";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(70, 42);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(159, 25);
            this.label48.TabIndex = 1;
            this.label48.Text = "Product Category";
            // 
            // textBoxBPCode
            // 
            this.textBoxBPCode.Enabled = false;
            this.textBoxBPCode.Location = new System.Drawing.Point(230, 180);
            this.textBoxBPCode.Name = "textBoxBPCode";
            this.textBoxBPCode.Size = new System.Drawing.Size(229, 33);
            this.textBoxBPCode.TabIndex = 8;
            // 
            // buttonPrintBarcode
            // 
            this.buttonPrintBarcode.Location = new System.Drawing.Point(301, 281);
            this.buttonPrintBarcode.Name = "buttonPrintBarcode";
            this.buttonPrintBarcode.Size = new System.Drawing.Size(158, 45);
            this.buttonPrintBarcode.TabIndex = 0;
            this.buttonPrintBarcode.Text = "Print Preview";
            this.buttonPrintBarcode.UseVisualStyleBackColor = true;
            this.buttonPrintBarcode.Click += new System.EventHandler(this.buttonPrintBarcode_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(98, 183);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(127, 25);
            this.label51.TabIndex = 7;
            this.label51.Text = "Product Code";
            // 
            // comboBoxProductBarcodeCategory
            // 
            this.comboBoxProductBarcodeCategory.DataSource = this.productCategoryBindingSource;
            this.comboBoxProductBarcodeCategory.DisplayMember = "Category_Code";
            this.comboBoxProductBarcodeCategory.FormattingEnabled = true;
            this.comboBoxProductBarcodeCategory.Location = new System.Drawing.Point(231, 39);
            this.comboBoxProductBarcodeCategory.Name = "comboBoxProductBarcodeCategory";
            this.comboBoxProductBarcodeCategory.Size = new System.Drawing.Size(228, 33);
            this.comboBoxProductBarcodeCategory.TabIndex = 2;
            this.comboBoxProductBarcodeCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProductBarcodeCategory_SelectionChangeCommitted);
            // 
            // textBoxBCSuffix
            // 
            this.textBoxBCSuffix.Location = new System.Drawing.Point(230, 135);
            this.textBoxBCSuffix.MaxLength = 4;
            this.textBoxBCSuffix.Name = "textBoxBCSuffix";
            this.textBoxBCSuffix.Size = new System.Drawing.Size(229, 33);
            this.textBoxBCSuffix.TabIndex = 6;
            this.textBoxBCSuffix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBCSuffix_KeyUp);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(19, 91);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(208, 25);
            this.label49.TabIndex = 3;
            this.label49.Text = "Product Category Code";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(48, 138);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(179, 25);
            this.label50.TabIndex = 5;
            this.label50.Text = "Product Code Suffix";
            // 
            // textBoxBPCCode
            // 
            this.textBoxBPCCode.Enabled = false;
            this.textBoxBPCCode.Location = new System.Drawing.Point(230, 88);
            this.textBoxBPCCode.Name = "textBoxBPCCode";
            this.textBoxBPCCode.Size = new System.Drawing.Size(229, 33);
            this.textBoxBPCCode.TabIndex = 4;
            // 
            // tabPageWorker
            // 
            this.tabPageWorker.Controls.Add(this.groupBox28);
            this.tabPageWorker.Controls.Add(this.gridControlWorker);
            this.tabPageWorker.Controls.Add(this.groupBox27);
            this.tabPageWorker.ImageKey = "builder.png";
            this.tabPageWorker.Location = new System.Drawing.Point(4, 39);
            this.tabPageWorker.Name = "tabPageWorker";
            this.tabPageWorker.Size = new System.Drawing.Size(1276, 622);
            this.tabPageWorker.TabIndex = 11;
            this.tabPageWorker.Text = "Workers";
            this.tabPageWorker.UseVisualStyleBackColor = true;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.label87);
            this.groupBox28.Location = new System.Drawing.Point(11, 14);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(379, 148);
            this.groupBox28.TabIndex = 6;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Total Worker";
            // 
            // label87
            // 
            this.label87.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(3, 29);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(373, 116);
            this.label87.TabIndex = 0;
            this.label87.Text = "00";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControlWorker
            // 
            this.gridControlWorker.Location = new System.Drawing.Point(396, 3);
            this.gridControlWorker.MainView = this.gridViewWorker;
            this.gridControlWorker.Name = "gridControlWorker";
            this.gridControlWorker.Size = new System.Drawing.Size(877, 616);
            this.gridControlWorker.TabIndex = 1;
            this.gridControlWorker.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWorker});
            // 
            // gridViewWorker
            // 
            this.gridViewWorker.GridControl = this.gridControlWorker;
            this.gridViewWorker.Name = "gridViewWorker";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.button14);
            this.groupBox27.Controls.Add(this.checkBox1);
            this.groupBox27.Controls.Add(this.textBox18);
            this.groupBox27.Controls.Add(this.label86);
            this.groupBox27.Controls.Add(this.textBox17);
            this.groupBox27.Controls.Add(this.label81);
            this.groupBox27.Location = new System.Drawing.Point(11, 168);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(379, 202);
            this.groupBox27.TabIndex = 0;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Add Worker";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(259, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(105, 35);
            this.button14.TabIndex = 28;
            this.button14.Text = "Add";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(110, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 29);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(110, 74);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(254, 26);
            this.textBox18.TabIndex = 26;
            // 
            // label86
            // 
            this.label86.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(6, 77);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(98, 20);
            this.label86.TabIndex = 25;
            this.label86.Text = "Worker Type";
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(110, 42);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(254, 26);
            this.textBox17.TabIndex = 24;
            // 
            // label81
            // 
            this.label81.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(53, 45);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(51, 20);
            this.label81.TabIndex = 23;
            this.label81.Text = "Name";
            // 
            // tabPageWorks
            // 
            this.tabPageWorks.Controls.Add(this.gridControlWorks);
            this.tabPageWorks.Controls.Add(this.groupBox32);
            this.tabPageWorks.ImageKey = "hammer.png";
            this.tabPageWorks.Location = new System.Drawing.Point(4, 39);
            this.tabPageWorks.Name = "tabPageWorks";
            this.tabPageWorks.Size = new System.Drawing.Size(1276, 622);
            this.tabPageWorks.TabIndex = 12;
            this.tabPageWorks.Text = "Works";
            this.tabPageWorks.UseVisualStyleBackColor = true;
            // 
            // gridControlWorks
            // 
            this.gridControlWorks.Location = new System.Drawing.Point(373, 3);
            this.gridControlWorks.MainView = this.gridViewWorks;
            this.gridControlWorks.Name = "gridControlWorks";
            this.gridControlWorks.Size = new System.Drawing.Size(896, 616);
            this.gridControlWorks.TabIndex = 8;
            this.gridControlWorks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWorks});
            // 
            // gridViewWorks
            // 
            this.gridViewWorks.GridControl = this.gridControlWorks;
            this.gridViewWorks.Name = "gridViewWorks";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.comboBox6);
            this.groupBox32.Controls.Add(this.label100);
            this.groupBox32.Controls.Add(this.comboBox5);
            this.groupBox32.Controls.Add(this.dateTimePicker5);
            this.groupBox32.Controls.Add(this.label97);
            this.groupBox32.Controls.Add(this.button16);
            this.groupBox32.Controls.Add(this.textBox26);
            this.groupBox32.Controls.Add(this.label98);
            this.groupBox32.Controls.Add(this.label99);
            this.groupBox32.Location = new System.Drawing.Point(8, 12);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(359, 231);
            this.groupBox32.TabIndex = 7;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Add Work";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(96, 77);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(253, 33);
            this.comboBox6.TabIndex = 42;
            // 
            // label100
            // 
            this.label100.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(6, 84);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(84, 20);
            this.label100.TabIndex = 41;
            this.label100.Text = "Work Type";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(96, 38);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(253, 33);
            this.comboBox5.TabIndex = 40;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "";
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(95, 116);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(254, 33);
            this.dateTimePicker5.TabIndex = 39;
            // 
            // label97
            // 
            this.label97.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(46, 126);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(44, 20);
            this.label97.TabIndex = 38;
            this.label97.Text = "Date";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(244, 187);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(105, 35);
            this.button16.TabIndex = 28;
            this.button16.Text = "Add";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // textBox26
            // 
            this.textBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(95, 155);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(254, 26);
            this.textBox26.TabIndex = 26;
            // 
            // label98
            // 
            this.label98.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(22, 158);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(68, 20);
            this.label98.TabIndex = 25;
            this.label98.Text = "Quantity";
            // 
            // label99
            // 
            this.label99.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(30, 45);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(60, 20);
            this.label99.TabIndex = 23;
            this.label99.Text = "Worker";
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.usersControl1);
            this.tabPageUser.ImageKey = "accounts.png";
            this.tabPageUser.Location = new System.Drawing.Point(4, 39);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Size = new System.Drawing.Size(1276, 622);
            this.tabPageUser.TabIndex = 7;
            this.tabPageUser.Text = "Users";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // usersControl1
            // 
            this.usersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersControl1.Location = new System.Drawing.Point(0, 0);
            this.usersControl1.Name = "usersControl1";
            this.usersControl1.Size = new System.Drawing.Size(1276, 622);
            this.usersControl1.TabIndex = 0;
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "accounts.png");
            this.imageListTab.Images.SetKeyName(1, "customers.png");
            this.imageListTab.Images.SetKeyName(2, "purchase.png");
            this.imageListTab.Images.SetKeyName(3, "sales.png");
            this.imageListTab.Images.SetKeyName(4, "services.png");
            this.imageListTab.Images.SetKeyName(5, "stocks.png");
            this.imageListTab.Images.SetKeyName(6, "supplier.png");
            this.imageListTab.Images.SetKeyName(7, "voucher.png");
            this.imageListTab.Images.SetKeyName(8, "barcode.png");
            this.imageListTab.Images.SetKeyName(9, "raw.png");
            this.imageListTab.Images.SetKeyName(10, "box.png");
            this.imageListTab.Images.SetKeyName(11, "processing.png");
            this.imageListTab.Images.SetKeyName(12, "hammer.png");
            this.imageListTab.Images.SetKeyName(13, "builder.png");
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(IslahGroupInventory.Supplier);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(IslahGroupInventory.Customer);
            // 
            // rawProductsBindingSource
            // 
            this.rawProductsBindingSource.DataSource = typeof(IslahGroupInventory.RawProduct);
            // 
            // suppliersControl1
            // 
            this.suppliersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersControl1.Location = new System.Drawing.Point(0, 0);
            this.suppliersControl1.Name = "suppliersControl1";
            this.suppliersControl1.Size = new System.Drawing.Size(1276, 622);
            this.suppliersControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "MainForm";
            this.Text = "Islah Inventory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageRawMaterial.ResumeLayout(false);
            this.tabPageProcessing.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageStocks.ResumeLayout(false);
            this.tabPagePurchase.ResumeLayout(false);
            this.tabPageSale.ResumeLayout(false);
            this.tabPageVocher.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageSupplier.ResumeLayout(false);
            this.tabPageBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarcodeProductControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductBarcode)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            this.tabPageWorker.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorker)).EndInit();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.tabPageWorks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorks)).EndInit();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.tabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurchaseItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islahInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem islahGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treebricksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsername;
        private System.Windows.Forms.ToolStripStatusLabel tsslBranchCode;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageStocks;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabPageSale;
        private System.Windows.Forms.TabPage tabPageVocher;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.ImageList imageListTab;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.BindingSource bindingSourcePurchaseItem;
        private System.Windows.Forms.TabPage tabPageBarcode;
        private System.Windows.Forms.Button buttonPrintBarcode;
        private DevExpress.XtraGrid.GridControl gridControlBarcodeProductControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colProdId1;
        private DevExpress.XtraGrid.Columns.GridColumn colProdCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colProdName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colReOrderPoint1;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCategory_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId3;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch3;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCategory1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBoxBPCode;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox comboBoxProductBarcodeCategory;
        private System.Windows.Forms.TextBox textBoxBCSuffix;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBoxBPCCode;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBoxBCNumber;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TabPage tabPageRawMaterial;
        private System.Windows.Forms.TabPage tabPageProcessing;
        private System.Windows.Forms.BindingSource rawProductsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn pTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PPId;
        private System.Windows.Forms.TabPage tabPageWorker;
        private System.Windows.Forms.TabPage tabPageWorks;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.Label label87;
        private DevExpress.XtraGrid.GridControl gridControlWorker;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWorker;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label81;
        private DevExpress.XtraGrid.GridControl gridControlWorks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWorks;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private ViewControls.UsersControl usersControl1;
        private ViewControls.RawMaterialControl rawMaterialControl1;
        private ViewControls.ProcessingControl processingControl1;
        private ViewControls.ProductsControl productsControl1;
        private ViewControls.StocksControl stocksControl1;
        private ViewControls.PurchasesControl purchasesControl1;
        private ViewControls.SalesControl salesControl1;
        private ViewControls.VouchersControl vouchersControl1;
        private ViewControls.CustomersControl customersControl1;
        private ViewControls.SuppliersControl suppliersControl1;
    }
}

