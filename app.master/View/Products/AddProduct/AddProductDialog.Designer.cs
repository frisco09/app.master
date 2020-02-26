namespace app.master.View.Products.AddProduct
{
    partial class AddProductDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductDialog));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnFoward = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbObservation = new System.Windows.Forms.RichTextBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.txbCodeProduct = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtAsSale = new System.Windows.Forms.RadioButton();
            this.rbtAsInput = new System.Windows.Forms.RadioButton();
            this.txbNameProduct = new System.Windows.Forms.MaskedTextBox();
            this.lblAddImage = new System.Windows.Forms.Label();
            this.pbImageProduct = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudProductPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantityUnit = new System.Windows.Forms.NumericUpDown();
            this.nudUnitStock = new System.Windows.Forms.NumericUpDown();
            this.nudUnitOrder = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.errorProviderProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxIsActive = new System.Windows.Forms.CheckBox();
            this.pnlTop.SuspendLayout();
            this.gbxData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitOrder)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Purple;
            this.pnlTop.Controls.Add(this.btnFoward);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(860, 35);
            this.pnlTop.TabIndex = 2;
            // 
            // btnFoward
            // 
            this.btnFoward.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFoward.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnFoward.FlatAppearance.BorderSize = 0;
            this.btnFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoward.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoward.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFoward.Image = global::app.master.Properties.Resources.Reply_Arrow_32;
            this.btnFoward.Location = new System.Drawing.Point(0, 0);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(53, 35);
            this.btnFoward.TabIndex = 9;
            this.btnFoward.UseVisualStyleBackColor = false;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar un nuevo Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxData
            // 
            this.gbxData.BackColor = System.Drawing.Color.Gainsboro;
            this.gbxData.Controls.Add(this.panel1);
            this.gbxData.Controls.Add(this.lblAddImage);
            this.gbxData.Controls.Add(this.pbImageProduct);
            this.gbxData.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxData.Location = new System.Drawing.Point(8, 41);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(842, 270);
            this.gbxData.TabIndex = 8;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "Informacion del Producto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbObservation);
            this.panel1.Controls.Add(this.cbxCategories);
            this.panel1.Controls.Add(this.txbCodeProduct);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txbNameProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 238);
            this.panel1.TabIndex = 9;
            // 
            // txbObservation
            // 
            this.txbObservation.BackColor = System.Drawing.Color.Lavender;
            this.txbObservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbObservation.Location = new System.Drawing.Point(3, 79);
            this.txbObservation.MaxLength = 200;
            this.txbObservation.Name = "txbObservation";
            this.txbObservation.Size = new System.Drawing.Size(563, 66);
            this.txbObservation.TabIndex = 12;
            this.txbObservation.Text = "";
            this.txbObservation.Enter += new System.EventHandler(this.txbObservation_Enter);
            this.txbObservation.Leave += new System.EventHandler(this.txbObservation_Leave);
            // 
            // cbxCategories
            // 
            this.cbxCategories.BackColor = System.Drawing.Color.Lavender;
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(3, 151);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(563, 33);
            this.cbxCategories.TabIndex = 3;
            // 
            // txbCodeProduct
            // 
            this.txbCodeProduct.BackColor = System.Drawing.Color.Lavender;
            this.txbCodeProduct.ForeColor = System.Drawing.Color.Gray;
            this.txbCodeProduct.Location = new System.Drawing.Point(3, 42);
            this.txbCodeProduct.Name = "txbCodeProduct";
            this.txbCodeProduct.Size = new System.Drawing.Size(563, 33);
            this.txbCodeProduct.TabIndex = 6;
            this.txbCodeProduct.Enter += new System.EventHandler(this.txbCodeProduct_Enter);
            this.txbCodeProduct.Leave += new System.EventHandler(this.txbCodeProduct_Leave);
            this.txbCodeProduct.Validating += new System.ComponentModel.CancelEventHandler(this.txbCodeProduct_Validating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rbtAsSale);
            this.panel2.Controls.Add(this.rbtAsInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 47);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "*tipo de producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbtAsSale
            // 
            this.rbtAsSale.AutoSize = true;
            this.rbtAsSale.Location = new System.Drawing.Point(180, 15);
            this.rbtAsSale.Name = "rbtAsSale";
            this.rbtAsSale.Size = new System.Drawing.Size(87, 29);
            this.rbtAsSale.TabIndex = 12;
            this.rbtAsSale.TabStop = true;
            this.rbtAsSale.Text = "VENTA";
            this.rbtAsSale.UseVisualStyleBackColor = true;
            this.rbtAsSale.Validating += new System.ComponentModel.CancelEventHandler(this.rbtAsSale_Validating);
            // 
            // rbtAsInput
            // 
            this.rbtAsInput.AutoSize = true;
            this.rbtAsInput.Location = new System.Drawing.Point(334, 15);
            this.rbtAsInput.Name = "rbtAsInput";
            this.rbtAsInput.Size = new System.Drawing.Size(103, 29);
            this.rbtAsInput.TabIndex = 11;
            this.rbtAsInput.TabStop = true;
            this.rbtAsInput.Text = "INSUMO";
            this.rbtAsInput.UseVisualStyleBackColor = true;
            this.rbtAsInput.Validating += new System.ComponentModel.CancelEventHandler(this.rbtAsInput_Validating);
            // 
            // txbNameProduct
            // 
            this.txbNameProduct.BackColor = System.Drawing.Color.Lavender;
            this.txbNameProduct.ForeColor = System.Drawing.Color.Gray;
            this.txbNameProduct.Location = new System.Drawing.Point(3, 3);
            this.txbNameProduct.Name = "txbNameProduct";
            this.txbNameProduct.Size = new System.Drawing.Size(563, 33);
            this.txbNameProduct.TabIndex = 5;
            this.txbNameProduct.Enter += new System.EventHandler(this.txbNameProduct_Enter);
            this.txbNameProduct.Leave += new System.EventHandler(this.txbNameProduct_Leave);
            this.txbNameProduct.Validating += new System.ComponentModel.CancelEventHandler(this.txbNameProduct_Validating);
            // 
            // lblAddImage
            // 
            this.lblAddImage.AutoSize = true;
            this.lblAddImage.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddImage.Location = new System.Drawing.Point(603, 220);
            this.lblAddImage.Name = "lblAddImage";
            this.lblAddImage.Size = new System.Drawing.Size(233, 17);
            this.lblAddImage.TabIndex = 8;
            this.lblAddImage.Text = "*click para agregar imagen del producto";
            // 
            // pbImageProduct
            // 
            this.pbImageProduct.Image = global::app.master.Properties.Resources.default_product;
            this.pbImageProduct.Location = new System.Drawing.Point(600, 29);
            this.pbImageProduct.Name = "pbImageProduct";
            this.pbImageProduct.Size = new System.Drawing.Size(236, 188);
            this.pbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageProduct.TabIndex = 7;
            this.pbImageProduct.TabStop = false;
            this.pbImageProduct.Click += new System.EventHandler(this.pbImageProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.cbxIsActive);
            this.groupBox2.Controls.Add(this.nudProductPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudQuantityUnit);
            this.groupBox2.Controls.Add(this.nudUnitStock);
            this.groupBox2.Controls.Add(this.nudUnitOrder);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 155);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock y facturacion";
            // 
            // nudProductPrice
            // 
            this.nudProductPrice.BackColor = System.Drawing.Color.Lavender;
            this.nudProductPrice.DecimalPlaces = 2;
            this.nudProductPrice.Location = new System.Drawing.Point(551, 33);
            this.nudProductPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudProductPrice.Name = "nudProductPrice";
            this.nudProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudProductPrice.Size = new System.Drawing.Size(285, 33);
            this.nudProductPrice.TabIndex = 18;
            this.nudProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProductPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label3
            // 
            this.label3.Image = global::app.master.Properties.Resources.purple_currency_32;
            this.label3.Location = new System.Drawing.Point(514, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 33);
            this.label3.TabIndex = 17;
            // 
            // nudQuantityUnit
            // 
            this.nudQuantityUnit.BackColor = System.Drawing.Color.Lavender;
            this.nudQuantityUnit.Location = new System.Drawing.Point(164, 70);
            this.nudQuantityUnit.Name = "nudQuantityUnit";
            this.nudQuantityUnit.Size = new System.Drawing.Size(152, 33);
            this.nudQuantityUnit.TabIndex = 13;
            this.nudQuantityUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantityUnit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nudUnitStock
            // 
            this.nudUnitStock.BackColor = System.Drawing.Color.Lavender;
            this.nudUnitStock.Location = new System.Drawing.Point(164, 31);
            this.nudUnitStock.Name = "nudUnitStock";
            this.nudUnitStock.Size = new System.Drawing.Size(152, 33);
            this.nudUnitStock.TabIndex = 12;
            this.nudUnitStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudUnitStock.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nudUnitOrder
            // 
            this.nudUnitOrder.BackColor = System.Drawing.Color.Lavender;
            this.nudUnitOrder.Location = new System.Drawing.Point(164, 109);
            this.nudUnitOrder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUnitOrder.Name = "nudUnitOrder";
            this.nudUnitOrder.Size = new System.Drawing.Size(152, 33);
            this.nudUnitOrder.TabIndex = 10;
            this.nudUnitOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudUnitOrder.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.75F);
            this.label8.Location = new System.Drawing.Point(0, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "unidades por orden:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(0, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "unidades en stock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(629, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 30);
            this.label10.TabIndex = 5;
            this.label10.Text = "precio unitario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.75F);
            this.label11.Location = new System.Drawing.Point(0, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "cantidad por unidad:";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.flowLayoutPanel1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 478);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(860, 82);
            this.pnlFooter.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.flowLayoutPanel1.Controls.Add(this.btnAddProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(860, 82);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Lavender;
            this.btnAddProduct.Image = global::app.master.Properties.Resources.Ok_48;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(857, 76);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "AGREGAR";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // errorProviderProduct
            // 
            this.errorProviderProduct.ContainerControl = this;
            this.errorProviderProduct.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderProduct.Icon")));
            // 
            // cbxIsActive
            // 
            this.cbxIsActive.AutoSize = true;
            this.cbxIsActive.Checked = true;
            this.cbxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIsActive.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11.75F);
            this.cbxIsActive.Location = new System.Drawing.Point(629, 78);
            this.cbxIsActive.Name = "cbxIsActive";
            this.cbxIsActive.Size = new System.Drawing.Size(153, 25);
            this.cbxIsActive.TabIndex = 19;
            this.cbxIsActive.Text = "Habilitar Producto";
            this.cbxIsActive.UseVisualStyleBackColor = true;
            this.cbxIsActive.CheckedChanged += new System.EventHandler(this.cbxIsActive_CheckedChanged);
            // 
            // AddProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxData);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddProductDialog_Load);
            this.pnlTop.ResumeLayout(false);
            this.gbxData.ResumeLayout(false);
            this.gbxData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitOrder)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label lblAddImage;
        private System.Windows.Forms.PictureBox pbImageProduct;
        private System.Windows.Forms.MaskedTextBox txbCodeProduct;
        private System.Windows.Forms.MaskedTextBox txbNameProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantityUnit;
        private System.Windows.Forms.NumericUpDown nudUnitStock;
        private System.Windows.Forms.NumericUpDown nudUnitOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnFoward;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtAsSale;
        private System.Windows.Forms.RadioButton rbtAsInput;
        private System.Windows.Forms.RichTextBox txbObservation;
        private System.Windows.Forms.ErrorProvider errorProviderProduct;
        private System.Windows.Forms.CheckBox cbxIsActive;
    }
}