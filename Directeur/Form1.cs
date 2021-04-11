using System;
using System.Windows.Forms;


namespace Directeur
{
    public partial class Form1 : Form
    {
        public static int Laboratoire_id;
        public Form1(IGestionLabo.Chercheur chercheur)
        {
            InitializeComponent();
            chercheur1.Show();
            equipe1.Hide();
            prod_Sci_Dir1.Hide();
            chercheur1.AfficherChercheur();
            LabelNom.Text = chercheur.Nom;
            LabelPrenom.Text = chercheur.Prenom;
            Laboratoire_id = chercheur.Laboratoire;
        }

        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            chercheur1.Show();
            equipe1.Hide();
            prod_Sci_Dir1.Hide();
            chercheur1.AfficherChercheur();
        }

        private void BtnEquipe_Click(object sender, EventArgs e)
        {
            chercheur1.Hide();
            equipe1.Show();
            prod_Sci_Dir1.Hide();
            equipe1.AfficherEquipe();

        }

        private void BtnProdSci_Click(object sender, EventArgs e)
        {
            chercheur1.Hide();
            equipe1.Hide();
            prod_Sci_Dir1.Show();
            prod_Sci_Dir1.AfficherProduction();
        }
    }
}
