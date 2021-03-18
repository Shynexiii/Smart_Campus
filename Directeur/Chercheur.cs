using System;
using System.Windows.Forms;
using System.Collections;

namespace Directeur
{
    public partial class Chercheur : UserControl
    {

        
        public Chercheur()
        {
            InitializeComponent();
            
            try
            {
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AfficherChercheur()
        {
            try
            {
                tbLastName.Text = "";
                TbFirstName.Text = "";
                CbRole.Text = "";
                listView1.Items.Clear();
                ArrayList rowList = Program.obj.ConsulterChercheur();

                foreach (object[] row in rowList)
                {
                    string[] values = new string[row.Length];
                    int columnIndex = 0;

                    foreach (object column in row)
                    {
                        values[columnIndex++] = Convert.ToString(column);
                    }

                    ListViewItem newItem = new ListViewItem(values);
                    listView1.Items.Add(newItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddChercheure_Click(object sender, EventArgs e)
        {
            try
            {
                IGestionLabo.Chercheur chercheur = new IGestionLabo.Chercheur(TbFirstName.Text, tbLastName.Text,CbRole.SelectedIndex.ToString());
                bool value = Program.obj.CreerChercheur(chercheur);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Chercheur_Load(object sender, EventArgs e)
        {
            AfficherChercheur();
        }

        private void BtnEditChercheure_Click(object sender, EventArgs e)
        {
            string LastName = tbLastName.Text;
            string FirstName = TbFirstName.Text;
            string Role = CbRole.SelectedIndex.ToString();
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                IGestionLabo.Chercheur chercheur = new IGestionLabo.Chercheur(LastName, FirstName, Role);
                bool value = Program.obj.ModifierChercheur(chercheur, id);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TbFirstName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbLastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CbRole.SelectedIndex = Int32.Parse(listView1.SelectedItems[0].SubItems[3].Text);
        }

        private void BtnDeleteChercheure_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                bool value = Program.obj.SupprimerChercheur(id);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
