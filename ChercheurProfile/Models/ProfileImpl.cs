using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ChercheurProfile.Models
{
    public class ProfileImpl
    {
        

        public List<Profile> GetProfile(int id)
        {
            List<Profile> profile = new List<Profile>();
            string query = $"SELECT profils.id, profils.lname, profils.fname, profils.email, roles.role, labs.code, teams.name " +
                $"FROM profils " +
                $"JOIN roles ON roles.id = profils.role_id " +
                $"JOIN labs ON labs.id = profils.lab_id " +
                $"JOIN teams ON teams.id = profils.team_id " +
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
                });
            }

            return profile;
        }
    }
}