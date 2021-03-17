using System;

namespace IGestionLabo
{
    [Serializable]
    public class Chercheur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Role { get; set; }

        public Chercheur(string nom, string prenom, string role)
        {
            Nom = nom;
            Prenom = prenom;
            Role = role;
        }
    }
}