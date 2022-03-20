using projecto_final_Andres_Garcia.API;
using projecto_final_Andres_Garcia.Classes;
using projecto_final_Andres_Garcia.Logic;
using projecto_final_Andres_Garcia.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_final_Andres_Garcia
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

      
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            frmMain objFrmMain = new frmMain();
            User objUser = new User(txtUsername.Text,"", txtPassword.Text,false);
            LogicInventory objInvLogic = new LogicInventory();
 
            if (objInvLogic.GrantAccess(objUser).Item1) {
                State.isLogUserAdmin = objInvLogic.GrantAccess(objUser).Item2;
                this.Hide();
                objFrmMain.ShowDialog();             
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

    }
}
