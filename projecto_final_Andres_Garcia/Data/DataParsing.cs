using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_final_Andres_Garcia.Data
{
   
    public class Result
    {

        public string description { get; set; }
        public int prod_code { get; set; }
        public int cat_code { get; set; }
    }

    internal class DataParsing
    {
        public string access { get; set; }
        public bool is_admin { get; set; }
        public string msg { get; set; }
        public string message { get; set; }
        public List<Result> results { get; set; }

    }

}
