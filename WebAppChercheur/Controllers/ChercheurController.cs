using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppChercheur.Models;

namespace WebAppChercheur.Controllers
{
    public class ChercheurController : Controller
    {
        // GET: Chercheur
        public ActionResult Profil(int id)
        {
            var chercheur = new Chercheur() { fname = "Habib" };
            return Content("chercheur =" + id);
        }
    }
}