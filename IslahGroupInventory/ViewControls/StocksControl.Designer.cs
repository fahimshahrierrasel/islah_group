namespace IslahGroupInventory.ViewControls
{
    partial class StocksControl
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbusNewStock = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ButtonUpdateLoadStock = new System.Windows.Forms.Button();
            this.ButtonUpdateStock = new System.Windows.Forms.Button();
            this.tbusCurrentStock = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbusProductCode = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelTotalProduct = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbsAddStock = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ButtonLoadStock = new System.Windows.Forms.Button();
            this.ButtonAddStock = new System.Windows.Forms.Button();
            this.tbsCurrentStock = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbsProductCode = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.gridControlStockProductList = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStockProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStockProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStockProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbusNewStock);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.ButtonUpdateLoadStock);
            this.groupBox7.Controls.Add(this.ButtonUpdateStock);
            this.groupBox7.Controls.Add(this.tbusCurrentStock);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.tbusProductCode);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(8, 384);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(344, 230);
            this.groupBox7.TabIndex = 43;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Update Stock";
            // 
            // tbusNewStock
            // 
            this.tbusNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusNewStock.Location = new System.Drawing.Point(118, 153);
            this.tbusNewStock.Name = "tbusNewStock";
            this.tbusNewStock.Size = new System.Drawing.Size(214, 26);
            this.tbusNewStock.TabIndex = 38;
            this.tbusNewStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbusNewStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(29, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "New Stock";
            // 
            // ButtonUpdateLoadStock
            // 
            this.ButtonUpdateLoadStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateLoadStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonUpdateLoadStock.Location = new System.Drawing.Point(242, 73);
            this.ButtonUpdateLoadStock.Name = "ButtonUpdateLoadStock";
            this.ButtonUpdateLoadStock.Size = new System.Drawing.Size(90, 36);
            this.ButtonUpdateLoadStock.TabIndex = 36;
            this.ButtonUpdateLoadStock.Text = "Load";
            this.ButtonUpdateLoadStock.UseVisualStyleBackColor = true;
            this.ButtonUpdateLoadStock.Click += new System.EventHandler(this.ButtonUpdateLoadStock_Click);
            // 
            // ButtonUpdateStock
            // 
            this.ButtonUpdateStock.Enabled = false;
            this.ButtonUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonUpdateStock.Location = new System.Drawing.Point(243, 183);
            this.ButtonUpdateStock.Name = "ButtonUpdateStock";
            this.ButtonUpdateStock.Size = new System.Drawing.Size(90, 36);
            this.ButtonUpdateStock.TabIndex = 35;
            this.ButtonUpdateStock.Text = "Update";
            this.ButtonUpdateStock.UseVisualStyleBackColor = true;
            this.ButtonUpdateStock.Click += new System.EventHandler(this.ButtonUpdateStock_Click);
            // 
            // tbusCurrentStock
            // 
            this.tbusCurrentStock.Enabled = false;
            this.tbusCurrentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusCurrentStock.Location = new System.Drawing.Point(118, 119);
            this.tbusCurrentStock.Name = "tbusCurrentStock";
            this.tbusCurrentStock.Size = new System.Drawing.Size(214, 26);
            this.tbusCurrentStock.TabIndex = 34;
            this.tbusCurrentStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 20);
            this.label20.TabIndex = 33;
            this.label20.Text = "Current Stock";
            // 
            // tbusProductCode
            // 
            this.tbusProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusProductCode.Location = new System.Drawing.Point(118, 41);
            this.tbusProductCode.Name = "tbusProductCode";
            this.tbusProductCode.Size = new System.Drawing.Size(214, 26);
            this.tbusProductCode.TabIndex = 20;
            // 
            // label21
            // 
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
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(8, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 144);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total Product";
            // 
            // labelTotalProduct
            // 
            this.labelTotalProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProduct.Location = new System.Drawing.Point(3, 25);
            this.labelTotalProduct.Name = "labelTotalProduct";
            this.labelTotalProduct.Size = new System.Drawing.Size(338, 116);
            this.labelTotalProduct.TabIndex = 0;
            this.labelTotalProduct.Text = "00";
            this.labelTotalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbsAddStock);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.ButtonLoadStock);
            this.groupBox5.Controls.Add(this.ButtonAddStock);
            this.groupBox5.Controls.Add(this.tbsCurrentStock);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.tbsProductCode);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 225);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Stock";
            // 
            // tbsAddStock
            // 
            this.tbsAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsAddStock.Location = new System.Drawing.Point(118, 153);
            this.tbsAddStock.Name = "tbsAddStock";
            this.tbsAddStock.Size = new System.Drawing.Size(214, 26);
            this.tbsAddStock.TabIndex = 38;
            this.tbsAddStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbsAddStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(29, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "Add Stock";
            // 
            // ButtonLoadStock
            // 
            this.ButtonLoadStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoadStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonLoadStock.Location = new System.Drawing.Point(242, 73);
            this.ButtonLoadStock.Name = "ButtonLoadStock";
            this.ButtonLoadStock.Size = new System.Drawing.Size(90, 36);
            this.ButtonLoadStock.TabIndex = 36;
            this.ButtonLoadStock.Text = "Load";
            this.ButtonLoadStock.UseVisualStyleBackColor = true;
            this.ButtonLoadStock.Click += new System.EventHandler(this.ButtonLoadStock_Click);
            // 
            // ButtonAddStock
            // 
            this.ButtonAddStock.Enabled = false;
            this.ButtonAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonAddStock.Location = new System.Drawing.Point(243, 183);
            this.ButtonAddStock.Name = "ButtonAddStock";
            this.ButtonAddStock.Size = new System.Drawing.Size(90, 36);
            this.ButtonAddStock.TabIndex = 35;
            this.ButtonAddStock.Text = "Add";
            this.ButtonAddStock.UseVisualStyleBackColor = true;
            this.ButtonAddStock.Click += new System.EventHandler(this.ButtonAddStock_Click);
            // 
            // tbsCurrentStock
            // 
            this.tbsCurrentStock.Enabled = false;
            this.tbsCurrentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsCurrentStock.Location = new System.Drawing.Point(118, 119);
            this.tbsCurrentStock.Name = "tbsCurrentStock";
            this.tbsCurrentStock.Size = new System.Drawing.Size(214, 26);
            this.tbsCurrentStock.TabIndex = 34;
            this.tbsCurrentStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Current Stock";
            // 
            // tbsProductCode
            // 
            this.tbsProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsProductCode.Location = new System.Drawing.Point(118, 41);
            this.tbsProductCode.Name = "tbsProductCode";
            this.tbsProductCode.Size = new System.Drawing.Size(214, 26);
            this.tbsProductCode.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 20);
            this.label25.TabIndex = 19;
            this.label25.Text = "Product Code";
            // 
            // gridControlStockProductList
            // 
            this.gridControlStockProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlStockProductList.DataSource = this.productsBindingSource;
            this.gridControlStockProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlStockProductList.Location = new System.Drawing.Point(358, 8);
            this.gridControlStockProductList.MainView = this.gridViewStockProducts;
            this.gridControlStockProductList.Name = "gridControlStockProductList";
            this.gridControlStockProductList.Size = new System.Drawing.Size(910, 606);
            this.gridControlStockProductList.TabIndex = 44;
            this.gridControlStockProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStockProducts});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(IslahGroupInventory.Product);
            // 
            // gridViewStockProducts
            // 
            this.gridViewStockProducts.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.gridViewStockProducts.Appearance.Row.Options.UseFont = true;
            this.gridViewStockProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridViewStockProducts.GridControl = this.gridControlStockProductList;
            this.gridViewStockProducts.Name = "gridViewStockProducts";
            this.gridViewStockProducts.OptionsBehavior.Editable = false;
            this.gridViewStockProducts.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewStockProducts.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewStockProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewStockProducts.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GridViewStockProducts_RowStyle);
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
            this.bandedGridColumn2.VisibleIndex = 0;
            this.bandedGridColumn2.Width = 128;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "Name";
            this.bandedGridColumn3.FieldName = "ProdName";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            this.bandedGridColumn3.VisibleIndex = 1;
            this.bandedGridColumn3.Width = 171;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "Category";
            this.bandedGridColumn4.FieldName = "SubCategory_Name";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.VisibleIndex = 2;
            this.bandedGridColumn4.Width = 84;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "Description";
            this.bandedGridColumn5.FieldName = "Description";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            this.bandedGridColumn5.VisibleIndex = 3;
            this.bandedGridColumn5.Width = 238;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "Selling Price";
            this.bandedGridColumn6.FieldName = "SellingPrice";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.Visible = true;
            this.bandedGridColumn6.VisibleIndex = 4;
            this.bandedGridColumn6.Width = 61;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.Caption = "Re-Order Point";
            this.bandedGridColumn7.FieldName = "ReOrderPoint";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.Visible = true;
            this.bandedGridColumn7.VisibleIndex = 5;
            this.bandedGridColumn7.Width = 82;
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.Caption = "Discount";
            this.bandedGridColumn8.FieldName = "Discount";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.Visible = true;
            this.bandedGridColumn8.VisibleIndex = 6;
            this.bandedGridColumn8.Width = 76;
            // 
            // bandedGridColumn9
            // 
            this.bandedGridColumn9.Caption = "Stock";
            this.bandedGridColumn9.FieldName = "Stock";
            this.bandedGridColumn9.Name = "bandedGridColumn9";
            this.bandedGridColumn9.Visible = true;
            this.bandedGridColumn9.VisibleIndex = 7;
            this.bandedGridColumn9.Width = 88;
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
            // StocksControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gridControlStockProductList);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "StocksControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.StocksControl_Load);
            this.VisibleChanged += new System.EventHandler(this.StocksControl_VisibleChanged);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStockProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStockProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbusNewStock;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button ButtonUpdateLoadStock;
        private System.Windows.Forms.Button ButtonUpdateStock;
        private System.Windows.Forms.TextBox tbusCurrentStock;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbusProductCode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelTotalProduct;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbsAddStock;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button ButtonLoadStock;
        private System.Windows.Forms.Button ButtonAddStock;
        private System.Windows.Forms.TextBox tbsCurrentStock;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbsProductCode;
        private System.Windows.Forms.Label label25;
        private DevExpress.XtraGrid.GridControl gridControlStockProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStockProducts;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn12;
        private System.Windows.Forms.BindingSource productsBindingSource;
    }
}
