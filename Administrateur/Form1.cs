using IGestionLabo;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Administrateur
{
    public partial class Form1 : Form
    {
        public Form1(Chercheur user)
        {
            InitializeComponent();
            chercheurView1.Show();
            equipeView1.Hide();
            roleView1.Hide();
            laboratoireView1.Hide();
            gradeView1.Hide();
            chercheurView1.AfficherChercheur();
            LabelNom.Text = user.Nom;
            LabelPrenom.Text = user.Prenom;
        }


        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            chercheurView1.Show();
            equipeView1.Hide();
            roleView1.Hide();
            laboratoireView1.Hide();
            gradeView1.Hide();
            chercheurView1.AfficherChercheur();
        }

        private void BtnEquipe_Click(object sender, EventArgs e)
        {
            chercheurView1.Hide();
            equipeView1.Show();
            roleView1.Hide();
            laboratoireView1.Hide();
            gradeView1.Hide();
            equipeView1.AfficherEquipe();
        }

        private void BtnRole_Click(object sender, EventArgs e)
        {
            chercheurView1.Hide();
            equipeView1.Hide();
            roleView1.Show();
            laboratoireView1.Hide();
            roleView1.AfficherRole();
            gradeView1.Hide();
        }

        private void BtnLaboratoire_Click(object sender, EventArgs e)
        {
            chercheurView1.Hide();
            equipeView1.Hide();
            roleView1.Hide();
            laboratoireView1.Show();
            gradeView1.Hide();
            laboratoireView1.AfficherLaboratoire();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            chercheurView1.Hide();
            equipeView1.Hide();
            roleView1.Hide();
            laboratoireView1.Hide();
            gradeView1.Show();
            gradeView1.AfficherGrade();
        }
    }
}
