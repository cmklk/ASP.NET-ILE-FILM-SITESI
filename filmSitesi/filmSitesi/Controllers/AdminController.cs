using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using filmSitesi.Models.siniflar;
namespace filmSitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context veri = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BilgiListe()
        {

            var bilgiler = veri.films.ToList();
            return View(bilgiler);
        }

        [HttpGet]
        public ActionResult filmEkle()
        {
            return View();
        }

       [HttpPost]
        public ActionResult filmEkle(film flm)
        {
            veri.films.Add(flm);
            veri.SaveChanges();
            return RedirectToAction("BilgiListe");
        }


        public ActionResult filmSil(int id)
        {
            var findMovie = veri.films.Find(id);
            veri.films.Remove(findMovie);
            veri.SaveChanges();
            return RedirectToAction("BilgiListe");
        }

     
        public ActionResult filmVeriGetir(int id)
        {
            var getir = veri.films.Find(id);
            return View("filmVeriGetir", getir);
        }


     

        public ActionResult filmGuncelle(film flm)
        {
            var mevcut = veri.films.Find(flm.ID);
            mevcut.filmAd = flm.filmAd;
            mevcut.imdp =  flm.imdp;
            mevcut.imgUrl = flm.imgUrl;
            mevcut.konu = flm.konu;
            mevcut.tur = flm.tur;
            mevcut.yapimYil = flm.yapimYil;
            mevcut.oyuncular = flm.oyuncular;
            mevcut.yonetmen = flm.yonetmen;
            veri.SaveChanges();
            return RedirectToAction("BilgiListe");
        }
    }
}