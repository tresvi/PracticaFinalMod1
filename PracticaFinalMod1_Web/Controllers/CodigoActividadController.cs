using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PracticaFinalMod1_Web;

namespace PracticaFinalMod1_Web.Controllers
{
    public class CodigoActividadController : Controller
    {
        private AFIPEntities db = new AFIPEntities();

        // GET: CodigoActividads
        public ActionResult Index()
        {
            return View(db.CodigoActividad.ToList());
        }

        // GET: CodigoActividads/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodigoActividad codigoActividad = db.CodigoActividad.Find(id);
            if (codigoActividad == null)
            {
                return HttpNotFound();
            }
            return View(codigoActividad);
        }

        // GET: CodigoActividads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CodigoActividads/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CUIL,Codigo")] CodigoActividad codigoActividad)
        {
            if (ModelState.IsValid)
            {
                db.CodigoActividad.Add(codigoActividad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(codigoActividad);
        }

        // GET: CodigoActividads/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodigoActividad codigoActividad = db.CodigoActividad.Find(id);
            if (codigoActividad == null)
            {
                return HttpNotFound();
            }
            return View(codigoActividad);
        }

        // POST: CodigoActividads/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CUIL,Codigo")] CodigoActividad codigoActividad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(codigoActividad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(codigoActividad);
        }

        // GET: CodigoActividads/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodigoActividad codigoActividad = db.CodigoActividad.Find(id);
            if (codigoActividad == null)
            {
                return HttpNotFound();
            }
            return View(codigoActividad);
        }

        // POST: CodigoActividads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CodigoActividad codigoActividad = db.CodigoActividad.Find(id);
            db.CodigoActividad.Remove(codigoActividad);
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
