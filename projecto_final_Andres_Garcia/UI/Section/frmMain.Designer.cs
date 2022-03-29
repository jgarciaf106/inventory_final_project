namespace projecto_final_Andres_Garcia.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryCode = new System.Windows.Forms.TextBox();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.lblCategoryCode = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnCreateNewCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.gridCategories = new System.Windows.Forms.DataGridView();
            this.grpCategoryActions = new System.Windows.Forms.GroupBox();
            this.btnAdminCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnCreateNewProduct = new System.Windows.Forms.Button();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductCategoryCode = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.grProductActions = new System.Windows.Forms.GroupBox();
            this.btnAdminProduct = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gridProductCategory = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.radioFalse = new System.Windows.Forms.RadioButton();
            this.radioTrue = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.grpAdminActions = new System.Windows.Forms.GroupBox();
            this.btnAdminUsers = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            this.grpCategoryActions.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.grProductActions.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductCategory)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.grpAdminActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(9, 10);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(582, 346);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logInBx_bg;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.grpCategory);
            this.tabPage1.Controls.Add(this.grpCategoryActions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(574, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categoria";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.txtCategoryDescription);
            this.grpCategory.Controls.Add(this.txtCategoryCode);
            this.grpCategory.Controls.Add(this.lblCategoryDescription);
            this.grpCategory.Controls.Add(this.lblCategoryCode);
            this.grpCategory.Controls.Add(this.btnDeleteCategory);
            this.grpCategory.Controls.Add(this.btnCreateNewCategory);
            this.grpCategory.Controls.Add(this.btnUpdateCategory);
            this.grpCategory.Controls.Add(this.gridCategories);
            this.grpCategory.ForeColor = System.Drawing.Color.White;
            this.grpCategory.Location = new System.Drawing.Point(155, 5);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(2);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(2);
            this.grpCategory.Size = new System.Drawing.Size(416, 313);
            this.grpCategory.TabIndex = 1;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Categoria";
            this.grpCategory.Visible = false;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(197, 87);
            this.txtCategoryDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(183, 87);
            this.txtCategoryDescription.TabIndex = 7;
            this.txtCategoryDescription.WordWrap = false;
            // 
            // txtCategoryCode
            // 
            this.txtCategoryCode.Location = new System.Drawing.Point(197, 41);
            this.txtCategoryCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryCode.Multiline = true;
            this.txtCategoryCode.Name = "txtCategoryCode";
            this.txtCategoryCode.Size = new System.Drawing.Size(183, 19);
            this.txtCategoryCode.TabIndex = 6;
            this.txtCategoryCode.Visible = false;
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.BackColor = System.Drawing.Color.White;
            this.lblCategoryDescription.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryDescription.Location = new System.Drawing.Point(23, 87);
            this.lblCategoryDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(124, 19);
            this.lblCategoryDescription.TabIndex = 5;
            this.lblCategoryDescription.Text = "Descripcion";
            this.lblCategoryDescription.Visible = false;
            // 
            // lblCategoryCode
            // 
            this.lblCategoryCode.BackColor = System.Drawing.Color.White;
            this.lblCategoryCode.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryCode.Location = new System.Drawing.Point(23, 41);
            this.lblCategoryCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryCode.Name = "lblCategoryCode";
            this.lblCategoryCode.Size = new System.Drawing.Size(124, 19);
            this.lblCategoryCode.TabIndex = 4;
            this.lblCategoryCode.Text = "Codigo de Categoria";
            this.lblCategoryCode.Visible = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCategory.Location = new System.Drawing.Point(271, 258);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(98, 42);
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Text = "Eliminar";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Visible = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnCreateNewCategory
            // 
            this.btnCreateNewCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateNewCategory.Location = new System.Drawing.Point(159, 244);
            this.btnCreateNewCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewCategory.Name = "btnCreateNewCategory";
            this.btnCreateNewCategory.Size = new System.Drawing.Size(98, 42);
            this.btnCreateNewCategory.TabIndex = 2;
            this.btnCreateNewCategory.Text = "Crear Categoria";
            this.btnCreateNewCategory.UseVisualStyleBackColor = true;
            this.btnCreateNewCategory.Visible = false;
            this.btnCreateNewCategory.Click += new System.EventHandler(this.btnCreateNewCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.Location = new System.Drawing.Point(49, 258);
            this.btnUpdateCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(98, 42);
            this.btnUpdateCategory.TabIndex = 1;
            this.btnUpdateCategory.Text = "Actualizar";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Visible = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // gridCategories
            // 
            this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategories.Location = new System.Drawing.Point(12, 25);
            this.gridCategories.Margin = new System.Windows.Forms.Padding(2);
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.RowHeadersWidth = 51;
            this.gridCategories.RowTemplate.Height = 24;
            this.gridCategories.Size = new System.Drawing.Size(391, 199);
            this.gridCategories.TabIndex = 0;
            this.gridCategories.Visible = false;
            // 
            // grpCategoryActions
            // 
            this.grpCategoryActions.Controls.Add(this.btnAdminCategory);
            this.grpCategoryActions.Controls.Add(this.btnCreateCategory);
            this.grpCategoryActions.Controls.Add(this.btnGetCategories);
            this.grpCategoryActions.ForeColor = System.Drawing.Color.White;
            this.grpCategoryActions.Location = new System.Drawing.Point(4, 5);
            this.grpCategoryActions.Margin = new System.Windows.Forms.Padding(2);
            this.grpCategoryActions.Name = "grpCategoryActions";
            this.grpCategoryActions.Padding = new System.Windows.Forms.Padding(2);
            this.grpCategoryActions.Size = new System.Drawing.Size(146, 313);
            this.grpCategoryActions.TabIndex = 0;
            this.grpCategoryActions.TabStop = false;
            this.grpCategoryActions.Text = "Acciones";
            // 
            // btnAdminCategory
            // 
            this.btnAdminCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAdminCategory.Location = new System.Drawing.Point(4, 152);
            this.btnAdminCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminCategory.Name = "btnAdminCategory";
            this.btnAdminCategory.Size = new System.Drawing.Size(137, 63);
            this.btnAdminCategory.TabIndex = 2;
            this.btnAdminCategory.Text = "Administrar Categoria";
            this.btnAdminCategory.UseVisualStyleBackColor = true;
            this.btnAdminCategory.Click += new System.EventHandler(this.btnAdminCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCategory.Location = new System.Drawing.Point(4, 84);
            this.btnCreateCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(137, 63);
            this.btnCreateCategory.TabIndex = 1;
            this.btnCreateCategory.Text = "Crear Categoria";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.ForeColor = System.Drawing.Color.Black;
            this.btnGetCategories.Location = new System.Drawing.Point(4, 17);
            this.btnGetCategories.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(137, 63);
            this.btnGetCategories.TabIndex = 0;
            this.btnGetCategories.Text = "Registros";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logInBx_bg;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.grpProducts);
            this.tabPage2.Controls.Add(this.grProductActions);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(574, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.btnDeleteProduct);
            this.grpProducts.Controls.Add(this.btnUpdateProduct);
            this.grpProducts.Controls.Add(this.btnCreateNewProduct);
            this.grpProducts.Controls.Add(this.txtProductDescription);
            this.grpProducts.Controls.Add(this.txtProductCategoryCode);
            this.grpProducts.Controls.Add(this.txtProductCode);
            this.grpProducts.Controls.Add(this.lblProductDescription);
            this.grpProducts.Controls.Add(this.lblProductCategory);
            this.grpProducts.Controls.Add(this.lblProduct);
            this.grpProducts.Controls.Add(this.gridProducts);
            this.grpProducts.ForeColor = System.Drawing.Color.White;
            this.grpProducts.Location = new System.Drawing.Point(155, 5);
            this.grpProducts.Margin = new System.Windows.Forms.Padding(2);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Padding = new System.Windows.Forms.Padding(2);
            this.grpProducts.Size = new System.Drawing.Size(416, 313);
            this.grpProducts.TabIndex = 1;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Productos";
            this.grpProducts.Visible = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.Location = new System.Drawing.Point(271, 258);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(98, 42);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.Location = new System.Drawing.Point(49, 258);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(98, 42);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Actualizar";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnCreateNewProduct
            // 
            this.btnCreateNewProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCreateNewProduct.Location = new System.Drawing.Point(159, 244);
            this.btnCreateNewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewProduct.Name = "btnCreateNewProduct";
            this.btnCreateNewProduct.Size = new System.Drawing.Size(96, 42);
            this.btnCreateNewProduct.TabIndex = 7;
            this.btnCreateNewProduct.Text = "Crear Producto";
            this.btnCreateNewProduct.UseVisualStyleBackColor = true;
            this.btnCreateNewProduct.Click += new System.EventHandler(this.btnCreateNewProduct_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(197, 128);
            this.txtProductDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(183, 87);
            this.txtProductDescription.TabIndex = 6;
            // 
            // txtProductCategoryCode
            // 
            this.txtProductCategoryCode.Location = new System.Drawing.Point(197, 87);
            this.txtProductCategoryCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductCategoryCode.Multiline = true;
            this.txtProductCategoryCode.Name = "txtProductCategoryCode";
            this.txtProductCategoryCode.Size = new System.Drawing.Size(183, 19);
            this.txtProductCategoryCode.TabIndex = 5;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(197, 41);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductCode.Multiline = true;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(183, 19);
            this.txtProductCode.TabIndex = 4;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.BackColor = System.Drawing.Color.White;
            this.lblProductDescription.ForeColor = System.Drawing.Color.Black;
            this.lblProductDescription.Location = new System.Drawing.Point(23, 134);
            this.lblProductDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(124, 19);
            this.lblProductDescription.TabIndex = 3;
            this.lblProductDescription.Text = "Descripcion";
            this.lblProductDescription.Visible = false;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.BackColor = System.Drawing.Color.White;
            this.lblProductCategory.ForeColor = System.Drawing.Color.Black;
            this.lblProductCategory.Location = new System.Drawing.Point(23, 87);
            this.lblProductCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(124, 19);
            this.lblProductCategory.TabIndex = 2;
            this.lblProductCategory.Text = "Codigo de Categoria";
            this.lblProductCategory.Visible = false;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.White;
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(23, 41);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(124, 19);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Codigo de Producto";
            this.lblProduct.Visible = false;
            // 
            // gridProducts
            // 
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.GridColor = System.Drawing.SystemColors.Control;
            this.gridProducts.Location = new System.Drawing.Point(12, 25);
            this.gridProducts.Margin = new System.Windows.Forms.Padding(2);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 24;
            this.gridProducts.Size = new System.Drawing.Size(390, 197);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.Visible = false;
            // 
            // grProductActions
            // 
            this.grProductActions.Controls.Add(this.btnAdminProduct);
            this.grProductActions.Controls.Add(this.btnCreateProduct);
            this.grProductActions.Controls.Add(this.btnGetProducts);
            this.grProductActions.ForeColor = System.Drawing.Color.White;
            this.grProductActions.Location = new System.Drawing.Point(4, 5);
            this.grProductActions.Margin = new System.Windows.Forms.Padding(2);
            this.grProductActions.Name = "grProductActions";
            this.grProductActions.Padding = new System.Windows.Forms.Padding(2);
            this.grProductActions.Size = new System.Drawing.Size(146, 313);
            this.grProductActions.TabIndex = 0;
            this.grProductActions.TabStop = false;
            this.grProductActions.Text = "Acciones";
            // 
            // btnAdminProduct
            // 
            this.btnAdminProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAdminProduct.Location = new System.Drawing.Point(4, 152);
            this.btnAdminProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminProduct.Name = "btnAdminProduct";
            this.btnAdminProduct.Size = new System.Drawing.Size(137, 63);
            this.btnAdminProduct.TabIndex = 2;
            this.btnAdminProduct.Text = "Administrar Productos";
            this.btnAdminProduct.UseVisualStyleBackColor = true;
            this.btnAdminProduct.Click += new System.EventHandler(this.btnAdminProduct_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCreateProduct.Location = new System.Drawing.Point(4, 84);
            this.btnCreateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(137, 63);
            this.btnCreateProduct.TabIndex = 1;
            this.btnCreateProduct.Text = "Crear Producto";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.ForeColor = System.Drawing.Color.Black;
            this.btnGetProducts.Location = new System.Drawing.Point(4, 17);
            this.btnGetProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(137, 63);
            this.btnGetProducts.TabIndex = 0;
            this.btnGetProducts.Text = "Registros";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logInBx_bg;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.btnPrint);
            this.tabPage3.Controls.Add(this.gridProductCategory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(574, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reportes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(224, 261);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 42);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridProductCategory
            // 
            this.gridProductCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductCategory.Location = new System.Drawing.Point(20, 20);
            this.gridProductCategory.Name = "gridProductCategory";
            this.gridProductCategory.Size = new System.Drawing.Size(539, 235);
            this.gridProductCategory.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logInBx_bg;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.grpUsers);
            this.tabPage4.Controls.Add(this.grpAdminActions);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(574, 320);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Admin";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.radioFalse);
            this.grpUsers.Controls.Add(this.radioTrue);
            this.grpUsers.Controls.Add(this.txtPassword);
            this.grpUsers.Controls.Add(this.txtName);
            this.grpUsers.Controls.Add(this.txtUsername);
            this.grpUsers.Controls.Add(this.lblIsAdmin);
            this.grpUsers.Controls.Add(this.lblPassword);
            this.grpUsers.Controls.Add(this.lblName);
            this.grpUsers.Controls.Add(this.lblUsername);
            this.grpUsers.Controls.Add(this.btnCreateNewUser);
            this.grpUsers.Controls.Add(this.btnDeleteUser);
            this.grpUsers.Controls.Add(this.btnUpdateUser);
            this.grpUsers.Controls.Add(this.gridUsers);
            this.grpUsers.ForeColor = System.Drawing.Color.White;
            this.grpUsers.Location = new System.Drawing.Point(155, 5);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(416, 313);
            this.grpUsers.TabIndex = 1;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Usuarios";
            this.grpUsers.Visible = false;
            // 
            // radioFalse
            // 
            this.radioFalse.AutoSize = true;
            this.radioFalse.ForeColor = System.Drawing.Color.Black;
            this.radioFalse.Location = new System.Drawing.Point(260, 177);
            this.radioFalse.Name = "radioFalse";
            this.radioFalse.Size = new System.Drawing.Size(39, 17);
            this.radioFalse.TabIndex = 12;
            this.radioFalse.TabStop = true;
            this.radioFalse.Text = "No";
            this.radioFalse.UseVisualStyleBackColor = true;
            // 
            // radioTrue
            // 
            this.radioTrue.AutoSize = true;
            this.radioTrue.ForeColor = System.Drawing.Color.Black;
            this.radioTrue.Location = new System.Drawing.Point(206, 177);
            this.radioTrue.Name = "radioTrue";
            this.radioTrue.Size = new System.Drawing.Size(34, 17);
            this.radioTrue.TabIndex = 11;
            this.radioTrue.TabStop = true;
            this.radioTrue.Text = "Si";
            this.radioTrue.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 9;
            this.txtName.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(197, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(183, 20);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.Visible = false;
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.BackColor = System.Drawing.Color.White;
            this.lblIsAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblIsAdmin.Location = new System.Drawing.Point(23, 175);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(124, 19);
            this.lblIsAdmin.TabIndex = 7;
            this.lblIsAdmin.Text = "Administrador";
            this.lblIsAdmin.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(23, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 19);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contraseña";
            this.lblPassword.Visible = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(23, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 19);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre";
            this.lblName.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(23, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Nombre de usuario";
            this.lblUsername.Visible = false;
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnCreateNewUser.Location = new System.Drawing.Point(159, 244);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(98, 42);
            this.btnCreateNewUser.TabIndex = 3;
            this.btnCreateNewUser.Text = "Crear Usuario";
            this.btnCreateNewUser.UseVisualStyleBackColor = true;
            this.btnCreateNewUser.Visible = false;
            this.btnCreateNewUser.Click += new System.EventHandler(this.btnCreateNewUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Location = new System.Drawing.Point(271, 258);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(98, 42);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Visible = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Location = new System.Drawing.Point(49, 258);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(98, 42);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Actualizar";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Visible = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // gridUsers
            // 
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(12, 25);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.Size = new System.Drawing.Size(391, 199);
            this.gridUsers.TabIndex = 0;
            this.gridUsers.Visible = false;
            // 
            // grpAdminActions
            // 
            this.grpAdminActions.Controls.Add(this.btnAdminUsers);
            this.grpAdminActions.Controls.Add(this.btnCreateUser);
            this.grpAdminActions.ForeColor = System.Drawing.Color.White;
            this.grpAdminActions.Location = new System.Drawing.Point(4, 5);
            this.grpAdminActions.Name = "grpAdminActions";
            this.grpAdminActions.Size = new System.Drawing.Size(146, 313);
            this.grpAdminActions.TabIndex = 0;
            this.grpAdminActions.TabStop = false;
            this.grpAdminActions.Text = "Acciones";
            // 
            // btnAdminUsers
            // 
            this.btnAdminUsers.ForeColor = System.Drawing.Color.Black;
            this.btnAdminUsers.Location = new System.Drawing.Point(4, 84);
            this.btnAdminUsers.Name = "btnAdminUsers";
            this.btnAdminUsers.Size = new System.Drawing.Size(137, 63);
            this.btnAdminUsers.TabIndex = 1;
            this.btnAdminUsers.Text = "Administrar Usuarios";
            this.btnAdminUsers.UseVisualStyleBackColor = true;
            this.btnAdminUsers.Click += new System.EventHandler(this.btnAdminUsers_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.ForeColor = System.Drawing.Color.Black;
            this.btnCreateUser.Location = new System.Drawing.Point(4, 17);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(137, 63);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Crear Usuario";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logIn_bg;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            this.grpCategoryActions.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpProducts.ResumeLayout(false);
            this.grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.grProductActions.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductCategory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.grpAdminActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox grProductActions;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.Button btnAdminProduct;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnCreateNewProduct;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductCategoryCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.GroupBox grpCategoryActions;
        private System.Windows.Forms.Button btnAdminCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Button btnGetCategories;
        private System.Windows.Forms.DataGridView gridCategories;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnCreateNewCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryCode;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Label lblCategoryCode;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.GroupBox grpAdminActions;
        private System.Windows.Forms.Button btnAdminUsers;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.RadioButton radioFalse;
        private System.Windows.Forms.RadioButton radioTrue;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView gridProductCategory;
    }
}