namespace IslahGroupInventory.ViewControls
{
    partial class WorkersControl
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
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.labelTotalWorker = new System.Windows.Forms.Label();
            this.gridControlWorker = new DevExpress.XtraGrid.GridControl();
            this.operatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewWorker = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colField = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.textBoxWorkerType = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorker)).BeginInit();
            this.groupBox27.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.labelTotalWorker);
            this.groupBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox28.Location = new System.Drawing.Point(8, 8);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(378, 154);
            this.groupBox28.TabIndex = 9;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Total Worker";
            // 
            // labelTotalWorker
            // 
            this.labelTotalWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalWorker.Location = new System.Drawing.Point(3, 25);
            this.labelTotalWorker.Name = "labelTotalWorker";
            this.labelTotalWorker.Size = new System.Drawing.Size(372, 126);
            this.labelTotalWorker.TabIndex = 0;
            this.labelTotalWorker.Text = "00";
            this.labelTotalWorker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControlWorker
            // 
            this.gridControlWorker.DataSource = this.operatorsBindingSource;
            this.gridControlWorker.Location = new System.Drawing.Point(392, 8);
            this.gridControlWorker.MainView = this.gridViewWorker;
            this.gridControlWorker.Name = "gridControlWorker";
            this.gridControlWorker.Size = new System.Drawing.Size(876, 606);
            this.gridControlWorker.TabIndex = 8;
            this.gridControlWorker.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWorker});
            // 
            // operatorsBindingSource
            // 
            this.operatorsBindingSource.DataSource = typeof(IslahGroupInventory.Operator);
            // 
            // gridViewWorker
            // 
            this.gridViewWorker.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOId,
            this.colName,
            this.colField,
            this.colActive,
            this.colBranch_BranchId,
            this.colBranch});
            this.gridViewWorker.GridControl = this.gridControlWorker;
            this.gridViewWorker.Name = "gridViewWorker";
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
            this.colName.Width = 470;
            // 
            // colField
            // 
            this.colField.FieldName = "Field";
            this.colField.Name = "colField";
            this.colField.Visible = true;
            this.colField.VisibleIndex = 1;
            this.colField.Width = 124;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            this.colActive.Width = 98;
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
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.buttonAddWorker);
            this.groupBox27.Controls.Add(this.checkBoxActive);
            this.groupBox27.Controls.Add(this.textBoxWorkerType);
            this.groupBox27.Controls.Add(this.label86);
            this.groupBox27.Controls.Add(this.textBoxName);
            this.groupBox27.Controls.Add(this.label81);
            this.groupBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox27.Location = new System.Drawing.Point(8, 168);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(378, 177);
            this.groupBox27.TabIndex = 7;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Add Worker";
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.Location = new System.Drawing.Point(267, 135);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(105, 35);
            this.buttonAddWorker.TabIndex = 28;
            this.buttonAddWorker.Text = "Add";
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            this.buttonAddWorker.Click += new System.EventHandler(this.ButtonAddWorker_Click);
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Checked = true;
            this.checkBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActive.Location = new System.Drawing.Point(110, 106);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(80, 28);
            this.checkBoxActive.TabIndex = 27;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // textBoxWorkerType
            // 
            this.textBoxWorkerType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWorkerType.Location = new System.Drawing.Point(110, 74);
            this.textBoxWorkerType.Name = "textBoxWorkerType";
            this.textBoxWorkerType.Size = new System.Drawing.Size(253, 26);
            this.textBoxWorkerType.TabIndex = 26;
            // 
            // label86
            // 
            this.label86.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(6, 77);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(98, 20);
            this.label86.TabIndex = 25;
            this.label86.Text = "Worker Type";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(110, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(253, 26);
            this.textBoxName.TabIndex = 24;
            // 
            // label81
            // 
            this.label81.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(53, 45);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(51, 20);
            this.label81.TabIndex = 23;
            this.label81.Text = "Name";
            // 
            // WorkersControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox28);
            this.Controls.Add(this.gridControlWorker);
            this.Controls.Add(this.groupBox27);
            this.Name = "WorkersControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.WorkersControl_Load);
            this.groupBox28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorker)).EndInit();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.Label labelTotalWorker;
        private DevExpress.XtraGrid.GridControl gridControlWorker;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWorker;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.TextBox textBoxWorkerType;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.BindingSource operatorsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colOId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colField;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
    }
}
