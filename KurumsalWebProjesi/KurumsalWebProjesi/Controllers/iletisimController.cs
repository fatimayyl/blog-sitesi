using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KurumsalWebProjesi.Models.Model;
using KurumsalWebProjesi.Models.Model.DataContext;

namespace KurumsalWebProjesi.Controllers
{
    public class iletisimController : Controller
    {
        private KurumsalDBContext db = new KurumsalDBContext();

        // GET: iletisim
        public ActionResult Index()
        {
            return View(db.iletisim.ToList());
        }

        // GET: iletisim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            iletisim il = db.iletisim.Find(id);
            if (il == null)
            {
                return HttpNotFound();
            }
            return View(il);
        }

        // GET: iletisim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: iletisim/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "iletisimId,Adres,Tel,Fax,Whatsapp,Facebook,Twitter,Instagram")] iletisim il)
        {
            if (ModelState.IsValid)
            {
                db.iletisim.Add(il);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(il);
        }

        // GET: iletisim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            iletisim il = db.iletisim.Find(id);
            if (il == null)
            {
                return HttpNotFound();
            }
            return View(il);
        }

        // POST: iletisim/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iletisimId,Adres,Tel,Fax,Whatsapp,Facebook,Twitter,Instagram")] iletisim il)
        {
            if (ModelState.IsValid)
            {
                db.Entry(il).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(il);
        }

        // GET: iletisim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            iletisim il = db.iletisim.Find(id);
            if (il == null)
            {
                return HttpNotFound();
            }
            return View(il);
        }

        // POST: iletisim/Delete/5


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            iletisim il = db.iletisim.Find(id);
            db.iletisim.Remove(il);
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

