namespace POS.ViewControls
{
    partial class ProductViewControl
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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductsGridControl = new DevExpress.XtraGrid.GridControl();
            this.ProductsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProdId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReOrderPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory_CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ProdCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProdNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.SellingPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ReOrderPointTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DiscountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StockTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Category_CategoryNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForProdCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForProdName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSellingPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStock = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiscount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReOrderPoint = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategory_CategoryName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ButtonAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDiscard = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReOrderPointTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_CategoryNameLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProdCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProdName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReOrderPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory_CategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForActive)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(POS.Product);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(POS.Category);
            // 
            // ProductsGridControl
            // 
            this.ProductsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsGridControl.DataSource = this.productsBindingSource;
            this.ProductsGridControl.Location = new System.Drawing.Point(420, 9);
            this.ProductsGridControl.MainView = this.ProductsGridView;
            this.ProductsGridControl.Name = "ProductsGridControl";
            this.ProductsGridControl.Size = new System.Drawing.Size(740, 654);
            this.ProductsGridControl.TabIndex = 1;
            this.ProductsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProductsGridView});
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProdId,
            this.colProdCode,
            this.colProdName,
            this.colDescription,
            this.colActive,
            this.colSellingPrice,
            this.colReOrderPoint,
            this.colDiscount,
            this.colStock,
            this.colBranch_BranchId,
            this.colCategory_CategoryName,
            this.colBranch,
            this.colCategory});
            this.ProductsGridView.GridControl = this.ProductsGridControl;
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.ProductsGridView.OptionsEditForm.EditFormColumnCount = 2;
            this.ProductsGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colProdId
            // 
            this.colProdId.FieldName = "ProdId";
            this.colProdId.Name = "colProdId";
            // 
            // colProdCode
            // 
            this.colProdCode.FieldName = "ProdCode";
            this.colProdCode.Name = "colProdCode";
            this.colProdCode.OptionsColumn.AllowEdit = false;
            this.colProdCode.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colProdCode.Visible = true;
            this.colProdCode.VisibleIndex = 0;
            this.colProdCode.Width = 65;
            // 
            // colProdName
            // 
            this.colProdName.FieldName = "ProdName";
            this.colProdName.Name = "colProdName";
            this.colProdName.Visible = true;
            this.colProdName.VisibleIndex = 1;
            this.colProdName.Width = 65;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 152;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            this.colActive.Width = 70;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.FieldName = "SellingPrice";
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.Visible = true;
            this.colSellingPrice.VisibleIndex = 5;
            this.colSellingPrice.Width = 85;
            // 
            // colReOrderPoint
            // 
            this.colReOrderPoint.Caption = "Re-Order Point";
            this.colReOrderPoint.FieldName = "ReOrderPoint";
            this.colReOrderPoint.Name = "colReOrderPoint";
            this.colReOrderPoint.Visible = true;
            this.colReOrderPoint.VisibleIndex = 6;
            this.colReOrderPoint.Width = 68;
            // 
            // colDiscount
            // 
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 7;
            this.colDiscount.Width = 60;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 8;
            this.colStock.Width = 62;
            // 
            // colBranch_BranchId
            // 
            this.colBranch_BranchId.FieldName = "Branch_BranchId";
            this.colBranch_BranchId.Name = "colBranch_BranchId";
            // 
            // colCategory_CategoryName
            // 
            this.colCategory_CategoryName.Caption = "Category";
            this.colCategory_CategoryName.FieldName = "Category_CategoryName";
            this.colCategory_CategoryName.Name = "colCategory_CategoryName";
            this.colCategory_CategoryName.Visible = true;
            this.colCategory_CategoryName.VisibleIndex = 2;
            this.colCategory_CategoryName.Width = 65;
            // 
            // colBranch
            // 
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dataLayoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(8, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(406, 416);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Add Product";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.dataLayoutControl1.Appearance.Control.Options.UseFont = true;
            this.dataLayoutControl1.Controls.Add(this.ProdCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ProdNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.SellingPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ReOrderPointTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DiscountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StockTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Category_CategoryNameLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 26);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(402, 388);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ProdCodeTextEdit
            // 
            this.ProdCodeTextEdit.Location = new System.Drawing.Point(12, 34);
            this.ProdCodeTextEdit.Name = "ProdCodeTextEdit";
            this.ProdCodeTextEdit.Size = new System.Drawing.Size(378, 26);
            this.ProdCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.ProdCodeTextEdit.TabIndex = 4;
            // 
            // ProdNameTextEdit
            // 
            this.ProdNameTextEdit.Location = new System.Drawing.Point(12, 86);
            this.ProdNameTextEdit.Name = "ProdNameTextEdit";
            this.ProdNameTextEdit.Size = new System.Drawing.Size(378, 26);
            this.ProdNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ProdNameTextEdit.TabIndex = 5;
            // 
            // ActiveCheckEdit
            // 
            this.ActiveCheckEdit.Location = new System.Drawing.Point(203, 224);
            this.ActiveCheckEdit.Name = "ActiveCheckEdit";
            this.ActiveCheckEdit.Properties.Caption = "Active";
            this.ActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.ActiveCheckEdit.Size = new System.Drawing.Size(187, 23);
            this.ActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.ActiveCheckEdit.TabIndex = 7;
            // 
            // SellingPriceTextEdit
            // 
            this.SellingPriceTextEdit.Location = new System.Drawing.Point(12, 298);
            this.SellingPriceTextEdit.Name = "SellingPriceTextEdit";
            this.SellingPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SellingPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SellingPriceTextEdit.Properties.Mask.EditMask = "G";
            this.SellingPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SellingPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SellingPriceTextEdit.Size = new System.Drawing.Size(187, 26);
            this.SellingPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.SellingPriceTextEdit.TabIndex = 8;
            // 
            // ReOrderPointTextEdit
            // 
            this.ReOrderPointTextEdit.Location = new System.Drawing.Point(203, 350);
            this.ReOrderPointTextEdit.Name = "ReOrderPointTextEdit";
            this.ReOrderPointTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ReOrderPointTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ReOrderPointTextEdit.Properties.Mask.EditMask = "N0";
            this.ReOrderPointTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ReOrderPointTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ReOrderPointTextEdit.Size = new System.Drawing.Size(187, 26);
            this.ReOrderPointTextEdit.StyleController = this.dataLayoutControl1;
            this.ReOrderPointTextEdit.TabIndex = 9;
            // 
            // DiscountTextEdit
            // 
            this.DiscountTextEdit.Location = new System.Drawing.Point(203, 298);
            this.DiscountTextEdit.Name = "DiscountTextEdit";
            this.DiscountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DiscountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DiscountTextEdit.Properties.Mask.EditMask = "G";
            this.DiscountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.DiscountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DiscountTextEdit.Size = new System.Drawing.Size(187, 26);
            this.DiscountTextEdit.StyleController = this.dataLayoutControl1;
            this.DiscountTextEdit.TabIndex = 10;
            // 
            // StockTextEdit
            // 
            this.StockTextEdit.Location = new System.Drawing.Point(12, 350);
            this.StockTextEdit.Name = "StockTextEdit";
            this.StockTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StockTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.StockTextEdit.Properties.Mask.EditMask = "N0";
            this.StockTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.StockTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.StockTextEdit.Size = new System.Drawing.Size(187, 26);
            this.StockTextEdit.StyleController = this.dataLayoutControl1;
            this.StockTextEdit.TabIndex = 11;
            // 
            // Category_CategoryNameLookUpEdit
            // 
            this.Category_CategoryNameLookUpEdit.Location = new System.Drawing.Point(12, 246);
            this.Category_CategoryNameLookUpEdit.Name = "Category_CategoryNameLookUpEdit";
            this.Category_CategoryNameLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Category_CategoryNameLookUpEdit.Properties.DataSource = this.categoriesBindingSource;
            this.Category_CategoryNameLookUpEdit.Properties.DisplayMember = "CategoryName";
            this.Category_CategoryNameLookUpEdit.Properties.NullText = "";
            this.Category_CategoryNameLookUpEdit.Properties.ValueMember = "CategoryName";
            this.Category_CategoryNameLookUpEdit.Size = new System.Drawing.Size(187, 26);
            this.Category_CategoryNameLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Category_CategoryNameLookUpEdit.TabIndex = 12;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.Location = new System.Drawing.Point(12, 138);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(378, 82);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(402, 388);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProdCode,
            this.ItemForProdName,
            this.ItemForSellingPrice,
            this.ItemForStock,
            this.ItemForDiscount,
            this.ItemForReOrderPoint,
            this.ItemForDescription,
            this.ItemForCategory_CategoryName,
            this.ItemForActive});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(382, 368);
            // 
            // ItemForProdCode
            // 
            this.ItemForProdCode.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForProdCode.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForProdCode.Control = this.ProdCodeTextEdit;
            this.ItemForProdCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForProdCode.Name = "ItemForProdCode";
            this.ItemForProdCode.Size = new System.Drawing.Size(382, 52);
            this.ItemForProdCode.Text = "Product Code (Barcode)";
            this.ItemForProdCode.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForProdCode.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForProdName
            // 
            this.ItemForProdName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForProdName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForProdName.Control = this.ProdNameTextEdit;
            this.ItemForProdName.Location = new System.Drawing.Point(0, 52);
            this.ItemForProdName.Name = "ItemForProdName";
            this.ItemForProdName.Size = new System.Drawing.Size(382, 52);
            this.ItemForProdName.Text = "Product Name";
            this.ItemForProdName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForProdName.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForSellingPrice
            // 
            this.ItemForSellingPrice.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForSellingPrice.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForSellingPrice.Control = this.SellingPriceTextEdit;
            this.ItemForSellingPrice.Location = new System.Drawing.Point(0, 264);
            this.ItemForSellingPrice.Name = "ItemForSellingPrice";
            this.ItemForSellingPrice.Size = new System.Drawing.Size(191, 52);
            this.ItemForSellingPrice.Text = "Selling Price";
            this.ItemForSellingPrice.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForSellingPrice.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForStock
            // 
            this.ItemForStock.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForStock.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForStock.Control = this.StockTextEdit;
            this.ItemForStock.Location = new System.Drawing.Point(0, 316);
            this.ItemForStock.Name = "ItemForStock";
            this.ItemForStock.Size = new System.Drawing.Size(191, 52);
            this.ItemForStock.Text = "Stock";
            this.ItemForStock.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForStock.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForDiscount
            // 
            this.ItemForDiscount.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForDiscount.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForDiscount.Control = this.DiscountTextEdit;
            this.ItemForDiscount.Location = new System.Drawing.Point(191, 264);
            this.ItemForDiscount.Name = "ItemForDiscount";
            this.ItemForDiscount.Size = new System.Drawing.Size(191, 52);
            this.ItemForDiscount.Text = "Discount";
            this.ItemForDiscount.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForDiscount.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForReOrderPoint
            // 
            this.ItemForReOrderPoint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForReOrderPoint.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForReOrderPoint.Control = this.ReOrderPointTextEdit;
            this.ItemForReOrderPoint.Location = new System.Drawing.Point(191, 316);
            this.ItemForReOrderPoint.Name = "ItemForReOrderPoint";
            this.ItemForReOrderPoint.Size = new System.Drawing.Size(191, 52);
            this.ItemForReOrderPoint.Text = "Re-Order Point";
            this.ItemForReOrderPoint.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForReOrderPoint.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForDescription.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 104);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(382, 108);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForDescription.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForCategory_CategoryName
            // 
            this.ItemForCategory_CategoryName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForCategory_CategoryName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCategory_CategoryName.Control = this.Category_CategoryNameLookUpEdit;
            this.ItemForCategory_CategoryName.Location = new System.Drawing.Point(0, 212);
            this.ItemForCategory_CategoryName.Name = "ItemForCategory_CategoryName";
            this.ItemForCategory_CategoryName.Size = new System.Drawing.Size(191, 52);
            this.ItemForCategory_CategoryName.Text = "Category Name";
            this.ItemForCategory_CategoryName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForCategory_CategoryName.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForActive
            // 
            this.ItemForActive.Control = this.ActiveCheckEdit;
            this.ItemForActive.Location = new System.Drawing.Point(191, 212);
            this.ItemForActive.Name = "ItemForActive";
            this.ItemForActive.Size = new System.Drawing.Size(191, 52);
            this.ItemForActive.Text = "Active";
            this.ItemForActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForActive.TextVisible = false;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ButtonAddProduct.Appearance.Options.UseFont = true;
            this.ButtonAddProduct.Location = new System.Drawing.Point(282, 431);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(130, 40);
            this.ButtonAddProduct.TabIndex = 3;
            this.ButtonAddProduct.Text = "Add Product";
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // ButtonDiscard
            // 
            this.ButtonDiscard.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ButtonDiscard.Appearance.Options.UseFont = true;
            this.ButtonDiscard.Location = new System.Drawing.Point(146, 431);
            this.ButtonDiscard.Name = "ButtonDiscard";
            this.ButtonDiscard.Size = new System.Drawing.Size(130, 40);
            this.ButtonDiscard.TabIndex = 4;
            this.ButtonDiscard.Text = "Discard";
            this.ButtonDiscard.Click += new System.EventHandler(this.ButtonDiscard_Click);
            // 
            // ProductViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonDiscard);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ProductsGridControl);
            this.Name = "ProductViewControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1168, 671);
            this.Load += new System.EventHandler(this.ProductViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReOrderPointTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_CategoryNameLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProdCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProdName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReOrderPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory_CategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraGrid.GridControl ProductsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ProductsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colProdId;
        private DevExpress.XtraGrid.Columns.GridColumn colProdCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProdName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colReOrderPoint;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory_CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit ProdCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit ProdNameTextEdit;
        private DevExpress.XtraEditors.MemoEdit DescriptionMemoEdit;
        private DevExpress.XtraEditors.CheckEdit ActiveCheckEdit;
        private DevExpress.XtraEditors.TextEdit SellingPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit ReOrderPointTextEdit;
        private DevExpress.XtraEditors.TextEdit DiscountTextEdit;
        private DevExpress.XtraEditors.TextEdit StockTextEdit;
        private DevExpress.XtraEditors.LookUpEdit Category_CategoryNameLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProdCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProdName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSellingPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReOrderPoint;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategory_CategoryName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForActive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiscount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStock;
        private DevExpress.XtraEditors.MemoEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonAddProduct;
        private DevExpress.XtraEditors.SimpleButton ButtonDiscard;
    }
}
