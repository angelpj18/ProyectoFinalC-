using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sistema_Reserva_Alquiler_Habi.Models;

namespace Sistema_Reserva_Alquiler_Habi.Controllers
{
    public class PisoesController : Controller
    {
        private ReservaAlquilerEntities db = new ReservaAlquilerEntities();

        // GET: Pisoes
        public ActionResult Index()
        {
            return View(db.Piso.ToList());
        }

        // GET: Pisoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Piso piso = db.Piso.Find(id);
            if (piso == null)
            {
                return HttpNotFound();
            }
            return View(piso);
        }

        // GET: Pisoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pisoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NroPiso,Descripcion")] Piso piso)
        {
            if (ModelState.IsValid)
            {
                db.Piso.Add(piso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(piso);
        }

        // GET: Pisoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Piso piso = db.Piso.Find(id);
            if (piso == null)
            {
                return HttpNotFound();
            }
            return View(piso);
        }

        // POST: Pisoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NroPiso,Descripcion")] Piso piso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(piso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(piso);
        }

        // GET: Pisoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Piso piso = db.Piso.Find(id);
            if (piso == null)
            {
                return HttpNotFound();
            }
            return View(piso);
        }

        // POST: Pisoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Piso piso = db.Piso.Find(id);
            db.Piso.Remove(piso);
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
