using System;
using System.Collections;
using System.Windows.Forms;
using Function;

namespace Administrateur
{
    public partial class LaboratoireView : UserControl
    {
        public LaboratoireView()
        {
            InitializeComponent();
            AfficherLaboratoire();
        }

        private void BtnAddLaboratoire_Click(object sender, EventArgs e)
        {
            try
            {
                Laboratoire laboratoire = new Laboratoire(TbLaboratoireName.Text);
                bool value = new Admin().CreerLaboratoire(laboratoire);
                MessageBox.Show(value.ToString());
                AfficherLaboratoire();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditLaboratoire_Click(object sender, EventArgs e)
        {
            string LaboratoireName = TbLaboratoireName.Text;
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                Laboratoire laboratoire = new Laboratoire(LaboratoireName);
                bool value = new Admin().ModifierLaboratoire(laboratoire, id);
                MessageBox.Show(value.ToString());
                AfficherLaboratoire();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteLaboratoire_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                bool value = new Admin().SupprimerLaboratoire(id);
                MessageBox.Show(value.ToString());
                AfficherLaboratoire();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AfficherLaboratoire();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TbLaboratoireName.Text = listView1.SelectedItems[0].SubItems[1].Text;

        }

        public void AfficherLaboratoire()
        {
            try
            {
                TbLaboratoireName.Text = "";
                listView1.Items.Clear();
                ArrayList rowList = new Admin().ConsulterLaboratoire();

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
