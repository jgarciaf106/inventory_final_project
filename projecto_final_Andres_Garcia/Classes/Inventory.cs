using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_final_Andres_Garcia.Classes
{
    
    internal class Inventory
    {
        public string proddescription, catdescription;
        public int prodcode, catcode;
        public Inventory(int in_prodcode, int in_catcode, string in_prod_description, string in_cat_description)
        {
            this.prodcode = in_prodcode;
            this.catcode = in_catcode;
            this.proddescription = in_prod_description;
            this.catdescription = in_cat_description;
        }
    }
}
