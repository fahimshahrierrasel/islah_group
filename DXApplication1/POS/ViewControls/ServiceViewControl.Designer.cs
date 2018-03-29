namespace POS.ViewControls
{
    partial class ServiceViewControl
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
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServicesXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.EntryXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.ListXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ServiceItemGridControl = new DevExpress.XtraGrid.GridControl();
            this.ServiceItemridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Details = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Charge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ServiceNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ServiceDetailsMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ChargeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForServiceName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForServiceDetails = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCharge = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.RegisterServiceDataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ServCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EstDeliveryDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.RemarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Customer_CustIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForServCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEstDeliveryDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomer_CustId = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesXtraTabControl)).BeginInit();
            this.ServicesXtraTabControl.SuspendLayout();
            this.EntryXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceItemridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDetailsMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterServiceDataLayoutControl)).BeginInit();
            this.RegisterServiceDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstDeliveryDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstDeliveryDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_CustIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEstDeliveryDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomer_CustId)).BeginInit();
            this.SuspendLayout();
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataSource = typeof(POS.Service);
            // 
            // ServicesXtraTabControl
            // 
            this.ServicesXtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ServicesXtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.ServicesXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesXtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.ServicesXtraTabControl.Name = "ServicesXtraTabControl";
            this.ServicesXtraTabControl.SelectedTabPage = this.EntryXtraTabPage;
            this.ServicesXtraTabControl.Size = new System.Drawing.Size(1153, 700);
            this.ServicesXtraTabControl.TabIndex = 0;
            this.ServicesXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.EntryXtraTabPage,
            this.ListXtraTabPage});
            // 
            // EntryXtraTabPage
            // 
            this.EntryXtraTabPage.Controls.Add(this.simpleButton2);
            this.EntryXtraTabPage.Controls.Add(this.simpleButton1);
            this.EntryXtraTabPage.Controls.Add(this.ServiceItemGridControl);
            this.EntryXtraTabPage.Controls.Add(this.groupControl2);
            this.EntryXtraTabPage.Controls.Add(this.groupControl1);
            this.EntryXtraTabPage.Name = "EntryXtraTabPage";
            this.EntryXtraTabPage.Size = new System.Drawing.Size(1147, 666);
            this.EntryXtraTabPage.Text = "Service Entry";
            // 
            // ListXtraTabPage
            // 
            this.ListXtraTabPage.Name = "ListXtraTabPage";
            this.ListXtraTabPage.Size = new System.Drawing.Size(294, 272);
            this.ListXtraTabPage.Text = "Service List";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(119, 589);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 43);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Discard";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(221, 589);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(96, 43);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Add";
            // 
            // ServiceItemGridControl
            // 
            this.ServiceItemGridControl.Location = new System.Drawing.Point(321, 3);
            this.ServiceItemGridControl.MainView = this.ServiceItemridView;
            this.ServiceItemGridControl.Name = "ServiceItemGridControl";
            this.ServiceItemGridControl.Size = new System.Drawing.Size(823, 580);
            this.ServiceItemGridControl.TabIndex = 7;
            this.ServiceItemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ServiceItemridView});
            // 
            // ServiceItemridView
            // 
            this.ServiceItemridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Name,
            this.Details,
            this.Charge});
            this.ServiceItemridView.GridControl = this.ServiceItemGridControl;
            this.ServiceItemridView.Name = "ServiceItemridView";
            this.ServiceItemridView.OptionsEditForm.EditFormColumnCount = 1;
            // 
            // Name
            // 
            this.Name.Caption = "Service Name";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            this.Name.Width = 170;
            // 
            // Details
            // 
            this.Details.Caption = "Details";
            this.Details.FieldName = "Details";
            this.Details.Name = "Details";
            this.Details.Visible = true;
            this.Details.VisibleIndex = 1;
            this.Details.Width = 832;
            // 
            // Charge
            // 
            this.Charge.Caption = "Charge";
            this.Charge.FieldName = "Charge";
            this.Charge.Name = "Charge";
            this.Charge.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Charge", "Total={0:0.##}")});
            this.Charge.Visible = true;
            this.Charge.VisibleIndex = 2;
            this.Charge.Width = 112;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dataLayoutControl1);
            this.groupControl2.Location = new System.Drawing.Point(3, 322);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(314, 261);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Add Item";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ServiceNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ServiceDetailsMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.ChargeTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 26);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup3;
            this.dataLayoutControl1.Size = new System.Drawing.Size(310, 233);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ServiceNameTextEdit
            // 
            this.ServiceNameTextEdit.Location = new System.Drawing.Point(12, 34);
            this.ServiceNameTextEdit.Name = "ServiceNameTextEdit";
            this.ServiceNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ServiceNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ServiceNameTextEdit.Size = new System.Drawing.Size(286, 26);
            this.ServiceNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ServiceNameTextEdit.TabIndex = 4;
            // 
            // ServiceDetailsMemoEdit
            // 
            this.ServiceDetailsMemoEdit.Location = new System.Drawing.Point(12, 138);
            this.ServiceDetailsMemoEdit.Name = "ServiceDetailsMemoEdit";
            this.ServiceDetailsMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ServiceDetailsMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.ServiceDetailsMemoEdit.Size = new System.Drawing.Size(286, 83);
            this.ServiceDetailsMemoEdit.StyleController = this.dataLayoutControl1;
            this.ServiceDetailsMemoEdit.TabIndex = 5;
            // 
            // ChargeTextEdit
            // 
            this.ChargeTextEdit.Location = new System.Drawing.Point(12, 86);
            this.ChargeTextEdit.Name = "ChargeTextEdit";
            this.ChargeTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ChargeTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ChargeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ChargeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ChargeTextEdit.Properties.Mask.EditMask = "G";
            this.ChargeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ChargeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ChargeTextEdit.Size = new System.Drawing.Size(286, 26);
            this.ChargeTextEdit.StyleController = this.dataLayoutControl1;
            this.ChargeTextEdit.TabIndex = 6;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(310, 233);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AllowDrawBackground = false;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForServiceName,
            this.ItemForServiceDetails,
            this.ItemForCharge});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "autoGeneratedGroup0";
            this.layoutControlGroup4.Size = new System.Drawing.Size(290, 213);
            // 
            // ItemForServiceName
            // 
            this.ItemForServiceName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForServiceName.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForServiceName.Control = this.ServiceNameTextEdit;
            this.ItemForServiceName.Location = new System.Drawing.Point(0, 0);
            this.ItemForServiceName.Name = "ItemForServiceName";
            this.ItemForServiceName.Size = new System.Drawing.Size(290, 52);
            this.ItemForServiceName.Text = "Service Name";
            this.ItemForServiceName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForServiceName.TextSize = new System.Drawing.Size(102, 19);
            // 
            // ItemForServiceDetails
            // 
            this.ItemForServiceDetails.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForServiceDetails.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForServiceDetails.Control = this.ServiceDetailsMemoEdit;
            this.ItemForServiceDetails.Location = new System.Drawing.Point(0, 104);
            this.ItemForServiceDetails.Name = "ItemForServiceDetails";
            this.ItemForServiceDetails.Size = new System.Drawing.Size(290, 109);
            this.ItemForServiceDetails.StartNewLine = true;
            this.ItemForServiceDetails.Text = "Service Details";
            this.ItemForServiceDetails.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForServiceDetails.TextSize = new System.Drawing.Size(102, 19);
            // 
            // ItemForCharge
            // 
            this.ItemForCharge.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForCharge.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCharge.Control = this.ChargeTextEdit;
            this.ItemForCharge.Location = new System.Drawing.Point(0, 52);
            this.ItemForCharge.Name = "ItemForCharge";
            this.ItemForCharge.Size = new System.Drawing.Size(290, 52);
            this.ItemForCharge.Text = "Charge";
            this.ItemForCharge.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForCharge.TextSize = new System.Drawing.Size(102, 19);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.RegisterServiceDataLayoutControl);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 315);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Register Service";
            // 
            // RegisterServiceDataLayoutControl
            // 
            this.RegisterServiceDataLayoutControl.Controls.Add(this.ServCodeTextEdit);
            this.RegisterServiceDataLayoutControl.Controls.Add(this.EstDeliveryDateDateEdit);
            this.RegisterServiceDataLayoutControl.Controls.Add(this.RemarkMemoEdit);
            this.RegisterServiceDataLayoutControl.Controls.Add(this.Customer_CustIdLookUpEdit);
            this.RegisterServiceDataLayoutControl.DataSource = this.servicesBindingSource;
            this.RegisterServiceDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterServiceDataLayoutControl.Location = new System.Drawing.Point(2, 26);
            this.RegisterServiceDataLayoutControl.Name = "RegisterServiceDataLayoutControl";
            this.RegisterServiceDataLayoutControl.Root = this.layoutControlGroup1;
            this.RegisterServiceDataLayoutControl.Size = new System.Drawing.Size(310, 287);
            this.RegisterServiceDataLayoutControl.TabIndex = 0;
            this.RegisterServiceDataLayoutControl.Text = "dataLayoutControl1";
            // 
            // ServCodeTextEdit
            // 
            this.ServCodeTextEdit.Location = new System.Drawing.Point(12, 34);
            this.ServCodeTextEdit.Name = "ServCodeTextEdit";
            this.ServCodeTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ServCodeTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ServCodeTextEdit.Size = new System.Drawing.Size(286, 26);
            this.ServCodeTextEdit.StyleController = this.RegisterServiceDataLayoutControl;
            this.ServCodeTextEdit.TabIndex = 4;
            // 
            // EstDeliveryDateDateEdit
            // 
            this.EstDeliveryDateDateEdit.EditValue = null;
            this.EstDeliveryDateDateEdit.Location = new System.Drawing.Point(12, 138);
            this.EstDeliveryDateDateEdit.Name = "EstDeliveryDateDateEdit";
            this.EstDeliveryDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.EstDeliveryDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.EstDeliveryDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EstDeliveryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EstDeliveryDateDateEdit.Size = new System.Drawing.Size(286, 26);
            this.EstDeliveryDateDateEdit.StyleController = this.RegisterServiceDataLayoutControl;
            this.EstDeliveryDateDateEdit.TabIndex = 5;
            // 
            // RemarkMemoEdit
            // 
            this.RemarkMemoEdit.Location = new System.Drawing.Point(12, 190);
            this.RemarkMemoEdit.Name = "RemarkMemoEdit";
            this.RemarkMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.RemarkMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.RemarkMemoEdit.Size = new System.Drawing.Size(286, 85);
            this.RemarkMemoEdit.StyleController = this.RegisterServiceDataLayoutControl;
            this.RemarkMemoEdit.TabIndex = 6;
            // 
            // Customer_CustIdLookUpEdit
            // 
            this.Customer_CustIdLookUpEdit.Location = new System.Drawing.Point(12, 86);
            this.Customer_CustIdLookUpEdit.Name = "Customer_CustIdLookUpEdit";
            this.Customer_CustIdLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Customer_CustIdLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.Customer_CustIdLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Customer_CustIdLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Customer_CustIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Customer_CustIdLookUpEdit.Properties.NullText = "";
            this.Customer_CustIdLookUpEdit.Size = new System.Drawing.Size(286, 26);
            this.Customer_CustIdLookUpEdit.StyleController = this.RegisterServiceDataLayoutControl;
            this.Customer_CustIdLookUpEdit.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(310, 287);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForServCode,
            this.ItemForEstDeliveryDate,
            this.ItemForRemark,
            this.ItemForCustomer_CustId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(290, 267);
            // 
            // ItemForServCode
            // 
            this.ItemForServCode.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForServCode.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForServCode.Control = this.ServCodeTextEdit;
            this.ItemForServCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForServCode.Name = "ItemForServCode";
            this.ItemForServCode.Size = new System.Drawing.Size(290, 52);
            this.ItemForServCode.Text = "Service Code";
            this.ItemForServCode.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForServCode.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForEstDeliveryDate
            // 
            this.ItemForEstDeliveryDate.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForEstDeliveryDate.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForEstDeliveryDate.Control = this.EstDeliveryDateDateEdit;
            this.ItemForEstDeliveryDate.Location = new System.Drawing.Point(0, 104);
            this.ItemForEstDeliveryDate.Name = "ItemForEstDeliveryDate";
            this.ItemForEstDeliveryDate.Size = new System.Drawing.Size(290, 52);
            this.ItemForEstDeliveryDate.Text = "Estimated Delivery Date";
            this.ItemForEstDeliveryDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForEstDeliveryDate.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForRemark
            // 
            this.ItemForRemark.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForRemark.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForRemark.Control = this.RemarkMemoEdit;
            this.ItemForRemark.Location = new System.Drawing.Point(0, 156);
            this.ItemForRemark.Name = "ItemForRemark";
            this.ItemForRemark.Size = new System.Drawing.Size(290, 111);
            this.ItemForRemark.StartNewLine = true;
            this.ItemForRemark.Text = "Remark";
            this.ItemForRemark.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForRemark.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ItemForCustomer_CustId
            // 
            this.ItemForCustomer_CustId.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ItemForCustomer_CustId.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForCustomer_CustId.Control = this.Customer_CustIdLookUpEdit;
            this.ItemForCustomer_CustId.Location = new System.Drawing.Point(0, 52);
            this.ItemForCustomer_CustId.Name = "ItemForCustomer_CustId";
            this.ItemForCustomer_CustId.Size = new System.Drawing.Size(290, 52);
            this.ItemForCustomer_CustId.Text = "Customer";
            this.ItemForCustomer_CustId.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForCustomer_CustId.TextSize = new System.Drawing.Size(168, 19);
            // 
            // ServiceViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServicesXtraTabControl);
            this.Size = new System.Drawing.Size(1153, 700);
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesXtraTabControl)).EndInit();
            this.ServicesXtraTabControl.ResumeLayout(false);
            this.EntryXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceItemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceItemridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDetailsMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChargeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServiceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegisterServiceDataLayoutControl)).EndInit();
            this.RegisterServiceDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstDeliveryDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstDeliveryDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_CustIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForServCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEstDeliveryDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomer_CustId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private DevExpress.XtraTab.XtraTabControl ServicesXtraTabControl;
        private DevExpress.XtraTab.XtraTabPage EntryXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage ListXtraTabPage;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl ServiceItemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ServiceItemridView;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Details;
        private DevExpress.XtraGrid.Columns.GridColumn Charge;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit ServiceNameTextEdit;
        private DevExpress.XtraEditors.MemoEdit ServiceDetailsMemoEdit;
        private DevExpress.XtraEditors.TextEdit ChargeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForServiceName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForServiceDetails;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCharge;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl RegisterServiceDataLayoutControl;
        private DevExpress.XtraEditors.TextEdit ServCodeTextEdit;
        private DevExpress.XtraEditors.DateEdit EstDeliveryDateDateEdit;
        private DevExpress.XtraEditors.MemoEdit RemarkMemoEdit;
        private DevExpress.XtraEditors.LookUpEdit Customer_CustIdLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForServCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEstDeliveryDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemark;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomer_CustId;
    }
}
