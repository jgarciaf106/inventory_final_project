using projecto_final_Andres_Garcia.API;
using projecto_final_Andres_Garcia.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_final_Andres_Garcia.Logic
{
    internal class LogicInventory
    {
        public Tuple<bool,bool> GrantAccess(User objUser)
        {
            Boolean grantAccess = false;
            Boolean isAdmin = false;

            DBAPI api = new DBAPI();

            if (objUser.username != "" && objUser.password != "")
            {
                grantAccess = api.UserLogIn(objUser).Item1;
                isAdmin = api.UserLogIn(objUser).Item2;
            }
            
            return Tuple.Create(grantAccess, isAdmin);
        }


    }
}
