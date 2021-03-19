﻿using System;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Directeur
{
    public partial class Chercheur : UserControl
    {
        public Chercheur()
        {
            InitializeComponent();
            
            try
            {
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void AfficherChercheur()
        {
            try
            {
                tbLastName.Text = "";
                TbFirstName.Text = "";
                CbRole.Text = "";
                CbRole.Items.Clear();
                listView1.Items.Clear();
                CbLaboratoire.Text = "";
                CbLaboratoire.Items.Clear();
                ArrayList rowList = Program.obj.ConsulterChercheur();

                MySqlDataReader role = Program.obj.ConsulterRoleReader();
                MySqlDataReader labo = Program.obj.ConsulterLaboratoireReader();

                string laboName;
                while (labo.Read())
                {
                    laboName = (string)labo[1];
                    CbLaboratoire.Items.Add(laboName);
                }


                string roleName;
                while (role.Read())
                {
                    roleName = (string)role[1];
                    CbRole.Items.Add(roleName);
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

        private void BtnAddChercheure_Click(object sender, EventArgs e)
        {
            try
            {
                int id_lab = CbLaboratoire.SelectedIndex + 1;
                int Role_id = CbRole.SelectedIndex + 1;
                IGestionLabo.Chercheur chercheur = new IGestionLabo.Chercheur(TbFirstName.Text, tbLastName.Text, Role_id, id_lab);
                bool value = Program.obj.CreerChercheur(chercheur);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Chercheur_Load(object sender, EventArgs e)
        {
            AfficherChercheur();
        }

        private void BtnEditChercheure_Click(object sender, EventArgs e)
        {
            string LastName = tbLastName.Text;
            string FirstName = TbFirstName.Text;
            int Role_id = CbRole.SelectedIndex + 1;
            int id_lab = CbLaboratoire.SelectedIndex + 1;
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                IGestionLabo.Chercheur chercheur = new IGestionLabo.Chercheur(LastName, FirstName, Role_id, id_lab);
                bool value = Program.obj.ModifierChercheur(chercheur, id);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            TbFirstName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbLastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CbRole.Text = listView1.SelectedItems[0].SubItems[3].Text;
            CbLaboratoire.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void BtnDeleteChercheure_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            try
            {
                bool value = Program.obj.SupprimerChercheur(id);
                MessageBox.Show(value.ToString());
                AfficherChercheur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AfficherChercheur();
        }
    }
}
