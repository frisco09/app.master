using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.master.models;
using app.master.Model;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace app.master.View.Products.AddProduct
{
    public partial class AddProductControl : UserControl
    {
        #region props_control
        const string NAMEPRODUCT = "Nombre del producto.";
        const string CODEPRODUCT = "Codigo del producto.";

        #endregion

        Product _product = new Product();
        Category _category = new Category();
        List<Category> _categories = new List<Category>();
        ProductControl parentForm;

        public AddProductControl()
        {
            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                if (c == null)
                {
                    throw new ArgumentNullException("c");
                }
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
                else if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndex = 1;
                }
                else if (c is NumericUpDown)
                {
                    (c as NumericUpDown).Value = 0;
                }
            }
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
                txbNameProduct.ForeColor = Color.Purple;
            }
        }

        private void txbCodeProduct_Enter(object sender, EventArgs e)
        {
            if (txbCodeProduct.Text.Equals(CODEPRODUCT))
            {
                txbCodeProduct.Clear();
                txbCodeProduct.ForeColor = Color.Purple;
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
            txbNameProduct.ForeColor = Color.Gray;
            txbCodeProduct.Text = CODEPRODUCT;
            txbCodeProduct.ForeColor = Color.Gray;

            using (var MyModelEntities = new AppDBContext())
            {
                _categories = MyModelEntities.Category.ToList<Category>();
            }
            cbxCategories.DataSource = _categories;
            cbxCategories.DisplayMember = "Name";
            cbxCategories.ValueMember = "CategoryId";
            cbxCategories.Invalidate();
           // For some reason, the ComboBox does not update it Items Collection,
           // then a new DataSource is detected.Invalidate() 
           // forces the Control to redraw iself, and in the process, updating its Items collection.

        }

        private void btnCancelControl_Click(object sender, EventArgs e)
        {
            // this.SendToBack();
            this.Parent.Controls.Remove(this);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _product.Name = txbNameProduct.Text;
            _product.Code = txbCodeProduct.Text;
            _product.UnitPrice = Convert.ToDouble(nudProductPrice.Value);
            _product.UnitInStock =Convert.ToInt32(nudUnitStock.Value);
            _product.QuantityPerUnit = Convert.ToInt32(nudQuantityUnit.Value);
            _product.UnitOrders = Convert.ToInt32(nudUnitOrder.Value);



            using (var MyDbEntities = new AppDBContext())
            {

                if (_product.ProductId == 0)
                {
                    MyDbEntities.Product.Add(_product);
                    MyDbEntities.SaveChanges();

                    // add product-categories relationship
                    ProductCategory categories = new ProductCategory();
                    int idcategori = Convert.ToInt32(cbxCategories.SelectedValue);
                    if (idcategori > 0)
                    {
                        categories.CategoryId = idcategori;
                        categories.ProductId = _product.ProductId;

                    }

                    _product.Categories = new List<ProductCategory>();
                    _product.Categories.Add(categories);
                    MyDbEntities.SaveChanges();
                    MessageBox.Show("Information has been Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MyDbEntities.Entry(_product).State = EntityState.Modified;
                    MyDbEntities.SaveChanges();
                    _product.ProductId = 0;
                    MessageBox.Show("Information has been Updated", "Modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            this.Parent.Controls.Remove(this);

            //(Parent as ProductControl).PopulateItems();
        }




    }
}

