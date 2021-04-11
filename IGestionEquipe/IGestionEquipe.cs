using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestionEquipe
{
    public interface IGestionEquipe
    {
        bool RetirerChercheur(int id);
        ArrayList ConsulterChercheur(int lab_id, int team_id);
        void ModifierCompte(Chercheur chercheur, int id);
        ArrayList ConsulterProdctionScientifique(int lab_id, int team_id);
    }
}
