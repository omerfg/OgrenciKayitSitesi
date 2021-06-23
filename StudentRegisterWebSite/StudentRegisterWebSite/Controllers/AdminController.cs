using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentRegisterWebSite.Models.Siniflar;

namespace StudentRegisterWebSite.Controllers
{
    public class AdminController : Controller
    {
        Context db = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = db.Duyurus.ToList();
            return View(degerler);
        }

        public ActionResult DuyuruSil(int id)
        {

            var degerler = db.Duyurus.Find(id);
            db.Duyurus.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult YeniDuyuru()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniDuyuru(Duyuru d)
        {
            db.Duyurus.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DuyuruGetir(int id)
        {
            var dy = db.Duyurus.Find(id);
            return View("DuyuruGetir",dy);
        }

        public ActionResult DuyuruGuncelle(Duyuru d)
        {
            var dyr = db.Duyurus.Find(d.ID);

            dyr.ID = d.ID;
            dyr.Baslik = d.Baslik;
            dyr.Aciklama = d.Aciklama;
            dyr.Tarih = d.Tarih;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Galeri()
        {
            var degerler = db.Galeris.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult GaleriResimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GaleriResimEkle(Galeri g)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                g.ResimUrl = "/Image/" + dosyaadi + uzanti;
            }
            db.Galeris.Add(g);
            db.SaveChanges();
            return View();
        }

        public ActionResult GaleriResimSil(int id)
        {

            var degerler = db.Galeris.Find(id);
            db.Galeris.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Iletisim()
        {
            var degerler = db.Iletisims.ToList();
            db.SaveChanges();
            return View(degerler);


        }

    }
}