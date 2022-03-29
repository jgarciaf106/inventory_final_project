using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_final_Andres_Garcia.Classes
{

    internal class Product
    {
        public int prodcode, productcatcode;
        public string description;
        /* This is a constructor. */
        public Product(int in_prodcode, int in_catcode, string in_description)
        {
            this.prodcode = in_prodcode;
            this.productcatcode = in_catcode;
            this.description = in_description;
        }

    }
}
