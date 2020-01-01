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
    public class YemekTarifiController : Controller
    {
        private EgzersizListemContext db = new EgzersizListemContext();

        // GET: YemekTarifi
        public ActionResult Index()
        {
            return View(db.tarifler.ToList());
        }

        // GET: YemekTarifi/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YemekTarifi yemekTarifi = db.tarifler.Find(id);
            if (yemekTarifi == null)
            {
                return HttpNotFound();
            }
            return View(yemekTarifi);
        }

        // GET: YemekTarifi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YemekTarifi/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "yemid,YemekAdi,YemekMalzemeler,YemekHazirlanisi,Resim")] YemekTarifi yemekTarifi)
        {
            if (ModelState.IsValid)
            {
                db.tarifler.Add(yemekTarifi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yemekTarifi);
        }

        // GET: YemekTarifi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YemekTarifi yemekTarifi = db.tarifler.Find(id);
            if (yemekTarifi == null)
            {
                return HttpNotFound();
            }
            return View(yemekTarifi);
        }

        // POST: YemekTarifi/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "yemid,YemekAdi,YemekMalzemeler,YemekHazirlanisi,Resim")] YemekTarifi yemekTarifi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yemekTarifi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yemekTarifi);
        }

        // GET: YemekTarifi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YemekTarifi yemekTarifi = db.tarifler.Find(id);
            if (yemekTarifi == null)
            {
                return HttpNotFound();
            }
            return View(yemekTarifi);
        }

        // POST: YemekTarifi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            YemekTarifi yemekTarifi = db.tarifler.Find(id);
            db.tarifler.Remove(yemekTarifi);
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
