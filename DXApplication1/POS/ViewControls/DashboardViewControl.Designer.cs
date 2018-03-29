namespace POS.ViewControls
{
    partial class DashboardViewControl
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TopSellingGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TopSellingGridControl = new DevExpress.XtraGrid.GridControl();
            this.TopSellingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSellingGroupControl)).BeginInit();
            this.TopSellingGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSellingGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSellingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TopSellingGroupControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1178, 723);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 50D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 50D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(1178, 723);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataSource = typeof(POS.Invoice);
            // 
            // TopSellingGroupControl
            // 
            this.TopSellingGroupControl.Controls.Add(this.TopSellingGridControl);
            this.TopSellingGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopSellingGroupControl.Location = new System.Drawing.Point(591, 12);
            this.TopSellingGroupControl.Name = "TopSellingGroupControl";
            this.TopSellingGroupControl.Size = new System.Drawing.Size(575, 347);
            this.TopSellingGroupControl.TabIndex = 6;
            this.TopSellingGroupControl.Text = "Top Products";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TopSellingGroupControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(579, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(579, 351);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // TopSellingGridControl
            // 
            this.TopSellingGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopSellingGridControl.Location = new System.Drawing.Point(2, 20);
            this.TopSellingGridControl.MainView = this.TopSellingGridView;
            this.TopSellingGridControl.Name = "TopSellingGridControl";
            this.TopSellingGridControl.Size = new System.Drawing.Size(571, 325);
            this.TopSellingGridControl.TabIndex = 9;
            this.TopSellingGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TopSellingGridView});
            // 
            // TopSellingGridView
            // 
            this.TopSellingGridView.GridControl = this.TopSellingGridControl;
            this.TopSellingGridView.Name = "TopSellingGridView";
            this.TopSellingGridView.OptionsView.ShowGroupPanel = false;
            // 
            // DashboardViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "DashboardViewControl";
            this.Size = new System.Drawing.Size(1178, 723);
            this.Load += new System.EventHandler(this.DashboardViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSellingGroupControl)).EndInit();
            this.TopSellingGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSellingGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSellingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl TopSellingGroupControl;
        private DevExpress.XtraGrid.GridControl TopSellingGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView TopSellingGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
