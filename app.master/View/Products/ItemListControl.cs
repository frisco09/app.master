using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.master.View.Products
{
    public partial class ItemListControl : UserControl
    {
        public ItemListControl()
        {
            InitializeComponent();
        }

        #region properties
            private string _title;
            private string _message;
            private Image _image;
            private string _name;
            private int _stock;
            private double _price;
            private List<int> _categories;
            
            [Category("Custom Props")]
            public string Title
            {
                get { return _title; }
                set { _title = value; lblTitle.Text = value; }
            }


            [Category("Custom Props")]
            public int Stock
            {
                get { return _stock; }
                set { _stock = value; lblProductStock.Text = value.ToString(); }
            }

            

            public double Price
            {
                get { return _price; }
                set { _price = value; lblProductPrice.Text = value.ToString(); }
            }

            [Category("Custom Props")]
            public string Name
            {
               get { return _name; }
               set { _name = value;  lblProductName.Text = value; }
            }


            [Category("Custom Props")]
            public string Message
            {
               get { return _message; }
               set { _message = value; }
            }
            

            public List<int> Categories
            {
                get { return _categories; }
                set { _categories = value; lblCategories.Text = string.Join(",", value.ToArray()); }
            }

            [Category("Custom Props")]
            public Image Image
            {
               get { return _image; }
               set { _image = value; pbxImageProduct.Image = value; }
            }

        #endregion

    }
}
