using IGestionLabo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Administrateur
{
    public class IGestionLaboImpl : MarshalByRefObject, IGestionLabo.IGestionLabo
    {
        public static string connectionString = "server=localhost; userid=root; password=root; database=uc2_smart_campus";


        public bool AffecterChercheur(Chercheur chercheur, Equipe equipe)
        {
            throw new NotImplementedException();
        }

        public bool ChoisirChef(Chercheur chercheur, Equipe equipe)
        {
            throw new NotImplementedException();
        }

        public ArrayList ConsulterChercheur()
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var query = "SELECT * FROM profils";
            MySqlCommand requete = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            reader = requete.ExecuteReader();
            ArrayList rowList = new ArrayList();

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                rowList.Add(values);
            }

            connection.Close();

            return rowList;
        }

        public ArrayList ConsulterEquipe()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var query = "SELECT * FROM teams";
            MySqlCommand requete = new MySqlCommand(query, connection);
            MySqlDataReader reader;
            reader = requete.ExecuteReader();
            ArrayList rowList = new ArrayList();

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                rowList.Add(values);
            }

            connection.Close();

            return rowList;
        }

        public bool CreerChercheur(Chercheur chercheur)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var query = $"INSERT INTO profils (`fname`, `lname`, `role_id`) VALUES ('{chercheur.Prenom}','{chercheur.Nom}','{chercheur.Role}');";
            MySqlCommand requete = new MySqlCommand(query, connection);
            int resultat = requete.ExecuteNonQuery();
            connection.Close();

            return resultat == -1 ? false : true;
        }

        public bool CreerEquipe(Equipe equipe)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var query = $"INSERT INTO teams (`name`) VALUES ('{equipe.Name}');";
            MySqlCommand requete = new MySqlCommand(query, connection);
            int resultat = requete.ExecuteNonQuery();
            connection.Close();

            return resultat == -1 ? false : true;
        }

        public bool ModifierChercheur(Chercheur chercheur, int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var query = $"UPDATE profils SET `fname`='{chercheur.Prenom}', `lname`='{chercheur.Nom}', `role_id`='{chercheur.Role}' WHERE  `id`={id};";
            MySqlCommand requete = new MySqlCommand(query, connection);
            int resultat = requete.ExecuteNonQuery();
            connection.Close();

            return resultat == -1 ? false : true;
        }

        public bool ModifierEquipe(Equipe equipe, int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var query = $"UPDATE teams SET `name`='{equipe.Name}' WHERE `id`={id};";
            MySqlCommand requete = new MySqlCommand(query, connection);
            int resultat = requete.ExecuteNonQuery();
            connection.Close();

            return resultat == -1 ? false : true;
        }

        public bool SupprimerChercheur(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var query = $"DELETE FROM profils WHERE `id`= {id};";
            MySqlCommand requete = new MySqlCommand(query, connection);
            int resultat = requete.ExecuteNonQuery();
            connection.Close();

            return resultat == -1 ? false : true;
        }

        public bool SupprimerEquipe(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            var query = $"DELETE FROM teams WHERE `id`= {id};";
            MySqlCommand requete = new MySqlCommand(query, connection);
            int resultat = requete.ExecuteNonQuery();
            connection.Close();

            return resultat == -1 ? false : true;
        }

    }
}
