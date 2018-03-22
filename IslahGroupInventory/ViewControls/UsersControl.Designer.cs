namespace IslahGroupInventory.ViewControls
{
    partial class UsersControl
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
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.label88 = new System.Windows.Forms.Label();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.iGUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserType_UsrType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.textBoxConfPass = new System.Windows.Forms.TextBox();
            this.label96 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label95 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.bindingSourceUsertype = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iGUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsertype)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.label88);
            this.groupBox29.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox29.Location = new System.Drawing.Point(8, 8);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(358, 143);
            this.groupBox29.TabIndex = 12;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Total User";
            // 
            // label88
            // 
            this.label88.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(3, 29);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(352, 111);
            this.label88.TabIndex = 0;
            this.label88.Text = "00";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlUsers.DataSource = this.iGUsersBindingSource;
            this.gridControlUsers.Location = new System.Drawing.Point(376, 8);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(892, 606);
            this.gridControlUsers.TabIndex = 11;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // iGUsersBindingSource
            // 
            this.iGUsersBindingSource.DataSource = typeof(IslahGroupInventory.IGUser);
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserId,
            this.colAName,
            this.colEmail,
            this.colAUsername,
            this.colAPassword,
            this.colStatus,
            this.colUserType_UsrType,
            this.colBranch_BranchId,
            this.colBranch,
            this.colUserType});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            // 
            // colAName
            // 
            this.colAName.Caption = "Name";
            this.colAName.FieldName = "AName";
            this.colAName.Name = "colAName";
            this.colAName.Visible = true;
            this.colAName.VisibleIndex = 0;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 1;
            // 
            // colAUsername
            // 
            this.colAUsername.Caption = "Username";
            this.colAUsername.FieldName = "AUsername";
            this.colAUsername.Name = "colAUsername";
            this.colAUsername.Visible = true;
            this.colAUsername.VisibleIndex = 2;
            // 
            // colAPassword
            // 
            this.colAPassword.Caption = "Password";
            this.colAPassword.FieldName = "APassword";
            this.colAPassword.Name = "colAPassword";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // colUserType_UsrType
            // 
            this.colUserType_UsrType.Caption = "Type";
            this.colUserType_UsrType.FieldName = "UserType_UsrType";
            this.colUserType_UsrType.Name = "colUserType_UsrType";
            this.colUserType_UsrType.Visible = true;
            this.colUserType_UsrType.VisibleIndex = 4;
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
            // colUserType
            // 
            this.colUserType.FieldName = "UserType";
            this.colUserType.Name = "colUserType";
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.comboBoxStatus);
            this.groupBox30.Controls.Add(this.label2);
            this.groupBox30.Controls.Add(this.comboBoxUserType);
            this.groupBox30.Controls.Add(this.label1);
            this.groupBox30.Controls.Add(this.textBoxConfPass);
            this.groupBox30.Controls.Add(this.label96);
            this.groupBox30.Controls.Add(this.textBoxPass);
            this.groupBox30.Controls.Add(this.label95);
            this.groupBox30.Controls.Add(this.textBoxUsername);
            this.groupBox30.Controls.Add(this.label93);
            this.groupBox30.Controls.Add(this.buttonRegisterUser);
            this.groupBox30.Controls.Add(this.textBoxEmail);
            this.groupBox30.Controls.Add(this.label89);
            this.groupBox30.Controls.Add(this.textBoxFullName);
            this.groupBox30.Controls.Add(this.label91);
            this.groupBox30.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox30.Location = new System.Drawing.Point(8, 157);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(362, 351);
            this.groupBox30.TabIndex = 10;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Add User";
            // 
            // textBoxConfPass
            // 
            this.textBoxConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfPass.Location = new System.Drawing.Point(135, 170);
            this.textBoxConfPass.Name = "textBoxConfPass";
            this.textBoxConfPass.PasswordChar = '*';
            this.textBoxConfPass.Size = new System.Drawing.Size(221, 26);
            this.textBoxConfPass.TabIndex = 34;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(9, 173);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(120, 20);
            this.label96.TabIndex = 33;
            this.label96.Text = "Conf. Password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(135, 138);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(221, 26);
            this.textBoxPass.TabIndex = 32;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(51, 141);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(78, 20);
            this.label95.TabIndex = 31;
            this.label95.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(135, 106);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(221, 26);
            this.textBoxUsername.TabIndex = 30;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(46, 109);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(83, 20);
            this.label93.TabIndex = 29;
            this.label93.Text = "Username";
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Location = new System.Drawing.Point(251, 310);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(105, 35);
            this.buttonRegisterUser.TabIndex = 28;
            this.buttonRegisterUser.Text = "Register";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            this.buttonRegisterUser.Click += new System.EventHandler(this.ButtonRegisterUser_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(135, 74);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(221, 26);
            this.textBoxEmail.TabIndex = 26;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(81, 77);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(48, 20);
            this.label89.TabIndex = 25;
            this.label89.Text = "Email";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(135, 42);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(221, 26);
            this.textBoxFullName.TabIndex = 24;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(78, 45);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(51, 20);
            this.label91.TabIndex = 23;
            this.label91.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "User Type";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.DataSource = this.bindingSourceUsertype;
            this.comboBoxUserType.DisplayMember = "UsrType";
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Location = new System.Drawing.Point(135, 203);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(220, 33);
            this.comboBoxUserType.TabIndex = 36;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "ACT",
            "SUS",
            "HLT"});
            this.comboBoxStatus.Location = new System.Drawing.Point(135, 242);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(220, 33);
            this.comboBoxStatus.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Status";
            // 
            // UsersControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox29);
            this.Controls.Add(this.gridControlUsers);
            this.Controls.Add(this.groupBox30);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UsersControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.UsersControl_Load);
            this.groupBox29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iGUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsertype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.Label label88;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.TextBox textBoxConfPass;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.BindingSource iGUsersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colAName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colAPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colUserType_UsrType;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colUserType;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceUsertype;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label2;
    }
}
