using System;
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
            chercheur1.AfficherChercheur();
        }

        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            chercheur1.Show();
            equipe1.Hide();
            chercheur1.AfficherChercheur();
        }

        private void BtnEquipe_Click(object sender, EventArgs e)
        {
            chercheur1.Hide();
            equipe1.Show();
            equipe1.AfficherEquipe();

        }
    }
}
