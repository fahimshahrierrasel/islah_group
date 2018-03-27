namespace POS.ViewControls
{
    partial class CustomerViewControl
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
            this.CustomerGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CustCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ContactNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.RemarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCustCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContactNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerGridControl = new DevExpress.XtraGrid.GridControl();
            this.CustomerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonRegisterCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDiscard = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGroupControl)).BeginInit();
            this.CustomerGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGroupControl
            // 
            this.CustomerGroupControl.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.CustomerGroupControl.AppearanceCaption.Options.UseFont = true;
            this.CustomerGroupControl.Controls.Add(this.dataLayoutControl1);
            this.CustomerGroupControl.Location = new System.Drawing.Point(8, 8);
            this.CustomerGroupControl.Name = "CustomerGroupControl";
            this.CustomerGroupControl.Size = new System.Drawing.Size(375, 462);
            this.CustomerGroupControl.TabIndex = 0;
            this.CustomerGroupControl.Text = "Add Customer";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CustCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarkMemoEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 26);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(371, 434);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CustCodeTextEdit
            // 
            this.CustCodeTextEdit.Location = new System.Drawing.Point(12, 34);
            this.CustCodeTextEdit.Name = "CustCodeTextEdit";
            this.CustCodeTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.CustCodeTextEdit.Properties.Appearance.Options.UseFont = true;
            this.CustCodeTextEdit.Size = new System.Drawing.Size(347, 26);
            this.CustCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CustCodeTextEdit.TabIndex = 4;
            // 
            // CustNameTextEdit
            // 
            this.CustNameTextEdit.Location = new System.Drawing.Point(12, 86);
            this.CustNameTextEdit.Name = "CustNameTextEdit";
            this.CustNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.CustNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.CustNameTextEdit.Size = new System.Drawing.Size(347, 26);
            this.CustNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CustNameTextEdit.TabIndex = 5;
            // 
            // ContactNoTextEdit
            // 
            this.ContactNoTextEdit.Location = new System.Drawing.Point(12, 138);
            this.ContactNoTextEdit.Name = "ContactNoTextEdit";
            this.ContactNoTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ContactNoTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ContactNoTextEdit.Size = new System.Drawing.Size(347, 26);
            this.ContactNoTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactNoTextEdit.TabIndex = 7;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.Location = new System.Drawing.Point(12, 190);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.EmailTextEdit.Properties.Appearance.Options.UseFont = true;
            this.EmailTextEdit.Size = new System.Drawing.Size(347, 26);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 8;
            // 
            // AddressMemoEdit
            // 
            this.AddressMemoEdit.Location = new System.Drawing.Point(12, 242);
            this.AddressMemoEdit.Name = "AddressMemoEdit";
            this.AddressMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.AddressMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.AddressMemoEdit.Size = new System.Drawing.Size(347, 75);
            this.AddressMemoEdit.StyleController = this.dataLayoutControl1;
            this.AddressMemoEdit.TabIndex = 10;
            // 
            // RemarkMemoEdit
            // 
            this.RemarkMemoEdit.Location = new System.Drawing.Point(12, 343);
            this.RemarkMemoEdit.Name = "RemarkMemoEdit";
            this.RemarkMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.RemarkMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.RemarkMemoEdit.Size = new System.Drawing.Size(347, 79);
            this.RemarkMemoEdit.StyleController = this.dataLayoutControl1;
            this.RemarkMemoEdit.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(371, 434);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCustCode,
            this.ItemForCustName,
            this.ItemForAddress,
            this.ItemForRemark,
            this.ItemForContactNo,
            this.ItemForEmail});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(351, 414);
            // 
            // ItemForCustCode
            // 
            this.ItemForCustCode.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForCustCode.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCustCode.Control = this.CustCodeTextEdit;
            this.ItemForCustCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCustCode.Name = "ItemForCustCode";
            this.ItemForCustCode.Size = new System.Drawing.Size(351, 52);
            this.ItemForCustCode.Text = "Customer Code";
            this.ItemForCustCode.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForCustCode.TextSize = new System.Drawing.Size(114, 19);
            // 
            // ItemForCustName
            // 
            this.ItemForCustName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForCustName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCustName.Control = this.CustNameTextEdit;
            this.ItemForCustName.Location = new System.Drawing.Point(0, 52);
            this.ItemForCustName.Name = "ItemForCustName";
            this.ItemForCustName.Size = new System.Drawing.Size(351, 52);
            this.ItemForCustName.Text = "Customer Name";
            this.ItemForCustName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForCustName.TextSize = new System.Drawing.Size(114, 19);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForAddress.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForAddress.Control = this.AddressMemoEdit;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 208);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(351, 101);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForAddress.TextSize = new System.Drawing.Size(114, 19);
            // 
            // ItemForRemark
            // 
            this.ItemForRemark.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForRemark.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForRemark.Control = this.RemarkMemoEdit;
            this.ItemForRemark.Location = new System.Drawing.Point(0, 309);
            this.ItemForRemark.Name = "ItemForRemark";
            this.ItemForRemark.Size = new System.Drawing.Size(351, 105);
            this.ItemForRemark.Text = "Remark";
            this.ItemForRemark.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForRemark.TextSize = new System.Drawing.Size(114, 19);
            // 
            // ItemForContactNo
            // 
            this.ItemForContactNo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForContactNo.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForContactNo.Control = this.ContactNoTextEdit;
            this.ItemForContactNo.Location = new System.Drawing.Point(0, 104);
            this.ItemForContactNo.Name = "ItemForContactNo";
            this.ItemForContactNo.Size = new System.Drawing.Size(351, 52);
            this.ItemForContactNo.Text = "Contact No";
            this.ItemForContactNo.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForContactNo.TextSize = new System.Drawing.Size(114, 19);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForEmail.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 156);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(351, 52);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForEmail.TextSize = new System.Drawing.Size(114, 19);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(POS.Customer);
            // 
            // CustomerGridControl
            // 
            this.CustomerGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerGridControl.DataSource = this.customersBindingSource;
            this.CustomerGridControl.Location = new System.Drawing.Point(389, 9);
            this.CustomerGridControl.MainView = this.CustomerGridView;
            this.CustomerGridControl.Name = "CustomerGridControl";
            this.CustomerGridControl.Size = new System.Drawing.Size(778, 716);
            this.CustomerGridControl.TabIndex = 1;
            this.CustomerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CustomerGridView});
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustId,
            this.colCustCode,
            this.colCustName,
            this.colAddress,
            this.colContactNo,
            this.colEmail,
            this.colRemark,
            this.colBranch_BranchId,
            this.colBranch});
            this.CustomerGridView.GridControl = this.CustomerGridControl;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colCustId
            // 
            this.colCustId.FieldName = "CustId";
            this.colCustId.Name = "colCustId";
            // 
            // colCustCode
            // 
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 0;
            // 
            // colCustName
            // 
            this.colCustName.FieldName = "CustName";
            this.colCustName.Name = "colCustName";
            this.colCustName.Visible = true;
            this.colCustName.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colContactNo
            // 
            this.colContactNo.FieldName = "ContactNo";
            this.colContactNo.Name = "colContactNo";
            this.colContactNo.Visible = true;
            this.colContactNo.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 5;
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
            // ButtonRegisterCustomer
            // 
            this.ButtonRegisterCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ButtonRegisterCustomer.Appearance.Options.UseFont = true;
            this.ButtonRegisterCustomer.Location = new System.Drawing.Point(233, 476);
            this.ButtonRegisterCustomer.Name = "ButtonRegisterCustomer";
            this.ButtonRegisterCustomer.Size = new System.Drawing.Size(148, 44);
            this.ButtonRegisterCustomer.TabIndex = 2;
            this.ButtonRegisterCustomer.Text = "Register Customer";
            this.ButtonRegisterCustomer.Click += new System.EventHandler(this.ButtonRegisterCustomer_Click);
            // 
            // ButtonDiscard
            // 
            this.ButtonDiscard.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ButtonDiscard.Appearance.Options.UseFont = true;
            this.ButtonDiscard.Location = new System.Drawing.Point(79, 476);
            this.ButtonDiscard.Name = "ButtonDiscard";
            this.ButtonDiscard.Size = new System.Drawing.Size(148, 44);
            this.ButtonDiscard.TabIndex = 3;
            this.ButtonDiscard.Text = "Discard";
            this.ButtonDiscard.Click += new System.EventHandler(this.ButtonDiscard_Click);
            // 
            // CustomerViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonDiscard);
            this.Controls.Add(this.ButtonRegisterCustomer);
            this.Controls.Add(this.CustomerGridControl);
            this.Controls.Add(this.CustomerGroupControl);
            this.Name = "CustomerViewControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1175, 733);
            this.Load += new System.EventHandler(this.CustomerViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGroupControl)).EndInit();
            this.CustomerGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl CustomerGroupControl;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit CustCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit CustNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ContactNoTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.MemoEdit AddressMemoEdit;
        private DevExpress.XtraEditors.MemoEdit RemarkMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemark;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraGrid.GridControl CustomerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CustomerGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCustId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraEditors.SimpleButton ButtonRegisterCustomer;
        private DevExpress.XtraEditors.SimpleButton ButtonDiscard;
    }
}
