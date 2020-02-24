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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductDialog));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnFoward = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblAddImage = new System.Windows.Forms.Label();
            this.pbImageProduct = new System.Windows.Forms.PictureBox();
            this.txbCodeProduct = new System.Windows.Forms.MaskedTextBox();
            this.txbNameProduct = new System.Windows.Forms.MaskedTextBox();
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
            this.cbxAsInput = new System.Windows.Forms.CheckBox();
            this.cbxAsSele = new System.Windows.Forms.CheckBox();
            this.txbObservation = new System.Windows.Forms.MaskedTextBox();
            this.pnlTop.SuspendLayout();
            this.gbxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitOrder)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.gbxData.Controls.Add(this.txbObservation);
            this.gbxData.Controls.Add(this.cbxAsSele);
            this.gbxData.Controls.Add(this.cbxAsInput);
            this.gbxData.Controls.Add(this.cbxCategories);
            this.gbxData.Controls.Add(this.lblAddImage);
            this.gbxData.Controls.Add(this.pbImageProduct);
            this.gbxData.Controls.Add(this.txbCodeProduct);
            this.gbxData.Controls.Add(this.txbNameProduct);
            this.gbxData.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxData.Location = new System.Drawing.Point(8, 41);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(842, 237);
            this.gbxData.TabIndex = 8;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "Informacion del Producto";
            // 
            // cbxCategories
            // 
            this.cbxCategories.BackColor = System.Drawing.Color.Lavender;
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(7, 156);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(593, 33);
            this.cbxCategories.TabIndex = 3;
            // 
            // lblAddImage
            // 
            this.lblAddImage.AutoSize = true;
            this.lblAddImage.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddImage.Location = new System.Drawing.Point(603, 207);
            this.lblAddImage.Name = "lblAddImage";
            this.lblAddImage.Size = new System.Drawing.Size(233, 17);
            this.lblAddImage.TabIndex = 8;
            this.lblAddImage.Text = "*click para agregar imagen del producto";
            // 
            // pbImageProduct
            // 
            this.pbImageProduct.Image = global::app.master.Properties.Resources.default_product;
            this.pbImageProduct.Location = new System.Drawing.Point(606, 23);
            this.pbImageProduct.Name = "pbImageProduct";
            this.pbImageProduct.Size = new System.Drawing.Size(230, 181);
            this.pbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageProduct.TabIndex = 7;
            this.pbImageProduct.TabStop = false;
            // 
            // txbCodeProduct
            // 
            this.txbCodeProduct.BackColor = System.Drawing.Color.Lavender;
            this.txbCodeProduct.ForeColor = System.Drawing.Color.Gray;
            this.txbCodeProduct.Location = new System.Drawing.Point(6, 71);
            this.txbCodeProduct.Name = "txbCodeProduct";
            this.txbCodeProduct.Size = new System.Drawing.Size(594, 33);
            this.txbCodeProduct.TabIndex = 6;
            this.txbCodeProduct.Enter += new System.EventHandler(this.txbCodeProduct_Enter);
            this.txbCodeProduct.Leave += new System.EventHandler(this.txbCodeProduct_Leave);
            // 
            // txbNameProduct
            // 
            this.txbNameProduct.BackColor = System.Drawing.Color.Lavender;
            this.txbNameProduct.ForeColor = System.Drawing.Color.Gray;
            this.txbNameProduct.Location = new System.Drawing.Point(6, 32);
            this.txbNameProduct.Name = "txbNameProduct";
            this.txbNameProduct.Size = new System.Drawing.Size(594, 33);
            this.txbNameProduct.TabIndex = 5;
            this.txbNameProduct.Enter += new System.EventHandler(this.txbNameProduct_Enter);
            this.txbNameProduct.Leave += new System.EventHandler(this.txbNameProduct_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
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
            this.groupBox2.Location = new System.Drawing.Point(8, 284);
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
            this.nudProductPrice.Location = new System.Drawing.Point(568, 107);
            this.nudProductPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudProductPrice.Name = "nudProductPrice";
            this.nudProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudProductPrice.Size = new System.Drawing.Size(268, 33);
            this.nudProductPrice.TabIndex = 18;
            this.nudProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProductPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label3
            // 
            this.label3.Image = global::app.master.Properties.Resources.purple_currency_32;
            this.label3.Location = new System.Drawing.Point(531, 108);
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
            this.label10.Location = new System.Drawing.Point(629, 68);
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
            // cbxAsInput
            // 
            this.cbxAsInput.AutoSize = true;
            this.cbxAsInput.Location = new System.Drawing.Point(153, 195);
            this.cbxAsInput.Name = "cbxAsInput";
            this.cbxAsInput.Size = new System.Drawing.Size(129, 29);
            this.cbxAsInput.TabIndex = 9;
            this.cbxAsInput.Text = "ES INSUMO";
            this.cbxAsInput.UseVisualStyleBackColor = true;
            // 
            // cbxAsSele
            // 
            this.cbxAsSele.AutoSize = true;
            this.cbxAsSele.Location = new System.Drawing.Point(288, 195);
            this.cbxAsSele.Name = "cbxAsSele";
            this.cbxAsSele.Size = new System.Drawing.Size(141, 29);
            this.cbxAsSele.TabIndex = 10;
            this.cbxAsSele.Text = "ES DE VENTA";
            this.cbxAsSele.UseVisualStyleBackColor = true;
            // 
            // txbObservation
            // 
            this.txbObservation.BackColor = System.Drawing.Color.Lavender;
            this.txbObservation.ForeColor = System.Drawing.Color.Gray;
            this.txbObservation.Location = new System.Drawing.Point(6, 117);
            this.txbObservation.Name = "txbObservation";
            this.txbObservation.Size = new System.Drawing.Size(594, 33);
            this.txbObservation.TabIndex = 11;
            this.txbObservation.Enter += new System.EventHandler(this.txbObservation_Enter);
            this.txbObservation.Leave += new System.EventHandler(this.txbObservation_Leave);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitOrder)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.MaskedTextBox txbObservation;
        private System.Windows.Forms.CheckBox cbxAsSele;
        private System.Windows.Forms.CheckBox cbxAsInput;
    }
}