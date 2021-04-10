using Function;
using IGestionProduction;
using System;
using System.Collections;

namespace ChefEquipe
{
    public class IGestionProdImpl : MarshalByRefObject, IGestionProduction.IGestionProd
    {
        public ArrayList ConsulerProductions(int id)
        {
            string query = $"SELECT * FROM prod_sci WHERE created_by = {id};";
            return new QueryBuilder().All(query);
        }

        public bool ModifierProduction(Production production, int id, int created_by)
        {
            string query = $"UPDATE prod_sci SET title = '{production.Title}', description = '{production.Description}', reference = '{production.Reference}', type = '{production.Type}', created_by = {created_by}, created_at = '{production.CreatedAt}' WHERE id = {id};";
            return new QueryBuilder().Select(query);
        }

        public bool PublierProduction(Production production, int created_by)
        {
            string query = $"INSERT INTO prod_sci (`title`, `description`, `reference`, `type`, `created_by`, `created_at`) VALUES ('{production.Title}', '{production.Description}', '{production.Reference}', '{production.Type}', '{created_by}', '{production.CreatedAt}');";
            return new QueryBuilder().Select(query);
        }

        public bool SupprimerProduction(int id)
        {
            string query = $"DELETE FROM prod_sci WHERE id = {id};";
            return new QueryBuilder().Select(query);
        }

    }
}
