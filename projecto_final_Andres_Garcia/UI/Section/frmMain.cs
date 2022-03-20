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
        private int lastTabIndex = 0;
        public frmMain()
        {
            InitializeComponent();
            this.FormClosing += frmMain_FormClosing;
            tabControl.Selected += new TabControlEventHandler(tabControl_Selected);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro de cerrar la aplicacion. Confirmar?", "Cerrar Inventario", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;

            }
            else { 
                Environment.Exit(0); 
            }

        }

        /// <summary>
        /// Loads the product grid view with the data from the database
        /// </summary>
        private void loadProductGridView()
        {
            BindingSource objBindingSource = new InventoryData().loadProducts();
            gridProducts.DataSource = objBindingSource;
            gridProducts.ClearSelection();
            gridProducts.DefaultCellStyle.ForeColor = Color.Black;
        }

        /// <summary>
        /// Load the category grid view with the data from the database
        /// </summary>
        private void loadCategoryGridView()
        {
            BindingSource objBindingSource = new InventoryData().loadCategories();
            gridCategories.DataSource = objBindingSource;
            gridCategories.ClearSelection();
            gridCategories.DefaultCellStyle.ForeColor = Color.Black;
        }

        /// <summary>
        /// Load the user grid view with the data from the database
        /// </summary>
        private void loadUserGridView()
        {
            BindingSource objBindingSource = new InventoryData().loadUsers();
            gridUsers.DataSource = objBindingSource;
            gridUsers.ClearSelection();
            gridUsers.DefaultCellStyle.ForeColor = Color.Black;
        }

        /// <summary>
        /// Create a new product and add it to the database
        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            int newProductCode, newCategoryCode;
            string newProductDescription;

            newProductCode = Int32.Parse(txtProductCode.Text);
            newCategoryCode = Int32.Parse(txtProductCategoryCode.Text);
            newProductDescription = txtProductDescription.Text;

            Product newProduct = new Product(newProductCode, newCategoryCode, newProductDescription);

            if (api.CreateProduct(newProduct))
            {

                MessageBox.Show("Producto creado exitosamente.");
                txtProductCode.Text = "";
                txtProductCategoryCode.Text = "";
                txtProductDescription.Text = "";
            }
            else
            {
                MessageBox.Show("Favor completar todos los campos de producto");
            }
        }

        /// <summary>
        /// It updates a product.
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedCells.Count > 0)
            {
                int indiceRow = gridProducts.SelectedCells[0].RowIndex;
                int productCodeToUpdate = Int32.Parse(gridProducts.Rows[indiceRow].Cells[0].Value.ToString());
                int productCategoryCodeToUpdate = Int32.Parse(gridProducts.Rows[indiceRow].Cells[1].Value.ToString());
                string productDescriptionToUpdate = gridProducts.Rows[indiceRow].Cells[2].Value.ToString();
                Product product = new Product(productCodeToUpdate, productCategoryCodeToUpdate, productDescriptionToUpdate);

                if (api.UpdateProduct(product, productCodeToUpdate))
                {
                    MessageBox.Show("Producto actualizado exitosamente.");
                    loadProductGridView();
                }
            }
        }

        /// <summary>
        /// Delete a product from the database
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (gridProducts.SelectedCells.Count > 0)
            {
                int indiceRow = gridProducts.SelectedCells[0].RowIndex;
                int productToDelete = Int32.Parse(gridProducts.Rows[indiceRow].Cells[0].Value.ToString());
                if (api.DeleteProduct(productToDelete))
                {
                    MessageBox.Show("Producto eliminado exitosamente.");
                    loadProductGridView();
                }

            }
        }

        /// <summary>
        /// Create a new category and add it to the database
        private void btnCreateNewCategory_Click(object sender, EventArgs e)
        {
            int newCategoryCode;
            string newProductDescription;

            newCategoryCode = Int32.Parse(txtCategoryCode.Text);
            newProductDescription = txtCategoryDescription.Text;

            Category newCategory = new Category(newCategoryCode, newProductDescription);

            if (api.CreateCategory(newCategory))
            {

                MessageBox.Show("Categoria creada exitosamente."); ;
                txtCategoryCode.Text = "";
                txtCategoryDescription.Text = "";
            }
            else
            {
                MessageBox.Show("Favor completar todos los campos de categoria");
            }

        }

        /// <summary>
        /// * Update a category
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (gridCategories.SelectedCells.Count > 0)
            {
                int indiceRow = gridCategories.SelectedCells[0].RowIndex;
                int categoryCodeToUpdate = Int32.Parse(gridCategories.Rows[indiceRow].Cells[0].Value.ToString());
                string categoryDescriptionToUpdate = gridCategories.Rows[indiceRow].Cells[1].Value.ToString();
                Category category = new Category(categoryCodeToUpdate, categoryDescriptionToUpdate);

                if (api.UpdateCategory(category, categoryCodeToUpdate))
                {
                    MessageBox.Show("Categoria actualizada exitosamente.");
                    loadCategoryGridView();
                }
            }
        }

        /// <summary>
        /// Delete a category from the database
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (gridCategories.SelectedCells.Count > 0)
            {
                int indiceRow = gridCategories.SelectedCells[0].RowIndex;
                int categoryToDelete = Int32.Parse(gridCategories.Rows[indiceRow].Cells[0].Value.ToString());
                if (api.DeleteCategory(categoryToDelete))
                {
                    MessageBox.Show("Categoria eliminada exitosamente.");
                    loadCategoryGridView();
                }

            }
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            string newUsername, newName, newPassword;
            bool newIsAdmin = false;

            if (radioTrue.Checked){ newIsAdmin = true; } 

            newUsername = txtUsername.Text;
            newName = txtName.Text;
            newPassword = txtPassword.Text;

            User newUser = new User(newUsername, newName, newPassword, newIsAdmin);

            if (api.CreateUser(newUser))
            {

                MessageBox.Show("Usuario creado exitosamente.");
                txtUsername.Text = "";
                txtName.Text = "";
                txtPassword.Text = "";
                radioTrue.Checked = false;
                radioFalse.Checked = false;
            }
            else
            {
                MessageBox.Show("Favor completar todos los campos de usuario.");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (gridUsers.SelectedCells.Count > 0)
            {                
                int indiceRow = gridUsers.SelectedCells[0].RowIndex;
                string usernameToUpdate = gridUsers.Rows[indiceRow].Cells[0].Value.ToString();
                string nameToUpdate = gridUsers.Rows[indiceRow].Cells[1].Value.ToString();
                string passwordToUpdate = gridUsers.Rows[indiceRow].Cells[2].Value.ToString();
                bool adminStatusToUpdate = Boolean.Parse(gridUsers.Rows[indiceRow].Cells[3].Value.ToString());

                if(passwordToUpdate == "********") { 
                    var user = new User(usernameToUpdate, nameToUpdate, "", adminStatusToUpdate);

                    if (api.UpdateUser(user, usernameToUpdate))
                    {
                        MessageBox.Show("Usuario actualizado exitosamente.");
                        loadUserGridView();
                    }
                }
                else
                {
                    var user = new User(usernameToUpdate, nameToUpdate, passwordToUpdate, adminStatusToUpdate);

                    if (api.UpdateUser(user, usernameToUpdate))
                    {
                        MessageBox.Show("Usuario actualizado exitosamente.");
                        loadUserGridView();
                    }
                }
                

                
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (gridUsers.SelectedCells.Count > 0)
            {
                int indiceRow = gridUsers.SelectedCells[0].RowIndex;
                string userToDelete = gridUsers.Rows[indiceRow].Cells[0].Value.ToString();
                if (api.DeleteUser(userToDelete))
                {
                    MessageBox.Show("Usuario eliminado exitosamente.");
                    loadUserGridView();
                }

            }
        }

        /// <summary>
        /// * Get all the products from the database and display them in a grid view
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

            loadProductGridView();
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

            loadProductGridView();
        }

        private void btnGetCategories_Click(object sender, EventArgs e)
        {
            gridCategories.Visible = true;
            gridCategories.Height = 275;
            gridCategories.Width = 390;

            lblCategoryCode.Visible = false;
            lblCategoryDescription.Visible = false;

            txtCategoryCode.Visible = false;
            txtCategoryDescription.Visible = false;

            grpCategory.Visible = true;
            grpCategory.Text = "Categorias";

            btnCreateNewCategory.Visible = false;
            btnUpdateCategory.Visible = false;
            btnDeleteCategory.Visible = false;

            loadCategoryGridView();

        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            gridCategories.Visible = false;

            lblCategoryCode.Visible = true;
            lblCategoryDescription.Visible = true;

            txtCategoryCode.Visible = true;
            txtCategoryDescription.Visible = true;

            btnCreateNewCategory.Visible = true;
            btnUpdateCategory.Visible = false;
            btnDeleteCategory.Visible = false;

            grpCategory.Visible = true;
            grpCategory.Text = "Crear Categoria";
        }

        private void btnAdminCategory_Click(object sender, EventArgs e)
        {
            gridCategories.Visible = true;
            gridCategories.Height = 220;
            gridCategories.Width = 390;

            lblCategoryCode.Visible = false;
            lblCategoryDescription.Visible = false;

            txtCategoryCode.Visible = false;
            txtCategoryDescription.Visible = false;

            btnCreateNewCategory.Visible = false;
            btnUpdateCategory.Visible = true;
            btnDeleteCategory.Visible = true;

            grpCategory.Visible = true;
            grpCategory.Text = "Administrar Categoria";

            loadCategoryGridView();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            gridUsers.Visible = false;
            
            lblUsername.Visible = true;
            lblName.Visible = true;
            lblPassword.Visible = true;
            lblIsAdmin.Visible = true;

            txtUsername.Visible = true;
            txtName.Visible = true;
            txtPassword.Visible = true;
            radioTrue.Visible = true;
            radioFalse.Visible = true; 
            
            btnCreateNewUser.Visible = true;
            btnUpdateUser.Visible = false;
            btnDeleteUser.Visible = false;

            grpUsers.Visible = true;
            grpUsers.Text = "Crear Usario";

        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            gridUsers.Visible = true;

            lblUsername.Visible = false;
            lblName.Visible = false;
            lblPassword.Visible = false;
            lblIsAdmin.Visible = false;

            txtUsername.Visible = false;
            txtName.Visible = false;
            txtPassword.Visible = false;
            radioTrue.Visible = false;
            radioFalse.Visible = false;

            btnCreateNewUser.Visible = false;
            btnUpdateUser.Visible = true;
            btnDeleteUser.Visible = true;

            grpUsers.Visible = true;
            grpUsers.Text = "Administrar Usuario";

            loadUserGridView();
        }
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {

            if (e.TabPage.Name == tabPage1.Name)
            {
                grpUsers.Visible = false;
                grpProducts.Visible = false;
                lastTabIndex = 0;

            }
            if (e.TabPage.Name == tabPage2.Name)
            {
                grpUsers.Visible = false;
                grpCategory.Visible = false;
                lastTabIndex = 1;
            }

            if (e.TabPage.Name == tabPage3.Name)
            {
                grpUsers.Visible = false;
                grpProducts.Visible = false;
                grpCategory.Visible = false;
                lastTabIndex = 2;
            }

            if (e.TabPage.Name == tabPage4.Name)
            {
                if (!State.isLogUserAdmin) {
                    MessageBox.Show("La funciones de esta Seccion estan habilitadas solamente para el administrador.", "Administrador Inventario.", MessageBoxButtons.OK,
                                                       MessageBoxIcon.Warning);
                    tabControl.SelectedIndex = lastTabIndex;
                }
                grpUsers.Visible = false;
                grpProducts.Visible = false;
                grpCategory.Visible = false;


            }


        }

    }
}