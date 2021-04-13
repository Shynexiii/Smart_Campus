using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using ChercheurProfile.Models;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ChercheurProfile.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index(int id)
        {
            dynamic dy = new ExpandoObject();
            dy.productions = GetProduction(id);
            dy.profile = GetProfile(id);
            return View(dy);
        }

        public ActionResult Home()
        {
            return View();
        }

        public List<Profile> GetProfile(int id)
        {
            List<Profile> profile = new List<Profile>();
            string query = $"SELECT profils.id, profils.lname, profils.fname, profils.email, roles.role, labs.code, teams.name, grades.grade_name " +
                $"FROM profils " +
                $"JOIN roles ON roles.id = profils.role_id " +
                $"JOIN labs ON labs.id = profils.lab_id " +
                $"JOIN teams ON teams.id = profils.team_id " +
                $"JOIN grades ON grades.id = profils.grade_id " +
                $"WHERE profils.id = {id} " +
                $"ORDER BY profils.id ASC";
            DataTable dataTable = new ProductionScientifiqueImpl().Connection(query);

            foreach (DataRow datarow in dataTable.Rows)
            {
                profile.Add(new Profile
                {
                    Id = Convert.ToInt32(datarow["id"]),
                    Nom = Convert.ToString(datarow["lname"]),
                    Prenom = Convert.ToString(datarow["fname"]),
                    Email = Convert.ToString(datarow["email"]),
                    Role = Convert.ToString(datarow["role"]),
                    Laboratoire = Convert.ToString(datarow["code"]),
                    Team = Convert.ToString(datarow["name"]),
                    Grade = Convert.ToString(datarow["grade_name"]),
                });
            }

            return profile;
        }
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