using IGestionLabo;
using System;
using System.Collections;
using Function;
using MySql.Data.MySqlClient;

namespace Administrateur
{
    public class IGestionLaboImpl : MarshalByRefObject, IGestionLabo.IGestionLabo
    {

        public ArrayList ConsulterChercheur()
        {
            var query = $"SELECT * FROM profils";
            return new QueryBuilder().All(query);
        }

        public ArrayList ConsulterEquipe()
        {
            var query = $"SELECT * FROM teams";
            return new QueryBuilder().All(query);
        }
        public MySqlDataReader ConsulterRoleReader()
        {
            var query = $"SELECT * FROM roles";
            return new QueryBuilder().AllData(query);
        }
        public MySqlDataReader ConsulterLaboratoireReader()
        {
            var query = $"SELECT * FROM labs";
            return new QueryBuilder().AllData(query);
        }

        public bool CreerChercheur(Chercheur chercheur)
        {
            string query = $"INSERT INTO profils (`fname`, `lname`, `role_id`, `lab_id`) VALUES ('{chercheur.Prenom}', '{chercheur.Nom}', '{chercheur.Role}', '{chercheur.Laboratoire}');";
            return new QueryBuilder().Create(query);
        }

        public bool CreerEquipe(Equipe equipe, int id_lab)
        {
            var query = $"INSERT INTO teams (`name`, `lab_id`) VALUES ('{equipe.Name}', {id_lab});";
            return new QueryBuilder().Create(query);
        }

        public bool ModifierChercheur(Chercheur chercheur, int id)
        {
            
            var query = $"UPDATE profils SET `fname`= '{chercheur.Prenom}', `lname`= '{chercheur.Nom}', `role_id`= {chercheur.Role}, `lab_id`= {chercheur.Laboratoire} WHERE  `id`={id};";
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
