namespace IslahGroupInventory.ViewControls
{
    partial class ProductsControl
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRPoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProdCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUPLoad = new System.Windows.Forms.Button();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.textBoxUPStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUPDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUPRPoint = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUPSPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxUPCategory = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxUPDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUPName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxUPCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonProductDelete = new System.Windows.Forms.Button();
            this.textBoxDPCode = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProdId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCategory_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReOrderPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch_BranchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAddProduct.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(381, 615);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxAddProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.buttonAddProduct);
            this.groupBoxAddProduct.Controls.Add(this.textBoxStock);
            this.groupBoxAddProduct.Controls.Add(this.label8);
            this.groupBoxAddProduct.Controls.Add(this.textBoxDiscount);
            this.groupBoxAddProduct.Controls.Add(this.label7);
            this.groupBoxAddProduct.Controls.Add(this.textBoxRPoint);
            this.groupBoxAddProduct.Controls.Add(this.label6);
            this.groupBoxAddProduct.Controls.Add(this.textBoxSPrice);
            this.groupBoxAddProduct.Controls.Add(this.label5);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddProduct.Controls.Add(this.label4);
            this.groupBoxAddProduct.Controls.Add(this.textBoxDescription);
            this.groupBoxAddProduct.Controls.Add(this.label3);
            this.groupBoxAddProduct.Controls.Add(this.textBoxName);
            this.groupBoxAddProduct.Controls.Add(this.label2);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProdCode);
            this.groupBoxAddProduct.Controls.Add(this.label1);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(357, 427);
            this.groupBoxAddProduct.TabIndex = 1;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Add Product";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddProduct.Location = new System.Drawing.Point(261, 385);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(90, 36);
            this.buttonAddProduct.TabIndex = 35;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(119, 337);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(232, 26);
            this.textBoxStock.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Stock";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(118, 300);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(232, 26);
            this.textBoxDiscount.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Discount";
            // 
            // textBoxRPoint
            // 
            this.textBoxRPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRPoint.Location = new System.Drawing.Point(118, 264);
            this.textBoxRPoint.Name = "textBoxRPoint";
            this.textBoxRPoint.Size = new System.Drawing.Size(232, 26);
            this.textBoxRPoint.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Reorder Point";
            // 
            // textBoxSPrice
            // 
            this.textBoxSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSPrice.Location = new System.Drawing.Point(118, 229);
            this.textBoxSPrice.Name = "textBoxSPrice";
            this.textBoxSPrice.Size = new System.Drawing.Size(232, 26);
            this.textBoxSPrice.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Selling Price";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DisplayMember = "Name";
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(118, 194);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(232, 28);
            this.comboBoxCategory.TabIndex = 26;
            this.comboBoxCategory.ValueMember = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Category";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(118, 105);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(232, 83);
            this.textBoxDescription.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(118, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(232, 26);
            this.textBoxName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // textBoxProdCode
            // 
            this.textBoxProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdCode.Location = new System.Drawing.Point(118, 41);
            this.textBoxProdCode.Name = "textBoxProdCode";
            this.textBoxProdCode.Size = new System.Drawing.Size(232, 26);
            this.textBoxProdCode.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product Code";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUPLoad);
            this.groupBox1.Controls.Add(this.buttonUpdateProduct);
            this.groupBox1.Controls.Add(this.textBoxUPStock);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxUPDiscount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxUPRPoint);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxUPSPrice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxUPCategory);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxUPDescription);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxUPName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxUPCode);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 451);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Product";
            // 
            // buttonUPLoad
            // 
            this.buttonUPLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUPLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUPLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUPLoad.Location = new System.Drawing.Point(261, 65);
            this.buttonUPLoad.Name = "buttonUPLoad";
            this.buttonUPLoad.Size = new System.Drawing.Size(90, 36);
            this.buttonUPLoad.TabIndex = 37;
            this.buttonUPLoad.Text = "Load";
            this.buttonUPLoad.UseVisualStyleBackColor = true;
            this.buttonUPLoad.Click += new System.EventHandler(this.ButtonUPLoad_Click);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateProduct.Enabled = false;
            this.buttonUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdateProduct.Location = new System.Drawing.Point(261, 404);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(90, 36);
            this.buttonUpdateProduct.TabIndex = 35;
            this.buttonUpdateProduct.Text = "Update";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.ButtonUpdateProduct_Click);
            // 
            // textBoxUPStock
            // 
            this.textBoxUPStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPStock.Enabled = false;
            this.textBoxUPStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPStock.Location = new System.Drawing.Point(119, 372);
            this.textBoxUPStock.Name = "textBoxUPStock";
            this.textBoxUPStock.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPStock.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Stock";
            // 
            // textBoxUPDiscount
            // 
            this.textBoxUPDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPDiscount.Location = new System.Drawing.Point(118, 335);
            this.textBoxUPDiscount.Name = "textBoxUPDiscount";
            this.textBoxUPDiscount.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPDiscount.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Discount";
            // 
            // textBoxUPRPoint
            // 
            this.textBoxUPRPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPRPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPRPoint.Location = new System.Drawing.Point(118, 299);
            this.textBoxUPRPoint.Name = "textBoxUPRPoint";
            this.textBoxUPRPoint.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPRPoint.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Reorder Point";
            // 
            // textBoxUPSPrice
            // 
            this.textBoxUPSPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPSPrice.Location = new System.Drawing.Point(118, 264);
            this.textBoxUPSPrice.Name = "textBoxUPSPrice";
            this.textBoxUPSPrice.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPSPrice.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Selling Price";
            // 
            // comboBoxUPCategory
            // 
            this.comboBoxUPCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUPCategory.DisplayMember = "Name";
            this.comboBoxUPCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUPCategory.FormattingEnabled = true;
            this.comboBoxUPCategory.Location = new System.Drawing.Point(118, 229);
            this.comboBoxUPCategory.Name = "comboBoxUPCategory";
            this.comboBoxUPCategory.Size = new System.Drawing.Size(232, 28);
            this.comboBoxUPCategory.TabIndex = 26;
            this.comboBoxUPCategory.ValueMember = "Name";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Category";
            // 
            // textBoxUPDescription
            // 
            this.textBoxUPDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPDescription.Location = new System.Drawing.Point(118, 140);
            this.textBoxUPDescription.Multiline = true;
            this.textBoxUPDescription.Name = "textBoxUPDescription";
            this.textBoxUPDescription.Size = new System.Drawing.Size(232, 83);
            this.textBoxUPDescription.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Description";
            // 
            // textBoxUPName
            // 
            this.textBoxUPName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPName.Location = new System.Drawing.Point(118, 108);
            this.textBoxUPName.Name = "textBoxUPName";
            this.textBoxUPName.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPName.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(61, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Name";
            // 
            // textBoxUPCode
            // 
            this.textBoxUPCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPCode.Location = new System.Drawing.Point(118, 33);
            this.textBoxUPCode.Name = "textBoxUPCode";
            this.textBoxUPCode.Size = new System.Drawing.Size(232, 26);
            this.textBoxUPCode.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Product Code";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(373, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonProductDelete);
            this.groupBox2.Controls.Add(this.textBoxDPCode);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Product";
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonProductDelete.Location = new System.Drawing.Point(260, 82);
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.Size = new System.Drawing.Size(90, 36);
            this.buttonProductDelete.TabIndex = 38;
            this.buttonProductDelete.Text = "Remove";
            this.buttonProductDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxDPCode
            // 
            this.textBoxDPCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDPCode.Location = new System.Drawing.Point(118, 33);
            this.textBoxDPCode.Name = "textBoxDPCode";
            this.textBoxDPCode.Size = new System.Drawing.Size(232, 26);
            this.textBoxDPCode.TabIndex = 20;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 20);
            this.label24.TabIndex = 19;
            this.label24.Text = "Product Code";
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlProducts.DataSource = this.productsBindingSource;
            this.gridControlProducts.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlProducts.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlProducts.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlProducts.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlProducts.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlProducts.Location = new System.Drawing.Point(386, 3);
            this.gridControlProducts.MainView = this.gridViewProducts;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(887, 614);
            this.gridControlProducts.TabIndex = 3;
            this.gridControlProducts.UseEmbeddedNavigator = true;
            this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(IslahGroupInventory.Product);
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.gridViewProducts.Appearance.Row.Options.UseFont = true;
            this.gridViewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProdId,
            this.colProdCode,
            this.colProdName,
            this.colSubCategory_Name,
            this.colDescription,
            this.colSellingPrice,
            this.colReOrderPoint,
            this.colDiscount,
            this.colStock,
            this.colBranch_BranchId,
            this.colBranch,
            this.colSubCategory});
            this.gridViewProducts.GridControl = this.gridControlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsBehavior.Editable = false;
            this.gridViewProducts.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewProducts.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewProducts.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GridViewProducts_RowStyle);
            // 
            // colProdId
            // 
            this.colProdId.FieldName = "ProdId";
            this.colProdId.Name = "colProdId";
            // 
            // colProdCode
            // 
            this.colProdCode.Caption = "Code";
            this.colProdCode.FieldName = "ProdCode";
            this.colProdCode.Name = "colProdCode";
            this.colProdCode.Visible = true;
            this.colProdCode.VisibleIndex = 0;
            this.colProdCode.Width = 74;
            // 
            // colProdName
            // 
            this.colProdName.Caption = "Name";
            this.colProdName.FieldName = "ProdName";
            this.colProdName.Name = "colProdName";
            this.colProdName.Visible = true;
            this.colProdName.VisibleIndex = 1;
            this.colProdName.Width = 116;
            // 
            // colSubCategory_Name
            // 
            this.colSubCategory_Name.Caption = "Category";
            this.colSubCategory_Name.FieldName = "SubCategory_Name";
            this.colSubCategory_Name.Name = "colSubCategory_Name";
            this.colSubCategory_Name.Visible = true;
            this.colSubCategory_Name.VisibleIndex = 2;
            this.colSubCategory_Name.Width = 64;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 184;
            // 
            // colSellingPrice
            // 
            this.colSellingPrice.Caption = "Selling Price";
            this.colSellingPrice.FieldName = "SellingPrice";
            this.colSellingPrice.Name = "colSellingPrice";
            this.colSellingPrice.Visible = true;
            this.colSellingPrice.VisibleIndex = 4;
            this.colSellingPrice.Width = 67;
            // 
            // colReOrderPoint
            // 
            this.colReOrderPoint.Caption = "Re-Order Point";
            this.colReOrderPoint.FieldName = "ReOrderPoint";
            this.colReOrderPoint.Name = "colReOrderPoint";
            this.colReOrderPoint.Visible = true;
            this.colReOrderPoint.VisibleIndex = 5;
            this.colReOrderPoint.Width = 66;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "Discount";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 6;
            this.colDiscount.Width = 70;
            // 
            // colStock
            // 
            this.colStock.Caption = "Stock";
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 7;
            this.colStock.Width = 51;
            // 
            // colBranch_BranchId
            // 
            this.colBranch_BranchId.FieldName = "Branch_BranchId";
            this.colBranch_BranchId.Name = "colBranch_BranchId";
            this.colBranch_BranchId.Width = 67;
            // 
            // colBranch
            // 
            this.colBranch.FieldName = "Branch";
            this.colBranch.Name = "colBranch";
            // 
            // colSubCategory
            // 
            this.colSubCategory.FieldName = "SubCategory";
            this.colSubCategory.Name = "colSubCategory";
            // 
            // ProductsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gridControlProducts);
            this.Controls.Add(this.tabControl2);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(1276, 622);
            this.Load += new System.EventHandler(this.ProductsControl_Load);
            this.VisibleChanged += new System.EventHandler(this.ProductsControl_VisibleChanged);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProdCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUPLoad;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.TextBox textBoxUPStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUPDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUPRPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxUPSPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxUPCategory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxUPDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUPName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxUPCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonProductDelete;
        private System.Windows.Forms.TextBox textBoxDPCode;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraGrid.GridControl gridControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colProdId;
        private DevExpress.XtraGrid.Columns.GridColumn colProdCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProdName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCategory_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colReOrderPoint;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch_BranchId;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCategory;
        private System.Windows.Forms.BindingSource productsBindingSource;
    }
}
