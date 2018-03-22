namespace IslahGroupInventory.ViewControls
{
    partial class BarcodeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.subCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBoxBCNumber = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBoxBPCode = new System.Windows.Forms.TextBox();
            this.buttonPrintBarcode = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBoxProductBarcodeCategory = new System.Windows.Forms.ComboBox();
            this.textBoxBCSuffix = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBoxBPCCode = new System.Windows.Forms.TextBox();
            this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
            this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProdId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReOrderPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCategory_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // subCategoriesBindingSource
            // 
            this.subCategoriesBindingSource.DataSource = typeof(IslahGroupInventory.SubCategory);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(IslahGroupInventory.Product);
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
            this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.Location = new System.Drawing.Point(8, 8);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(455, 315);
            this.groupBox16.TabIndex = 11;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Barcode Generator";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(411, 228);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(35, 24);
            this.label53.TabIndex = 11;
            this.label53.Text = "x 3";
            // 
            // textBoxBCNumber
            // 
            this.textBoxBCNumber.Location = new System.Drawing.Point(218, 225);
            this.textBoxBCNumber.Name = "textBoxBCNumber";
            this.textBoxBCNumber.Size = new System.Drawing.Size(190, 29);
            this.textBoxBCNumber.TabIndex = 10;
            this.textBoxBCNumber.Text = "8";
            this.textBoxBCNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(37, 228);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(175, 24);
            this.label52.TabIndex = 9;
            this.label52.Text = "Number of Barcode";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(57, 41);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(155, 24);
            this.label48.TabIndex = 1;
            this.label48.Text = "Product Category";
            // 
            // textBoxBPCode
            // 
            this.textBoxBPCode.Enabled = false;
            this.textBoxBPCode.Location = new System.Drawing.Point(217, 179);
            this.textBoxBPCode.Name = "textBoxBPCode";
            this.textBoxBPCode.Size = new System.Drawing.Size(229, 29);
            this.textBoxBPCode.TabIndex = 8;
            // 
            // buttonPrintBarcode
            // 
            this.buttonPrintBarcode.Location = new System.Drawing.Point(288, 260);
            this.buttonPrintBarcode.Name = "buttonPrintBarcode";
            this.buttonPrintBarcode.Size = new System.Drawing.Size(158, 45);
            this.buttonPrintBarcode.TabIndex = 0;
            this.buttonPrintBarcode.Text = "Print Preview";
            this.buttonPrintBarcode.UseVisualStyleBackColor = true;
            this.buttonPrintBarcode.Click += new System.EventHandler(this.ButtonPrintBarcode_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(85, 182);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(126, 24);
            this.label51.TabIndex = 7;
            this.label51.Text = "Product Code";
            // 
            // comboBoxProductBarcodeCategory
            // 
            this.comboBoxProductBarcodeCategory.DataSource = this.subCategoriesBindingSource;
            this.comboBoxProductBarcodeCategory.DisplayMember = "Name";
            this.comboBoxProductBarcodeCategory.FormattingEnabled = true;
            this.comboBoxProductBarcodeCategory.Location = new System.Drawing.Point(218, 38);
            this.comboBoxProductBarcodeCategory.Name = "comboBoxProductBarcodeCategory";
            this.comboBoxProductBarcodeCategory.Size = new System.Drawing.Size(228, 32);
            this.comboBoxProductBarcodeCategory.TabIndex = 2;
            this.comboBoxProductBarcodeCategory.ValueMember = "Code";
            this.comboBoxProductBarcodeCategory.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxProductBarcodeCategory_SelectionChangeCommitted);
            // 
            // textBoxBCSuffix
            // 
            this.textBoxBCSuffix.Location = new System.Drawing.Point(217, 134);
            this.textBoxBCSuffix.MaxLength = 4;
            this.textBoxBCSuffix.Name = "textBoxBCSuffix";
            this.textBoxBCSuffix.Size = new System.Drawing.Size(229, 29);
            this.textBoxBCSuffix.TabIndex = 6;
            this.textBoxBCSuffix.TextChanged += new System.EventHandler(this.TextBoxBCSuffix_TextChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 90);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(206, 24);
            this.label49.TabIndex = 3;
            this.label49.Text = "Product Category Code";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(35, 137);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(176, 24);
            this.label50.TabIndex = 5;
            this.label50.Text = "Product Code Suffix";
            // 
            // textBoxBPCCode
            // 
            this.textBoxBPCCode.Enabled = false;
            this.textBoxBPCCode.Location = new System.Drawing.Point(217, 87);
            this.textBoxBPCCode.Name = "textBoxBPCCode";
            this.textBoxBPCCode.Size = new System.Drawing.Size(229, 29);
            this.textBoxBPCCode.TabIndex = 4;
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlProducts.DataSource = this.productsBindingSource;
            this.gridControlProducts.Location = new System.Drawing.Point(469, 8);
            this.gridControlProducts.MainView = this.gridViewProducts;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(799, 606);
            this.gridControlProducts.TabIndex = 12;
            this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProdId,
            this.colProdCode,
            this.colProdName,
            this.colDescription,
            this.colActive,
            this.colSellingPrice,
            this.colReOrderPoint,
            this.colDiscount,
            this.colStock,
            this.colSubCategory_Name,
            this.colBranch_BranchId,
            this.colBranch,
            this.colSubCategory});
            this.gridViewProducts.GridControl = this.gridControlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            // 
            // colProdId
            // 
            this.colProdId.FieldName = "ProdId";
            this.colProdId.Name = "colProdId";
            this.colProdId.OptionsColumn.AllowEdit = false;
            // 
            // colProdCode
            // 
            this.colProdCode.Caption = "Code";
            this.colProdCode.FieldName = "ProdCode";
            this.colProdCode.Name = "colProdCode";
            this.colProdCode.OptionsColumn.AllowEdit = false;
            this.colProdCode.Visible = true;
            this.colProdCode.VisibleIndex = 0;
            this.colProdCode.Width = 154;
            // 
            // colProdName
            // 
            this.colProdName.Caption = "Name";
            this.colProdName.FieldName = "ProdName";
            this.colProdName.Name = "colProdName";
            this.colProdName.OptionsColumn.AllowEdit = false;
            this.colProdName.Visible = true;
            this.colProdName.VisibleIndex = 1;
            this.colProdName.Width = 391;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.AllowEdit = false;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.FieldName = "SellingPrice";
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.OptionsColumn.AllowEdit = false;
            // 
            // colReOrderPoint
            // 
            this.colReOrderPoint.FieldName = "ReOrderPoint";
            this.colReOrderPoint.Name = "colReOrderPoint";
            this.colReOrderPoint.OptionsColumn.AllowEdit = false;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowEdit = false;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.OptionsColumn.AllowEdit = false;
            // 
            // colSubCategory_Name
            // 
            this.colSubCategory_Name.Caption = "Category";
            this.colSubCategory_Name.FieldName = "SubCategory_Name";
            this.colSubCategory_Name.Name = "colSubCategory_Name";
            this.colSubCategory_Name.OptionsColumn.AllowEdit = false;
            this.colSubCategory_Name.Visible = true;
            this.colSubCategory_Name.VisibleIndex = 2;
            // 
            // colBranch_BranchId
            // 
            this.colBranch_BranchId.FieldName = "Branch_BranchId";
            this.colBranch_BranchId.Name = "colBranch_BranchId";
            this.colBranch_BranchId.OptionsColumn.AllowEdit = false;
            // 
            // colBranch
            // 
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            this.colBranch.OptionsColumn.AllowEdit = false;
            // 
            // colSubCategory
            // 
            this.colSubCategory.Caption = "Category";
            this.colSubCategory.FieldName = "SubCategory";
            this.colSubCategory.Name = "colSubCategory";
            this.colSubCategory.OptionsColumn.AllowEdit = false;
            this.colSubCategory.Width = 147;
            // 
            // BarcodeControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gridControlProducts);
            this.Controls.Add(this.groupBox16);
            this.Name = "BarcodeControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.BarcodeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBoxBCNumber;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBoxBPCode;
        private System.Windows.Forms.Button buttonPrintBarcode;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox comboBoxProductBarcodeCategory;
        private System.Windows.Forms.TextBox textBoxBCSuffix;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBoxBPCCode;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource subCategoriesBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colProdId;
        private DevExpress.XtraGrid.Columns.GridColumn colProdCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProdName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colReOrderPoint;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCategory_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCategory;
    }
}
