using System;
using System.Collections;
using System.Windows.Forms;

namespace Administrateur
{
    public partial class Form1 : Form
    {
        public Form1(ArrayList user)
        {
            InitializeComponent();
            chercheurView1.Show();
            equipeView1.Hide();
            roleView1.Hide();
            laboratoireView1.Hide();
            chercheurView1.AfficherChercheur();
            
        }


        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            chercheurView1.Show();
            equipeView1.Hide();
            roleView1.Hide();
            laboratoireView1.Hide();
            chercheurView1.AfficherChercheur();
        }

        private void BtnEquipe_Click(object sender, EventArgs e)
        {
            chercheurView1.Hide();
            equipeView1.Show();
            roleView1.Hide();
            laboratoireView1.Hide();
            equipeView1.AfficherEquipe();
        }

        private void BtnRole_Click(object sender, EventArgs e)
        {
            chercheurView1.Hide();
            equipeView1.Hide();
            roleView1.Show();
            laboratoireView1.Hide();
            roleView1.AfficherRole();
        }

        private void BtnLaboratoire_Click(object sender, EventArgs e)
        {
            chercheurView1.Hide();
            equipeView1.Hide();
            roleView1.Hide();
            laboratoireView1.Show();
            laboratoireView1.AfficherLaboratoire();
        }
    }
}
