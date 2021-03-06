using Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChefEquipe
{
    public partial class LoginFormChef : Form
    {
        public bool UserSuccessfullyAuthenticated { get; set; }
        public static IGestionLabo.Chercheur user;
        public LoginFormChef()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = TbEmail.Text;
            string password = TbPassword.Text;
            string role = "Chef d\\'équipe";
            user = new fonctions().login(email, password, role);

            if (user != null)
            {
                UserSuccessfullyAuthenticated = true;
                Close();
            }
            else
            {
                BtnLogin.Enabled = true;
                labelNotMatch.Visible = true;
            }
        }
    }
}
