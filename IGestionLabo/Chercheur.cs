using System;

namespace IGestionLabo
{
    [Serializable]
    public class Chercheur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Role { get; set; }
        public int Laboratoire { get; set; }

        public Chercheur(string nom, string prenom, int role, int laboratoire)
        {
            Nom = nom;
            Prenom = prenom;
            Role = role;
            Laboratoire = laboratoire;
        }
    }
}