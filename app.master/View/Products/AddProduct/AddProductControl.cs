using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.master.View.Products.AddProduct
{
    public partial class AddProductControl : UserControl
    {
        #region props_control
        const string NAMEPRODUCT = "Nombre del producto.";
        const string CODEPRODUCT = "Codigo del producto.";

        #endregion

        public AddProductControl()
        {
            InitializeComponent();
        }




        #region TODO UI
        private void txbNameProduct_Leave(object sender, EventArgs e)
        {
            if (txbNameProduct.Text == "")
            {
                txbNameProduct.Text = NAMEPRODUCT;
                txbNameProduct.ForeColor = Color.Gray;
            }
        }

        private void txbNameProduct_Enter(object sender, EventArgs e)
        {
            if (txbNameProduct.Text.Equals(NAMEPRODUCT))
            {
                txbNameProduct.Clear();
            }
        }

        private void txbCodeProduct_Enter(object sender, EventArgs e)
        {
            if (txbCodeProduct.Text.Equals(CODEPRODUCT))
            {
                txbCodeProduct.Clear();
            }
        }

        private void txbCodeProduct_Leave(object sender, EventArgs e)
        {
            if (txbCodeProduct.Text == "")
            {
                txbCodeProduct.Text = CODEPRODUCT;
                txbCodeProduct.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void AddProductControl_Load(object sender, EventArgs e)
        {
            txbNameProduct.Text = NAMEPRODUCT;
            txbCodeProduct.Text = CODEPRODUCT;

        }


    }
}
