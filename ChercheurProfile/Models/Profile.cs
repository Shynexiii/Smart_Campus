using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChercheurProfile.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Laboratoire { get; set; }
        public string Team { get; set; }
    }
}