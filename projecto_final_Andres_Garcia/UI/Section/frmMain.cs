using projecto_final_Andres_Garcia.API;
using projecto_final_Andres_Garcia.Classes;
using projecto_final_Andres_Garcia.Data;
using projecto_final_Andres_Garcia.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_final_Andres_Garcia.UI
{
    public partial class frmMain : Form
    {
        DBAPI api = new DBAPI();
        public frmMain()
        {
            InitializeComponent();
        }

        private void loadGridView()
        {
            BindingSource objBindingSource = new InventoryData().loadProducts();
            gridProducts.DataSource = objBindingSource;
            gridProducts.ClearSelection();
            gridProducts.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            gridProducts.Visible = true;
            gridProducts.Height = 275;
            gridProducts.Width = 390;
            
            lblProduct.Visible = false;
            lblProductCategory.Visible = false;
            lblProductDescription.Visible = false;

            txtProductCode.Visible = false;
            txtProductCategoryCode.Visible = false;
            txtProductDescription.Visible = false;

            grpProducts.Visible = true;
            grpProducts.Text = "Productos";

            btnCreateNewProduct.Visible = false;
            btnUpdateProduct.Visible = false;
            btnDeleteProduct.Visible = false;

            loadGridView();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            gridProducts.Visible = false;

            lblProduct.Visible = true;
            lblProductCategory.Visible = true;
            lblProductDescription.Visible = true;

            txtProductCode.Visible = true;
            txtProductCategoryCode.Visible = true;
            txtProductDescription.Visible = true;

            btnCreateNewProduct.Visible = true;
            btnUpdateProduct.Visible = false;
            btnDeleteProduct.Visible = false;

            grpProducts.Visible = true;
            grpProducts.Text = "Crear Producto";
           
        }

        private void btnAdminProduct_Click(object sender, EventArgs e)
        {
            gridProducts.Visible = true;
            gridProducts.Height = 220;
            gridProducts.Width = 390;

            lblProduct.Visible = false;
            lblProductCategory.Visible = false;
            lblProductDescription.Visible = false;

            txtProductCode.Visible = false;
            txtProductCategoryCode.Visible = false;
            txtProductDescription.Visible = false;

            btnCreateNewProduct.Visible = false;
            btnUpdateProduct.Visible = true;
            btnDeleteProduct.Visible = true;

            grpProducts.Visible = true;
            grpProducts.Text = "Administrar Producto";

            loadGridView();
        }

        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            int newProductCode, newCategoryCode;
            string newProductDescription;

            newProductCode = Int32.Parse(txtProductCode.Text);
            newCategoryCode = Int32.Parse(txtProductCategoryCode.Text);
            newProductDescription = txtProductDescription.Text;

            Product newProduct = new Product(newProductCode, newCategoryCode, newProductDescription);

            if (api.CreateProduct(newProduct)){

                MessageBox.Show("Producto creado exitosamente.");
            }
            else
            {
                MessageBox.Show("Favor completar todos los campos de producto");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedCells.Count > 0)
            {
                int indiceRow = gridProducts.SelectedCells[0].RowIndex;
                int productToDelete = Int32.Parse(gridProducts.Rows[indiceRow].Cells[0].Value.ToString());
                if (api.DeleteProduct(Convert.ToInt32(productToDelete))) {
                    MessageBox.Show("Producto eliminado exitosamente.");
                    loadGridView();
                }
                
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedCells.Count > 0)
            {
                int indiceRow = gridProducts.SelectedCells[0].RowIndex;
                int productToUpdate = Int32.Parse(gridProducts.Rows[indiceRow].Cells[0].Value.ToString());
                if (api.DeleteProduct(Convert.ToInt32(productToUpdate)))
                {
                    MessageBox.Show("Producto actualizado exitosamente.");
                    loadGridView();
                }
            }
        }
    }
}
