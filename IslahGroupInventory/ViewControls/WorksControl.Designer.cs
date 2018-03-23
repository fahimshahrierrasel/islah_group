namespace IslahGroupInventory.ViewControls
{
    partial class WorksControl
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
            this.operatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.comboBoxWorkType = new System.Windows.Forms.ComboBox();
            this.workTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label100 = new System.Windows.Forms.Label();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.bindingSourceSelectOperator = new System.Windows.Forms.BindingSource(this.components);
            this.dtpWorkingDay = new System.Windows.Forms.DateTimePicker();
            this.label97 = new System.Windows.Forms.Label();
            this.buttonAddWork = new System.Windows.Forms.Button();
            this.textBoxWorkQuantity = new System.Windows.Forms.TextBox();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.operatorWorksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlOperator = new DevExpress.XtraGrid.GridControl();
            this.gridViewOperator = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colField = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlOperation = new DevExpress.XtraGrid.GridControl();
            this.gridViewOperation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOWId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkType_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperator_OId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).BeginInit();
            this.groupBox32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorWorksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // operatorsBindingSource
            // 
            this.operatorsBindingSource.DataSource = typeof(IslahGroupInventory.Operator);
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.comboBoxWorkType);
            this.groupBox32.Controls.Add(this.label100);
            this.groupBox32.Controls.Add(this.comboBoxWorker);
            this.groupBox32.Controls.Add(this.dtpWorkingDay);
            this.groupBox32.Controls.Add(this.label97);
            this.groupBox32.Controls.Add(this.buttonAddWork);
            this.groupBox32.Controls.Add(this.textBoxWorkQuantity);
            this.groupBox32.Controls.Add(this.label98);
            this.groupBox32.Controls.Add(this.label99);
            this.groupBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox32.Location = new System.Drawing.Point(8, 8);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(359, 231);
            this.groupBox32.TabIndex = 9;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Add Work";
            // 
            // comboBoxWorkType
            // 
            this.comboBoxWorkType.DataSource = this.workTypesBindingSource;
            this.comboBoxWorkType.DisplayMember = "Type";
            this.comboBoxWorkType.FormattingEnabled = true;
            this.comboBoxWorkType.Location = new System.Drawing.Point(96, 77);
            this.comboBoxWorkType.Name = "comboBoxWorkType";
            this.comboBoxWorkType.Size = new System.Drawing.Size(258, 32);
            this.comboBoxWorkType.TabIndex = 42;
            this.comboBoxWorkType.ValueMember = "Type";
            // 
            // workTypesBindingSource
            // 
            this.workTypesBindingSource.DataSource = typeof(IslahGroupInventory.WorkType);
            // 
            // label100
            // 
            this.label100.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(6, 83);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(84, 20);
            this.label100.TabIndex = 41;
            this.label100.Text = "Work Type";
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.DataSource = this.bindingSourceSelectOperator;
            this.comboBoxWorker.DisplayMember = "Name";
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(96, 38);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(258, 32);
            this.comboBoxWorker.TabIndex = 40;
            this.comboBoxWorker.ValueMember = "OId";
            // 
            // bindingSourceSelectOperator
            // 
            this.bindingSourceSelectOperator.DataSource = typeof(IslahGroupInventory.Operator);
            // 
            // dtpWorkingDay
            // 
            this.dtpWorkingDay.CustomFormat = "";
            this.dtpWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkingDay.Location = new System.Drawing.Point(95, 116);
            this.dtpWorkingDay.Name = "dtpWorkingDay";
            this.dtpWorkingDay.Size = new System.Drawing.Size(259, 29);
            this.dtpWorkingDay.TabIndex = 39;
            // 
            // label97
            // 
            this.label97.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(46, 123);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(44, 20);
            this.label97.TabIndex = 38;
            this.label97.Text = "Date";
            // 
            // buttonAddWork
            // 
            this.buttonAddWork.Location = new System.Drawing.Point(244, 187);
            this.buttonAddWork.Name = "buttonAddWork";
            this.buttonAddWork.Size = new System.Drawing.Size(105, 35);
            this.buttonAddWork.TabIndex = 28;
            this.buttonAddWork.Text = "Add";
            this.buttonAddWork.UseVisualStyleBackColor = true;
            this.buttonAddWork.Click += new System.EventHandler(this.ButtonAddWork_Click);
            // 
            // textBoxWorkQuantity
            // 
            this.textBoxWorkQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWorkQuantity.Location = new System.Drawing.Point(95, 155);
            this.textBoxWorkQuantity.Name = "textBoxWorkQuantity";
            this.textBoxWorkQuantity.Size = new System.Drawing.Size(254, 26);
            this.textBoxWorkQuantity.TabIndex = 26;
            // 
            // label98
            // 
            this.label98.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(22, 158);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(68, 20);
            this.label98.TabIndex = 25;
            this.label98.Text = "Quantity";
            // 
            // label99
            // 
            this.label99.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(30, 44);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(60, 20);
            this.label99.TabIndex = 23;
            this.label99.Text = "Worker";
            // 
            // operatorWorksBindingSource
            // 
            this.operatorWorksBindingSource.DataMember = "OperatorWorks";
            this.operatorWorksBindingSource.DataSource = this.operatorsBindingSource;
            // 
            // gridControlOperator
            // 
            this.gridControlOperator.DataSource = this.operatorsBindingSource;
            this.gridControlOperator.Location = new System.Drawing.Point(374, 9);
            this.gridControlOperator.MainView = this.gridViewOperator;
            this.gridControlOperator.Name = "gridControlOperator";
            this.gridControlOperator.Size = new System.Drawing.Size(462, 605);
            this.gridControlOperator.TabIndex = 10;
            this.gridControlOperator.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOperator});
            // 
            // gridViewOperator
            // 
            this.gridViewOperator.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOId,
            this.colName,
            this.colField,
            this.colActive,
            this.colBranch_BranchId,
            this.colBranch});
            this.gridViewOperator.GridControl = this.gridControlOperator;
            this.gridViewOperator.Name = "gridViewOperator";
            // 
            // colOId
            // 
            this.colOId.FieldName = "OId";
            this.colOId.Name = "colOId";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colField
            // 
            this.colField.FieldName = "Field";
            this.colField.Name = "colField";
            this.colField.Visible = true;
            this.colField.VisibleIndex = 1;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
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
            // gridControlOperation
            // 
            this.gridControlOperation.DataSource = this.operatorWorksBindingSource;
            this.gridControlOperation.Location = new System.Drawing.Point(842, 8);
            this.gridControlOperation.MainView = this.gridViewOperation;
            this.gridControlOperation.Name = "gridControlOperation";
            this.gridControlOperation.Size = new System.Drawing.Size(426, 606);
            this.gridControlOperation.TabIndex = 11;
            this.gridControlOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOperation});
            // 
            // gridViewOperation
            // 
            this.gridViewOperation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOWId,
            this.colDate,
            this.colQuantity,
            this.colWorkType_Type,
            this.colOperator_OId,
            this.colOperator,
            this.colWorkType,
            this.colName1});
            this.gridViewOperation.GridControl = this.gridControlOperation;
            this.gridViewOperation.Name = "gridViewOperation";
            // 
            // colOWId
            // 
            this.colOWId.FieldName = "OWId";
            this.colOWId.Name = "colOWId";
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colWorkType_Type
            // 
            this.colWorkType_Type.Caption = "Work";
            this.colWorkType_Type.FieldName = "WorkType_Type";
            this.colWorkType_Type.Name = "colWorkType_Type";
            this.colWorkType_Type.Visible = true;
            this.colWorkType_Type.VisibleIndex = 2;
            // 
            // colOperator_OId
            // 
            this.colOperator_OId.FieldName = "Operator_OId";
            this.colOperator_OId.Name = "colOperator_OId";
            // 
            // colOperator
            // 
            this.colOperator.FieldName = "Operator";
            this.colOperator.Name = "colOperator";
            // 
            // colWorkType
            // 
            this.colWorkType.FieldName = "WorkType";
            this.colWorkType.Name = "colWorkType";
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.ReadOnly = true;
            // 
            // WorksControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gridControlOperation);
            this.Controls.Add(this.gridControlOperator);
            this.Controls.Add(this.groupBox32);
            this.Name = "WorksControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.WorksControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).EndInit();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelectOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorWorksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.ComboBox comboBoxWorkType;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.DateTimePicker dtpWorkingDay;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Button buttonAddWork;
        private System.Windows.Forms.TextBox textBoxWorkQuantity;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.BindingSource operatorsBindingSource;
        private System.Windows.Forms.BindingSource operatorWorksBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlOperator;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOperator;
        private DevExpress.XtraGrid.Columns.GridColumn colOId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colField;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.GridControl gridControlOperation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOperation;
        private DevExpress.XtraGrid.Columns.GridColumn colOWId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkType_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colOperator_OId;
        private DevExpress.XtraGrid.Columns.GridColumn colOperator;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkType;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private System.Windows.Forms.BindingSource bindingSourceSelectOperator;
        private System.Windows.Forms.BindingSource workTypesBindingSource;
    }
}
