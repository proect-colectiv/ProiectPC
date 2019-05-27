using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RezervareClientsController : Controller
    {
        private Model1 db = new Model1();

        // GET: RezervareClients
        public ActionResult Index()
        {
            return View(db.RezervareClients.ToList());
        }

        // GET: RezervareClients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezervareClient rezervareClient = db.RezervareClients.Find(id);
            if (rezervareClient == null)
            {
                return HttpNotFound();
            }
            return View(rezervareClient);
        }

        // GET: RezervareClients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RezervareClients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NumeEveniment,Data,Nume,Prenume,Adresa,NumarTelefon")] RezervareClient rezervareClient)
        {
            if (ModelState.IsValid)
            {
                db.RezervareClients.Add(rezervareClient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rezervareClient);
        }

        // GET: RezervareClients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezervareClient rezervareClient = db.RezervareClients.Find(id);
            if (rezervareClient == null)
            {
                return HttpNotFound();
            }
            return View(rezervareClient);
        }

        // POST: RezervareClients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NumeEveniment,Data,Nume,Prenume,Adresa,NumarTelefon")] RezervareClient rezervareClient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rezervareClient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rezervareClient);
        }

        // GET: RezervareClients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezervareClient rezervareClient = db.RezervareClients.Find(id);
            if (rezervareClient == null)
            {
                return HttpNotFound();
            }
            return View(rezervareClient);
        }

        // POST: RezervareClients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RezervareClient rezervareClient = db.RezervareClients.Find(id);
            db.RezervareClients.Remove(rezervareClient);
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
