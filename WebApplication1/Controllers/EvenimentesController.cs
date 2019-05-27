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
    public class EvenimentesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Evenimentes
        public ActionResult Index()
        {
            return View(db.Evenimentes.ToList());
        }

        // GET: Evenimentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evenimente evenimente = db.Evenimentes.Find(id);
            if (evenimente == null)
            {
                return HttpNotFound();
            }
            return View(evenimente);
        }

        // GET: Evenimentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evenimentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nume,Data,Locatie")] Evenimente evenimente)
        {
            if (ModelState.IsValid)
            {
                db.Evenimentes.Add(evenimente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evenimente);
        }

        // GET: Evenimentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evenimente evenimente = db.Evenimentes.Find(id);
            if (evenimente == null)
            {
                return HttpNotFound();
            }
            return View(evenimente);
        }

        // POST: Evenimentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nume,Data,Locatie")] Evenimente evenimente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evenimente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evenimente);
        }

        // GET: Evenimentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evenimente evenimente = db.Evenimentes.Find(id);
            if (evenimente == null)
            {
                return HttpNotFound();
            }
            return View(evenimente);
        }

        // POST: Evenimentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evenimente evenimente = db.Evenimentes.Find(id);
            db.Evenimentes.Remove(evenimente);
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
