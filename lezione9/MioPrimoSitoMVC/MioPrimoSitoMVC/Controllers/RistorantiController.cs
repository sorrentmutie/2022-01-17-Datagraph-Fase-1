

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
            var ristorante = new Ristorante { Id = 1, Nome = "Pizzera Bella Napoli",
                Stelle = 4, Indirizzo = "Via del Pino 1, Napoli"};

            var ristoranti = new List<Ristorante>();
            ristoranti.Add(ristorante);
            ristoranti.Add(new Ristorante { Id = 2, Nome = "Da Pino", Indirizzo = "Piazza Duomo, Milano" });

            return View(ristoranti);
        }

        

        public IActionResult About()
        {
            return View();
        }

    }
}
