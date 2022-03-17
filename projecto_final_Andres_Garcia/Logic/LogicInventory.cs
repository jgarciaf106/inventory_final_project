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
        public Boolean GrantAccess(User objUser)
        {
            Boolean registro_persona = false;
            DBAPI api = new DBAPI();

            if (objUser.username != "" && objUser.password != "")
            {
                registro_persona = api.UserLogIn(objUser);
            }
            
            return registro_persona;
        }

    }
}
