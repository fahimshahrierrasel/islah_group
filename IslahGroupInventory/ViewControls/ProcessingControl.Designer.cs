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
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.gridControlProcessingItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewProcessingItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.cbMaterialName = new System.Windows.Forms.ComboBox();
            this.tbMaterialQuantity = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label94 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.tbProcessingDetails = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.dtpProcessingDate = new System.Windows.Forms.DateTimePicker();
            this.label90 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabControl6.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProcessingItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcessingItem)).BeginInit();
            this.groupBox26.SuspendLayout();
            this.groupBox20.SuspendLayout();
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
            this.tabPage6.Controls.Add(this.gridControlProcessingItem);
            this.tabPage6.Controls.Add(this.groupBox26);
            this.tabPage6.Controls.Add(this.groupBox20);
            this.tabPage6.Location = new System.Drawing.Point(4, 33);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1268, 585);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "New Processing";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // gridControlProcessingItem
            // 
            this.gridControlProcessingItem.Location = new System.Drawing.Point(387, 10);
            this.gridControlProcessingItem.MainView = this.gridViewProcessingItem;
            this.gridControlProcessingItem.Name = "gridControlProcessingItem";
            this.gridControlProcessingItem.Size = new System.Drawing.Size(875, 568);
            this.gridControlProcessingItem.TabIndex = 6;
            this.gridControlProcessingItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProcessingItem});
            // 
            // gridViewProcessingItem
            // 
            this.gridViewProcessingItem.GridControl = this.gridControlProcessingItem;
            this.gridViewProcessingItem.Name = "gridViewProcessingItem";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.cbMaterialName);
            this.groupBox26.Controls.Add(this.tbMaterialQuantity);
            this.groupBox26.Controls.Add(this.label92);
            this.groupBox26.Controls.Add(this.button11);
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
            this.cbMaterialName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaterialName.DisplayMember = "RPName";
            this.cbMaterialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialName.FormattingEnabled = true;
            this.cbMaterialName.Location = new System.Drawing.Point(115, 39);
            this.cbMaterialName.Name = "cbMaterialName";
            this.cbMaterialName.Size = new System.Drawing.Size(256, 28);
            this.cbMaterialName.TabIndex = 49;
            this.cbMaterialName.ValueMember = "RPId";
            // 
            // tbMaterialQuantity
            // 
            this.tbMaterialQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaterialQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaterialQuantity.Location = new System.Drawing.Point(115, 73);
            this.tbMaterialQuantity.Name = "tbMaterialQuantity";
            this.tbMaterialQuantity.Size = new System.Drawing.Size(256, 26);
            this.tbMaterialQuantity.TabIndex = 47;
            // 
            // label92
            // 
            this.label92.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(41, 76);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(68, 20);
            this.label92.TabIndex = 46;
            this.label92.Text = "Quantity";
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(253, 105);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(118, 36);
            this.button11.TabIndex = 45;
            this.button11.Text = "Add Material";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label94
            // 
            this.label94.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tbProcessingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProcessingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProcessingDetails.Location = new System.Drawing.Point(97, 73);
            this.tbProcessingDetails.Multiline = true;
            this.tbProcessingDetails.Name = "tbProcessingDetails";
            this.tbProcessingDetails.Size = new System.Drawing.Size(271, 116);
            this.tbProcessingDetails.TabIndex = 42;
            // 
            // label70
            // 
            this.label70.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dtpProcessingDate.Size = new System.Drawing.Size(270, 29);
            this.dtpProcessingDate.TabIndex = 37;
            // 
            // label90
            // 
            this.label90.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1268, 596);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Processing List";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // ProcessingControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl6);
            this.Name = "ProcessingControl";
            this.Size = new System.Drawing.Size(1276, 622);
            this.tabControl6.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProcessingItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcessingItem)).EndInit();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage6;
        private DevExpress.XtraGrid.GridControl gridControlProcessingItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProcessingItem;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.ComboBox cbMaterialName;
        private System.Windows.Forms.TextBox tbMaterialQuantity;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox tbProcessingDetails;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.DateTimePicker dtpProcessingDate;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TabPage tabPage8;
    }
}
