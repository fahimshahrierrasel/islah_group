namespace IslahGroupInventory.ViewControls
{
    partial class VouchersControl
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
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonSaveVoucher = new System.Windows.Forms.Button();
            this.gridControlVoucherItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewVoucherItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.textBoxItemAmount = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxItemDetails = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReferenceNo = new System.Windows.Forms.TextBox();
            this.textBoxSubmittedBy = new System.Windows.Forms.TextBox();
            this.dtpVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.textBoxVoucherCode = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControlVouchers = new DevExpress.XtraGrid.GridControl();
            this.gridViewVouchers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlVItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewVItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vouchersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colVoucId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoucCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoucDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.voucherItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colVIIid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetails1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoucher_VoucId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVoucherItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVoucherItem)).BeginInit();
            this.groupBox24.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vouchersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage7);
            this.tabControl5.Controls.Add(this.tabPage);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(1276, 622);
            this.tabControl5.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonDiscard);
            this.tabPage7.Controls.Add(this.buttonSaveVoucher);
            this.tabPage7.Controls.Add(this.gridControlVoucherItem);
            this.tabPage7.Controls.Add(this.groupBox24);
            this.tabPage7.Controls.Add(this.groupBox25);
            this.tabPage7.Location = new System.Drawing.Point(4, 33);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1268, 585);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "New Voucher";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(187, 535);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(94, 43);
            this.buttonDiscard.TabIndex = 9;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            // 
            // buttonSaveVoucher
            // 
            this.buttonSaveVoucher.Location = new System.Drawing.Point(287, 535);
            this.buttonSaveVoucher.Name = "buttonSaveVoucher";
            this.buttonSaveVoucher.Size = new System.Drawing.Size(94, 43);
            this.buttonSaveVoucher.TabIndex = 8;
            this.buttonSaveVoucher.Text = "Save";
            this.buttonSaveVoucher.UseVisualStyleBackColor = true;
            this.buttonSaveVoucher.Click += new System.EventHandler(this.ButtonSaveVoucher_Click);
            // 
            // gridControlVoucherItem
            // 
            this.gridControlVoucherItem.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlVoucherItem.Location = new System.Drawing.Point(394, 6);
            this.gridControlVoucherItem.MainView = this.gridViewVoucherItem;
            this.gridControlVoucherItem.Name = "gridControlVoucherItem";
            this.gridControlVoucherItem.Size = new System.Drawing.Size(868, 573);
            this.gridControlVoucherItem.TabIndex = 7;
            this.gridControlVoucherItem.UseEmbeddedNavigator = true;
            this.gridControlVoucherItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVoucherItem});
            // 
            // gridViewVoucherItem
            // 
            this.gridViewVoucherItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VItemName,
            this.VDetails,
            this.VAmount});
            this.gridViewVoucherItem.GridControl = this.gridControlVoucherItem;
            this.gridViewVoucherItem.Name = "gridViewVoucherItem";
            this.gridViewVoucherItem.OptionsView.ShowFooter = true;
            this.gridViewVoucherItem.OptionsView.ShowGroupPanel = false;
            this.gridViewVoucherItem.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.GridViewVoucherItem_CustomDrawFooterCell);
            // 
            // VItemName
            // 
            this.VItemName.Caption = "Item Name";
            this.VItemName.FieldName = "VItemName";
            this.VItemName.Name = "VItemName";
            this.VItemName.Visible = true;
            this.VItemName.VisibleIndex = 0;
            this.VItemName.Width = 244;
            // 
            // VDetails
            // 
            this.VDetails.Caption = "Details";
            this.VDetails.FieldName = "VDetails";
            this.VDetails.Name = "VDetails";
            this.VDetails.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.VDetails.Visible = true;
            this.VDetails.VisibleIndex = 1;
            this.VDetails.Width = 536;
            // 
            // VAmount
            // 
            this.VAmount.Caption = "Amount";
            this.VAmount.FieldName = "VAmount";
            this.VAmount.Name = "VAmount";
            this.VAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VAmount", "Total = {0:c2}")});
            this.VAmount.Visible = true;
            this.VAmount.VisibleIndex = 2;
            this.VAmount.Width = 148;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.textBoxItemAmount);
            this.groupBox24.Controls.Add(this.label79);
            this.groupBox24.Controls.Add(this.textBoxItemName);
            this.groupBox24.Controls.Add(this.textBoxItemDetails);
            this.groupBox24.Controls.Add(this.label65);
            this.groupBox24.Controls.Add(this.buttonAddItem);
            this.groupBox24.Controls.Add(this.label71);
            this.groupBox24.Location = new System.Drawing.Point(6, 299);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(382, 219);
            this.groupBox24.TabIndex = 6;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Add Item";
            // 
            // textBoxItemAmount
            // 
            this.textBoxItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemAmount.Location = new System.Drawing.Point(115, 144);
            this.textBoxItemAmount.Name = "textBoxItemAmount";
            this.textBoxItemAmount.Size = new System.Drawing.Size(260, 26);
            this.textBoxItemAmount.TabIndex = 50;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(44, 147);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(65, 20);
            this.label79.TabIndex = 49;
            this.label79.Text = "Amount";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemName.Location = new System.Drawing.Point(115, 37);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(260, 26);
            this.textBoxItemName.TabIndex = 48;
            // 
            // textBoxItemDetails
            // 
            this.textBoxItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemDetails.Location = new System.Drawing.Point(115, 69);
            this.textBoxItemDetails.Multiline = true;
            this.textBoxItemDetails.Name = "textBoxItemDetails";
            this.textBoxItemDetails.Size = new System.Drawing.Size(260, 69);
            this.textBoxItemDetails.TabIndex = 47;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(52, 72);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(58, 20);
            this.label65.TabIndex = 46;
            this.label65.Text = "Details";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddItem.Location = new System.Drawing.Point(257, 177);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(118, 36);
            this.buttonAddItem.TabIndex = 45;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(23, 40);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(87, 20);
            this.label71.TabIndex = 41;
            this.label71.Text = "Item Name";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.textBoxTotalAmount);
            this.groupBox25.Controls.Add(this.label1);
            this.groupBox25.Controls.Add(this.textBoxReferenceNo);
            this.groupBox25.Controls.Add(this.textBoxSubmittedBy);
            this.groupBox25.Controls.Add(this.dtpVoucherDate);
            this.groupBox25.Controls.Add(this.textBoxDetails);
            this.groupBox25.Controls.Add(this.label80);
            this.groupBox25.Controls.Add(this.label82);
            this.groupBox25.Controls.Add(this.label83);
            this.groupBox25.Controls.Add(this.label84);
            this.groupBox25.Controls.Add(this.textBoxVoucherCode);
            this.groupBox25.Controls.Add(this.label85);
            this.groupBox25.Location = new System.Drawing.Point(6, 6);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(382, 287);
            this.groupBox25.TabIndex = 5;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Voucher Information";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Enabled = false;
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(115, 250);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(260, 26);
            this.textBoxTotalAmount.TabIndex = 44;
            this.textBoxTotalAmount.Text = "0.00";
            this.textBoxTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Total";
            // 
            // textBoxReferenceNo
            // 
            this.textBoxReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReferenceNo.Location = new System.Drawing.Point(115, 137);
            this.textBoxReferenceNo.Name = "textBoxReferenceNo";
            this.textBoxReferenceNo.Size = new System.Drawing.Size(260, 26);
            this.textBoxReferenceNo.TabIndex = 42;
            // 
            // textBoxSubmittedBy
            // 
            this.textBoxSubmittedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubmittedBy.Location = new System.Drawing.Point(115, 105);
            this.textBoxSubmittedBy.Name = "textBoxSubmittedBy";
            this.textBoxSubmittedBy.Size = new System.Drawing.Size(260, 26);
            this.textBoxSubmittedBy.TabIndex = 41;
            // 
            // dtpVoucherDate
            // 
            this.dtpVoucherDate.CustomFormat = "";
            this.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVoucherDate.Location = new System.Drawing.Point(116, 66);
            this.dtpVoucherDate.Name = "dtpVoucherDate";
            this.dtpVoucherDate.Size = new System.Drawing.Size(259, 29);
            this.dtpVoucherDate.TabIndex = 37;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetails.Location = new System.Drawing.Point(115, 169);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(260, 75);
            this.textBoxDetails.TabIndex = 30;
            this.textBoxDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(52, 172);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(58, 20);
            this.label80.TabIndex = 29;
            this.label80.Text = "Details";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(1, 140);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(108, 20);
            this.label82.TabIndex = 25;
            this.label82.Text = "Reference No";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(5, 108);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(104, 20);
            this.label83.TabIndex = 23;
            this.label83.Text = "Submitted By";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(66, 73);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(44, 20);
            this.label84.TabIndex = 21;
            this.label84.Text = "Date";
            // 
            // textBoxVoucherCode
            // 
            this.textBoxVoucherCode.Enabled = false;
            this.textBoxVoucherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVoucherCode.Location = new System.Drawing.Point(115, 34);
            this.textBoxVoucherCode.Name = "textBoxVoucherCode";
            this.textBoxVoucherCode.Size = new System.Drawing.Size(260, 26);
            this.textBoxVoucherCode.TabIndex = 20;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(-2, 37);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(111, 20);
            this.label85.TabIndex = 19;
            this.label85.Text = "Voucher Code";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.splitContainer1);
            this.tabPage.Location = new System.Drawing.Point(4, 33);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(1268, 585);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "Voucher List";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControlVouchers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlVItems);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 579);
            this.splitContainer1.SplitterDistance = 775;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControlVouchers
            // 
            this.gridControlVouchers.DataSource = this.vouchersBindingSource;
            this.gridControlVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVouchers.Location = new System.Drawing.Point(0, 0);
            this.gridControlVouchers.MainView = this.gridViewVouchers;
            this.gridControlVouchers.Name = "gridControlVouchers";
            this.gridControlVouchers.Size = new System.Drawing.Size(775, 579);
            this.gridControlVouchers.TabIndex = 0;
            this.gridControlVouchers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVouchers});
            // 
            // gridViewVouchers
            // 
            this.gridViewVouchers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVoucId,
            this.colVoucCode,
            this.colVoucDate,
            this.colReferenceNo,
            this.colName,
            this.colDetails,
            this.colBranch_BranchId,
            this.colBranch});
            this.gridViewVouchers.GridControl = this.gridControlVouchers;
            this.gridViewVouchers.Name = "gridViewVouchers";
            // 
            // gridControlVItems
            // 
            this.gridControlVItems.DataSource = this.voucherItemsBindingSource;
            this.gridControlVItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVItems.Location = new System.Drawing.Point(0, 0);
            this.gridControlVItems.MainView = this.gridViewVItems;
            this.gridControlVItems.Name = "gridControlVItems";
            this.gridControlVItems.Size = new System.Drawing.Size(483, 579);
            this.gridControlVItems.TabIndex = 1;
            this.gridControlVItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVItems});
            // 
            // gridViewVItems
            // 
            this.gridViewVItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVIIid,
            this.colItemName,
            this.colDetails1,
            this.colAmount,
            this.colVoucher_VoucId,
            this.colVoucher});
            this.gridViewVItems.GridControl = this.gridControlVItems;
            this.gridViewVItems.Name = "gridViewVItems";
            // 
            // vouchersBindingSource
            // 
            this.vouchersBindingSource.DataSource = typeof(IslahGroupInventory.Voucher);
            // 
            // colVoucId
            // 
            this.colVoucId.FieldName = "VoucId";
            this.colVoucId.Name = "colVoucId";
            // 
            // colVoucCode
            // 
            this.colVoucCode.FieldName = "VoucCode";
            this.colVoucCode.Name = "colVoucCode";
            this.colVoucCode.Visible = true;
            this.colVoucCode.VisibleIndex = 0;
            // 
            // colVoucDate
            // 
            this.colVoucDate.FieldName = "VoucDate";
            this.colVoucDate.Name = "colVoucDate";
            this.colVoucDate.Visible = true;
            this.colVoucDate.VisibleIndex = 1;
            // 
            // colReferenceNo
            // 
            this.colReferenceNo.FieldName = "ReferenceNo";
            this.colReferenceNo.Name = "colReferenceNo";
            this.colReferenceNo.Visible = true;
            this.colReferenceNo.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // colDetails
            // 
            this.colDetails.FieldName = "Details";
            this.colDetails.Name = "colDetails";
            this.colDetails.Visible = true;
            this.colDetails.VisibleIndex = 4;
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
            // voucherItemsBindingSource
            // 
            this.voucherItemsBindingSource.DataMember = "VoucherItems";
            this.voucherItemsBindingSource.DataSource = this.vouchersBindingSource;
            // 
            // colVIIid
            // 
            this.colVIIid.FieldName = "VIIid";
            this.colVIIid.Name = "colVIIid";
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 0;
            // 
            // colDetails1
            // 
            this.colDetails1.FieldName = "Details";
            this.colDetails1.Name = "colDetails1";
            this.colDetails1.Visible = true;
            this.colDetails1.VisibleIndex = 1;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            // 
            // colVoucher_VoucId
            // 
            this.colVoucher_VoucId.FieldName = "Voucher_VoucId";
            this.colVoucher_VoucId.Name = "colVoucher_VoucId";
            // 
            // colVoucher
            // 
            this.colVoucher.FieldName = "Voucher";
            this.colVoucher.Name = "colVoucher";
            // 
            // VouchersControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl5);
            this.Name = "VouchersControl";
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.VouchersControl_Load);
            this.tabControl5.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVoucherItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVoucherItem)).EndInit();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vouchersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonSaveVoucher;
        private DevExpress.XtraGrid.GridControl gridControlVoucherItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVoucherItem;
        private DevExpress.XtraGrid.Columns.GridColumn VItemName;
        private DevExpress.XtraGrid.Columns.GridColumn VDetails;
        private DevExpress.XtraGrid.Columns.GridColumn VAmount;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.TextBox textBoxItemAmount;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxItemDetails;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.TextBox textBoxReferenceNo;
        private System.Windows.Forms.TextBox textBoxSubmittedBy;
        private System.Windows.Forms.DateTimePicker dtpVoucherDate;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox textBoxVoucherCode;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControlVouchers;
        private System.Windows.Forms.BindingSource vouchersBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVouchers;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucId;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucCode;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.GridControl gridControlVItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVItems;
        private System.Windows.Forms.BindingSource voucherItemsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colVIIid;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colDetails1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucher_VoucId;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucher;
    }
}
