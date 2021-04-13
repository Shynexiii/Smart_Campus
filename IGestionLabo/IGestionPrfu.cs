using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestionLabo
{
    public interface IGestionPrfu
    {
        bool AjouterMembre(int chercheur_id);
        bool RetirerMembre(int chercheur_id);
        ArrayList ConsulterMembres(int lab_id);
    }
}
