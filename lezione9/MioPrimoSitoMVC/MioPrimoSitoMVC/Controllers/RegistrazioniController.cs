using Datagraph.Models.Protocollo;
using Datagraph.Models.Protocollo.ViewModels;
using Datagraph.Services.Protocollo;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MioPrimoSitoMVC.Controllers
{
    public class RegistrazioniController : Controller
    {
        private readonly IServizioRegistrazioni servizioRegistrazioni;

        public RegistrazioniController(IServizioRegistrazioni servizioRegistrazioni)
        {
            this.servizioRegistrazioni = servizioRegistrazioni;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(servizioRegistrazioni.EstraiRegistrazioni(1, 20));
        }

        [HttpGet]
        public IActionResult Modifica(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Dettagli(int id)
        {
            var registrazione = servizioRegistrazioni.EstraiRegistrazionePerId(id);
            if(registrazione == null) return RedirectToAction("Index");
            return View(registrazione);
        }

        public IActionResult Elimina(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Crea()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crea(ViewModelCreazioneRegistrazione nuovaRegistrazione)
        {
            var id = servizioRegistrazioni.CreaRegistrazione(nuovaRegistrazione);
            return RedirectToAction("Dettagli", new {id= id});
        }

    }
}
