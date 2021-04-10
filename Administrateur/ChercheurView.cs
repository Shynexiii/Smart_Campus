using System;
using System.Collections;
using System.Windows.Forms;
using Function;
using MySql.Data.MySqlClient;

namespace Administrateur
{
    public partial class ChercheurView : UserControl
    {
        public ChercheurView()
        {
            InitializeComponent();
            AfficherChercheur();
        }
        public void AfficherChercheur()
        {
            try
            {
                tbLastName.Text = "";
                TbFirstName.Text = "";
                TbEmail.Text = "";
                TbPassword.Text = "";
                CbRole.Text = "";
                CbRole.Items.Clear();
                listView1.Items.Clear();
                CbLaboratoire.Text = "";
                CbLaboratoire.Items.Clear();
                CbTeam.Text = "";
                CbTeam.Items.Clear();
                ArrayList rowList = new Admin().ConsulterChercheur();
                MySqlDataReader role = new Admin().ConsulterTableReader("roles");
                MySqlDataReader labo = new Admin().ConsulterTableReader("labs");
                MySqlDataReader team = new Admin().ConsulterTableReader("teams");

                string laboName;
                while (labo.Read())
                {
                    laboName = (string)labo[1];
                    CbLaboratoire.Items.Add(laboName);
                }


                string roleName;
                while (role.Read())
                {
                    roleName = (string)role[1];
                    CbRole.Items.Add(roleName);
                }

                string teamName;
                while (team.Read())
                {
                    teamName = (string)team[1];
                    CbTeam.Items.Add(teamName);
                }

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
                int id_lab = CbLaboratoire.SelectedIndex + 1;
                int Role_id = CbRole.SelectedIndex + 1;
                int Team_id = CbTeam.SelectedIndex + 1;
                IGestionLabo.Chercheur chercheur = new IGestionLabo.Chercheur(TbFirstName.Text, tbLastName.Text, Role_id, id_lab, Team_id, TbEmail.Text, TbPassword.Text);
                bool value = new IGestionLaboImpl().CreerChercheur(chercheur);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteChercheure_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                bool value = new IGestionLaboImpl().SupprimerChercheur(id);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditChercheure_Click(object sender, EventArgs e)
        {
            string LastName = tbLastName.Text;
            string FirstName = TbFirstName.Text;
            int Role_id = CbRole.SelectedIndex + 1;
            int id_lab = CbLaboratoire.SelectedIndex + 1;
            int Team_id = CbTeam.SelectedIndex + 1;
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                IGestionLabo.Chercheur chercheur = new IGestionLabo.Chercheur(LastName, FirstName, Role_id, id_lab, Team_id, TbEmail.Text, TbPassword.Text);
                bool value = new IGestionLaboImpl().ModifierChercheur(chercheur, id);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
                BtnAddChercheure.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChercheurView_Load(object sender, EventArgs e)
        {
            BtnAddChercheure.Enabled = true;
            AfficherChercheur();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TbFirstName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbLastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CbRole.Text = listView1.SelectedItems[0].SubItems[3].Text;
            CbLaboratoire.Text = listView1.SelectedItems[0].SubItems[4].Text;
            CbTeam.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TbEmail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TbPassword.Text = listView1.SelectedItems[0].SubItems[7].Text;
            BtnAddChercheure.Enabled = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AfficherChercheur();
        }

        private void listView1_Leave(object sender, EventArgs e)
        {
            BtnAddChercheure.Enabled = true;
        }
    }
}
