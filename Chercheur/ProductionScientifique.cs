using IGestionProduction;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Chercheur
{
    public partial class ProductionScientifique : UserControl
    {
        public ProductionScientifique()
        {
            InitializeComponent();
        }

        private void BtnAddProduction_Click(object sender, EventArgs e)
        {
            int created_by = 1;
            string title = TbTitle.Text;
            string description = TbDescription.Text;
            string reference = TbReference.Text;
            string type = TbType.Text;
            Production production = new Production(title, description, reference, type);
            Program.objProduction.PublierProduction(production, created_by);
            AfficherProduction();
        }

        private void BtnEditProduction_Click(object sender, EventArgs e)
        {
            int created_by = 1;
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string title = TbTitle.Text;
            string description = TbDescription.Text;
            string reference = TbReference.Text;
            string type = TbType.Text;
            Production production = new Production(title, description, reference, type);
            Program.objProduction.ModifierProduction(production, id, created_by);
            AfficherProduction();
        }

        private void BtnDeleteProduction_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Program.objProduction.SupprimerProduction(id);
            AfficherProduction();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TbTitle.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TbDescription.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TbReference.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TbType.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        public void AfficherProduction()
        {
            try
            {
                TbTitle.Text = "";
                TbDescription.Text = "";
                TbReference.Text = "";
                TbType.Text = "";
                listView1.Items.Clear();
                int id = 1;
                ArrayList rowList = Program.objProduction.ConsulerProductions(id);

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

        private void ProductionScientifique_Load(object sender, EventArgs e)
        {
            AfficherProduction();
        }
    }
}
