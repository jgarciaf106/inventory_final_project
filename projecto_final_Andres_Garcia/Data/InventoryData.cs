﻿using projecto_final_Andres_Garcia.API;
using projecto_final_Andres_Garcia.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_final_Andres_Garcia.Data
{
    internal class InventoryData
    {
        /// <summary>
        /// It loads the products from the database into a DataTable.
        /// </summary>
        /// <returns>
        /// A BindingSource object.
        /// </returns>
        public BindingSource loadProducts()
        {
            List<Product> products = new DBAPI().GetProducts();

            BindingSource source = new BindingSource();
            DataTable dt = new DataTable();

            dt.Columns.Add("Product Code", typeof(int));
            dt.Columns.Add("Category Code", typeof(int));
            dt.Columns.Add("Description", typeof(string));

            foreach(Product product in products)
            {
                DataRow row = dt.NewRow();
                row["Product Code"] = product.prodcode;
                row["Category Code"] = product.catcode;
                row["Description"] = product.description;
                dt.Rows.Add(row);
            }

            source.DataSource = dt;

            return source;
        }
        
        /// <summary>
        /// Loads the categories from the database and returns them as a BindingSource
        /// </summary>
        /// <returns>
        /// A BindingSource object.
        /// </returns>
        public BindingSource loadCategories()
        {
            List<Category> categories = new DBAPI().GetCategories();

            BindingSource source = new BindingSource();
            DataTable dt = new DataTable();

            dt.Columns.Add("Category Code", typeof(int));
            dt.Columns.Add("Description", typeof(string));

            foreach (Category category in categories)
            {
                DataRow row = dt.NewRow();
                row["Category Code"] = category.catcode;
                row["Description"] = category.description;
                dt.Rows.Add(row);
            }

            source.DataSource = dt;

            return source;
        }

        /// <summary>
        /// Loads the users from the database and returns them as a BindingSource
        /// </summary>
        /// <returns>
        /// A BindingSource object.
        /// </returns>
        public BindingSource loadUsers()
        {
            List<User> users = new DBAPI().GetUsers();

            BindingSource source = new BindingSource();
            DataTable dt = new DataTable();

            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Is Admin?", typeof(bool));

            foreach (User user in users)
            {
                DataRow row = dt.NewRow();
                row["Username"] = user.username;
                row["Name"] = user.name;
                row["Password"] = user.password;
                row["Is Admin?"] = user.isadmin;
                dt.Rows.Add(row);
            }


            source.DataSource = dt;

            return source;
        }

        public BindingSource loadProductsCategories()
        {
            List<Product> products = new DBAPI().GetProducts();
            List<Category> categories = new DBAPI().GetCategories();

            BindingSource source = new BindingSource();
            DataTable dtP = new DataTable();
            DataTable dtC = new DataTable();

            
            dtP.Columns.Add("Product Code", typeof(int));
            dtP.Columns.Add("Category Code", typeof(int));
            dtP.Columns.Add("Product Description", typeof(string));
            dtP.PrimaryKey = new DataColumn[] { dtP.Columns["Category Code"] };

            foreach (Product product in products)
            {
                DataRow row = dtP.NewRow();
                row["Product Code"] = product.prodcode;
                row["Category Code"] = product.catcode;
                row["Product Description"] = product.description;
                dtP.Rows.Add(row);
            }

            
            dtC.Columns.Add("Category Code", typeof(int));
            dtC.Columns.Add("Category Description", typeof(string));
            dtC.PrimaryKey = new DataColumn[] { dtC.Columns["Category Code"] };

            foreach (Category category in categories)
            {
                DataRow row = dtC.NewRow();
                row["Category Code"] = category.catcode;
                row["Category Description"] = category.description;
                dtC.Rows.Add(row);
            }

            dtP.Merge(dtC);

            source.DataSource = dtP;

            return source;
        }
    }
}
