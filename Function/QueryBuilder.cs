using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Function
{
    public class QueryBuilder
    {
        public MySqlConnection connection;
        public string con = "server=localhost; userid=root; password=; database=uc2_smart_campus";
        public QueryBuilder()
        {
            this.connection = new MySqlConnection(con);
        }

        public ArrayList All(string query)
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

        public MySqlDataReader AllData(string query)
        {
            this.connection.Open();
            MySqlCommand requete = new MySqlCommand(query, this.connection);
            MySqlDataReader reader;
            reader = requete.ExecuteReader();
            return reader;
        }
        public string[] AllDataArray(string query)
        {
            this.connection.Open();
            MySqlCommand requete = new MySqlCommand(query, this.connection);
            MySqlDataReader reader;
            reader = requete.ExecuteReader();

            string[] data = new string[reader.FieldCount];
            int i = 0;
            while (reader.Read())
            {
                data[i] = reader.GetValue(i).ToString();
            }
            return data;
        }
        public bool Select(string query)
        {
            return queryExecute(query);
        }

        public bool Create(string query)
        {
            return queryExecute(query);
        }

        public bool Update(string query)
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

        public bool GetQueryResult(string query)
        {
            this.connection.Open();
            MySqlDataAdapter requete = new MySqlDataAdapter(query, this.connection);
            DataTable dt = new DataTable();
            requete.Fill(dt);
            return dt.Rows[0][0].ToString() == "1";
            
        }
    }
}
