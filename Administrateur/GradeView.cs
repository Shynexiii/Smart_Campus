using Function;
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

namespace Administrateur
{
    public partial class GradeView : UserControl
    {
        public GradeView()
        {
            InitializeComponent();
            AfficherGrade();
        }

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                Grade grade = new Grade(TbGradeName.Text);
                bool value = new Admin().CreerGrade(grade);
                MessageBox.Show(value.ToString());
                AfficherGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditGrade_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                Grade grade = new Grade(TbGradeName.Text);
                bool value = new Admin().ModifierGrade(grade, id);
                MessageBox.Show(value.ToString());
                AfficherGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteGrade_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                bool value = new Admin().SupprimerGrade(id);
                MessageBox.Show(value.ToString());
                AfficherGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TbGradeName.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        public void AfficherGrade()
        {
            try
            {
                TbGradeName.Text = "";
                listView1.Items.Clear();
                ArrayList rowList = new Admin().ConsulterGrade();

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
