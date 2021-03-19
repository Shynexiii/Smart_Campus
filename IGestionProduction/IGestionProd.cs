using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestionProduction
{
    public interface IGestionProd
    {
        ArrayList ConsulerProductions(int id);
        bool PublierProduction(Production production, int created_by);
        bool ModifierProduction(Production production, int id, int created_by);
        bool SupprimerProduction(int id);

    }
}
