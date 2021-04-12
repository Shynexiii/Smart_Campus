using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebAppChercheur.Models
{
    public class Chercheur
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int role_id { get; set; }
        public int lab_id { get; set; }
        public int team_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}