using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using filmSitesi.Models.siniflar;
namespace filmSitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context veri = new Context();
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult AnasayfaFilmListe()
        {
            var filmler = veri.films.ToList();
            return View(filmler);
        }

        public ActionResult filmDetay(int id)
        {
            var detayGetir = veri.films.Where(x => x.ID == id).ToList();
            return View(detayGetir);
        }
    }
}