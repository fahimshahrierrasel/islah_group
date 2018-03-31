namespace IslahGroupInventory.ViewControls
{
    partial class ProcessingControl
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
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonDiscardProcessing = new System.Windows.Forms.Button();
            this.buttonSaveProcessing = new System.Windows.Forms.Button();
            this.gridControlProcessingItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewProcessingItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.cbMaterialName = new System.Windows.Forms.ComboBox();
            this.rawProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMaterialQuantity = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.label94 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.tbProcessingDetails = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.dtpProcessingDate = new System.Windows.Forms.DateTimePicker();
            this.label90 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControlProcessing = new DevExpress.XtraGrid.GridControl();
            this.processingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProcessing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProcessingID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlPItems = new DevExpress.XtraGrid.GridControl();
            this.processingItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProcessing_ProcessingID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawProduct_RPId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRawProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProcessingErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RMaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl6.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProcessingItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcessingItem)).BeginInit();
            this.groupBox26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawProductsBindingSource)).BeginInit();
            this.groupBox20.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProcessing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcessing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessingErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage6);
            this.tabControl6.Controls.Add(this.tabPage8);
            this.tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl6.Location = new System.Drawing.Point(0, 0);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(1276, 622);
            this.tabControl6.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonDiscardProcessing);
            this.tabPage6.Controls.Add(this.buttonSaveProcessing);
            this.tabPage6.Controls.Add(this.gridControlProcessingItem);
            this.tabPage6.Controls.Add(this.groupBox26);
            this.tabPage6.Controls.Add(this.groupBox20);
            this.tabPage6.Location = new System.Drawing.Point(4, 33);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage6.Size = new System.Drawing.Size(1268, 585);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "New Processing";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonDiscardProcessing
            // 
            this.buttonDiscardProcessing.Location = new System.Drawing.Point(187, 388);
            this.buttonDiscardProcessing.Name = "buttonDiscardProcessing";
            this.buttonDiscardProcessing.Size = new System.Drawing.Size(94, 43);
            this.buttonDiscardProcessing.TabIndex = 8;
            this.buttonDiscardProcessing.Text = "Discard";
            this.buttonDiscardProcessing.UseVisualStyleBackColor = true;
            // 
            // buttonSaveProcessing
            // 
            this.buttonSaveProcessing.Location = new System.Drawing.Point(287, 389);
            this.buttonSaveProcessing.Name = "buttonSaveProcessing";
            this.buttonSaveProcessing.Size = new System.Drawing.Size(94, 43);
            this.buttonSaveProcessing.TabIndex = 7;
            this.buttonSaveProcessing.Text = "Save";
            this.buttonSaveProcessing.UseVisualStyleBackColor = true;
            this.buttonSaveProcessing.Click += new System.EventHandler(this.ButtonSaveProcessing_Click);
            // 
            // gridControlProcessingItem
            // 
            this.gridControlProcessingItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlProcessingItem.Location = new System.Drawing.Point(388, 9);
            this.gridControlProcessingItem.MainView = this.gridViewProcessingItem;
            this.gridControlProcessingItem.Name = "gridControlProcessingItem";
            this.gridControlProcessingItem.Size = new System.Drawing.Size(872, 568);
            this.gridControlProcessingItem.TabIndex = 6;
            this.gridControlProcessingItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProcessingItem});
            // 
            // gridViewProcessingItem
            // 
            this.gridViewProcessingItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RMaterialId,
            this.RMaterialName,
            this.RQuantity});
            this.gridViewProcessingItem.GridControl = this.gridControlProcessingItem;
            this.gridViewProcessingItem.Name = "gridViewProcessingItem";
            this.gridViewProcessingItem.OptionsView.ShowFooter = true;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.cbMaterialName);
            this.groupBox26.Controls.Add(this.tbMaterialQuantity);
            this.groupBox26.Controls.Add(this.label92);
            this.groupBox26.Controls.Add(this.buttonAddMaterial);
            this.groupBox26.Controls.Add(this.label94);
            this.groupBox26.Location = new System.Drawing.Point(3, 217);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(378, 147);
            this.groupBox26.TabIndex = 5;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Add Raw Material";
            // 
            // cbMaterialName
            // 
            this.cbMaterialName.DataSource = this.rawProductsBindingSource;
            this.cbMaterialName.DisplayMember = "RPName";
            this.cbMaterialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialName.FormattingEnabled = true;
            this.cbMaterialName.Location = new System.Drawing.Point(115, 39);
            this.cbMaterialName.Name = "cbMaterialName";
            this.cbMaterialName.Size = new System.Drawing.Size(243, 28);
            this.cbMaterialName.TabIndex = 49;
            this.cbMaterialName.ValueMember = "RPId";
            // 
            // rawProductsBindingSource
            // 
            this.rawProductsBindingSource.DataSource = typeof(IslahGroupInventory.RawProduct);
            // 
            // tbMaterialQuantity
            // 
            this.tbMaterialQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaterialQuantity.Location = new System.Drawing.Point(115, 73);
            this.tbMaterialQuantity.Name = "tbMaterialQuantity";
            this.tbMaterialQuantity.Size = new System.Drawing.Size(243, 26);
            this.tbMaterialQuantity.TabIndex = 47;
            this.tbMaterialQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMaterialQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckWholeNumber);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(41, 76);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(68, 20);
            this.label92.TabIndex = 46;
            this.label92.Text = "Quantity";
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMaterial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddMaterial.Location = new System.Drawing.Point(242, 105);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(116, 36);
            this.buttonAddMaterial.TabIndex = 45;
            this.buttonAddMaterial.Text = "Add Material";
            this.buttonAddMaterial.UseVisualStyleBackColor = true;
            this.buttonAddMaterial.Click += new System.EventHandler(this.ButtonAddMaterial_Click);
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(1, 42);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(111, 20);
            this.label94.TabIndex = 41;
            this.label94.Text = "Material Name";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.tbProcessingDetails);
            this.groupBox20.Controls.Add(this.label70);
            this.groupBox20.Controls.Add(this.dtpProcessingDate);
            this.groupBox20.Controls.Add(this.label90);
            this.groupBox20.Location = new System.Drawing.Point(6, 6);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(375, 205);
            this.groupBox20.TabIndex = 3;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Processing Information";
            // 
            // tbProcessingDetails
            // 
            this.tbProcessingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProcessingDetails.Location = new System.Drawing.Point(97, 73);
            this.tbProcessingDetails.Multiline = true;
            this.tbProcessingDetails.Name = "tbProcessingDetails";
            this.tbProcessingDetails.Size = new System.Drawing.Size(258, 116);
            this.tbProcessingDetails.TabIndex = 42;
            this.tbProcessingDetails.Validating += new System.ComponentModel.CancelEventHandler(this.CheckNullorEmpty);
            // 
            // label70
            // 
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(2, 73);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(89, 50);
            this.label70.TabIndex = 41;
            this.label70.Text = "Processing Details";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpProcessingDate
            // 
            this.dtpProcessingDate.CustomFormat = "";
            this.dtpProcessingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProcessingDate.Location = new System.Drawing.Point(98, 34);
            this.dtpProcessingDate.Name = "dtpProcessingDate";
            this.dtpProcessingDate.Size = new System.Drawing.Size(257, 29);
            this.dtpProcessingDate.TabIndex = 37;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(47, 42);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(44, 20);
            this.label90.TabIndex = 21;
            this.label90.Text = "Date";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.splitContainer1);
            this.tabPage8.Location = new System.Drawing.Point(4, 33);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1268, 585);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Processing List";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControlProcessing);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlPItems);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 579);
            this.splitContainer1.SplitterDistance = 730;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControlProcessing
            // 
            this.gridControlProcessing.DataSource = this.processingsBindingSource;
            this.gridControlProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProcessing.Location = new System.Drawing.Point(0, 0);
            this.gridControlProcessing.MainView = this.gridViewProcessing;
            this.gridControlProcessing.Name = "gridControlProcessing";
            this.gridControlProcessing.Size = new System.Drawing.Size(730, 579);
            this.gridControlProcessing.TabIndex = 0;
            this.gridControlProcessing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProcessing});
            // 
            // processingsBindingSource
            // 
            this.processingsBindingSource.DataSource = typeof(IslahGroupInventory.Processing);
            // 
            // gridViewProcessing
            // 
            this.gridViewProcessing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProcessingID,
            this.colDescription,
            this.colDate,
            this.colBranch_BranchId,
            this.colBranch});
            this.gridViewProcessing.GridControl = this.gridControlProcessing;
            this.gridViewProcessing.Name = "gridViewProcessing";
            this.gridViewProcessing.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colProcessingID
            // 
            this.colProcessingID.FieldName = "ProcessingID";
            this.colProcessingID.Name = "colProcessingID";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
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
            // gridControlPItems
            // 
            this.gridControlPItems.DataSource = this.processingItemsBindingSource;
            this.gridControlPItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPItems.Location = new System.Drawing.Point(0, 0);
            this.gridControlPItems.MainView = this.gridViewPItems;
            this.gridControlPItems.Name = "gridControlPItems";
            this.gridControlPItems.Size = new System.Drawing.Size(528, 579);
            this.gridControlPItems.TabIndex = 0;
            this.gridControlPItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPItems});
            // 
            // processingItemsBindingSource
            // 
            this.processingItemsBindingSource.DataMember = "ProcessingItems";
            this.processingItemsBindingSource.DataSource = this.processingsBindingSource;
            // 
            // gridViewPItems
            // 
            this.gridViewPItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProcessing_ProcessingID,
            this.colRawProduct_RPId,
            this.colQuantity,
            this.colProcessing,
            this.colRawProduct});
            this.gridViewPItems.GridControl = this.gridControlPItems;
            this.gridViewPItems.Name = "gridViewPItems";
            // 
            // colProcessing_ProcessingID
            // 
            this.colProcessing_ProcessingID.FieldName = "Processing_ProcessingID";
            this.colProcessing_ProcessingID.Name = "colProcessing_ProcessingID";
            // 
            // colRawProduct_RPId
            // 
            this.colRawProduct_RPId.Caption = "Raw Material Id";
            this.colRawProduct_RPId.FieldName = "RawProduct_RPId";
            this.colRawProduct_RPId.Name = "colRawProduct_RPId";
            this.colRawProduct_RPId.Visible = true;
            this.colRawProduct_RPId.VisibleIndex = 0;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colProcessing
            // 
            this.colProcessing.FieldName = "Processing";
            this.colProcessing.Name = "colProcessing";
            // 
            // colRawProduct
            // 
            this.colRawProduct.FieldName = "RawProduct";
            this.colRawProduct.Name = "colRawProduct";
            // 
            // ProcessingErrorProvider
            // 
            this.ProcessingErrorProvider.ContainerControl = this;
            // 
            // RMaterialId
            // 
            this.RMaterialId.Caption = "Material Id";
            this.RMaterialId.FieldName = "RMaterialId";
            this.RMaterialId.Name = "RMaterialId";
            // 
            // RMaterialName
            // 
            this.RMaterialName.Caption = "Material Name";
            this.RMaterialName.FieldName = "RMaterialName";
            this.RMaterialName.Name = "RMaterialName";
            this.RMaterialName.Visible = true;
            this.RMaterialName.VisibleIndex = 0;
            // 
            // RQuantity
            // 
            this.RQuantity.Caption = "Quantity";
            this.RQuantity.FieldName = "RQuantity";
            this.RQuantity.Name = "RQuantity";
            this.RQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RQuantity", "Total ={0:0}")});
            this.RQuantity.Visible = true;
            this.RQuantity.VisibleIndex = 1;
            // 
            // ProcessingControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl6);
            this.Name = "ProcessingControl";
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.ProcessingControl_Load);
            this.tabControl6.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProcessingItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcessingItem)).EndInit();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawProductsBindingSource)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProcessing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcessing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processingItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessingErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.ComboBox cbMaterialName;
        private System.Windows.Forms.TextBox tbMaterialQuantity;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox tbProcessingDetails;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.DateTimePicker dtpProcessingDate;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.BindingSource rawProductsBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlProcessingItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProcessingItem;
        private System.Windows.Forms.Button buttonDiscardProcessing;
        private System.Windows.Forms.Button buttonSaveProcessing;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControlProcessing;
        private System.Windows.Forms.BindingSource processingsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProcessing;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessingID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.GridControl gridControlPItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPItems;
        private System.Windows.Forms.BindingSource processingItemsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessing_ProcessingID;
        private DevExpress.XtraGrid.Columns.GridColumn colRawProduct_RPId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessing;
        private DevExpress.XtraGrid.Columns.GridColumn colRawProduct;
        private System.Windows.Forms.ErrorProvider ProcessingErrorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn RMaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn RMaterialName;
        private DevExpress.XtraGrid.Columns.GridColumn RQuantity;
    }
}
