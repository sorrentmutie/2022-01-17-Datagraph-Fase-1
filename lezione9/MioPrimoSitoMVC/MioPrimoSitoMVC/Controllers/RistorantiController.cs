

using Microsoft.AspNetCore.Mvc;
using MioPrimoSitoMVC.Models;
using System.Collections.Generic;

namespace MioPrimoSitoMVC.Controllers
{
    //[Route("tipici")]
    public class RistorantiController : Controller
    {
        //[Route("")]
        public IActionResult Index()
        {
            //var a = new ContentResult();
            //a.Content = "ciao";
            var ristorante = new Ristorante { Id = 1, Nome = "Pizzera Bella Napoli",
                Stelle = 4, Indirizzo = "Via del Pino 1, Napoli"};

            var ristoranti = new List<Ristorante>();
            ristoranti.Add(ristorante);
            ristoranti.Add(new Ristorante { Id = 2, Nome = "Da Pino", Indirizzo = "Piazza Duomo, Milano" });

            //ViewBag.Titolo = "Ciao ciao";
            //ViewData["Title"] = "I 4 ristoranti";
            return View(ristoranti);
        }

        //public IActionResult Index()
        //{
        //  ////return RedirectPermanent("http://repubblica.it");
        //}

        //[Route("circa/suppergiu/[action]")]
        //public JsonResult About()
        //{ 
        //    var a = new { id = 1 };
        //    return new JsonResult(a);
        //}

        public IActionResult About()
        {
            return View();
        }

    }
}
