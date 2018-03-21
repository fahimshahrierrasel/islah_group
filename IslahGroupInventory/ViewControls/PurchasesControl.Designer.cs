namespace IslahGroupInventory.ViewControls
{
    partial class PurchasesControl
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
            this.tabControlPurchases = new System.Windows.Forms.TabControl();
            this.tabPageNewPurchase = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonPSubmit = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBoxPPName = new System.Windows.Forms.TextBox();
            this.textBoxPPQuantity = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.buttonAddPurchaseProduct = new System.Windows.Forms.Button();
            this.textBoxPPUPrice = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.gridControlPurchaseItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewPurchaseItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPurchaser = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.textBoxPDue = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBoxPSupplier = new System.Windows.Forms.ComboBox();
            this.dtpPurchaseTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxPAmount = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBoxPTotal = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.textBoxPurchaseCode = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tabPagePurchaseList = new System.Windows.Forms.TabPage();
            this.splitContainerPurchasesList = new System.Windows.Forms.SplitContainer();
            this.gridControlPurchases = new DevExpress.XtraGrid.GridControl();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPurchases = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPurcId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurcCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier_SuppId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType_PType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlPItems = new DevExpress.XtraGrid.GridControl();
            this.purchaseItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchase_PurcId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControlPurchases.SuspendLayout();
            this.tabPageNewPurchase.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPurchaseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurchaseItem)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.tabPagePurchaseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPurchasesList)).BeginInit();
            this.splitContainerPurchasesList.Panel1.SuspendLayout();
            this.splitContainerPurchasesList.Panel2.SuspendLayout();
            this.splitContainerPurchasesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPurchases
            // 
            this.tabControlPurchases.Controls.Add(this.tabPageNewPurchase);
            this.tabControlPurchases.Controls.Add(this.tabPagePurchaseList);
            this.tabControlPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPurchases.Location = new System.Drawing.Point(0, 0);
            this.tabControlPurchases.Name = "tabControlPurchases";
            this.tabControlPurchases.SelectedIndex = 0;
            this.tabControlPurchases.Size = new System.Drawing.Size(1276, 622);
            this.tabControlPurchases.TabIndex = 1;
            this.tabControlPurchases.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlPurchases_Selected);
            // 
            // tabPageNewPurchase
            // 
            this.tabPageNewPurchase.Controls.Add(this.button12);
            this.tabPageNewPurchase.Controls.Add(this.buttonPSubmit);
            this.tabPageNewPurchase.Controls.Add(this.groupBox15);
            this.tabPageNewPurchase.Controls.Add(this.gridControlPurchaseItems);
            this.tabPageNewPurchase.Controls.Add(this.groupBox14);
            this.tabPageNewPurchase.Location = new System.Drawing.Point(4, 33);
            this.tabPageNewPurchase.Name = "tabPageNewPurchase";
            this.tabPageNewPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewPurchase.Size = new System.Drawing.Size(1268, 585);
            this.tabPageNewPurchase.TabIndex = 0;
            this.tabPageNewPurchase.Text = "New Purchase";
            this.tabPageNewPurchase.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(194, 535);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 43);
            this.button12.TabIndex = 6;
            this.button12.Text = "Discard";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // buttonPSubmit
            // 
            this.buttonPSubmit.Location = new System.Drawing.Point(294, 536);
            this.buttonPSubmit.Name = "buttonPSubmit";
            this.buttonPSubmit.Size = new System.Drawing.Size(94, 43);
            this.buttonPSubmit.TabIndex = 5;
            this.buttonPSubmit.Text = "Save";
            this.buttonPSubmit.UseVisualStyleBackColor = true;
            this.buttonPSubmit.Click += new System.EventHandler(this.ButtonPSubmit_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBoxPPName);
            this.groupBox15.Controls.Add(this.textBoxPPQuantity);
            this.groupBox15.Controls.Add(this.label47);
            this.groupBox15.Controls.Add(this.buttonAddPurchaseProduct);
            this.groupBox15.Controls.Add(this.textBoxPPUPrice);
            this.groupBox15.Controls.Add(this.label45);
            this.groupBox15.Controls.Add(this.label38);
            this.groupBox15.Location = new System.Drawing.Point(6, 346);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(382, 183);
            this.groupBox15.TabIndex = 4;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Add Product";
            // 
            // textBoxPPName
            // 
            this.textBoxPPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPPName.Location = new System.Drawing.Point(115, 36);
            this.textBoxPPName.Name = "textBoxPPName";
            this.textBoxPPName.Size = new System.Drawing.Size(260, 26);
            this.textBoxPPName.TabIndex = 48;
            // 
            // textBoxPPQuantity
            // 
            this.textBoxPPQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPPQuantity.Location = new System.Drawing.Point(115, 102);
            this.textBoxPPQuantity.Name = "textBoxPPQuantity";
            this.textBoxPPQuantity.Size = new System.Drawing.Size(260, 26);
            this.textBoxPPQuantity.TabIndex = 50;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(42, 105);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(68, 20);
            this.label47.TabIndex = 46;
            this.label47.Text = "Quantity";
            // 
            // buttonAddPurchaseProduct
            // 
            this.buttonAddPurchaseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPurchaseProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddPurchaseProduct.Location = new System.Drawing.Point(257, 141);
            this.buttonAddPurchaseProduct.Name = "buttonAddPurchaseProduct";
            this.buttonAddPurchaseProduct.Size = new System.Drawing.Size(118, 36);
            this.buttonAddPurchaseProduct.TabIndex = 45;
            this.buttonAddPurchaseProduct.Text = "&Add Product";
            this.buttonAddPurchaseProduct.UseVisualStyleBackColor = true;
            this.buttonAddPurchaseProduct.Click += new System.EventHandler(this.ButtonAddPurchaseProduct_Click);
            // 
            // textBoxPPUPrice
            // 
            this.textBoxPPUPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPPUPrice.Location = new System.Drawing.Point(115, 70);
            this.textBoxPPUPrice.Name = "textBoxPPUPrice";
            this.textBoxPPUPrice.Size = new System.Drawing.Size(260, 26);
            this.textBoxPPUPrice.TabIndex = 49;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(32, 73);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(77, 20);
            this.label45.TabIndex = 43;
            this.label45.Text = "Unit Price";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(0, 39);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(110, 20);
            this.label38.TabIndex = 41;
            this.label38.Text = "Product Name";
            // 
            // gridControlPurchaseItems
            // 
            this.gridControlPurchaseItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPurchaseItems.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridControlPurchaseItems.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControlPurchaseItems.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControlPurchaseItems.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlPurchaseItems.Location = new System.Drawing.Point(394, 6);
            this.gridControlPurchaseItems.MainView = this.gridViewPurchaseItem;
            this.gridControlPurchaseItems.Name = "gridControlPurchaseItems";
            this.gridControlPurchaseItems.Size = new System.Drawing.Size(868, 573);
            this.gridControlPurchaseItems.TabIndex = 3;
            this.gridControlPurchaseItems.UseEmbeddedNavigator = true;
            this.gridControlPurchaseItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPurchaseItem});
            // 
            // gridViewPurchaseItem
            // 
            this.gridViewPurchaseItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductCode,
            this.UnitPrice,
            this.Quantity,
            this.TotalPrice});
            this.gridViewPurchaseItem.GridControl = this.gridControlPurchaseItems;
            this.gridViewPurchaseItem.Name = "gridViewPurchaseItem";
            this.gridViewPurchaseItem.OptionsEditForm.EditFormColumnCount = 1;
            this.gridViewPurchaseItem.OptionsView.ShowFooter = true;
            this.gridViewPurchaseItem.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.GridViewPurchaseItem_CustomDrawFooterCell);
            this.gridViewPurchaseItem.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GridViewPurchaseItem_ValidateRow);
            // 
            // ProductCode
            // 
            this.ProductCode.Caption = "Product Code";
            this.ProductCode.FieldName = "ProductCode";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.OptionsColumn.AllowEdit = false;
            this.ProductCode.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.ProductCode.Visible = true;
            this.ProductCode.VisibleIndex = 0;
            this.ProductCode.Width = 479;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Caption = "Unit Price";
            this.UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UnitPrice.FieldName = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.OptionsColumn.AllowEdit = false;
            this.UnitPrice.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.UnitPrice.Visible = true;
            this.UnitPrice.VisibleIndex = 1;
            this.UnitPrice.Width = 123;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 2;
            this.Quantity.Width = 105;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Caption = "Price";
            this.TotalPrice.DisplayFormat.FormatString = "c2";
            this.TotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.OptionsColumn.AllowEdit = false;
            this.TotalPrice.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.TotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "Total={0:c2}")});
            this.TotalPrice.UnboundExpression = "[Quantity] * [UnitPrice]";
            this.TotalPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 3;
            this.TotalPrice.Width = 143;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.dtpPaymentDate);
            this.groupBox14.Controls.Add(this.label1);
            this.groupBox14.Controls.Add(this.textBoxPurchaser);
            this.groupBox14.Controls.Add(this.label46);
            this.groupBox14.Controls.Add(this.textBoxPDue);
            this.groupBox14.Controls.Add(this.label22);
            this.groupBox14.Controls.Add(this.comboBoxPSupplier);
            this.groupBox14.Controls.Add(this.dtpPurchaseTime);
            this.groupBox14.Controls.Add(this.textBoxPAmount);
            this.groupBox14.Controls.Add(this.label39);
            this.groupBox14.Controls.Add(this.textBoxPTotal);
            this.groupBox14.Controls.Add(this.label40);
            this.groupBox14.Controls.Add(this.comboBoxPaymentType);
            this.groupBox14.Controls.Add(this.label41);
            this.groupBox14.Controls.Add(this.label42);
            this.groupBox14.Controls.Add(this.label43);
            this.groupBox14.Controls.Add(this.textBoxPurchaseCode);
            this.groupBox14.Controls.Add(this.label44);
            this.groupBox14.Location = new System.Drawing.Point(6, 6);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(382, 334);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = " Purchase Information";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "";
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(157, 169);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(218, 29);
            this.dtpPaymentDate.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Payment Date";
            // 
            // textBoxPurchaser
            // 
            this.textBoxPurchaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchaser.Location = new System.Drawing.Point(157, 206);
            this.textBoxPurchaser.Name = "textBoxPurchaser";
            this.textBoxPurchaser.Size = new System.Drawing.Size(218, 26);
            this.textBoxPurchaser.TabIndex = 42;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(70, 209);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(81, 20);
            this.label46.TabIndex = 41;
            this.label46.Text = "Purchaser";
            // 
            // textBoxPDue
            // 
            this.textBoxPDue.Enabled = false;
            this.textBoxPDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPDue.Location = new System.Drawing.Point(157, 302);
            this.textBoxPDue.Name = "textBoxPDue";
            this.textBoxPDue.Size = new System.Drawing.Size(218, 26);
            this.textBoxPDue.TabIndex = 40;
            this.textBoxPDue.Text = "0.00";
            this.textBoxPDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(112, 305);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 20);
            this.label22.TabIndex = 39;
            this.label22.Text = "Due";
            // 
            // comboBoxPSupplier
            // 
            this.comboBoxPSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPSupplier.FormattingEnabled = true;
            this.comboBoxPSupplier.Location = new System.Drawing.Point(157, 101);
            this.comboBoxPSupplier.Name = "comboBoxPSupplier";
            this.comboBoxPSupplier.Size = new System.Drawing.Size(218, 28);
            this.comboBoxPSupplier.TabIndex = 38;
            // 
            // dtpPurchaseTime
            // 
            this.dtpPurchaseTime.CustomFormat = "";
            this.dtpPurchaseTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseTime.Location = new System.Drawing.Point(157, 62);
            this.dtpPurchaseTime.Name = "dtpPurchaseTime";
            this.dtpPurchaseTime.Size = new System.Drawing.Size(218, 29);
            this.dtpPurchaseTime.TabIndex = 37;
            // 
            // textBoxPAmount
            // 
            this.textBoxPAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPAmount.Location = new System.Drawing.Point(157, 270);
            this.textBoxPAmount.Name = "textBoxPAmount";
            this.textBoxPAmount.Size = new System.Drawing.Size(218, 26);
            this.textBoxPAmount.TabIndex = 30;
            this.textBoxPAmount.Text = "0.00";
            this.textBoxPAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPAmount.TextChanged += new System.EventHandler(this.TextBoxPAmount_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(86, 273);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(65, 20);
            this.label39.TabIndex = 29;
            this.label39.Text = "Amount";
            // 
            // textBoxPTotal
            // 
            this.textBoxPTotal.Enabled = false;
            this.textBoxPTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPTotal.Location = new System.Drawing.Point(157, 238);
            this.textBoxPTotal.Name = "textBoxPTotal";
            this.textBoxPTotal.Size = new System.Drawing.Size(218, 26);
            this.textBoxPTotal.TabIndex = 28;
            this.textBoxPTotal.Text = "0.00";
            this.textBoxPTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(107, 241);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(44, 20);
            this.label40.TabIndex = 27;
            this.label40.Text = "Total";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.DisplayMember = "Ptype";
            this.comboBoxPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Location = new System.Drawing.Point(157, 135);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(218, 28);
            this.comboBoxPaymentType.TabIndex = 26;
            this.comboBoxPaymentType.ValueMember = "PType";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(42, 138);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(109, 20);
            this.label41.TabIndex = 25;
            this.label41.Text = "Payment Type";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(13, 104);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(138, 20);
            this.label42.TabIndex = 23;
            this.label42.Text = "Supplier/Company";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(36, 69);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(115, 20);
            this.label43.TabIndex = 21;
            this.label43.Text = "Purchase Date";
            // 
            // textBoxPurchaseCode
            // 
            this.textBoxPurchaseCode.Enabled = false;
            this.textBoxPurchaseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurchaseCode.Location = new System.Drawing.Point(157, 28);
            this.textBoxPurchaseCode.Name = "textBoxPurchaseCode";
            this.textBoxPurchaseCode.Size = new System.Drawing.Size(218, 26);
            this.textBoxPurchaseCode.TabIndex = 20;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(31, 31);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(118, 20);
            this.label44.TabIndex = 19;
            this.label44.Text = "Purchase Code";
            // 
            // tabPagePurchaseList
            // 
            this.tabPagePurchaseList.Controls.Add(this.splitContainerPurchasesList);
            this.tabPagePurchaseList.Location = new System.Drawing.Point(4, 33);
            this.tabPagePurchaseList.Name = "tabPagePurchaseList";
            this.tabPagePurchaseList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchaseList.Size = new System.Drawing.Size(1268, 585);
            this.tabPagePurchaseList.TabIndex = 1;
            this.tabPagePurchaseList.Text = "Purchase List";
            this.tabPagePurchaseList.UseVisualStyleBackColor = true;
            // 
            // splitContainerPurchasesList
            // 
            this.splitContainerPurchasesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPurchasesList.Location = new System.Drawing.Point(3, 3);
            this.splitContainerPurchasesList.Name = "splitContainerPurchasesList";
            // 
            // splitContainerPurchasesList.Panel1
            // 
            this.splitContainerPurchasesList.Panel1.Controls.Add(this.gridControlPurchases);
            // 
            // splitContainerPurchasesList.Panel2
            // 
            this.splitContainerPurchasesList.Panel2.Controls.Add(this.gridControlPItems);
            this.splitContainerPurchasesList.Size = new System.Drawing.Size(1262, 579);
            this.splitContainerPurchasesList.SplitterDistance = 823;
            this.splitContainerPurchasesList.TabIndex = 0;
            // 
            // gridControlPurchases
            // 
            this.gridControlPurchases.DataSource = this.purchasesBindingSource;
            this.gridControlPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPurchases.Location = new System.Drawing.Point(0, 0);
            this.gridControlPurchases.MainView = this.gridViewPurchases;
            this.gridControlPurchases.Name = "gridControlPurchases";
            this.gridControlPurchases.Size = new System.Drawing.Size(823, 579);
            this.gridControlPurchases.TabIndex = 0;
            this.gridControlPurchases.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPurchases});
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataSource = typeof(IslahGroupInventory.Purchase);
            // 
            // gridViewPurchases
            // 
            this.gridViewPurchases.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPurcId,
            this.colPurcCode,
            this.colPurcDate,
            this.colPaymentDate,
            this.colPurchaser,
            this.colAmount,
            this.colDue,
            this.colSupplier_SuppId,
            this.colPaymentType_PType,
            this.colBranch_BranchId,
            this.colBranch,
            this.colPaymentType,
            this.colSupplier});
            this.gridViewPurchases.GridControl = this.gridControlPurchases;
            this.gridViewPurchases.Name = "gridViewPurchases";
            this.gridViewPurchases.OptionsView.ShowFooter = true;
            // 
            // colPurcId
            // 
            this.colPurcId.FieldName = "PurcId";
            this.colPurcId.Name = "colPurcId";
            // 
            // colPurcCode
            // 
            this.colPurcCode.Caption = "Code";
            this.colPurcCode.FieldName = "PurcCode";
            this.colPurcCode.Name = "colPurcCode";
            this.colPurcCode.OptionsColumn.AllowEdit = false;
            this.colPurcCode.Visible = true;
            this.colPurcCode.VisibleIndex = 0;
            this.colPurcCode.Width = 86;
            // 
            // colPurcDate
            // 
            this.colPurcDate.Caption = "Date";
            this.colPurcDate.FieldName = "PurcDate";
            this.colPurcDate.Name = "colPurcDate";
            this.colPurcDate.Visible = true;
            this.colPurcDate.VisibleIndex = 1;
            this.colPurcDate.Width = 60;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 7;
            this.colPaymentDate.Width = 94;
            // 
            // colPurchaser
            // 
            this.colPurchaser.FieldName = "Purchaser";
            this.colPurchaser.Name = "colPurchaser";
            this.colPurchaser.Visible = true;
            this.colPurchaser.VisibleIndex = 2;
            this.colPurchaser.Width = 183;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            this.colAmount.Width = 46;
            // 
            // colDue
            // 
            this.colDue.FieldName = "Due";
            this.colDue.Name = "colDue";
            this.colDue.Visible = true;
            this.colDue.VisibleIndex = 4;
            this.colDue.Width = 43;
            // 
            // colSupplier_SuppId
            // 
            this.colSupplier_SuppId.Caption = "Supplier";
            this.colSupplier_SuppId.FieldName = "Supplier_SuppId";
            this.colSupplier_SuppId.Name = "colSupplier_SuppId";
            this.colSupplier_SuppId.Visible = true;
            this.colSupplier_SuppId.VisibleIndex = 5;
            this.colSupplier_SuppId.Width = 102;
            // 
            // colPaymentType_PType
            // 
            this.colPaymentType_PType.Caption = "Payment Type";
            this.colPaymentType_PType.FieldName = "PaymentType_PType";
            this.colPaymentType_PType.Name = "colPaymentType_PType";
            this.colPaymentType_PType.Visible = true;
            this.colPaymentType_PType.VisibleIndex = 6;
            this.colPaymentType_PType.Width = 78;
            // 
            // colBranch_BranchId
            // 
            this.colBranch_BranchId.FieldName = "Branch_BranchId";
            this.colBranch_BranchId.Name = "colBranch_BranchId";
            // 
            // colBranch
            // 
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            // 
            // colPaymentType
            // 
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            // 
            // colSupplier
            // 
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            // 
            // gridControlPItems
            // 
            this.gridControlPItems.DataSource = this.purchaseItemsBindingSource;
            this.gridControlPItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPItems.Location = new System.Drawing.Point(0, 0);
            this.gridControlPItems.MainView = this.gridViewPItems;
            this.gridControlPItems.Name = "gridControlPItems";
            this.gridControlPItems.Size = new System.Drawing.Size(435, 579);
            this.gridControlPItems.TabIndex = 0;
            this.gridControlPItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPItems});
            // 
            // purchaseItemsBindingSource
            // 
            this.purchaseItemsBindingSource.DataMember = "PurchaseItems";
            this.purchaseItemsBindingSource.DataSource = this.purchasesBindingSource;
            // 
            // gridViewPItems
            // 
            this.gridViewPItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemId,
            this.colItemName,
            this.colQuantity,
            this.colUnitPrice,
            this.colPrice,
            this.colPurchase_PurcId,
            this.colPurchase});
            this.gridViewPItems.GridControl = this.gridControlPItems;
            this.gridViewPItems.Name = "gridViewPItems";
            this.gridViewPItems.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewPItems.OptionsView.ShowFooter = true;
            // 
            // colItemId
            // 
            this.colItemId.FieldName = "ItemId";
            this.colItemId.Name = "colItemId";
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 0;
            this.colItemName.Width = 387;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 99;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 2;
            this.colUnitPrice.Width = 96;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 110;
            // 
            // colPurchase_PurcId
            // 
            this.colPurchase_PurcId.FieldName = "Purchase_PurcId";
            this.colPurchase_PurcId.Name = "colPurchase_PurcId";
            // 
            // colPurchase
            // 
            this.colPurchase.FieldName = "Purchase";
            this.colPurchase.Name = "colPurchase";
            // 
            // PurchasesControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControlPurchases);
            this.Name = "PurchasesControl";
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.PurchasesControl_Load);
            this.tabControlPurchases.ResumeLayout(false);
            this.tabPageNewPurchase.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPurchaseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurchaseItem)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tabPagePurchaseList.ResumeLayout(false);
            this.splitContainerPurchasesList.Panel1.ResumeLayout(false);
            this.splitContainerPurchasesList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPurchasesList)).EndInit();
            this.splitContainerPurchasesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPurchases;
        private System.Windows.Forms.TabPage tabPageNewPurchase;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button buttonPSubmit;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox textBoxPPName;
        private System.Windows.Forms.TextBox textBoxPPQuantity;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button buttonAddPurchaseProduct;
        private System.Windows.Forms.TextBox textBoxPPUPrice;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label38;
        private DevExpress.XtraGrid.GridControl gridControlPurchaseItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPurchaseItem;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox textBoxPurchaser;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBoxPDue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxPSupplier;
        private System.Windows.Forms.DateTimePicker dtpPurchaseTime;
        private System.Windows.Forms.TextBox textBoxPAmount;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBoxPTotal;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBoxPurchaseCode;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TabPage tabPagePurchaseList;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private System.Windows.Forms.BindingSource purchaseItemsBindingSource;
        private System.Windows.Forms.SplitContainer splitContainerPurchasesList;
        private DevExpress.XtraGrid.GridControl gridControlPurchases;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPurchases;
        private DevExpress.XtraGrid.Columns.GridColumn colPurcId;
        private DevExpress.XtraGrid.Columns.GridColumn colPurcCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPurcDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaser;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDue;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier_SuppId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType_PType;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.GridControl gridControlPItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPItems;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchase_PurcId;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchase;
    }
}
