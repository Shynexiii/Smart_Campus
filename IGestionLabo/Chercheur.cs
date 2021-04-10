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
        public int Team { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Chercheur(string nom, string prenom, int role, int laboratoire, int team, string email, string password)
        {
            Nom = nom;
            Prenom = prenom;
            Role = role;
            Laboratoire = laboratoire;
            Team = team;
            Email = email;
            Password = password;
        }
    }
}