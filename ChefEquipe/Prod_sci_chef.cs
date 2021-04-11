using System;
using System.Collections;
using System.Windows.Forms;

namespace ChefEquipe
{
    public partial class Prod_sci_chef : UserControl
    {
        public Prod_sci_chef()
        {
            InitializeComponent();
            AfficherProduction();
        }

        public void AfficherProduction()
        {
            try
            {
                listView1.Items.Clear();
                ArrayList rowList = Program.objEquipe.ConsulterProdctionScientifique(Form1.Lab_id, Form1.Team_id);
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
