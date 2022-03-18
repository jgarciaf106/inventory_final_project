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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.grpCategoryActions = new System.Windows.Forms.GroupBox();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnAdminCategory = new System.Windows.Forms.Button();
            this.gridCategories = new System.Windows.Forms.DataGridView();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnCreateNewCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lblCategoryCode = new System.Windows.Forms.Label();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.txtCategoryCode = new System.Windows.Forms.TextBox();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.grpCategoryActions.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.grProductActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logInBx_bg;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.grpCategory);
            this.tabPage1.Controls.Add(this.grpCategoryActions);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
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
            this.grpCategory.Location = new System.Drawing.Point(207, 6);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(555, 385);
            this.grpCategory.TabIndex = 1;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Categoria";
            this.grpCategory.Visible = false;
            // 
            // grpCategoryActions
            // 
            this.grpCategoryActions.Controls.Add(this.btnAdminCategory);
            this.grpCategoryActions.Controls.Add(this.btnCreateCategory);
            this.grpCategoryActions.Controls.Add(this.btnGetCategories);
            this.grpCategoryActions.ForeColor = System.Drawing.Color.White;
            this.grpCategoryActions.Location = new System.Drawing.Point(6, 6);
            this.grpCategoryActions.Name = "grpCategoryActions";
            this.grpCategoryActions.Size = new System.Drawing.Size(195, 385);
            this.grpCategoryActions.TabIndex = 0;
            this.grpCategoryActions.TabStop = false;
            this.grpCategoryActions.Text = "Acciones";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logInBx_bg;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.grpProducts);
            this.tabPage2.Controls.Add(this.grProductActions);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
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
            this.grpProducts.Location = new System.Drawing.Point(207, 6);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(555, 385);
            this.grpProducts.TabIndex = 1;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Productos";
            this.grpProducts.Visible = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.Location = new System.Drawing.Point(361, 317);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(131, 52);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.Location = new System.Drawing.Point(65, 317);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(131, 52);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Actualizar";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnCreateNewProduct
            // 
            this.btnCreateNewProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCreateNewProduct.Location = new System.Drawing.Point(212, 300);
            this.btnCreateNewProduct.Name = "btnCreateNewProduct";
            this.btnCreateNewProduct.Size = new System.Drawing.Size(128, 52);
            this.btnCreateNewProduct.TabIndex = 7;
            this.btnCreateNewProduct.Text = "Crear Producto";
            this.btnCreateNewProduct.UseVisualStyleBackColor = true;
            this.btnCreateNewProduct.Click += new System.EventHandler(this.btnCreateNewProduct_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(263, 158);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(243, 106);
            this.txtProductDescription.TabIndex = 6;
            // 
            // txtProductCategoryCode
            // 
            this.txtProductCategoryCode.Location = new System.Drawing.Point(263, 107);
            this.txtProductCategoryCode.Multiline = true;
            this.txtProductCategoryCode.Name = "txtProductCategoryCode";
            this.txtProductCategoryCode.Size = new System.Drawing.Size(243, 23);
            this.txtProductCategoryCode.TabIndex = 5;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(263, 51);
            this.txtProductCode.Multiline = true;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(243, 23);
            this.txtProductCode.TabIndex = 4;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.BackColor = System.Drawing.Color.White;
            this.lblProductDescription.ForeColor = System.Drawing.Color.Black;
            this.lblProductDescription.Location = new System.Drawing.Point(31, 165);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(132, 23);
            this.lblProductDescription.TabIndex = 3;
            this.lblProductDescription.Text = "Descripcion";
            this.lblProductDescription.Visible = false;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.BackColor = System.Drawing.Color.White;
            this.lblProductCategory.ForeColor = System.Drawing.Color.Black;
            this.lblProductCategory.Location = new System.Drawing.Point(31, 107);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(132, 23);
            this.lblProductCategory.TabIndex = 2;
            this.lblProductCategory.Text = "Codigo de Categoria";
            this.lblProductCategory.Visible = false;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.White;
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(31, 51);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(132, 23);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Codigo de Producto";
            this.lblProduct.Visible = false;
            // 
            // gridProducts
            // 
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.GridColor = System.Drawing.SystemColors.Control;
            this.gridProducts.Location = new System.Drawing.Point(16, 31);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 24;
            this.gridProducts.Size = new System.Drawing.Size(520, 243);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.Visible = false;
            // 
            // grProductActions
            // 
            this.grProductActions.Controls.Add(this.btnAdminProduct);
            this.grProductActions.Controls.Add(this.btnCreateProduct);
            this.grProductActions.Controls.Add(this.btnGetProducts);
            this.grProductActions.ForeColor = System.Drawing.Color.White;
            this.grProductActions.Location = new System.Drawing.Point(6, 6);
            this.grProductActions.Name = "grProductActions";
            this.grProductActions.Size = new System.Drawing.Size(195, 385);
            this.grProductActions.TabIndex = 0;
            this.grProductActions.TabStop = false;
            this.grProductActions.Text = "Acciones";
            // 
            // btnAdminProduct
            // 
            this.btnAdminProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAdminProduct.Location = new System.Drawing.Point(6, 187);
            this.btnAdminProduct.Name = "btnAdminProduct";
            this.btnAdminProduct.Size = new System.Drawing.Size(183, 77);
            this.btnAdminProduct.TabIndex = 2;
            this.btnAdminProduct.Text = "Administrar Productos";
            this.btnAdminProduct.UseVisualStyleBackColor = true;
            this.btnAdminProduct.Click += new System.EventHandler(this.btnAdminProduct_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.ForeColor = System.Drawing.Color.Black;
            this.btnCreateProduct.Location = new System.Drawing.Point(6, 104);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(183, 77);
            this.btnCreateProduct.TabIndex = 1;
            this.btnCreateProduct.Text = "Crear Producto";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.ForeColor = System.Drawing.Color.Black;
            this.btnGetProducts.Location = new System.Drawing.Point(6, 21);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(183, 77);
            this.btnGetProducts.TabIndex = 0;
            this.btnGetProducts.Text = "Registros";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logInBx_bg;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reportes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logInBx_bg;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Admin";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.ForeColor = System.Drawing.Color.Black;
            this.btnGetCategories.Location = new System.Drawing.Point(6, 21);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(183, 77);
            this.btnGetCategories.TabIndex = 0;
            this.btnGetCategories.Text = "Registros";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCategory.Location = new System.Drawing.Point(6, 104);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(183, 77);
            this.btnCreateCategory.TabIndex = 1;
            this.btnCreateCategory.Text = "Crear Categoria";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnAdminCategory
            // 
            this.btnAdminCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAdminCategory.Location = new System.Drawing.Point(6, 187);
            this.btnAdminCategory.Name = "btnAdminCategory";
            this.btnAdminCategory.Size = new System.Drawing.Size(183, 77);
            this.btnAdminCategory.TabIndex = 2;
            this.btnAdminCategory.Text = "Administrar Categoria";
            this.btnAdminCategory.UseVisualStyleBackColor = true;
            this.btnAdminCategory.Click += new System.EventHandler(this.btnAdminCategory_Click);
            // 
            // gridCategories
            // 
            this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategories.Location = new System.Drawing.Point(16, 31);
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.RowHeadersWidth = 51;
            this.gridCategories.RowTemplate.Height = 24;
            this.gridCategories.Size = new System.Drawing.Size(521, 245);
            this.gridCategories.TabIndex = 0;
            this.gridCategories.Visible = false;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCategory.Location = new System.Drawing.Point(65, 317);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(131, 52);
            this.btnUpdateCategory.TabIndex = 1;
            this.btnUpdateCategory.Text = "Actualizar";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Visible = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnCreateNewCategory
            // 
            this.btnCreateNewCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateNewCategory.Location = new System.Drawing.Point(212, 300);
            this.btnCreateNewCategory.Name = "btnCreateNewCategory";
            this.btnCreateNewCategory.Size = new System.Drawing.Size(131, 52);
            this.btnCreateNewCategory.TabIndex = 2;
            this.btnCreateNewCategory.Text = "Crear Categoria";
            this.btnCreateNewCategory.UseVisualStyleBackColor = true;
            this.btnCreateNewCategory.Visible = false;
            this.btnCreateNewCategory.Click += new System.EventHandler(this.btnCreateNewCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCategory.Location = new System.Drawing.Point(361, 317);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(131, 52);
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Text = "Eliminar";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Visible = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lblCategoryCode
            // 
            this.lblCategoryCode.BackColor = System.Drawing.Color.White;
            this.lblCategoryCode.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryCode.Location = new System.Drawing.Point(31, 51);
            this.lblCategoryCode.Name = "lblCategoryCode";
            this.lblCategoryCode.Size = new System.Drawing.Size(132, 23);
            this.lblCategoryCode.TabIndex = 4;
            this.lblCategoryCode.Text = "Codigo de Categoria";
            this.lblCategoryCode.Visible = false;
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.BackColor = System.Drawing.Color.White;
            this.lblCategoryDescription.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryDescription.Location = new System.Drawing.Point(31, 107);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(132, 23);
            this.lblCategoryDescription.TabIndex = 5;
            this.lblCategoryDescription.Text = "Descripcion";
            this.lblCategoryDescription.Visible = false;
            // 
            // txtCategoryCode
            // 
            this.txtCategoryCode.Location = new System.Drawing.Point(263, 51);
            this.txtCategoryCode.Multiline = true;
            this.txtCategoryCode.Name = "txtCategoryCode";
            this.txtCategoryCode.Size = new System.Drawing.Size(243, 23);
            this.txtCategoryCode.TabIndex = 6;
            this.txtCategoryCode.Visible = false;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(263, 107);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(243, 106);
            this.txtCategoryDescription.TabIndex = 7;
            this.txtCategoryDescription.WordWrap = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projecto_final_Andres_Garcia.Properties.Resources.logIn_bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.grpCategoryActions.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpProducts.ResumeLayout(false);
            this.grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.grProductActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}