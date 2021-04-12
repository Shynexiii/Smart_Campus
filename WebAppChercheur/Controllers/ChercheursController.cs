using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppChercheur.Data;
using WebAppChercheur.Models;

namespace WebAppChercheur.Controllers
{
    public class ChercheursController : Controller
    {
        private WebAppChercheurContext db = new WebAppChercheurContext();

        // GET: Chercheurs
        public ActionResult Index()
        {
            return View(db.Chercheurs.ToList());
        }

        // GET: Chercheurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chercheur chercheur = db.Chercheurs.Find(id);
            if (chercheur == null)
            {
                return HttpNotFound();
            }
            return View(chercheur);
        }

        // GET: Chercheurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chercheurs/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,fname,lname,role_id,lab_id,team_id,email,password")] Chercheur chercheur)
        {
            if (ModelState.IsValid)
            {
                db.Chercheurs.Add(chercheur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chercheur);
        }

        // GET: Chercheurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chercheur chercheur = db.Chercheurs.Find(id);
            if (chercheur == null)
            {
                return HttpNotFound();
            }
            return View(chercheur);
        }

        // POST: Chercheurs/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,fname,lname,role_id,lab_id,team_id,email,password")] Chercheur chercheur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chercheur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chercheur);
        }

        // GET: Chercheurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chercheur chercheur = db.Chercheurs.Find(id);
            if (chercheur == null)
            {
                return HttpNotFound();
            }
            return View(chercheur);
        }

        // POST: Chercheurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chercheur chercheur = db.Chercheurs.Find(id);
            db.Chercheurs.Remove(chercheur);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
