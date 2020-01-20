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
using app.master.View.Products.AddProduct;

namespace app.master.View.Products
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
            PopulateItems();
        }
        public List<Product> _ProductItems;

        [Category("Custom Props")]
        public List<Product> ProductItems
        {
            get { return _ProductItems; }
            set { _ProductItems = value;}
        }
        private static AddProductControl _instanceAddProductControl;
        public static AddProductControl InstanceAddProductControl
        {
            get
            {
                if (_instanceAddProductControl == null)
                    _instanceAddProductControl = new AddProductControl();
                return _instanceAddProductControl;
            }
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }

        public void PopulateItems()
        {
            using (var MyModelEntities = new AppDBContext())
            {

                pnlProductsContainer.Controls.Clear();
                _ProductItems = new List<Product>();
                _ProductItems.Clear();
                _ProductItems = MyModelEntities.Product.Include("Categories").OrderByDescending(pr => pr.ProductId).ToList();
            
                if (_ProductItems != null)
                {
                    if (_ProductItems.Count > 0)
                        {
                        foreach (var product in _ProductItems)
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
            pnlProductsContainer.Controls.Clear();
            //AddProductControl addProduct = new AddProductControl();
            ////pnlProductsContainer.Controls.Add(addProduct);
            //addProduct.BringToFront();
            _instanceAddProductControl = null;
            pnlContainer.Controls.Add(InstanceAddProductControl);
            InstanceAddProductControl.BringToFront();
            PopulateItems();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateItems();
        }
    }
}
