using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Admin 
    { 
        public ArrayList ConsulterRole()
        {
            var query = $"SELECT * FROM roles";
            return new QueryBuilder().All(query);
        }

        public MySqlDataReader ConsulterRoleReader()
        {
            var query = $"SELECT * FROM roles";
            return new QueryBuilder().AllData(query);
        }

        public MySqlDataReader GetRoleChef()
        {
            var query = $"SELECT id FROM roles WHERE `role`= 'Chef d\'équipe' ;";
            return new QueryBuilder().AllData(query);
        }

        public bool CreerRole(Role role)
        {
            string query = $"INSERT INTO roles (`role`) VALUES (\"{role.Name}\");";
            return new QueryBuilder().Create(query);
        }

        public bool ModifierRole(Role role, int id)
        {

            var query = $"UPDATE roles SET `role`='{role.Name}' WHERE `id`={id};";
            return new QueryBuilder().Update(query);
        }

        public bool SupprimerRole(int id)
        {
            var query = $"DELETE FROM roles WHERE `id`= {id};";
            return new QueryBuilder().Delete(query);
        }

        public ArrayList ConsulterLaboratoire()
        {
            var query = $"SELECT * FROM labs";
            return new QueryBuilder().All(query);
        }

        public MySqlDataReader ConsulterLaboratoireReader()
        {
            var query = $"SELECT * FROM labs";
            return new QueryBuilder().AllData(query);
        }

        public bool CreerLaboratoire(Laboratoire laboratoire)
        {
            string query = $"INSERT INTO labs (`code`) VALUES ('{laboratoire.Name}');";
            return new QueryBuilder().Create(query);
        }

        public bool ModifierLaboratoire(Laboratoire laboratoire, int id)
        {

            var query = $"UPDATE labs SET `code`='{laboratoire.Name}' WHERE  `id`={id};";
            return new QueryBuilder().Update(query);
        }

        public bool SupprimerLaboratoire(int id)
        {
            var query = $"DELETE FROM labs WHERE `id`= {id};";
            return new QueryBuilder().Delete(query);
        }
    }
}
