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
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.gridControlVoucherItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewVoucherItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.tabControl5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVoucherItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVoucherItem)).BeginInit();
            this.groupBox24.SuspendLayout();
            this.groupBox25.SuspendLayout();
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
            this.tabPage7.Controls.Add(this.button13);
            this.tabPage7.Controls.Add(this.button8);
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
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(187, 535);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 43);
            this.button13.TabIndex = 9;
            this.button13.Text = "Discard";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(287, 535);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 43);
            this.button8.TabIndex = 8;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
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
            this.groupBox24.Controls.Add(this.textBox11);
            this.groupBox24.Controls.Add(this.label79);
            this.groupBox24.Controls.Add(this.textBox9);
            this.groupBox24.Controls.Add(this.textBox8);
            this.groupBox24.Controls.Add(this.label65);
            this.groupBox24.Controls.Add(this.button6);
            this.groupBox24.Controls.Add(this.label71);
            this.groupBox24.Location = new System.Drawing.Point(6, 299);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(382, 219);
            this.groupBox24.TabIndex = 6;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Add Item";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(115, 144);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(260, 26);
            this.textBox11.TabIndex = 50;
            // 
            // label79
            // 
            this.label79.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(44, 147);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(65, 20);
            this.label79.TabIndex = 49;
            this.label79.Text = "Amount";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(115, 37);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(260, 26);
            this.textBox9.TabIndex = 48;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(115, 69);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(260, 69);
            this.textBox8.TabIndex = 47;
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(52, 72);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(58, 20);
            this.label65.TabIndex = 46;
            this.label65.Text = "Details";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(257, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 36);
            this.button6.TabIndex = 45;
            this.button6.Text = "Add Item";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label71
            // 
            this.label71.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox25.Controls.Add(this.textBox15);
            this.groupBox25.Controls.Add(this.textBox14);
            this.groupBox25.Controls.Add(this.dateTimePicker3);
            this.groupBox25.Controls.Add(this.textBox10);
            this.groupBox25.Controls.Add(this.label80);
            this.groupBox25.Controls.Add(this.label82);
            this.groupBox25.Controls.Add(this.label83);
            this.groupBox25.Controls.Add(this.label84);
            this.groupBox25.Controls.Add(this.textBox12);
            this.groupBox25.Controls.Add(this.label85);
            this.groupBox25.Location = new System.Drawing.Point(6, 6);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(382, 287);
            this.groupBox25.TabIndex = 5;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Voucher Information";
            // 
            // textBox15
            // 
            this.textBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(115, 137);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(260, 26);
            this.textBox15.TabIndex = 42;
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(115, 105);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(260, 26);
            this.textBox14.TabIndex = 41;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(116, 66);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(259, 29);
            this.dateTimePicker3.TabIndex = 37;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(115, 169);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(260, 106);
            this.textBox10.TabIndex = 30;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label80
            // 
            this.label80.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label82.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(2, 140);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(108, 20);
            this.label82.TabIndex = 25;
            this.label82.Text = "Reference No";
            // 
            // label83
            // 
            this.label83.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(6, 108);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(104, 20);
            this.label83.TabIndex = 23;
            this.label83.Text = "Submitted By";
            // 
            // label84
            // 
            this.label84.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(66, 76);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(44, 20);
            this.label84.TabIndex = 21;
            this.label84.Text = "Date";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(115, 34);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(260, 26);
            this.textBox12.TabIndex = 20;
            // 
            // label85
            // 
            this.label85.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(17, 37);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(93, 20);
            this.label85.TabIndex = 19;
            this.label85.Text = "Voucher No";
            // 
            // tabPage
            // 
            this.tabPage.Location = new System.Drawing.Point(4, 33);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(1268, 585);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "Voucher List";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // VouchersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl5);
            this.Name = "VouchersControl";
            this.Size = new System.Drawing.Size(1276, 622);
            this.tabControl5.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVoucherItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVoucherItem)).EndInit();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private DevExpress.XtraGrid.GridControl gridControlVoucherItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVoucherItem;
        private DevExpress.XtraGrid.Columns.GridColumn VItemName;
        private DevExpress.XtraGrid.Columns.GridColumn VDetails;
        private DevExpress.XtraGrid.Columns.GridColumn VAmount;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TabPage tabPage;
    }
}
