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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProductPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductStock = new MaterialSkin.Controls.MaterialLabel();
            this.lblCategories = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageProduct)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooterLine
            // 
            this.pnlFooterLine.BackColor = System.Drawing.Color.LightGreen;
            this.pnlFooterLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterLine.Location = new System.Drawing.Point(0, 96);
            this.pnlFooterLine.Name = "pnlFooterLine";
            this.pnlFooterLine.Size = new System.Drawing.Size(839, 10);
            this.pnlFooterLine.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.lblTitle.Text = "Nombre del Producto";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(111, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Stock disponible:";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(157, 52);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Categoria: ";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblProductPrice.Depth = 0;
            this.lblProductPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductPrice.Location = new System.Drawing.Point(3, 0);
            this.lblProductPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(149, 64);
            this.lblProductPrice.TabIndex = 0;
            this.lblProductPrice.Text = "$nn.nn";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.BackColor = System.Drawing.Color.Transparent;
            this.lblProductStock.Depth = 0;
            this.lblProductStock.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductStock.Location = new System.Drawing.Point(242, 32);
            this.lblProductStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(49, 19);
            this.lblProductStock.TabIndex = 9;
            this.lblProductStock.Text = "nnnnn";
            this.lblProductStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.Depth = 0;
            this.lblCategories.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategories.Location = new System.Drawing.Point(242, 52);
            this.lblCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(49, 19);
            this.lblCategories.TabIndex = 10;
            this.lblCategories.Text = "nnnnn";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.DimGray;
            this.lblProductName.Location = new System.Drawing.Point(281, 3);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(61, 25);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "label1";
            // 
            // ItemListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblProductPrice;
        private MaterialSkin.Controls.MaterialLabel lblProductStock;
        private MaterialSkin.Controls.MaterialLabel lblCategories;
        private System.Windows.Forms.Label lblProductName;
    }
}
