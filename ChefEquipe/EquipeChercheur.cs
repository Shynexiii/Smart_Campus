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

namespace ChefEquipe
{
    public partial class EquipeChercheur : UserControl
    {
        public EquipeChercheur()
        {
            InitializeComponent();
            AfficherChercheur();
        }

        private void BtnRetirerChercheure_Click(object sender, EventArgs e)
        {
            
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Program.objEquipe.RetirerChercheur(id);
            AfficherChercheur();
            
        }

        public void AfficherChercheur()
        {
            try
            {
                listView1.Items.Clear();
                int ChefEquipe_teamId = 1;
                int ChefEquipe_labId = 1;
                ArrayList rowList = Program.objEquipe.ConsulterChercheur(ChefEquipe_teamId, ChefEquipe_labId);

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
