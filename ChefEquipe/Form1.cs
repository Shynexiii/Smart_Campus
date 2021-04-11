using System;
using System.Windows.Forms;


namespace ChefEquipe
{
    public partial class Form1 : Form
    {
        public static int Lab_id;
        public static int Team_id;
        public Form1(IGestionLabo.Chercheur chercheur)
        {
            InitializeComponent();
            equipeChercheur1.Show();
            prod_sci_chef1.Hide();
            LabelNom.Text = chercheur.Nom;
            LabelPrenom.Text = chercheur.Prenom;
            Lab_id = chercheur.Laboratoire;
            Team_id = chercheur.Team;
        }
        
        private void BtnChercheure_Click(object sender, EventArgs e)
        {
            equipeChercheur1.Show();
            prod_sci_chef1.Hide();
            equipeChercheur1.AfficherChercheur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            equipeChercheur1.Hide();
            prod_sci_chef1.Show();
            prod_sci_chef1.AfficherProduction();
        }
    }
}
