﻿namespace POS
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.xtraTabControlPos = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageDashboard = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageSale = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageLedger = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageProduct = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageService = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageReport = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageIslah = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlPos)).BeginInit();
            this.xtraTabControlPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControlPos
            // 
            this.xtraTabControlPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlPos.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlPos.Name = "xtraTabControlPos";
            this.xtraTabControlPos.SelectedTabPage = this.xtraTabPageDashboard;
            this.xtraTabControlPos.Size = new System.Drawing.Size(1006, 611);
            this.xtraTabControlPos.TabIndex = 0;
            this.xtraTabControlPos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageDashboard,
            this.xtraTabPageSale,
            this.xtraTabPageLedger,
            this.xtraTabPageProduct,
            this.xtraTabPageCustomer,
            this.xtraTabPageService,
            this.xtraTabPageReport,
            this.xtraTabPageIslah});
            // 
            // xtraTabPageDashboard
            // 
            this.xtraTabPageDashboard.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageDashboard.Image")));
            this.xtraTabPageDashboard.Name = "xtraTabPageDashboard";
            this.xtraTabPageDashboard.Size = new System.Drawing.Size(1000, 564);
            this.xtraTabPageDashboard.Text = "Dashboard";
            // 
            // xtraTabPageSale
            // 
            this.xtraTabPageSale.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageSale.Image")));
            this.xtraTabPageSale.Name = "xtraTabPageSale";
            this.xtraTabPageSale.Size = new System.Drawing.Size(1000, 564);
            this.xtraTabPageSale.Text = "Sale";
            // 
            // xtraTabPageLedger
            // 
            this.xtraTabPageLedger.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageLedger.Image")));
            this.xtraTabPageLedger.Name = "xtraTabPageLedger";
            this.xtraTabPageLedger.Size = new System.Drawing.Size(1000, 564);
            this.xtraTabPageLedger.Text = "Sale Ledger";
            // 
            // xtraTabPageProduct
            // 
            this.xtraTabPageProduct.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageProduct.Image")));
            this.xtraTabPageProduct.Name = "xtraTabPageProduct";
            this.xtraTabPageProduct.Size = new System.Drawing.Size(1000, 564);
            this.xtraTabPageProduct.Text = "Products";
            // 
            // xtraTabPageCustomer
            // 
            this.xtraTabPageCustomer.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageCustomer.Image")));
            this.xtraTabPageCustomer.Name = "xtraTabPageCustomer";
            this.xtraTabPageCustomer.Size = new System.Drawing.Size(1000, 564);
            this.xtraTabPageCustomer.Text = "Customers";
            // 
            // xtraTabPageService
            // 
            this.xtraTabPageService.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageService.Image")));
            this.xtraTabPageService.Name = "xtraTabPageService";
            this.xtraTabPageService.Size = new System.Drawing.Size(1000, 564);
            this.xtraTabPageService.Text = "Services";
            // 
            // xtraTabPageReport
            // 
            this.xtraTabPageReport.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageReport.Image")));
            this.xtraTabPageReport.Name = "xtraTabPageReport";
            this.xtraTabPageReport.Size = new System.Drawing.Size(1000, 564);
            this.xtraTabPageReport.Text = "Reports";
            // 
            // xtraTabPageIslah
            // 
            this.xtraTabPageIslah.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageIslah.Image")));
            this.xtraTabPageIslah.Name = "xtraTabPageIslah";
            this.xtraTabPageIslah.Size = new System.Drawing.Size(1000, 564);
            this.xtraTabPageIslah.Text = "Islah";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 611);
            this.Controls.Add(this.xtraTabControlPos);
            this.Name = "MainForm";
            this.Text = "Islah POS";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlPos)).EndInit();
            this.xtraTabControlPos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlPos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDashboard;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSale;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageLedger;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCustomer;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageService;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageReport;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageIslah;
    }
}

