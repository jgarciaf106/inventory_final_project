using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_final_Andres_Garcia.Classes
{
    internal class Category
    {
        public int catcode;
        public string description;

        public Category(int in_catcode, string in_description)
        {
            this.catcode = in_catcode;
            this.description = in_description;
        }
    }
}
