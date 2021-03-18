using MySql.Data.MySqlClient;
using System.Collections;

namespace Administrateur
{
    public class functions
    {

        public MySqlConnection connection;
        public string con = "server=localhost; userid=root; password=root; database=uc2_smart_campus";
        public functions()
        {
            connection = new MySqlConnection(con);
        }
        internal ArrayList All(string query)
        {

            this.connection.Open();
            MySqlCommand requete = new MySqlCommand(query, this.connection);
            MySqlDataReader reader;
            reader = requete.ExecuteReader();
            ArrayList rowList = new ArrayList();

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                rowList.Add(values);
            }

            this.connection.Close();

            return rowList;
        }

        internal bool Create(string query)
        {
            return queryExecute(query);
        }

        internal bool Update(string query)
        {
            return queryExecute(query);
        }

        public bool Delete(string query)
        {
            return queryExecute(query);
        }

        private bool queryExecute(string query)
        {
            this.connection.Open();
            MySqlCommand requete = new MySqlCommand(query, this.connection);
            int resultat = requete.ExecuteNonQuery();
            this.connection.Close();

            return resultat == -1 ? false : true;
        }
    }
}
