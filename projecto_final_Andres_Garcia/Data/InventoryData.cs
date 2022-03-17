using projecto_final_Andres_Garcia.API;
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

        /*
        public BindingSource loadCategories()
        {
            List<Product> products = new DBAPI().GetCategory();

            BindingSource source = new BindingSource();
            DataTable dt = new DataTable();

            dt.Columns.Add("Category Code", typeof(int));
            dt.Columns.Add("Description", typeof(string));

            foreach (Category category in category)
            {
                DataRow row = dt.NewRow();
                row["Category Code"] = category.catcode;
                row["Description"] = category.description;
                dt.Rows.Add(row);
            }

            source.DataSource = dt;

            return source;
        }*/
    }
}
