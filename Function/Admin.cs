using IGestionLabo;
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
        public Chercheur chercheur;
        public String[] CurrentUser;
        public ArrayList ConsulterRole()
        {
            var query = $"SELECT * FROM roles";
            return new QueryBuilder().All(query);
        }
        public ArrayList ConsulterChercheur()
        {
            var query = $"SELECT p.id, p.fname, p.lname, r.role, l.code, t.name, p.email, p.password, g.grade_name " +
                $"FROM profils p " +
                $"JOIN roles r ON p.role_id = r.id " +
                $"JOIN labs l ON p.lab_id = l.id " +
                $"JOIN teams t ON p.team_id = t.id " +
                $"JOIN grades g ON p.grade_id = g.id " +
                $"ORDER BY p.id ASC";

            return new QueryBuilder().All(query);
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

        public MySqlDataReader ConsulterTableReader(string table)
        {
            var query = $"SELECT * FROM {table}";
            return new QueryBuilder().AllData(query);
        }

        public ArrayList ConsulterGrade()
        {
            var query = $"SELECT * FROM grades";
            return new QueryBuilder().All(query);
        }
        public bool CreerGrade(Grade grade)
        {
            string query = $"INSERT INTO grades (`grade_name`) VALUES (\"{grade.Name}\");";
            return new QueryBuilder().Create(query);
        }

        public bool ModifierGrade(Grade grade, int id)
        {
            var query = $"UPDATE grades SET `grade_name`='{grade.Name}' WHERE `id`={id};";
            return new QueryBuilder().Update(query);
        }

        public bool SupprimerGrade(int id)
        {
            var query = $"DELETE FROM grades WHERE `id`= {id};";
            return new QueryBuilder().Delete(query);
        }

        public Chercheur login(string email, string password, string role)
        {
            string query = $"SELECT * FROM profils WHERE email ='{email}' AND password ='{password}' AND role_id = '{role}';";
            var value = new QueryBuilder().AllData(query);
            
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

        public ArrayList Consulter(string name)
        {
            string query = $"SELECT * FROM {name};";
            var value = new QueryBuilder().AllData(query);
            ArrayList arrayList = new ArrayList();

            while (value.Read())
            {
                object[] data = new object[value.FieldCount];
                value.GetValues(data);
                arrayList.Add(data);
            }
            return arrayList;
        }

        public String[] GetCurrentUser(string email, string password)
        {
            string query = $"SELECT * FROM profils WHERE email = '{email}' AND password = '{password}';";
            var value = new QueryBuilder().AllData(query);
            CurrentUser = new string[9];
            while (value.Read())
            {
                if (value.FieldCount == 0)
                {
                    CurrentUser = null;
                }
                else
                {
                    CurrentUser[0] = value.GetString(0);
                    CurrentUser[1] = value.GetString(1);
                    CurrentUser[2] = value.GetString(2);
                    CurrentUser[3] = value.GetString(3);
                    CurrentUser[4] = value.GetString(4);
                    CurrentUser[5] = value.GetString(5);
                    CurrentUser[6] = value.GetString(6);
                    CurrentUser[7] = value.GetString(7);
                }
            }
            return CurrentUser;
        }
    }
}
