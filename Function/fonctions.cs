using IGestionLabo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class fonctions
    {
        public Chercheur chercheur;
        public Chercheur login(string email, string password, string role = "0")
        {
            string query;
            if (role == "0")
            {
                query = $"SELECT p.id, p.fname, p.lname, p.role_id, p.lab_id, p.team_id, p.email, p.password, p.grade_id " +
                $"FROM profils p " +
                $"JOIN roles r ON r.id = p.role_id " +
                $"WHERE p.email ='{email}' AND p.password = '{password}';";
            }
            else
            {
                query = $"SELECT p.id, p.fname, p.lname, p.role_id, p.lab_id, p.team_id, p.email, p.password, p.grade_id " +
                $"FROM profils p " +
                $"JOIN roles r ON r.id = p.role_id " +
                $"WHERE p.email ='{email}' AND p.password = '{password}' AND r.role = '{role}';";
            }
            
            var value = new QueryBuilder().AllData(query);
            Console.WriteLine();
            while (value.Read())
            {
                if (value.FieldCount == 0)
                {
                    chercheur = null;
                }
                else
                {
                    chercheur = new Chercheur(value.GetString(2), value.GetString(1), value.GetInt32(3), value.GetInt32(4), value.GetInt32(5), value.GetString(6), value.GetString(7), value.GetInt32(8));
                }
            }
            return chercheur;
        }

    }
}
