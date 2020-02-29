using app.master.Model;
using app.master.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.master.View.Products.AddProduct
{
    public partial class AddProductDialog : Form
    {
        #region props_control
        const string NAMEPRODUCT = "Nombre del producto.";
        const string CODEPRODUCT = "Codigo del producto.";
        const string OBSERVATION = "Observacion.";

        #endregion

        Product _product = new Product();
        Category _category = new Category();
        List<Category> _categories = new List<Category>();
        OpenFileDialog openFile = new OpenFileDialog();

        public AddProductDialog()
        {
            InitializeComponent();

        }

        private void AddProductDialog_Load(object sender, EventArgs e)
        {
            txbNameProduct.Text = NAMEPRODUCT;
            txbNameProduct.ForeColor = Color.Gray;
            txbCodeProduct.Text = CODEPRODUCT;
            txbCodeProduct.ForeColor = Color.Gray;
            txbObservation.Text = OBSERVATION;
            txbObservation.ForeColor = Color.Gray;

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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cbxIsActive.Checked)
            {
                if(saveProduct())
                {
                    MessageBox.Show("Information has been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                
            }
            else
            {
                DialogResult result = MessageBox.Show("El producto sera registrado pero no podra realizar operaciones de venta o consumo.",
                "Desea agregar este producto como inhabilitado?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    if (saveProduct())
                    {
                        MessageBox.Show("Information has been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            

        }
        private bool saveProduct()
        {
            if (validateForm())
            {
                _product.Name = txbNameProduct.Text;
                _product.Code = txbCodeProduct.Text;
                _product.Observation = txbObservation.Text;
                _product.IsActive = cbxIsActive.Checked;

                if (rbtAsInput.Checked)
                {
                    _product.AsInput = true;
                }
                else if (rbtAsSale.Checked)
                {
                    _product.AsSale = true;
                }
                else
                {
                    // MessageBox.Show("Marque el tipo de producto!");
                }

                _product.UnitPrice = Convert.ToDouble(nudProductPrice.Value);
                _product.UnitInStock = Convert.ToInt32(nudUnitStock.Value);
                _product.QuantityPerUnit = Convert.ToInt32(nudQuantityUnit.Value);
                _product.UnitOrders = Convert.ToInt32(nudUnitOrder.Value);

                using (var MyDbEntities = new AppDBContext())
                {

                    if (_product.ProductId == 0)
                    {
                        try
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

                            if (!openFile.FileName.Equals(""))
                            {
                                if (openFile.CheckFileExists)
                                {
                                    var fileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(openFile.FileName)}";

                                    string fullPath = Path.GetDirectoryName(Application.ExecutablePath);
                                    fullPath = fullPath.Remove(fullPath.IndexOf("\\bin\\Debug"));
                                    string filePath = fullPath + AppConsts.DefaultPathFolderImage + fileName;
                                    System.IO.File.Copy(openFile.FileName, filePath);

                                    FileAttach file = new FileAttach();
                                    file.FileName = fileName;
                                    file.Path = filePath;
                                    file.Type = FileType.ProductImage;
                                    var fileInfo = new FileInfo(filePath);
                                    file.Size = fileInfo.Length;
                                    file.IsActive = true;
                                    //file.ProductId = _product.ProductId;
                                    MyDbEntities.FileAttach.Add(file);
                                    MyDbEntities.SaveChanges();

                                    _product.FileAttaches = new List<FileAttach>();
                                    _product.FileAttaches.Add(file);
                                    MyDbEntities.SaveChanges();
                                }
                            }
                            

                            MyDbEntities.SaveChanges();
                            return true;
                        }
                        catch (Exception exc)
                        {
                            var msj = exc.Message.ToString();
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                        //MyDbEntities.Entry(_product).State = EntityState.Modified;
                        //MyDbEntities.SaveChanges();
                        //_product.ProductId = 0;
                        //MessageBox.Show("Information has been Updated", "Modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }

            return false;
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
                txbNameProduct.ForeColor = Color.DarkBlue;
            }
        }

        private void txbCodeProduct_Enter(object sender, EventArgs e)
        {
            if (txbCodeProduct.Text.Equals(CODEPRODUCT))
            {
                txbCodeProduct.Clear();
                txbCodeProduct.ForeColor = Color.DarkBlue;
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

        private void txbObservation_Leave(object sender, EventArgs e)
        {
            if (txbObservation.Text == "")
            {
                txbObservation.Text = OBSERVATION;
                txbObservation.ForeColor = Color.Gray;
            }
        }

        private void txbObservation_Enter(object sender, EventArgs e)
        {
            if (txbObservation.Text.Equals(OBSERVATION))
            {
                txbObservation.Clear();
                txbObservation.ForeColor = Color.DarkBlue;
            }
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void txbNameProduct_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNameProduct.Text) ||  txbNameProduct.Text == NAMEPRODUCT)
            {
                e.Cancel = true;
                txbNameProduct.Focus();
                errorProviderProduct.SetError(txbNameProduct, "INGRESE UN NOMBRE DE PRODUCTO!");
            }
            else
            {
                e.Cancel = false;
                errorProviderProduct.SetError(txbNameProduct, null);
            }
        }

        private void txbCodeProduct_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbCodeProduct.Text) || txbCodeProduct.Text == CODEPRODUCT)
            {
                e.Cancel = true;
                txbCodeProduct.Focus();
                errorProviderProduct.SetError(txbCodeProduct, "INGRESE UN CODIGO DE PRODUCTO!");
            }
            else
            {
                e.Cancel = false;
                errorProviderProduct.SetError(txbCodeProduct, null);
            }
        }

        private void rbtAsInput_Validating(object sender, CancelEventArgs e)
        {
            if (!rbtAsInput.Checked && !rbtAsSale.Checked)
            {
                e.Cancel = true;
                rbtAsInput.Focus();
                errorProviderProduct.SetError(rbtAsInput, "INGRESE UN TIPO DE PRODUCTO!");
            }
            else
            {
                e.Cancel = false;
                errorProviderProduct.SetError(rbtAsInput, null);
            }
        }

        private void rbtAsSale_Validating(object sender, CancelEventArgs e)
        {
            if (!rbtAsSale.Checked && !rbtAsInput.Checked)
            {
                e.Cancel = true;
                rbtAsSale.Focus();
                errorProviderProduct.SetError(rbtAsSale, "INGRESE UN TIPO DE PRODUCTO!");
            }
            else
            {
                e.Cancel = false;
                errorProviderProduct.SetError(rbtAsSale, null);
            }
        }

        private bool validateForm()
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                return true;
            }
            return false;
        }

        private void pbImageProduct_Click(object sender, EventArgs e)
        {
            
            openFile.InitialDirectory = "C:\\";
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.ico)|*.jpg; *.jpeg; *.png; *.ico";
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFile.CheckFileExists)
                {
                    pbImageProduct.Image = new Bitmap(openFile.FileName);
                }
            }
        }

        private void cbxIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _product.IsActive = cbxIsActive.Checked;
        }

        #endregion
    }
}
