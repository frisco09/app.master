namespace app.master.View.Products
{
    partial class ItemListControl
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
            this.pnlFooterLine = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxImageProduct = new System.Windows.Forms.PictureBox();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageProduct)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooterLine
            // 
            this.pnlFooterLine.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlFooterLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterLine.Location = new System.Drawing.Point(0, 96);
            this.pnlFooterLine.Name = "pnlFooterLine";
            this.pnlFooterLine.Size = new System.Drawing.Size(839, 10);
            this.pnlFooterLine.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pbxImageProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 96);
            this.panel1.TabIndex = 2;
            // 
            // pbxImageProduct
            // 
            this.pbxImageProduct.Location = new System.Drawing.Point(3, 3);
            this.pbxImageProduct.Name = "pbxImageProduct";
            this.pbxImageProduct.Size = new System.Drawing.Size(105, 90);
            this.pbxImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImageProduct.TabIndex = 0;
            this.pbxImageProduct.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Depth = 0;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(111, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(728, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblProductPrice);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(684, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(155, 67);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProductPrice.Location = new System.Drawing.Point(3, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(149, 67);
            this.lblProductPrice.TabIndex = 0;
            this.lblProductPrice.Text = "$0000";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProductName.Location = new System.Drawing.Point(117, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(61, 25);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(117, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stock disponible:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(117, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categoria: ";
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblProductStock.Location = new System.Drawing.Point(268, 46);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(70, 21);
            this.lblProductStock.TabIndex = 14;
            this.lblProductStock.Text = "NNNNN";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCategories.Location = new System.Drawing.Point(214, 71);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(70, 21);
            this.lblCategories.TabIndex = 15;
            this.lblCategories.Text = "NNNNN";
            // 
            // ItemListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFooterLine);
            this.Name = "ItemListControl";
            this.Size = new System.Drawing.Size(839, 106);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageProduct)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooterLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxImageProduct;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.Label lblCategories;
    }
}
