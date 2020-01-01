using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webOdevi.Models;

namespace webOdevi.Controllers
{
    public class EgzersizlerimController : Controller
    {
        private EgzersizListemContext db = new EgzersizListemContext();
        // GET: Egzersizlerim
        public ActionResult Index()
        {
            return View(GetEgzersiz());
        }
        public ActionResult EgzersizEkle(int id)
        {
            var egzesiz = db.egzersizOnerileri.FirstOrDefault(i => i.id == id);
            if (egzesiz !=null)
            {
                GetEgzersiz().AddProduct(egzesiz,1);
            }
            return RedirectToAction("Index");
        }

        public ActionResult ListemdenSil(int id)
        {
            var egzesiz = db.egzersizOnerileri.FirstOrDefault(i => i.id == id);
            if (egzesiz != null)
            {
                GetEgzersiz().DeleteProduct(egzesiz);
            }
            return RedirectToAction("Index");
        }
        public EgzersizListesi GetEgzersiz()
        {
            var egzersiz = (EgzersizListesi)Session["EgzersizListesi"];
            if (egzersiz == null)
            {
                egzersiz = new EgzersizListesi();
                Session["EgzersizListesi"] = egzersiz;



            }
            return egzersiz;

        }
    }

}