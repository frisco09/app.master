using app.master.Model;
using app.master.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.master
{
    public partial class frmContent : Form
    {
        List<Product> productList = new List<Product>();

        public frmContent()
        {
            InitializeComponent();
            // GetProducts();
        }

        private void frmContent_Load(object sender, EventArgs e)
        {

        }

        #region LoadData
        public void GetProducts()
        {
            using (var MyModelEntities = new AppDBContext())
            {
                // var list = MyModelEntities.Product.OrderBy(e => e.ProductId).ToList();

                productList = MyModelEntities.Product.Include("Categories").OrderByDescending(pr => pr.ProductId).ToList();

                productControl1.ProductItems = productList;

            }
        }
        #endregion

        #region LoadView
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMenuDrawer_Click(object sender, EventArgs e)
        {

        }

        void ShowDrawer()
        {

        }

        void HideDrawer()
        {

        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            RemovePanel();
            orderControl1.Visible = true;
            orderControl1.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            RemovePanel();
            productControl1.Visible = true;
            productControl1.BringToFront();
        }

        private void RemovePanel()
        {
            if (orderControl1.Visible)
            {
                //orderControl1.Visible = false;
                this.Controls.RemoveByKey(orderControl1.Name);
            }
            if (productControl1.Visible)
            {
                productControl1.Visible = false;
                this.Controls.RemoveByKey(productControl1.Name);
            }
        }
        #endregion


    }
}
