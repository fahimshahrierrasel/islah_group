namespace POS.ViewControls
{
    partial class SaleLedgerViewControl
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
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.InvoiceGridControl = new DevExpress.XtraGrid.GridControl();
            this.InvoicesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.InvoiceItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.InvoiceItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvcId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvcCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_CustId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType_PType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colInvoice_InvcId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_ProdId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataSource = typeof(POS.Invoice);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.InvoiceGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.InvoiceItemsGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1306, 807);
            this.splitContainerControl1.SplitterPosition = 733;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // InvoiceGridControl
            // 
            this.InvoiceGridControl.DataSource = this.invoicesBindingSource;
            this.InvoiceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceGridControl.Location = new System.Drawing.Point(0, 0);
            this.InvoiceGridControl.MainView = this.InvoicesGridView;
            this.InvoiceGridControl.Name = "InvoiceGridControl";
            this.InvoiceGridControl.Size = new System.Drawing.Size(733, 807);
            this.InvoiceGridControl.TabIndex = 0;
            this.InvoiceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InvoicesGridView});
            // 
            // InvoicesGridView
            // 
            this.InvoicesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvcId,
            this.colInvcCode,
            this.colInvcDate,
            this.colPaymentDate,
            this.colAmount,
            this.colPaid,
            this.colDue,
            this.colCustomer_CustId,
            this.colPaymentType_PType,
            this.colBranch_BranchId,
            this.colBranch,
            this.colCustomer,
            this.colPaymentType});
            this.InvoicesGridView.GridControl = this.InvoiceGridControl;
            this.InvoicesGridView.Name = "InvoicesGridView";
            // 
            // InvoiceItemsGridControl
            // 
            this.InvoiceItemsGridControl.DataSource = this.invoiceItemsBindingSource;
            this.InvoiceItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceItemsGridControl.Location = new System.Drawing.Point(0, 0);
            this.InvoiceItemsGridControl.MainView = this.InvoiceItemsGridView;
            this.InvoiceItemsGridControl.Name = "InvoiceItemsGridControl";
            this.InvoiceItemsGridControl.Size = new System.Drawing.Size(568, 807);
            this.InvoiceItemsGridControl.TabIndex = 0;
            this.InvoiceItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InvoiceItemsGridView});
            // 
            // InvoiceItemsGridView
            // 
            this.InvoiceItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoice_InvcId,
            this.colProduct_ProdId,
            this.colQuantity,
            this.colPrice,
            this.colInvoice,
            this.colProduct});
            this.InvoiceItemsGridView.GridControl = this.InvoiceItemsGridControl;
            this.InvoiceItemsGridView.Name = "InvoiceItemsGridView";
            // 
            // colInvcId
            // 
            this.colInvcId.FieldName = "InvcId";
            this.colInvcId.Name = "colInvcId";
            // 
            // colInvcCode
            // 
            this.colInvcCode.FieldName = "InvcCode";
            this.colInvcCode.Name = "colInvcCode";
            this.colInvcCode.Visible = true;
            this.colInvcCode.VisibleIndex = 0;
            // 
            // colInvcDate
            // 
            this.colInvcDate.FieldName = "InvcDate";
            this.colInvcDate.Name = "colInvcDate";
            this.colInvcDate.Visible = true;
            this.colInvcDate.VisibleIndex = 1;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colPaid
            // 
            this.colPaid.FieldName = "Paid";
            this.colPaid.Name = "colPaid";
            this.colPaid.Visible = true;
            this.colPaid.VisibleIndex = 4;
            // 
            // colDue
            // 
            this.colDue.FieldName = "Due";
            this.colDue.Name = "colDue";
            this.colDue.Visible = true;
            this.colDue.VisibleIndex = 5;
            // 
            // colCustomer_CustId
            // 
            this.colCustomer_CustId.FieldName = "Customer_CustId";
            this.colCustomer_CustId.Name = "colCustomer_CustId";
            this.colCustomer_CustId.Visible = true;
            this.colCustomer_CustId.VisibleIndex = 6;
            // 
            // colPaymentType_PType
            // 
            this.colPaymentType_PType.FieldName = "PaymentType_PType";
            this.colPaymentType_PType.Name = "colPaymentType_PType";
            this.colPaymentType_PType.Visible = true;
            this.colPaymentType_PType.VisibleIndex = 7;
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
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            // 
            // colPaymentType
            // 
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            // 
            // invoiceItemsBindingSource
            // 
            this.invoiceItemsBindingSource.DataMember = "InvoiceItems";
            this.invoiceItemsBindingSource.DataSource = this.invoicesBindingSource;
            // 
            // colInvoice_InvcId
            // 
            this.colInvoice_InvcId.FieldName = "Invoice_InvcId";
            this.colInvoice_InvcId.Name = "colInvoice_InvcId";
            // 
            // colProduct_ProdId
            // 
            this.colProduct_ProdId.FieldName = "Product_ProdId";
            this.colProduct_ProdId.Name = "colProduct_ProdId";
            this.colProduct_ProdId.Visible = true;
            this.colProduct_ProdId.VisibleIndex = 0;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colInvoice
            // 
            this.colInvoice.FieldName = "Invoice";
            this.colInvoice.Name = "colInvoice";
            // 
            // colProduct
            // 
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            // 
            // SaleLedgerViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "SaleLedgerViewControl";
            this.Size = new System.Drawing.Size(1306, 807);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl InvoiceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView InvoicesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colInvcId;
        private DevExpress.XtraGrid.Columns.GridColumn colInvcCode;
        private DevExpress.XtraGrid.Columns.GridColumn colInvcDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colDue;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_CustId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType_PType;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.GridControl InvoiceItemsGridControl;
        private System.Windows.Forms.BindingSource invoiceItemsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView InvoiceItemsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoice_InvcId;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ProdId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
    }
}
