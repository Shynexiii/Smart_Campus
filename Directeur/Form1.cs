using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directeur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chercheur1.Show();
            equipe1.Hide();
        }

        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            chercheur1.Show();
            equipe1.Hide();
        }

        private void BtnEquipe_Click(object sender, EventArgs e)
        {
            chercheur1.Hide();
            equipe1.Show();
        }

        private void equipe1_Load(object sender, EventArgs e)
        {

        }
    }
}
