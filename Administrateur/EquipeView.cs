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
using Function;
using MySql.Data.MySqlClient;

namespace Administrateur
{
    public partial class EquipeView : UserControl
    {
        public EquipeView()
        {
            InitializeComponent();
            AfficherEquipe();
        }


        private void BtnAddTeam_Click(object sender, EventArgs e)
        {
            try
            {
                int id_lab = CbLaboratoire.SelectedIndex + 1;
                IGestionLabo.Equipe equipe = new IGestionLabo.Equipe(TbTeamName.Text);
                bool value = new IGestionLaboImpl().CreerEquipe(equipe, id_lab);
                MessageBox.Show(value.ToString());
                AfficherEquipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditTeam_Click(object sender, EventArgs e)
        {
            string TeamName = TbTeamName.Text;
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                int id_lab = CbLaboratoire.SelectedIndex + 1;
                IGestionLabo.Equipe equipe = new IGestionLabo.Equipe(TeamName);
                bool value = new IGestionLaboImpl().ModifierEquipe(equipe, id, id_lab);
                MessageBox.Show(value.ToString());
                AfficherEquipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteTeam_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                bool value = new IGestionLaboImpl().SupprimerEquipe(id);
                MessageBox.Show(value.ToString());
                AfficherEquipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AfficherEquipe();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TbTeamName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            CbLaboratoire.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        public void AfficherEquipe()
        {
            try
            {
                TbTeamName.Text = "";
                listView1.Items.Clear();
                CbLaboratoire.Text = "";
                CbLaboratoire.Items.Clear();
                ArrayList rowList = new IGestionLaboImpl().ConsulterEquipe();
                MySqlDataReader labo = new Admin().ConsulterLaboratoireReader();
                
                string name;
                while (labo.Read())
                {
                    name = (string)labo[1];
                    CbLaboratoire.Items.Add(name);
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

    }
}
