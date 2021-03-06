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
        ArrayList ConsulterChercheur(int id);

        /**/
        ArrayList ConsulterProdctionScientifique(int lab_id);
        MySqlDataReader ConsulterRoleReader();
        MySqlDataReader ConsulterLaboratoireReader();
        MySqlDataReader ConsulterTeamReader();
        MySqlDataReader ConsulterGradeReader();

    }
}
