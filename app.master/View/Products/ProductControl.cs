using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using app.master.models;
using app.master.Model;
using System.Threading.Tasks;
using System.ComponentModel;

namespace app.master.View.Products
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
            
        }
        public List<Product> _ProductItems;

        [Category("Custom Props")]
        public List<Product> ProductItems
        {
            get { return _ProductItems; }
            set { _ProductItems = value;}
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }

        private void PopulateItems()
        {
            List<ItemListControl> ListItems = new List<ItemListControl>();
            List<Product> ListProducts = this.ProductItems;

            if (ListProducts.Count > 0)
            {
                foreach (var product in this.ProductItems)
                {
                    ItemListControl item = new ItemListControl();
                    item.Name = product.Name;
                    item.Stock = product.UnitInStock;
                    item.Price = product.UnitPrice;
                    if (product.Categories.Count > 0)
                    {
                        List<int> categoriesIDS = new List<int>();
                        foreach (var i in product.Categories)
                        {
                            categoriesIDS.Add(i.CategoryId);
                        }
                        item.Categories = categoriesIDS;
                    }
                    
                    pnlProductsContainer.Controls.Add(item);
                }
            }

        }


        private void ConfigureBtnAddProduct()
        {
            if (btnNewProduct.Visible)
            {

            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            // AddProductControl.Visible = true;
        }
    }
}
