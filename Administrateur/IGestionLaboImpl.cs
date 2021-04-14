using IGestionLabo;
using System;
using System.Collections;
using Function;
using MySql.Data.MySqlClient;

namespace Administrateur
{
    public class IGestionLaboImpl : MarshalByRefObject, IGestionLabo.IGestionLabo
    {

        public ArrayList ConsulterChercheur(int id)
        {
            var query = $"SELECT p.id, p.fname, p.lname, r.role, l.code, t.name, p.email, p.password, g.grade_name " +
                $"FROM profils p " +
                $"JOIN roles r ON p.role_id = r.id " +
                $"JOIN labs l ON p.lab_id = l.id " +
                $"JOIN teams t ON p.team_id = t.id " +
                $"JOIN grades g ON p.grade_id = g.id " +
                $"WHERE p.lab_id = {id} " +
                $"ORDER BY p.id ASC";

            return new QueryBuilder().All(query);
        }

        public ArrayList ConsulterEquipe()
        {
            var query = $"SELECT teams.id, teams.name, labs.code FROM teams JOIN labs ON labs.id = lab_id ORDER	BY teams.id";
            return new QueryBuilder().All(query);
        }

        public ArrayList ConsulterProdctionScientifique(int lab_id)
        {
            var query = $"SELECT prod_sci.id, prod_sci.title, prod_sci.description, prod_sci.reference, prod_sci.type, profils.fname," +
                $" profils.lname, labs.code, teams.name, prod_sci.created_at " +
                $"FROM prod_sci " +
                $"JOIN profils ON profils.id = prod_sci.created_by " +
                $"JOIN labs ON labs.id = profils.lab_id " +
                $"JOIN teams ON teams.id = profils.team_id " +
                $"WHERE profils.lab_id = {lab_id} " +
                $"ORDER BY prod_sci.id ASC";

            return new QueryBuilder().All(query);
        }

        public MySqlDataReader ConsulterRoleReader()
        {
            var query = $"SELECT * FROM roles";
            return new QueryBuilder().AllData(query);
        }
        public MySqlDataReader ConsulterGradeReader()
        {
            var query = $"SELECT * FROM grades";
            return new QueryBuilder().AllData(query);
        }
        public MySqlDataReader ConsulterLaboratoireReader()
        {
            var query = $"SELECT * FROM labs";
            return new QueryBuilder().AllData(query);
        }
        public MySqlDataReader ConsulterTeamReader()
        {
            var query = $"SELECT * FROM teams";
            return new QueryBuilder().AllData(query);
        }

        public bool CreerChercheur(Chercheur chercheur)
        {
            string query = $"INSERT INTO profils (`fname`, `lname`, `role_id`, `lab_id`, `team_id`, `email`, `password`, `grade_id`) VALUES ('{chercheur.Prenom}', '{chercheur.Nom}', '{chercheur.Role}', '{chercheur.Laboratoire}', '{chercheur.Team}', '{chercheur.Email}', '{chercheur.Password}', '{chercheur.Grade}');";
            return new QueryBuilder().Create(query);
        }

        public bool CreerEquipe(Equipe equipe, int id_lab)
        {
            var query = $"INSERT INTO teams (`name`, `lab_id`) VALUES ('{equipe.Name}', {id_lab});";
            return new QueryBuilder().Create(query);
        }

        public bool ModifierChercheur(Chercheur chercheur, int id)
        {
            
            var query = $"UPDATE profils SET `fname`= '{chercheur.Prenom}', `lname`= '{chercheur.Nom}', `role_id`= '{chercheur.Role}', `lab_id`= '{chercheur.Laboratoire}', `team_id`= '{chercheur.Team}', `email`= '{chercheur.Email}', `password`= '{chercheur.Password}', `grade_id`= '{chercheur.Grade}' WHERE `id`={id};";
            return new QueryBuilder().Update(query);
        }

        public bool ModifierEquipe(Equipe equipe, int id, int id_lab)
        {
            
            var query = $"UPDATE teams SET `name`= '{equipe.Name}', `lab_id`= {id_lab} WHERE `id`={id};";
            return new QueryBuilder().Update(query);
        }

        public bool SupprimerChercheur(int id)
        {
            var query = $"DELETE FROM profils WHERE `id`= {id};";
            return new QueryBuilder().Delete(query);
        }

        public bool SupprimerEquipe(int id)
        {
            var query = $"DELETE FROM teams WHERE `id`= {id};";
            return new QueryBuilder().Delete(query);
        }

    }
}
