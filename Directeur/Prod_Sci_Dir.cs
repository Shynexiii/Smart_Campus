using System;
using System.Collections;
using System.Windows.Forms;

namespace Directeur
{
    public partial class Prod_Sci_Dir : UserControl
    {
        public Prod_Sci_Dir()
        {
            InitializeComponent();
            AfficherProduction();
        }

        public void AfficherProduction()
        {
            try
            {
                listView1.Items.Clear();
                ArrayList rowList = Program.obj.ConsulterProdctionScientifique(Form1.Laboratoire_id);
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
