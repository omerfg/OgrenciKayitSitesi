using StudentRegisterWebSite.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegisterWebSite.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult OgrenciKayit()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult OgrenciKayit(OgrenciKayitTalebi d)
        {
            db.OgrenciKayitTalebis.Add(d);
            db.SaveChanges();
            return PartialView();
        }

        public PartialViewResult Hakkimizda()
        {
            var degerler = db.Hakkimizdas.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Kurslarimiz()
        {
            var degerler = db.Kurslars.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Istatistik()
        {
            var degerler = db.Istatistiks.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Duyuru()
        {
            var degerler = db.Duyurus.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Galeri()
        {
            var degerler = db.Galeris.ToList();
            return PartialView(degerler);
        }

        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(Iletisim d)
        {
            db.Iletisims.Add(d);
            db.SaveChanges();
            return PartialView();
        }


    }
}