using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webOdevi.Models;

namespace webOdevi.Controllers
{
    public class EgzesizOnerileriController : Controller
    {
        private EgzersizListemContext db = new EgzersizListemContext();

        // GET: EgzesizOnerileri
        public ActionResult Index()
        {
            
            return View(db.egzersizOnerileri.ToList());
        }

        
        // GET: EgzesizOnerileri/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EgzesizOnerileri egzesizOnerileri = db.egzersizOnerileri.Find(id);
            if (egzesizOnerileri == null)
            {
                return HttpNotFound();
            }
            return View(egzesizOnerileri);
        }
        public ActionResult Details1(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EgzesizOnerileri egzesizOnerileri = db.egzersizOnerileri.Find(id);
            if (egzesizOnerileri == null)
            {
                return HttpNotFound();
            }
            return View(egzesizOnerileri);
        }

        // GET: EgzesizOnerileri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EgzesizOnerileri/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,IsinmaResimler,ZayiflamaResimler,ekle")] EgzesizOnerileri egzesizOnerileri)
        {
            if (ModelState.IsValid)
            {
                db.egzersizOnerileri.Add(egzesizOnerileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(egzesizOnerileri);
        }

        // GET: EgzesizOnerileri/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EgzesizOnerileri egzesizOnerileri = db.egzersizOnerileri.Find(id);
            if (egzesizOnerileri == null)
            {
                return HttpNotFound();
            }
            return View(egzesizOnerileri);
        }

        // POST: EgzesizOnerileri/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,IsinmaResimler,ZayiflamaResimler,ekle")] EgzesizOnerileri egzesizOnerileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(egzesizOnerileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(egzesizOnerileri);
        }

        // GET: EgzesizOnerileri/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EgzesizOnerileri egzesizOnerileri = db.egzersizOnerileri.Find(id);
            if (egzesizOnerileri == null)
            {
                return HttpNotFound();
            }
            return View(egzesizOnerileri);
        }

        // POST: EgzesizOnerileri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EgzesizOnerileri egzesizOnerileri = db.egzersizOnerileri.Find(id);
            db.egzersizOnerileri.Remove(egzesizOnerileri);
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
