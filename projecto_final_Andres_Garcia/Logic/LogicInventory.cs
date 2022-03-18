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
       /// <summary>
       /// It checks if the user is in the database and if the password matches the username.
       /// </summary>
       /// <param name="User">The user object that contains the username and password.</param>
       /// <returns>
       /// A Tuple of two booleans. The first boolean is a flag to indicate if the user has been granted
       /// access. The second boolean is a flag to indicate if the user is an admin.
       /// </returns>
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
