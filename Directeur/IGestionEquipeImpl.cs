using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function;

namespace Directeur
{
    public class IGestionEquipeImpl : MarshalByRefObject, IGestionEquipe.IGestionEquipe
    {
        public static string connectionString = "server=localhost; userid=root; password=root; database=uc2_smart_campus";
        public ArrayList ConsulterChercheur(int lab_id, int team_id)
        {
            var query = $"SELECT * FROM profils WHERE lab_id={lab_id} AND team_id={team_id};";
            return new QueryBuilder().All(query);
        }

        public void ModifierCompte(IGestionEquipe.Chercheur chercheur, int id)
        {
            throw new NotImplementedException();
        }

        public bool RetirerChercheur(int id)
        {
            var query = $"UPDATE profils SET team_id = NULL WHERE id={id};";
            return new QueryBuilder().Select(query);
        }
    }
}
