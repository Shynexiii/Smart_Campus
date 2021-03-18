using IGestionLabo;
using System;
using System.Collections;

namespace Administrateur
{
    public class IGestionLaboImpl : MarshalByRefObject, IGestionLabo.IGestionLabo
    {
        public static string connectionString = "server=localhost; userid=root; password=root; database=uc2_smart_campus";


        public bool AffecterChercheur(Chercheur chercheur, Equipe equipe)
        {
            throw new NotImplementedException();
        }

        public bool ChoisirChef(Chercheur chercheur, Equipe equipe)
        {
            throw new NotImplementedException();
        }

        public ArrayList ConsulterChercheur()
        {
            var query = $"SELECT * FROM profils";
            return new functions().All(query);
        }

        public ArrayList ConsulterEquipe()
        {
            var query = $"SELECT * FROM teams";
            return new functions().All(query);
        }

        public bool CreerChercheur(Chercheur chercheur)
        {
            string query = $"INSERT INTO profils (`fname`, `lname`, `role_id`) VALUES ('{chercheur.Prenom}','{chercheur.Nom}','{chercheur.Role}');";
            return new functions().Create(query);
        }

        public bool CreerEquipe(Equipe equipe)
        {
            var query = $"INSERT INTO teams (`name`) VALUES ('{equipe.Name}');";
            return new functions().Create(query);
        }

        public bool ModifierChercheur(Chercheur chercheur, int id)
        {
            
            var query = $"UPDATE profils SET `fname`='{chercheur.Prenom}', `lname`='{chercheur.Nom}', `role_id`='{chercheur.Role}' WHERE  `id`={id};";
            return new functions().Update(query);
        }

        public bool ModifierEquipe(Equipe equipe, int id)
        {
            
            var query = $"UPDATE teams SET `name`='{equipe.Name}' WHERE `id`={id};";
            return new functions().Update(query);
        }

        public bool SupprimerChercheur(int id)
        {
            var query = $"DELETE FROM profils WHERE `id`= {id};";
            return new functions().Delete(query);
        }

        public bool SupprimerEquipe(int id)
        {
            var query = $"DELETE FROM teams WHERE `id`= {id};";
            return new functions().Delete(query);
        }

    }
}
