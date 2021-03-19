using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGestionLabo
{
    public interface IGestionLabo
    {
        /**/
        bool CreerEquipe(Equipe equipe, int id_lab);
        bool ModifierEquipe(Equipe equipe, int id, int id_lab);
        bool SupprimerEquipe(int id);
        ArrayList ConsulterEquipe();

        /**/
        bool CreerChercheur(Chercheur chercheur);
        bool ModifierChercheur(Chercheur chercheur, int id);
        bool SupprimerChercheur(int id);
        ArrayList ConsulterChercheur();

        /**/
        MySqlDataReader ConsulterRoleReader();
        MySqlDataReader ConsulterLaboratoireReader();

        /**/
        bool ChoisirChef(Chercheur chercheur, Equipe equipe);
        bool AffecterChercheur(Chercheur chercheur, Equipe equipe);
    }
}
