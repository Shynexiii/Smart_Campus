using System;
using System.Windows.Forms;


namespace ChefEquipe
{
    public partial class Form1 : Form
    {
        public Form1(IGestionLabo.Chercheur chercheur)
        {
            InitializeComponent();
            equipeChercheur1.Show();
            LabelNom.Text = chercheur.Nom;
            LabelPrenom.Text = chercheur.Prenom;
        }
        
        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            equipeChercheur1.Show();
            equipeChercheur1.AfficherChercheur();
        }
    }
}
