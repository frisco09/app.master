namespace app.master
{
    partial class frmContent
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContent));
            this.drawer = new System.Windows.Forms.Panel();
            this.btnAboutThis = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAdmin = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMasterDetail = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnProducts = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOrder = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conten = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.orderControl1 = new app.master.View.Orders.OrderControl();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnShutdown = new MaterialSkin.Controls.MaterialFlatButton();
            this.productControl1 = new app.master.View.Products.ProductControl();
            this.productControl2 = new app.master.View.Products.ProductControl();
            this.productControl3 = new app.master.View.Products.ProductControl();
            this.productControl4 = new app.master.View.Products.ProductControl();
            this.drawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.conten.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawer
            // 
            this.drawer.Controls.Add(this.btnAboutThis);
            this.drawer.Controls.Add(this.btnAdmin);
            this.drawer.Controls.Add(this.btnMasterDetail);
            this.drawer.Controls.Add(this.btnProducts);
            this.drawer.Controls.Add(this.btnOrder);
            this.drawer.Controls.Add(this.pictureBox1);
            this.drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawer.Location = new System.Drawing.Point(0, 0);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(200, 600);
            this.drawer.TabIndex = 0;
            // 
            // btnAboutThis
            // 
            this.btnAboutThis.AutoSize = true;
            this.btnAboutThis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAboutThis.Depth = 0;
            this.btnAboutThis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAboutThis.Icon = global::app.master.Properties.Resources.Brainstorm_Skill_64;
            this.btnAboutThis.Location = new System.Drawing.Point(0, 564);
            this.btnAboutThis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAboutThis.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAboutThis.Name = "btnAboutThis";
            this.btnAboutThis.Primary = false;
            this.btnAboutThis.Size = new System.Drawing.Size(200, 36);
            this.btnAboutThis.TabIndex = 5;
            this.btnAboutThis.Text = "SOBRE ESTE SISTEMA";
            this.btnAboutThis.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmin.Depth = 0;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.Icon = global::app.master.Properties.Resources.Tools_48;
            this.btnAdmin.Location = new System.Drawing.Point(0, 290);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Primary = false;
            this.btnAdmin.Size = new System.Drawing.Size(200, 36);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "ADMINISTRAR";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnMasterDetail
            // 
            this.btnMasterDetail.AutoSize = true;
            this.btnMasterDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMasterDetail.Depth = 0;
            this.btnMasterDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterDetail.Icon = global::app.master.Properties.Resources.Show_Property_48;
            this.btnMasterDetail.Location = new System.Drawing.Point(0, 254);
            this.btnMasterDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMasterDetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMasterDetail.Name = "btnMasterDetail";
            this.btnMasterDetail.Primary = false;
            this.btnMasterDetail.Size = new System.Drawing.Size(200, 36);
            this.btnMasterDetail.TabIndex = 3;
            this.btnMasterDetail.Text = "MAESTRO / DETALLE";
            this.btnMasterDetail.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.AutoSize = true;
            this.btnProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProducts.Depth = 0;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.Icon = global::app.master.Properties.Resources.Food_64;
            this.btnProducts.Location = new System.Drawing.Point(0, 218);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProducts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Primary = false;
            this.btnProducts.Size = new System.Drawing.Size(200, 36);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "PRODUCTOS";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AutoSize = true;
            this.btnOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrder.Depth = 0;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.Icon = global::app.master.Properties.Resources.order_48;
            this.btnOrder.Location = new System.Drawing.Point(0, 182);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Primary = false;
            this.btnOrder.Size = new System.Drawing.Size(200, 36);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "PEDIDOS";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::app.master.Properties.Resources._13996757;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // conten
            // 
            this.conten.Controls.Add(this.pnlContainer);
            this.conten.Controls.Add(this.pnlHeader);
            this.conten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conten.Location = new System.Drawing.Point(200, 0);
            this.conten.Name = "conten";
            this.conten.Size = new System.Drawing.Size(860, 600);
            this.conten.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pnlContainer.Controls.Add(this.orderControl1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 39);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(860, 561);
            this.pnlContainer.TabIndex = 2;
            // 
            // orderControl1
            // 
            this.orderControl1.Location = new System.Drawing.Point(0, 224);
            this.orderControl1.Name = "orderControl1";
            this.orderControl1.Size = new System.Drawing.Size(860, 561);
            this.orderControl1.TabIndex = 1;
            this.orderControl1.Visible = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Indigo;
            this.pnlHeader.Controls.Add(this.materialLabel1);
            this.pnlHeader.Controls.Add(this.btnShutdown);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(860, 39);
            this.pnlHeader.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(188, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "FAST FOOD SYSTEM - ULP";
            // 
            // btnShutdown
            // 
            this.btnShutdown.AutoSize = true;
            this.btnShutdown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShutdown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutdown.Depth = 0;
            this.btnShutdown.Icon = global::app.master.Properties.Resources.Shutdown_32;
            this.btnShutdown.Location = new System.Drawing.Point(813, 2);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShutdown.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Primary = false;
            this.btnShutdown.Size = new System.Drawing.Size(44, 36);
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // productControl1
            // 
            this.productControl1.Location = new System.Drawing.Point(0, 0);
            this.productControl1.Name = "productControl1";
            this.productControl1.Size = new System.Drawing.Size(860, 561);
            this.productControl1.TabIndex = 0;
            // 
            // productControl2
            // 
            this.productControl2.Location = new System.Drawing.Point(0, 0);
            this.productControl2.Name = "productControl2";
            this.productControl2.Size = new System.Drawing.Size(860, 561);
            this.productControl2.TabIndex = 0;
            // 
            // productControl3
            // 
            this.productControl3.Location = new System.Drawing.Point(0, 0);
            this.productControl3.Name = "productControl3";
            this.productControl3.Size = new System.Drawing.Size(860, 561);
            this.productControl3.TabIndex = 0;
            // 
            // productControl4
            // 
            this.productControl4.Location = new System.Drawing.Point(0, 0);
            this.productControl4.Name = "productControl4";
            this.productControl4.Size = new System.Drawing.Size(860, 561);
            this.productControl4.TabIndex = 0;
            // 
            // frmContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1060, 600);
            this.Controls.Add(this.conten);
            this.Controls.Add(this.drawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmContent_Load);
            this.drawer.ResumeLayout(false);
            this.drawer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.conten.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawer;
        private System.Windows.Forms.Panel conten;
        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialFlatButton btnShutdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnAdmin;
        private MaterialSkin.Controls.MaterialFlatButton btnMasterDetail;
        private MaterialSkin.Controls.MaterialFlatButton btnProducts;
        private MaterialSkin.Controls.MaterialFlatButton btnOrder;
        private MaterialSkin.Controls.MaterialFlatButton btnAboutThis;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel pnlContainer;
        private View.Orders.OrderControl orderControl1;
        private View.Products.ProductControl productControl1;
        private View.Products.ProductControl productControl2;
        private View.Products.ProductControl productControl3;
        private View.Products.ProductControl productControl4;
    }
}

