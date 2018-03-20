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
            this.suppliersControl1 = new IslahGroupInventory.ViewControls.SuppliersControl();
            this.tabPageBarcode = new System.Windows.Forms.TabPage();
            this.barcodeControl1 = new IslahGroupInventory.ViewControls.BarcodeControl();
            this.tabPageWorker = new System.Windows.Forms.TabPage();
            this.workersControl1 = new IslahGroupInventory.ViewControls.WorkersControl();
            this.tabPageWorks = new System.Windows.Forms.TabPage();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.usersControl1 = new IslahGroupInventory.ViewControls.UsersControl();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePurchaseItem = new System.Windows.Forms.BindingSource(this.components);
            this.worksControl1 = new IslahGroupInventory.ViewControls.WorksControl();
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
            this.tabPageWorker.SuspendLayout();
            this.tabPageWorks.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
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
            // suppliersControl1
            // 
            this.suppliersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersControl1.Location = new System.Drawing.Point(0, 0);
            this.suppliersControl1.Name = "suppliersControl1";
            this.suppliersControl1.Size = new System.Drawing.Size(1276, 622);
            this.suppliersControl1.TabIndex = 0;
            // 
            // tabPageBarcode
            // 
            this.tabPageBarcode.Controls.Add(this.barcodeControl1);
            this.tabPageBarcode.ImageKey = "barcode.png";
            this.tabPageBarcode.Location = new System.Drawing.Point(4, 39);
            this.tabPageBarcode.Name = "tabPageBarcode";
            this.tabPageBarcode.Size = new System.Drawing.Size(1276, 622);
            this.tabPageBarcode.TabIndex = 8;
            this.tabPageBarcode.Text = "Barcode";
            this.tabPageBarcode.UseVisualStyleBackColor = true;
            // 
            // barcodeControl1
            // 
            this.barcodeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeControl1.Location = new System.Drawing.Point(0, 0);
            this.barcodeControl1.Margin = new System.Windows.Forms.Padding(6);
            this.barcodeControl1.Name = "barcodeControl1";
            this.barcodeControl1.Size = new System.Drawing.Size(1276, 622);
            this.barcodeControl1.TabIndex = 0;
            // 
            // tabPageWorker
            // 
            this.tabPageWorker.Controls.Add(this.workersControl1);
            this.tabPageWorker.ImageKey = "builder.png";
            this.tabPageWorker.Location = new System.Drawing.Point(4, 39);
            this.tabPageWorker.Name = "tabPageWorker";
            this.tabPageWorker.Size = new System.Drawing.Size(1276, 622);
            this.tabPageWorker.TabIndex = 11;
            this.tabPageWorker.Text = "Workers";
            this.tabPageWorker.UseVisualStyleBackColor = true;
            // 
            // workersControl1
            // 
            this.workersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workersControl1.Location = new System.Drawing.Point(0, 0);
            this.workersControl1.Name = "workersControl1";
            this.workersControl1.Size = new System.Drawing.Size(1276, 622);
            this.workersControl1.TabIndex = 0;
            // 
            // tabPageWorks
            // 
            this.tabPageWorks.Controls.Add(this.worksControl1);
            this.tabPageWorks.ImageKey = "hammer.png";
            this.tabPageWorks.Location = new System.Drawing.Point(4, 39);
            this.tabPageWorks.Name = "tabPageWorks";
            this.tabPageWorks.Size = new System.Drawing.Size(1276, 622);
            this.tabPageWorks.TabIndex = 12;
            this.tabPageWorks.Text = "Works";
            this.tabPageWorks.UseVisualStyleBackColor = true;
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
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(IslahGroupInventory.Product);
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
            // worksControl1
            // 
            this.worksControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worksControl1.Location = new System.Drawing.Point(0, 0);
            this.worksControl1.Name = "worksControl1";
            this.worksControl1.Size = new System.Drawing.Size(1276, 622);
            this.worksControl1.TabIndex = 0;
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
            this.tabPageWorker.ResumeLayout(false);
            this.tabPageWorks.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageRawMaterial;
        private System.Windows.Forms.TabPage tabPageProcessing;
        private System.Windows.Forms.BindingSource rawProductsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn pTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PPId;
        private System.Windows.Forms.TabPage tabPageWorker;
        private System.Windows.Forms.TabPage tabPageWorks;
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
        private ViewControls.BarcodeControl barcodeControl1;
        private ViewControls.WorkersControl workersControl1;
        private ViewControls.WorksControl worksControl1;
    }
}

