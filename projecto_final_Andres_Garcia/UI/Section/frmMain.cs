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
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar_registros();
        }

        private void cargar_registros()
        {
            
            // cargar datos
            /*listBox1.Items.Clear();

            List<Product> productList = new DBAPI().GetProducts();

            foreach (Product objProduct in productList)
            {
                string datos = objProduct.prodcode + " | " + objProduct.catcode + " | " + objProduct.description;
                listBox1.Items.Add(datos);
            }*/
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


            BindingSource objBindingSource = new InventoryData().loadProducts();
            gridProducts.DataSource = objBindingSource;
            gridProducts.ClearSelection();
            gridProducts.DefaultCellStyle.ForeColor = Color.Black;
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
        }

    }
}
