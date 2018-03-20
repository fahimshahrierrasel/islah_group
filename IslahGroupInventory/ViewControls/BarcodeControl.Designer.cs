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
            this.gridControlBarcodeProductControl = new DevExpress.XtraGrid.GridControl();
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
            this.textBoxBCSuffix = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBoxBPCCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarcodeProductControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductBarcode)).BeginInit();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlBarcodeProductControl
            // 
            this.gridControlBarcodeProductControl.Location = new System.Drawing.Point(464, 3);
            this.gridControlBarcodeProductControl.MainView = this.gridViewProductBarcode;
            this.gridControlBarcodeProductControl.Name = "gridControlBarcodeProductControl";
            this.gridControlBarcodeProductControl.Size = new System.Drawing.Size(809, 616);
            this.gridControlBarcodeProductControl.TabIndex = 12;
            this.gridControlBarcodeProductControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductBarcode});
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
            this.colProdCode1.Width = 214;
            // 
            // colProdName1
            // 
            this.colProdName1.Caption = "Product Name";
            this.colProdName1.FieldName = "Product Name";
            this.colProdName1.Name = "colProdName1";
            this.colProdName1.Visible = true;
            this.colProdName1.VisibleIndex = 1;
            this.colProdName1.Width = 365;
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
            this.colSubCategory_Name1.Width = 148;
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
            this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox16.Location = new System.Drawing.Point(3, 3);
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
            this.buttonPrintBarcode.Click += new System.EventHandler(this.buttonPrintBarcode_Click);
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
            this.comboBoxProductBarcodeCategory.DisplayMember = "Category_Code";
            this.comboBoxProductBarcodeCategory.FormattingEnabled = true;
            this.comboBoxProductBarcodeCategory.Location = new System.Drawing.Point(218, 38);
            this.comboBoxProductBarcodeCategory.Name = "comboBoxProductBarcodeCategory";
            this.comboBoxProductBarcodeCategory.Size = new System.Drawing.Size(228, 32);
            this.comboBoxProductBarcodeCategory.TabIndex = 2;
            this.comboBoxProductBarcodeCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProductBarcodeCategory_SelectionChangeCommitted);
            // 
            // textBoxBCSuffix
            // 
            this.textBoxBCSuffix.Location = new System.Drawing.Point(217, 134);
            this.textBoxBCSuffix.MaxLength = 4;
            this.textBoxBCSuffix.Name = "textBoxBCSuffix";
            this.textBoxBCSuffix.Size = new System.Drawing.Size(229, 29);
            this.textBoxBCSuffix.TabIndex = 6;
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
            // BarcodeControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gridControlBarcodeProductControl);
            this.Controls.Add(this.groupBox16);
            this.Name = "BarcodeControl";
            this.Size = new System.Drawing.Size(1276, 622);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarcodeProductControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductBarcode)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}
