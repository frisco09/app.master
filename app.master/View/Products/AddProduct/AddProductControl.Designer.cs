namespace app.master.View.Products.AddProduct
{
    partial class AddProductControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txbNameProduct = new System.Windows.Forms.MaskedTextBox();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.lblAddImage = new System.Windows.Forms.Label();
            this.pbImageProduct = new System.Windows.Forms.PictureBox();
            this.txbCodeProduct = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantityUnit = new System.Windows.Forms.NumericUpDown();
            this.nudUnitStock = new System.Windows.Forms.NumericUpDown();
            this.nudUnitOrder = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelControl = new System.Windows.Forms.Button();
            this.nudProductPrice = new System.Windows.Forms.NumericUpDown();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            this.gbxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitOrder)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
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
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Purple;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(860, 35);
            this.pnlTop.TabIndex = 1;
            // 
            // txbNameProduct
            // 
            this.txbNameProduct.BackColor = System.Drawing.Color.Lavender;
            this.txbNameProduct.Location = new System.Drawing.Point(6, 32);
            this.txbNameProduct.Name = "txbNameProduct";
            this.txbNameProduct.Size = new System.Drawing.Size(594, 33);
            this.txbNameProduct.TabIndex = 5;
            this.txbNameProduct.Enter += new System.EventHandler(this.txbNameProduct_Enter);
            this.txbNameProduct.Leave += new System.EventHandler(this.txbNameProduct_Leave);
            // 
            // gbxData
            // 
            this.gbxData.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbxData.Controls.Add(this.cbxCategories);
            this.gbxData.Controls.Add(this.lblAddImage);
            this.gbxData.Controls.Add(this.pbImageProduct);
            this.gbxData.Controls.Add(this.txbCodeProduct);
            this.gbxData.Controls.Add(this.txbNameProduct);
            this.gbxData.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxData.Location = new System.Drawing.Point(7, 41);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(842, 237);
            this.gbxData.TabIndex = 7;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "Informacion del Producto";
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
            this.txbCodeProduct.Location = new System.Drawing.Point(6, 71);
            this.txbCodeProduct.Name = "txbCodeProduct";
            this.txbCodeProduct.Size = new System.Drawing.Size(594, 33);
            this.txbCodeProduct.TabIndex = 6;
            this.txbCodeProduct.Enter += new System.EventHandler(this.txbCodeProduct_Enter);
            this.txbCodeProduct.Leave += new System.EventHandler(this.txbCodeProduct_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudProductPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudQuantityUnit);
            this.groupBox1.Controls.Add(this.nudUnitStock);
            this.groupBox1.Controls.Add(this.nudUnitOrder);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock y facturacion";
            // 
            // label2
            // 
            this.label2.Image = global::app.master.Properties.Resources.purple_currency_32;
            this.label2.Location = new System.Drawing.Point(531, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 33);
            this.label2.TabIndex = 17;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.75F);
            this.label7.Location = new System.Drawing.Point(0, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "unidades por orden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(0, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "unidades en stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(629, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "precio unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.75F);
            this.label4.Location = new System.Drawing.Point(0, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "cantidad por unidad:";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.flowLayoutPanel1);
            this.pnlFooter.Controls.Add(this.panel1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 479);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(860, 82);
            this.pnlFooter.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Purple;
            this.flowLayoutPanel1.Controls.Add(this.btnAddProduct);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(430, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(430, 82);
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
            this.btnAddProduct.Size = new System.Drawing.Size(424, 76);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "AGREGAR";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnCancelControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelControl
            // 
            this.btnCancelControl.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelControl.FlatAppearance.BorderSize = 0;
            this.btnCancelControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelControl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelControl.ForeColor = System.Drawing.Color.Lavender;
            this.btnCancelControl.Image = global::app.master.Properties.Resources._Back_Arrow_48;
            this.btnCancelControl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelControl.Location = new System.Drawing.Point(3, 3);
            this.btnCancelControl.Name = "btnCancelControl";
            this.btnCancelControl.Size = new System.Drawing.Size(424, 76);
            this.btnCancelControl.TabIndex = 9;
            this.btnCancelControl.Text = "CANCELAR";
            this.btnCancelControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelControl.UseVisualStyleBackColor = false;
            this.btnCancelControl.Click += new System.EventHandler(this.btnCancelControl_Click);
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
            // cbxCategories
            // 
            this.cbxCategories.BackColor = System.Drawing.Color.Lavender;
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(7, 110);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(593, 33);
            this.cbxCategories.TabIndex = 3;
            // 
            // AddProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxData);
            this.Controls.Add(this.pnlTop);
            this.Name = "AddProductControl";
            this.Size = new System.Drawing.Size(860, 561);
            this.Load += new System.EventHandler(this.AddProductControl_Load);
            this.pnlTop.ResumeLayout(false);
            this.gbxData.ResumeLayout(false);
            this.gbxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitOrder)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.MaskedTextBox txbNameProduct;
        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.MaskedTextBox txbCodeProduct;
        private System.Windows.Forms.PictureBox pbImageProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudQuantityUnit;
        private System.Windows.Forms.NumericUpDown nudUnitStock;
        private System.Windows.Forms.NumericUpDown nudUnitOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddImage;
        private System.Windows.Forms.Button btnCancelControl;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudProductPrice;
        private System.Windows.Forms.ComboBox cbxCategories;
    }
}
