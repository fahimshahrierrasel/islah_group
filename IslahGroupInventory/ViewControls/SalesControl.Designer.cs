namespace IslahGroupInventory.ViewControls
{
    partial class SalesControl
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
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPageNewInvoice = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.gridControlSaleProducts = new DevExpress.XtraGrid.GridControl();
            this.gridViewSaleProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PUPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.comboBoxIProducts = new System.Windows.Forms.ComboBox();
            this.textBoxIQuantity = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.buttonAddInvoiceItem = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.textBoxIDue = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxIAmount = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.textBoxITotal = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.tabPageInvoiceList = new System.Windows.Forms.TabPage();
            this.tabControl4.SuspendLayout();
            this.tabPageNewInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSaleProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleProducts)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPageNewInvoice);
            this.tabControl4.Controls.Add(this.tabPageInvoiceList);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1276, 622);
            this.tabControl4.TabIndex = 1;
            // 
            // tabPageNewInvoice
            // 
            this.tabPageNewInvoice.Controls.Add(this.button10);
            this.tabPageNewInvoice.Controls.Add(this.button9);
            this.tabPageNewInvoice.Controls.Add(this.button7);
            this.tabPageNewInvoice.Controls.Add(this.gridControlSaleProducts);
            this.tabPageNewInvoice.Controls.Add(this.groupBox22);
            this.tabPageNewInvoice.Controls.Add(this.groupBox23);
            this.tabPageNewInvoice.Location = new System.Drawing.Point(4, 33);
            this.tabPageNewInvoice.Name = "tabPageNewInvoice";
            this.tabPageNewInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewInvoice.Size = new System.Drawing.Size(1268, 585);
            this.tabPageNewInvoice.TabIndex = 0;
            this.tabPageNewInvoice.Text = "New Invoice";
            this.tabPageNewInvoice.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(118, 535);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 43);
            this.button10.TabIndex = 10;
            this.button10.Text = "Discard";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(218, 535);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(163, 43);
            this.button9.TabIndex = 9;
            this.button9.Text = "Save and Print";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(287, 486);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 43);
            this.button7.TabIndex = 8;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // gridControlSaleProducts
            // 
            this.gridControlSaleProducts.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlSaleProducts.Location = new System.Drawing.Point(394, 6);
            this.gridControlSaleProducts.MainView = this.gridViewSaleProducts;
            this.gridControlSaleProducts.Name = "gridControlSaleProducts";
            this.gridControlSaleProducts.Size = new System.Drawing.Size(868, 573);
            this.gridControlSaleProducts.TabIndex = 7;
            this.gridControlSaleProducts.UseEmbeddedNavigator = true;
            this.gridControlSaleProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaleProducts});
            // 
            // gridViewSaleProducts
            // 
            this.gridViewSaleProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PProductId,
            this.PCode,
            this.PUPrice,
            this.PQuantity,
            this.PTotalPrice});
            this.gridViewSaleProducts.GridControl = this.gridControlSaleProducts;
            this.gridViewSaleProducts.Name = "gridViewSaleProducts";
            this.gridViewSaleProducts.OptionsView.ShowFooter = true;
            this.gridViewSaleProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewSaleProducts.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridViewSaleProducts_CustomDrawFooterCell);
            this.gridViewSaleProducts.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewSaleProducts_ValidateRow);
            // 
            // PProductId
            // 
            this.PProductId.Caption = "Product Id";
            this.PProductId.FieldName = "PProductId";
            this.PProductId.Name = "PProductId";
            // 
            // PCode
            // 
            this.PCode.Caption = "Product Code";
            this.PCode.FieldName = "PCode";
            this.PCode.Name = "PCode";
            this.PCode.OptionsColumn.AllowEdit = false;
            this.PCode.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.PCode.Visible = true;
            this.PCode.VisibleIndex = 0;
            // 
            // PUPrice
            // 
            this.PUPrice.Caption = "Unit Price";
            this.PUPrice.FieldName = "PUPrice";
            this.PUPrice.Name = "PUPrice";
            this.PUPrice.OptionsColumn.AllowEdit = false;
            this.PUPrice.Visible = true;
            this.PUPrice.VisibleIndex = 1;
            // 
            // PQuantity
            // 
            this.PQuantity.Caption = "Quantity";
            this.PQuantity.FieldName = "PQuantity";
            this.PQuantity.Name = "PQuantity";
            this.PQuantity.Visible = true;
            this.PQuantity.VisibleIndex = 2;
            // 
            // PTotalPrice
            // 
            this.PTotalPrice.Caption = "Total Price";
            this.PTotalPrice.DisplayFormat.FormatString = "c2";
            this.PTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PTotalPrice.FieldName = "PTotalPrice";
            this.PTotalPrice.Name = "PTotalPrice";
            this.PTotalPrice.OptionsColumn.AllowEdit = false;
            this.PTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PTotalPrice", "Total={0:c2}")});
            this.PTotalPrice.UnboundExpression = "[PUPrice] * [PQuantity]";
            this.PTotalPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.PTotalPrice.Visible = true;
            this.PTotalPrice.VisibleIndex = 3;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.comboBoxIProducts);
            this.groupBox22.Controls.Add(this.textBoxIQuantity);
            this.groupBox22.Controls.Add(this.label63);
            this.groupBox22.Controls.Add(this.buttonAddInvoiceItem);
            this.groupBox22.Controls.Add(this.label66);
            this.groupBox22.Location = new System.Drawing.Point(6, 288);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(382, 146);
            this.groupBox22.TabIndex = 6;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Add Product";
            // 
            // comboBoxIProducts
            // 
            this.comboBoxIProducts.DisplayMember = "ProdName";
            this.comboBoxIProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIProducts.FormattingEnabled = true;
            this.comboBoxIProducts.Location = new System.Drawing.Point(115, 36);
            this.comboBoxIProducts.Name = "comboBoxIProducts";
            this.comboBoxIProducts.Size = new System.Drawing.Size(260, 28);
            this.comboBoxIProducts.TabIndex = 48;
            this.comboBoxIProducts.ValueMember = "ProdCode";
            // 
            // textBoxIQuantity
            // 
            this.textBoxIQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIQuantity.Location = new System.Drawing.Point(115, 70);
            this.textBoxIQuantity.Name = "textBoxIQuantity";
            this.textBoxIQuantity.Size = new System.Drawing.Size(260, 26);
            this.textBoxIQuantity.TabIndex = 47;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(42, 73);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(68, 20);
            this.label63.TabIndex = 46;
            this.label63.Text = "Quantity";
            // 
            // buttonAddInvoiceItem
            // 
            this.buttonAddInvoiceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddInvoiceItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddInvoiceItem.Location = new System.Drawing.Point(257, 104);
            this.buttonAddInvoiceItem.Name = "buttonAddInvoiceItem";
            this.buttonAddInvoiceItem.Size = new System.Drawing.Size(118, 36);
            this.buttonAddInvoiceItem.TabIndex = 45;
            this.buttonAddInvoiceItem.Text = "Add Product";
            this.buttonAddInvoiceItem.UseVisualStyleBackColor = true;
            this.buttonAddInvoiceItem.Click += new System.EventHandler(this.buttonAddInvoiceItem_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(0, 39);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(110, 20);
            this.label66.TabIndex = 41;
            this.label66.Text = "Product Name";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.textBoxIDue);
            this.groupBox23.Controls.Add(this.label72);
            this.groupBox23.Controls.Add(this.comboBox2);
            this.groupBox23.Controls.Add(this.dateTimePicker2);
            this.groupBox23.Controls.Add(this.textBoxIAmount);
            this.groupBox23.Controls.Add(this.label73);
            this.groupBox23.Controls.Add(this.textBoxITotal);
            this.groupBox23.Controls.Add(this.label74);
            this.groupBox23.Controls.Add(this.comboBox3);
            this.groupBox23.Controls.Add(this.label75);
            this.groupBox23.Controls.Add(this.label76);
            this.groupBox23.Controls.Add(this.label77);
            this.groupBox23.Controls.Add(this.textBox25);
            this.groupBox23.Controls.Add(this.label78);
            this.groupBox23.Location = new System.Drawing.Point(6, 6);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(382, 276);
            this.groupBox23.TabIndex = 5;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Invoice Information";
            // 
            // textBoxIDue
            // 
            this.textBoxIDue.Enabled = false;
            this.textBoxIDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDue.Location = new System.Drawing.Point(121, 239);
            this.textBoxIDue.Name = "textBoxIDue";
            this.textBoxIDue.Size = new System.Drawing.Size(254, 26);
            this.textBoxIDue.TabIndex = 40;
            this.textBoxIDue.Text = "0.00";
            this.textBoxIDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(76, 242);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(39, 20);
            this.label72.TabIndex = 39;
            this.label72.Text = "Due";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "CustName";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 28);
            this.comboBox2.TabIndex = 38;
            this.comboBox2.ValueMember = "CustId";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(253, 29);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // textBoxIAmount
            // 
            this.textBoxIAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIAmount.Location = new System.Drawing.Point(121, 207);
            this.textBoxIAmount.Name = "textBoxIAmount";
            this.textBoxIAmount.Size = new System.Drawing.Size(254, 26);
            this.textBoxIAmount.TabIndex = 30;
            this.textBoxIAmount.Text = "0.00";
            this.textBoxIAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(50, 210);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(65, 20);
            this.label73.TabIndex = 29;
            this.label73.Text = "Amount";
            // 
            // textBoxITotal
            // 
            this.textBoxITotal.Enabled = false;
            this.textBoxITotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxITotal.Location = new System.Drawing.Point(120, 175);
            this.textBoxITotal.Name = "textBoxITotal";
            this.textBoxITotal.Size = new System.Drawing.Size(254, 26);
            this.textBoxITotal.TabIndex = 28;
            this.textBoxITotal.Text = "0.00";
            this.textBoxITotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(71, 178);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(44, 20);
            this.label74.TabIndex = 27;
            this.label74.Text = "Total";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(120, 141);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(254, 28);
            this.comboBox3.TabIndex = 26;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(6, 145);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(109, 20);
            this.label75.TabIndex = 25;
            this.label75.Text = "Payment Type";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(37, 110);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(78, 20);
            this.label76.TabIndex = 23;
            this.label76.Text = "Customer";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(71, 79);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(44, 20);
            this.label77.TabIndex = 21;
            this.label77.Text = "Date";
            // 
            // textBox25
            // 
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.Location = new System.Drawing.Point(119, 38);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(254, 26);
            this.textBox25.TabIndex = 20;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(32, 41);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(83, 20);
            this.label78.TabIndex = 19;
            this.label78.Text = "Invoice No";
            // 
            // tabPageInvoiceList
            // 
            this.tabPageInvoiceList.Location = new System.Drawing.Point(4, 33);
            this.tabPageInvoiceList.Name = "tabPageInvoiceList";
            this.tabPageInvoiceList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInvoiceList.Size = new System.Drawing.Size(1268, 585);
            this.tabPageInvoiceList.TabIndex = 1;
            this.tabPageInvoiceList.Text = "Invoice List";
            this.tabPageInvoiceList.UseVisualStyleBackColor = true;
            // 
            // SalesControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl4);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.SalesControl_Load);
            this.tabControl4.ResumeLayout(false);
            this.tabPageNewInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSaleProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleProducts)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPageNewInvoice;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private DevExpress.XtraGrid.GridControl gridControlSaleProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaleProducts;
        private DevExpress.XtraGrid.Columns.GridColumn PProductId;
        private DevExpress.XtraGrid.Columns.GridColumn PCode;
        private DevExpress.XtraGrid.Columns.GridColumn PUPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn PTotalPrice;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.ComboBox comboBoxIProducts;
        private System.Windows.Forms.TextBox textBoxIQuantity;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Button buttonAddInvoiceItem;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox textBoxIDue;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxIAmount;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox textBoxITotal;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TabPage tabPageInvoiceList;
    }
}
