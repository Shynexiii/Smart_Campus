using System;
using System.Collections;
using System.Windows.Forms;
using Function;

namespace Administrateur
{
    public partial class RoleView : UserControl
    {
        public RoleView()
        {
            InitializeComponent();
            AfficherRole();
        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                Role role = new Role(TbRoleName.Text);
                bool value = new Admin().CreerRole(role);
                MessageBox.Show(value.ToString());
                AfficherRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditRole_Click(object sender, EventArgs e)
        {
            string RoleName = TbRoleName.Text;
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                Role role = new Role(RoleName);
                bool value = new Admin().ModifierRole(role, id);
                MessageBox.Show(value.ToString());
                AfficherRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteRole_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                bool value = new Admin().SupprimerRole(id);
                MessageBox.Show(value.ToString());
                AfficherRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AfficherRole();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TbRoleName.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        public void AfficherRole()
        {
            try
            {
                TbRoleName.Text = "";
                listView1.Items.Clear();
                ArrayList rowList = new Admin().ConsulterRole();

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
