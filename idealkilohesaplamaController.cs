using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webOdevi.Models;

namespace webOdevi.Controllers
{
    public class idealkilohesaplamaController : Controller
    {
        // GET: idealkilohesaplama
        [HttpGet]
        public ActionResult idealkilo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult idealkilo(idealkilo model, string command)
        {



            if (command == "kadın")
            {
                model.C = model.Boy / 2.54;
                model.A = model.C - 60;
                model.B = model.A * 2.3;
                model.D = model.B + 45.5;


            }
            if (command == "erkek")
            {
                model.C = model.Boy / 2.54;
                model.A = model.C - 60;
                model.B = model.A * 2.3;
                model.D = model.B + 50;
            }
            return View(model);
        }
    }
}
    
