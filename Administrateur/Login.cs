using Function;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrateur
{
    public partial class Login : Form
    {
        public ArrayList user;
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //BtnLogin.Enabled = false;
            string email = TbEmail.Text;
            string password = TbPassword.Text;
            user = new Admin().login(email, password);

            if (user.Count != 0)
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

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {
            labelNotMatch.Visible = false;
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            labelNotMatch.Visible = false;
        }
    }
}
