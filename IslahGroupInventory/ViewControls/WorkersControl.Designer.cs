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
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.label87 = new System.Windows.Forms.Label();
            this.gridControlWorker = new DevExpress.XtraGrid.GridControl();
            this.gridViewWorker = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorker)).BeginInit();
            this.groupBox27.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.label87);
            this.groupBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox28.Location = new System.Drawing.Point(7, 14);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(379, 148);
            this.groupBox28.TabIndex = 9;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Total Worker";
            // 
            // label87
            // 
            this.label87.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(3, 25);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(373, 120);
            this.label87.TabIndex = 0;
            this.label87.Text = "00";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControlWorker
            // 
            this.gridControlWorker.Location = new System.Drawing.Point(392, 3);
            this.gridControlWorker.MainView = this.gridViewWorker;
            this.gridControlWorker.Name = "gridControlWorker";
            this.gridControlWorker.Size = new System.Drawing.Size(881, 616);
            this.gridControlWorker.TabIndex = 8;
            this.gridControlWorker.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWorker});
            // 
            // gridViewWorker
            // 
            this.gridViewWorker.GridControl = this.gridControlWorker;
            this.gridViewWorker.Name = "gridViewWorker";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.button14);
            this.groupBox27.Controls.Add(this.checkBox1);
            this.groupBox27.Controls.Add(this.textBox18);
            this.groupBox27.Controls.Add(this.label86);
            this.groupBox27.Controls.Add(this.textBox17);
            this.groupBox27.Controls.Add(this.label81);
            this.groupBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox27.Location = new System.Drawing.Point(7, 168);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(379, 202);
            this.groupBox27.TabIndex = 7;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Add Worker";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(259, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(105, 35);
            this.button14.TabIndex = 28;
            this.button14.Text = "Add";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(110, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 28);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(110, 74);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(254, 26);
            this.textBox18.TabIndex = 26;
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
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(110, 42);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(254, 26);
            this.textBox17.TabIndex = 24;
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
            this.Size = new System.Drawing.Size(1276, 622);
            this.groupBox28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorker)).EndInit();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.Label label87;
        private DevExpress.XtraGrid.GridControl gridControlWorker;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWorker;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label81;
    }
}
