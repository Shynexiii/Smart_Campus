using System;
using System.Collections;
using System.Diagnostics;
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
                ArrayList rowList = Program.objEquipe.ConsulterChercheur(LoginFormChef.user.Laboratoire,LoginFormChef.user.Team);

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

        private void BtnView_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            string url = $"http://localhost:54267/Profile/Index/{id}";
            Process.Start(url);
        }
    }
}
