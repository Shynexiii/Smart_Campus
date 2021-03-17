using System;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;

namespace Directeur
{
    public partial class Equipe : UserControl
    {
        public Equipe()
        {
            InitializeComponent();
            
            try
            {
                AfficherEquipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AfficherEquipe()
        {
            tbTeamName.Text = "";
            CbTeamLaboratoire.Text = "";
            listView1.Items.Clear();
            ArrayList rowList = Program.obj.ConsulterEquipe();

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

        private void BtnAddTeam_Click(object sender, EventArgs e)
        {
            try
            {
                IGestionLabo.Equipe equipe = new IGestionLabo.Equipe(tbTeamName.Text);
                bool value = Program.obj.CreerEquipe(equipe);
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
            string Name = tbTeamName.Text;
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                IGestionLabo.Equipe equipe = new IGestionLabo.Equipe(Name);
                bool value = Program.obj.ModifierEquipe(equipe, id);
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
                bool value = Program.obj.SupprimerEquipe(id);
                MessageBox.Show(value.ToString());
                AfficherEquipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Equipe_Load(object sender, EventArgs e)
        {
            try
            {
                AfficherEquipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            tbTeamName.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }
    }
}
