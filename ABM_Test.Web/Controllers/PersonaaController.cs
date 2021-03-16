using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ABM_Test.EntityFramework;

namespace ABM_Test.Web.Controllers
{
    public class PersonaaController : Controller
    {
        private ABM_TestDbContext db = new ABM_TestDbContext();
        string link = "~/App/Main/views/abmpersona/";
        // GET: Personaa
        public ActionResult Index()
        {
            return View(link + "Index.cshtml",db.Personaas.ToList());
        }

        // GET: Personaa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personaa personaa = db.Personaas.Find(id);
            if (personaa == null)
            {
                return HttpNotFound();
            }
            return View(link + "Details.cshtml",personaa);
        }

        // GET: Personaa/Create
        public ActionResult Create()
        {
            return View(link+"Create.cshtml");
        }

        // POST: Personaa/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,Direccion,Age")] Personaa personaa)
        {
            if (ModelState.IsValid)
            {
                db.Personaas.Add(personaa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(link + "Create.cshtml",personaa);
        }

        // GET: Personaa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personaa personaa = db.Personaas.Find(id);
            if (personaa == null)
            {
                return HttpNotFound();
            }
            return View(link + "Edit.cshtml",personaa);
        }

        // POST: Personaa/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,Direccion,Age")] Personaa personaa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personaa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(link + "Edit.cshtml",personaa);
        }

        // GET: Personaa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personaa personaa = db.Personaas.Find(id);
            if (personaa == null)
            {
                return HttpNotFound();
            }
            return View(link + "Delete.cshtml",personaa);
        }

        // POST: Personaa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personaa personaa = db.Personaas.Find(id);
            db.Personaas.Remove(personaa);
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
