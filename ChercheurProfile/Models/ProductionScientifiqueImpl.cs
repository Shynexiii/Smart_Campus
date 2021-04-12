using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ChercheurProfile.Models
{
    public class ProductionScientifiqueImpl
    {
        public List<ProductionScientifique> GetProduction(int id)
        {
            List<ProductionScientifique> production = new List<ProductionScientifique>();
            string query = $"SELECT prod_sci.id, prod_sci.title, prod_sci.description, prod_sci.reference, " +
                $"prod_sci.type, prod_sci.created_at, prod_sci.created_by " +
                $"FROM prod_sci " +
                $"JOIN profils ON profils.id = prod_sci.created_by " +
                $"JOIN labs ON labs.id = profils.lab_id " +
                $"JOIN teams ON teams.id = profils.team_id " +
                $"WHERE profils.id = {id} " +
                $"ORDER BY prod_sci.id ASC";

            DataTable dataTable = Connection(query);

            foreach (DataRow datarow in dataTable.Rows)
            {
                production.Add(new ProductionScientifique
                {
                    Id = Convert.ToInt32(datarow["id"]),
                    Title = Convert.ToString(datarow["title"]),
                    Description = Convert.ToString(datarow["description"]),
                    Reference = Convert.ToString(datarow["reference"]),
                    Type = Convert.ToString(datarow["type"]),
                    Created_at = Convert.ToString(datarow["created_at"]),
                    Created_by = Convert.ToInt32(datarow["created_by"]),
                });
            }

            return production;
        }

        public DataTable Connection(String query)
        {
            string con = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(con);
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlConnection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            mySqlConnection.Close();

            return dataTable;
        }
    }
}