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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProdId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProdCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProdName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSubCategory_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSellingPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colReOrderPoint = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBranch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSubCategory = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRPoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProdCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUPLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.textBoxUPStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUPDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUPRPoint = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUPSPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxUPCategory = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxUPDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUPName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxUPCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonProductDelete = new System.Windows.Forms.Button();
            this.textBoxDPCode = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPageStocks = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelTotalProduct = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridControlStockProductList = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn12 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.tabPageSale = new System.Windows.Forms.TabPage();
            this.tabPageVocher = new System.Windows.Forms.TabPage();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.labelTotalCustomers = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxICRemarks = new System.Windows.Forms.TextBox();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxICEmail = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxICContactNo = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxICAddress = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxICName = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxICCode = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.gridControlCustomers = new DevExpress.XtraGrid.GridControl();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageStocks.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStockProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView2)).BeginInit();
            this.tabPageCustomer.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).BeginInit();
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
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "Username";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel2.Text = "Branch Code";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageProducts);
            this.tabControlMain.Controls.Add(this.tabPageStocks);
            this.tabControlMain.Controls.Add(this.tabPagePurchase);
            this.tabControlMain.Controls.Add(this.tabPageSale);
            this.tabControlMain.Controls.Add(this.tabPageVocher);
            this.tabControlMain.Controls.Add(this.tabPageCustomer);
            this.tabControlMain.Controls.Add(this.tabPageSupplier);
            this.tabControlMain.Controls.Add(this.tabPageUser);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ImageList = this.imageListTab;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1284, 665);
            this.tabControlMain.TabIndex = 3;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.groupBox3);
            this.tabPageProducts.Controls.Add(this.tabControl2);
            this.tabPageProducts.ImageKey = "product.png";
            this.tabPageProducts.Location = new System.Drawing.Point(4, 39);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(1276, 622);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControlProducts);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(386, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 616);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Products List";
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.DataSource = this.productsBindingSource;
            this.gridControlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlProducts.Location = new System.Drawing.Point(3, 25);
            this.gridControlProducts.MainView = this.bandedGridView1;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(881, 588);
            this.gridControlProducts.TabIndex = 0;
            this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(IslahGroupInventory.Product);
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProdId,
            this.colProdCode,
            this.colProdName,
            this.colSubCategory_Name,
            this.colDescription,
            this.colSellingPrice,
            this.colReOrderPoint,
            this.colDiscount,
            this.colStock,
            this.colBranch_BranchId,
            this.colBranch,
            this.colSubCategory});
            this.bandedGridView1.GridControl = this.gridControlProducts;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Product";
            this.gridBand1.Columns.Add(this.colProdId);
            this.gridBand1.Columns.Add(this.colProdCode);
            this.gridBand1.Columns.Add(this.colProdName);
            this.gridBand1.Columns.Add(this.colSubCategory_Name);
            this.gridBand1.Columns.Add(this.colDescription);
            this.gridBand1.Columns.Add(this.colSellingPrice);
            this.gridBand1.Columns.Add(this.colReOrderPoint);
            this.gridBand1.Columns.Add(this.colDiscount);
            this.gridBand1.Columns.Add(this.colStock);
            this.gridBand1.Columns.Add(this.colBranch_BranchId);
            this.gridBand1.Columns.Add(this.colBranch);
            this.gridBand1.Columns.Add(this.colSubCategory);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 625;
            // 
            // colProdId
            // 
            this.colProdId.FieldName = "ProdId";
            this.colProdId.Name = "colProdId";
            // 
            // colProdCode
            // 
            this.colProdCode.Caption = "Code";
            this.colProdCode.FieldName = "ProdCode";
            this.colProdCode.Name = "colProdCode";
            this.colProdCode.Visible = true;
            this.colProdCode.Width = 76;
            // 
            // colProdName
            // 
            this.colProdName.Caption = "Name";
            this.colProdName.FieldName = "ProdName";
            this.colProdName.Name = "colProdName";
            this.colProdName.Visible = true;
            this.colProdName.Width = 76;
            // 
            // colSubCategory_Name
            // 
            this.colSubCategory_Name.Caption = "Category";
            this.colSubCategory_Name.FieldName = "SubCategory_Name";
            this.colSubCategory_Name.Name = "colSubCategory_Name";
            this.colSubCategory_Name.Visible = true;
            this.colSubCategory_Name.Width = 72;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.Width = 171;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.Caption = "Selling Price";
            this.colSellingPrice.FieldName = "SellingPrice";
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.Visible = true;
            this.colSellingPrice.Width = 64;
            // 
            // colReOrderPoint
            // 
            this.colReOrderPoint.Caption = "Re-Order Point";
            this.colReOrderPoint.FieldName = "ReOrderPoint";
            this.colReOrderPoint.Name = "colReOrderPoint";
            this.colReOrderPoint.Visible = true;
            this.colReOrderPoint.Width = 63;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "Discount";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.Width = 53;
            // 
            // colStock
            // 
            this.colStock.Caption = "Stock";
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.Width = 50;
            // 
            // colBranch_BranchId
            // 
            this.colBranch_BranchId.FieldName = "Branch_BranchId";
            this.colBranch_BranchId.Name = "colBranch_BranchId";
            this.colBranch_BranchId.Width = 67;
            // 
            // colBranch
            // 
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            // 
            // colSubCategory
            // 
            this.colSubCategory.FieldName = "SubCategory";
            this.colSubCategory.Name = "colSubCategory";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(381, 619);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxAddProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.buttonAddCategory);
            this.groupBoxAddProduct.Controls.Add(this.buttonAddProduct);
            this.groupBoxAddProduct.Controls.Add(this.textBoxStock);
            this.groupBoxAddProduct.Controls.Add(this.label8);
            this.groupBoxAddProduct.Controls.Add(this.textBoxDiscount);
            this.groupBoxAddProduct.Controls.Add(this.label7);
            this.groupBoxAddProduct.Controls.Add(this.textBoxRPoint);
            this.groupBoxAddProduct.Controls.Add(this.label6);
            this.groupBoxAddProduct.Controls.Add(this.textBoxSPrice);
            this.groupBoxAddProduct.Controls.Add(this.label5);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddProduct.Controls.Add(this.label4);
            this.groupBoxAddProduct.Controls.Add(this.textBoxDescription);
            this.groupBoxAddProduct.Controls.Add(this.label3);
            this.groupBoxAddProduct.Controls.Add(this.textBoxName);
            this.groupBoxAddProduct.Controls.Add(this.label2);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProdCode);
            this.groupBoxAddProduct.Controls.Add(this.label1);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(357, 427);
            this.groupBoxAddProduct.TabIndex = 1;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Add Product";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCategory.AutoSize = true;
            this.buttonAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCategory.Location = new System.Drawing.Point(316, 192);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(29, 30);
            this.buttonAddCategory.TabIndex = 36;
            this.buttonAddCategory.Text = "+";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddProduct.Location = new System.Drawing.Point(261, 385);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(90, 36);
            this.buttonAddProduct.TabIndex = 35;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(119, 337);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(232, 26);
            this.textBoxStock.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Stock";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(118, 300);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(232, 26);
            this.textBoxDiscount.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Discount";
            // 
            // textBoxRPoint
            // 
            this.textBoxRPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRPoint.Location = new System.Drawing.Point(118, 264);
            this.textBoxRPoint.Name = "textBoxRPoint";
            this.textBoxRPoint.Size = new System.Drawing.Size(232, 26);
            this.textBoxRPoint.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Reorder Point";
            // 
            // textBoxSPrice
            // 
            this.textBoxSPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSPrice.Location = new System.Drawing.Point(118, 229);
            this.textBoxSPrice.Name = "textBoxSPrice";
            this.textBoxSPrice.Size = new System.Drawing.Size(232, 26);
            this.textBoxSPrice.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Selling Price";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategory.DataSource = this.productCategoryBindingSource;
            this.comboBoxCategory.DisplayMember = "Name";
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(118, 194);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(192, 28);
            this.comboBoxCategory.TabIndex = 26;
            this.comboBoxCategory.ValueMember = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Category";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(118, 105);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(232, 83);
            this.textBoxDescription.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(118, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(232, 26);
            this.textBoxName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // textBoxProdCode
            // 
            this.textBoxProdCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdCode.Location = new System.Drawing.Point(118, 41);
            this.textBoxProdCode.Name = "textBoxProdCode";
            this.textBoxProdCode.Size = new System.Drawing.Size(232, 26);
            this.textBoxProdCode.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product Code";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUPLoad);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonUpdateProduct);
            this.groupBox1.Controls.Add(this.textBoxUPStock);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxUPDiscount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxUPRPoint);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxUPSPrice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxUPCategory);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxUPDescription);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxUPName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxUPCode);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 451);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Product";
            // 
            // buttonUPLoad
            // 
            this.buttonUPLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUPLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUPLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUPLoad.Location = new System.Drawing.Point(261, 65);
            this.buttonUPLoad.Name = "buttonUPLoad";
            this.buttonUPLoad.Size = new System.Drawing.Size(90, 36);
            this.buttonUPLoad.TabIndex = 37;
            this.buttonUPLoad.Text = "Load";
            this.buttonUPLoad.UseVisualStyleBackColor = true;
            this.buttonUPLoad.Click += new System.EventHandler(this.buttonUPLoad_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 30);
            this.button1.TabIndex = 36;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateProduct.Enabled = false;
            this.buttonUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdateProduct.Location = new System.Drawing.Point(261, 404);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(90, 36);
            this.buttonUpdateProduct.TabIndex = 35;
            this.buttonUpdateProduct.Text = "Update";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // textBoxUPStock
            // 
            this.textBoxUPStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPStock.Enabled = false;
            this.textBoxUPStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPStock.Location = new System.Drawing.Point(119, 372);
            this.textBoxUPStock.Name = "textBoxUPStock";
            this.textBoxUPStock.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPStock.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Stock";
            // 
            // textBoxUPDiscount
            // 
            this.textBoxUPDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPDiscount.Location = new System.Drawing.Point(118, 335);
            this.textBoxUPDiscount.Name = "textBoxUPDiscount";
            this.textBoxUPDiscount.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPDiscount.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Discount";
            // 
            // textBoxUPRPoint
            // 
            this.textBoxUPRPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPRPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPRPoint.Location = new System.Drawing.Point(118, 299);
            this.textBoxUPRPoint.Name = "textBoxUPRPoint";
            this.textBoxUPRPoint.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPRPoint.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Reorder Point";
            // 
            // textBoxUPSPrice
            // 
            this.textBoxUPSPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPSPrice.Location = new System.Drawing.Point(118, 264);
            this.textBoxUPSPrice.Name = "textBoxUPSPrice";
            this.textBoxUPSPrice.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPSPrice.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Selling Price";
            // 
            // comboBoxUPCategory
            // 
            this.comboBoxUPCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUPCategory.DisplayMember = "Name";
            this.comboBoxUPCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUPCategory.FormattingEnabled = true;
            this.comboBoxUPCategory.Location = new System.Drawing.Point(118, 229);
            this.comboBoxUPCategory.Name = "comboBoxUPCategory";
            this.comboBoxUPCategory.Size = new System.Drawing.Size(192, 28);
            this.comboBoxUPCategory.TabIndex = 26;
            this.comboBoxUPCategory.ValueMember = "Name";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Category";
            // 
            // textBoxUPDescription
            // 
            this.textBoxUPDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPDescription.Location = new System.Drawing.Point(118, 140);
            this.textBoxUPDescription.Multiline = true;
            this.textBoxUPDescription.Name = "textBoxUPDescription";
            this.textBoxUPDescription.Size = new System.Drawing.Size(232, 83);
            this.textBoxUPDescription.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Description";
            // 
            // textBoxUPName
            // 
            this.textBoxUPName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPName.Location = new System.Drawing.Point(118, 108);
            this.textBoxUPName.Name = "textBoxUPName";
            this.textBoxUPName.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPName.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(61, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Name";
            // 
            // textBoxUPCode
            // 
            this.textBoxUPCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPCode.Location = new System.Drawing.Point(118, 33);
            this.textBoxUPCode.Name = "textBoxUPCode";
            this.textBoxUPCode.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPCode.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Product Code";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(373, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonProductDelete);
            this.groupBox2.Controls.Add(this.textBoxDPCode);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Product";
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonProductDelete.Location = new System.Drawing.Point(260, 82);
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.Size = new System.Drawing.Size(90, 36);
            this.buttonProductDelete.TabIndex = 38;
            this.buttonProductDelete.Text = "Remove";
            this.buttonProductDelete.UseVisualStyleBackColor = true;
            this.buttonProductDelete.Click += new System.EventHandler(this.buttonProductDelete_Click);
            // 
            // textBoxDPCode
            // 
            this.textBoxDPCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDPCode.Location = new System.Drawing.Point(118, 33);
            this.textBoxDPCode.Name = "textBoxDPCode";
            this.textBoxDPCode.Size = new System.Drawing.Size(232, 26);
            this.textBoxDPCode.TabIndex = 20;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 20);
            this.label24.TabIndex = 19;
            this.label24.Text = "Product Code";
            // 
            // tabPageStocks
            // 
            this.tabPageStocks.Controls.Add(this.groupBox7);
            this.tabPageStocks.Controls.Add(this.groupBox6);
            this.tabPageStocks.Controls.Add(this.groupBox5);
            this.tabPageStocks.Controls.Add(this.groupBox4);
            this.tabPageStocks.ImageKey = "stocks.png";
            this.tabPageStocks.Location = new System.Drawing.Point(4, 39);
            this.tabPageStocks.Name = "tabPageStocks";
            this.tabPageStocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStocks.Size = new System.Drawing.Size(1276, 622);
            this.tabPageStocks.TabIndex = 1;
            this.tabPageStocks.Text = "Stocks";
            this.tabPageStocks.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.textBox4);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.textBox5);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Location = new System.Drawing.Point(23, 384);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(339, 225);
            this.groupBox7.TabIndex = 39;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Update Stock";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(118, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 26);
            this.textBox3.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(29, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "New Stock";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(242, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 36);
            this.button4.TabIndex = 36;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(243, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 36);
            this.button5.TabIndex = 35;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(118, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 26);
            this.textBox4.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 20);
            this.label20.TabIndex = 33;
            this.label20.Text = "Current Stock";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(118, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(214, 26);
            this.textBox5.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 44);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 20);
            this.label21.TabIndex = 19;
            this.label21.Text = "Product Code";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelTotalProduct);
            this.groupBox6.Location = new System.Drawing.Point(23, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(339, 148);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total Product";
            // 
            // labelTotalProduct
            // 
            this.labelTotalProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProduct.Location = new System.Drawing.Point(3, 25);
            this.labelTotalProduct.Name = "labelTotalProduct";
            this.labelTotalProduct.Size = new System.Drawing.Size(333, 120);
            this.labelTotalProduct.TabIndex = 0;
            this.labelTotalProduct.Text = "26";
            this.labelTotalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Location = new System.Drawing.Point(23, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 225);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Stock";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(118, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 26);
            this.textBox2.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(29, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "Add Stock";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(242, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 36;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(243, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 35;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 26);
            this.textBox1.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Current Stock";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(118, 41);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(214, 26);
            this.textBox7.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 20);
            this.label25.TabIndex = 19;
            this.label25.Text = "Product Code";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridControlStockProductList);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(381, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(892, 616);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products List";
            // 
            // gridControlStockProductList
            // 
            this.gridControlStockProductList.DataSource = this.productsBindingSource;
            this.gridControlStockProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStockProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlStockProductList.Location = new System.Drawing.Point(3, 16);
            this.gridControlStockProductList.MainView = this.bandedGridView2;
            this.gridControlStockProductList.Name = "gridControlStockProductList";
            this.gridControlStockProductList.Size = new System.Drawing.Size(886, 597);
            this.gridControlStockProductList.TabIndex = 0;
            this.gridControlStockProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView2});
            // 
            // bandedGridView2
            // 
            this.bandedGridView2.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.bandedGridView2.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn7,
            this.bandedGridColumn8,
            this.bandedGridColumn9,
            this.bandedGridColumn10,
            this.bandedGridColumn11,
            this.bandedGridColumn12});
            this.bandedGridView2.GridControl = this.gridControlStockProductList;
            this.bandedGridView2.Name = "bandedGridView2";
            this.bandedGridView2.OptionsBehavior.Editable = false;
            this.bandedGridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Product";
            this.gridBand2.Columns.Add(this.bandedGridColumn1);
            this.gridBand2.Columns.Add(this.bandedGridColumn2);
            this.gridBand2.Columns.Add(this.bandedGridColumn3);
            this.gridBand2.Columns.Add(this.bandedGridColumn4);
            this.gridBand2.Columns.Add(this.bandedGridColumn5);
            this.gridBand2.Columns.Add(this.bandedGridColumn6);
            this.gridBand2.Columns.Add(this.bandedGridColumn7);
            this.gridBand2.Columns.Add(this.bandedGridColumn8);
            this.gridBand2.Columns.Add(this.bandedGridColumn9);
            this.gridBand2.Columns.Add(this.bandedGridColumn10);
            this.gridBand2.Columns.Add(this.bandedGridColumn11);
            this.gridBand2.Columns.Add(this.bandedGridColumn12);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 625;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.FieldName = "ProdId";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "Code";
            this.bandedGridColumn2.FieldName = "ProdCode";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.Width = 76;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Name";
            this.bandedGridColumn3.FieldName = "ProdName";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            this.bandedGridColumn3.Width = 76;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Category";
            this.bandedGridColumn4.FieldName = "SubCategory_Name";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.Width = 72;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "Description";
            this.bandedGridColumn5.FieldName = "Description";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            this.bandedGridColumn5.Width = 171;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "Selling Price";
            this.bandedGridColumn6.FieldName = "SellingPrice";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.Visible = true;
            this.bandedGridColumn6.Width = 64;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.Caption = "Re-Order Point";
            this.bandedGridColumn7.FieldName = "ReOrderPoint";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.Visible = true;
            this.bandedGridColumn7.Width = 63;
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.Caption = "Discount";
            this.bandedGridColumn8.FieldName = "Discount";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.Visible = true;
            this.bandedGridColumn8.Width = 53;
            // 
            // bandedGridColumn9
            // 
            this.bandedGridColumn9.Caption = "Stock";
            this.bandedGridColumn9.FieldName = "Stock";
            this.bandedGridColumn9.Name = "bandedGridColumn9";
            this.bandedGridColumn9.Visible = true;
            this.bandedGridColumn9.Width = 50;
            // 
            // bandedGridColumn10
            // 
            this.bandedGridColumn10.FieldName = "Branch_BranchId";
            this.bandedGridColumn10.Name = "bandedGridColumn10";
            this.bandedGridColumn10.Width = 67;
            // 
            // bandedGridColumn11
            // 
            this.bandedGridColumn11.FieldName = "Branch";
            this.bandedGridColumn11.Name = "bandedGridColumn11";
            // 
            // bandedGridColumn12
            // 
            this.bandedGridColumn12.FieldName = "SubCategory";
            this.bandedGridColumn12.Name = "bandedGridColumn12";
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.ImageKey = "purchase.png";
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 39);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Size = new System.Drawing.Size(1276, 622);
            this.tabPagePurchase.TabIndex = 2;
            this.tabPagePurchase.Text = "Purchases";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // tabPageSale
            // 
            this.tabPageSale.ImageKey = "sales.png";
            this.tabPageSale.Location = new System.Drawing.Point(4, 39);
            this.tabPageSale.Name = "tabPageSale";
            this.tabPageSale.Size = new System.Drawing.Size(1276, 622);
            this.tabPageSale.TabIndex = 3;
            this.tabPageSale.Text = "Sales";
            this.tabPageSale.UseVisualStyleBackColor = true;
            // 
            // tabPageVocher
            // 
            this.tabPageVocher.ImageKey = "voucher.png";
            this.tabPageVocher.Location = new System.Drawing.Point(4, 39);
            this.tabPageVocher.Name = "tabPageVocher";
            this.tabPageVocher.Size = new System.Drawing.Size(1276, 622);
            this.tabPageVocher.TabIndex = 4;
            this.tabPageVocher.Text = "Vouchers";
            this.tabPageVocher.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.groupBox10);
            this.tabPageCustomer.Controls.Add(this.groupBox9);
            this.tabPageCustomer.Controls.Add(this.groupBox8);
            this.tabPageCustomer.ImageKey = "customers.png";
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 39);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Size = new System.Drawing.Size(1276, 622);
            this.tabPageCustomer.TabIndex = 5;
            this.tabPageCustomer.Text = "Customers";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.labelTotalCustomers);
            this.groupBox10.Location = new System.Drawing.Point(15, 16);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(357, 148);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Total Customer";
            // 
            // labelTotalCustomers
            // 
            this.labelTotalCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCustomers.Location = new System.Drawing.Point(3, 25);
            this.labelTotalCustomers.Name = "labelTotalCustomers";
            this.labelTotalCustomers.Size = new System.Drawing.Size(351, 120);
            this.labelTotalCustomers.TabIndex = 0;
            this.labelTotalCustomers.Text = "26";
            this.labelTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxICRemarks);
            this.groupBox9.Controls.Add(this.buttonAddCustomer);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.textBoxICEmail);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.textBoxICContactNo);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.textBoxICAddress);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.textBoxICName);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.textBoxICCode);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Location = new System.Drawing.Point(15, 179);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(357, 390);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Add Customer";
            // 
            // textBoxICRemarks
            // 
            this.textBoxICRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxICRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxICRemarks.Location = new System.Drawing.Point(100, 258);
            this.textBoxICRemarks.Multiline = true;
            this.textBoxICRemarks.Name = "textBoxICRemarks";
            this.textBoxICRemarks.Size = new System.Drawing.Size(251, 83);
            this.textBoxICRemarks.TabIndex = 36;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddCustomer.Location = new System.Drawing.Point(261, 347);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(90, 36);
            this.buttonAddCustomer.TabIndex = 35;
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(21, 261);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 20);
            this.label23.TabIndex = 31;
            this.label23.Text = "Remarks";
            // 
            // textBoxICEmail
            // 
            this.textBoxICEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxICEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxICEmail.Location = new System.Drawing.Point(100, 226);
            this.textBoxICEmail.Name = "textBoxICEmail";
            this.textBoxICEmail.Size = new System.Drawing.Size(251, 26);
            this.textBoxICEmail.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(46, 229);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 20);
            this.label26.TabIndex = 29;
            this.label26.Text = "Email";
            // 
            // textBoxICContactNo
            // 
            this.textBoxICContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxICContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxICContactNo.Location = new System.Drawing.Point(100, 194);
            this.textBoxICContactNo.Name = "textBoxICContactNo";
            this.textBoxICContactNo.Size = new System.Drawing.Size(251, 26);
            this.textBoxICContactNo.TabIndex = 28;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(5, 197);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 20);
            this.label27.TabIndex = 27;
            this.label27.Text = "Contact No";
            // 
            // textBoxICAddress
            // 
            this.textBoxICAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxICAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxICAddress.Location = new System.Drawing.Point(100, 105);
            this.textBoxICAddress.Multiline = true;
            this.textBoxICAddress.Name = "textBoxICAddress";
            this.textBoxICAddress.Size = new System.Drawing.Size(251, 83);
            this.textBoxICAddress.TabIndex = 24;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(26, 108);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 20);
            this.label29.TabIndex = 23;
            this.label29.Text = "Address";
            // 
            // textBoxICName
            // 
            this.textBoxICName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxICName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxICName.Location = new System.Drawing.Point(100, 73);
            this.textBoxICName.Name = "textBoxICName";
            this.textBoxICName.Size = new System.Drawing.Size(251, 26);
            this.textBoxICName.TabIndex = 22;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(43, 76);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 20);
            this.label30.TabIndex = 21;
            this.label30.Text = "Name";
            // 
            // textBoxICCode
            // 
            this.textBoxICCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxICCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxICCode.Location = new System.Drawing.Point(100, 41);
            this.textBoxICCode.Name = "textBoxICCode";
            this.textBoxICCode.Size = new System.Drawing.Size(251, 26);
            this.textBoxICCode.TabIndex = 20;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(47, 44);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 20);
            this.label31.TabIndex = 19;
            this.label31.Text = "Code";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.gridControlCustomers);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(386, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(887, 616);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Customers";
            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.DataSource = this.customersBindingSource;
            this.gridControlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustomers.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlCustomers.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlCustomers.Location = new System.Drawing.Point(3, 25);
            this.gridControlCustomers.MainView = this.gridViewCustomer;
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.Size = new System.Drawing.Size(881, 588);
            this.gridControlCustomers.TabIndex = 0;
            this.gridControlCustomers.UseEmbeddedNavigator = true;
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomer});
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(IslahGroupInventory.Customer);
            // 
            // gridViewCustomer
            // 
            this.gridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustId,
            this.colCustCode,
            this.colCustName,
            this.colAddress,
            this.colContactNo,
            this.colEmail,
            this.colRemark,
            this.colBranch_BranchId1,
            this.colBranch1});
            this.gridViewCustomer.GridControl = this.gridControlCustomers;
            this.gridViewCustomer.Name = "gridViewCustomer";
            this.gridViewCustomer.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gridViewCustomer.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewCustomer.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewCustomer_ValidateRow);
            // 
            // colCustId
            // 
            this.colCustId.FieldName = "CustId";
            this.colCustId.Name = "colCustId";
            this.colCustId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colCustCode
            // 
            this.colCustCode.Caption = "Code";
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 0;
            this.colCustCode.Width = 87;
            // 
            // colCustName
            // 
            this.colCustName.Caption = "Name";
            this.colCustName.FieldName = "CustName";
            this.colCustName.Name = "colCustName";
            this.colCustName.Visible = true;
            this.colCustName.VisibleIndex = 1;
            this.colCustName.Width = 145;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 146;
            // 
            // colContactNo
            // 
            this.colContactNo.FieldName = "ContactNo";
            this.colContactNo.Name = "colContactNo";
            this.colContactNo.Visible = true;
            this.colContactNo.VisibleIndex = 3;
            this.colContactNo.Width = 102;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 102;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 5;
            this.colRemark.Width = 110;
            // 
            // colBranch_BranchId1
            // 
            this.colBranch_BranchId1.FieldName = "Branch_BranchId";
            this.colBranch_BranchId1.Name = "colBranch_BranchId1";
            // 
            // colBranch1
            // 
            this.colBranch1.FieldName = "Branch";
            this.colBranch1.Name = "colBranch1";
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.ImageKey = "supplier.png";
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 39);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Size = new System.Drawing.Size(1276, 622);
            this.tabPageSupplier.TabIndex = 6;
            this.tabPageSupplier.Text = "Suppliers";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // tabPageUser
            // 
            this.tabPageUser.ImageKey = "accounts.png";
            this.tabPageUser.Location = new System.Drawing.Point(4, 39);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Size = new System.Drawing.Size(1276, 622);
            this.tabPageUser.TabIndex = 7;
            this.tabPageUser.Text = "Users";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "accounts.png");
            this.imageListTab.Images.SetKeyName(1, "customers.png");
            this.imageListTab.Images.SetKeyName(2, "product.png");
            this.imageListTab.Images.SetKeyName(3, "purchase.png");
            this.imageListTab.Images.SetKeyName(4, "sales.png");
            this.imageListTab.Images.SetKeyName(5, "services.png");
            this.imageListTab.Images.SetKeyName(6, "stocks.png");
            this.imageListTab.Images.SetKeyName(7, "supplier.png");
            this.imageListTab.Images.SetKeyName(8, "voucher.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1300, 750);
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "MainForm";
            this.Text = "Islah Inventory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageStocks.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStockProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView2)).EndInit();
            this.tabPageCustomer.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).EndInit();
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProdCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUPLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.TextBox textBoxUPStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUPDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUPRPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxUPSPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxUPCategory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxUPDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUPName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxUPCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDPCode;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gridControlProducts;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProdId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProdCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProdName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSubCategory_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSellingPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colReOrderPoint;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiscount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBranch;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSubCategory;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private System.Windows.Forms.Button buttonProductDelete;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelTotalProduct;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridControlStockProductList;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn11;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxICEmail;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxICContactNo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxICAddress;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxICName;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxICCode;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraGrid.GridControl gridControlCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCustId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId1;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label labelTotalCustomers;
        private System.Windows.Forms.TextBox textBoxICRemarks;
    }
}

