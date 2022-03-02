using Datagraph.Models.Protocollo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenFu;
using Datagraph.Models.Protocollo.ViewModels;

namespace Datagraph.Services.Protocollo
{
    public class ServizioStaticoRegistrazioni : IServizioRegistrazioni
    {
        private List<Registrazione> registrazioni = new List<Registrazione>();
        private Random random = new Random();

        public ServizioStaticoRegistrazioni()
        {
            
            var i = 1;
            A.Configure<Registrazione>()
                .Fill(li => li.Id, () => { return random.Next(1, 1000); })
                .Fill(li => li.Anno, () => { return 2022; })
                .Fill(li => li.Numero, () => { return i++; })
                .Fill(li => li.Oggetto).AsLoremIpsumSentences(1);
            A.Configure<Soggetto>()
                .Fill(li => li.Id, () => { return random.Next(10000, 15000); })
                .Fill(li => li.Nome).AsFirstName()
                .Fill(li => li.Cognome).AsLastName();

            registrazioni = A.ListOf<Registrazione>(1000);

        }

        public int CreaRegistrazione(ViewModelCreazioneRegistrazione NuovaRegistrazione)
        {
            var id = random.Next(10000, 15000);
            registrazioni.Add(new Registrazione
            {
                Oggetto = NuovaRegistrazione.Oggetto,
                DataRegistrazione = DateTime.Now,
                Anno = DateTime.Today.Year,
                Numero = registrazioni.Max(i => i.Numero) + 1,
                Id = id
            });
            return id;
        }

        public Registrazione EstraiRegistrazionePerId(int Id)
        {
            var registrazione = registrazioni.FirstOrDefault(r => r.Id == Id);
            registrazione.Soggetti = A.ListOf<Soggetto>(5);
            return registrazione;
        }

        public List<Registrazione> EstraiRegistrazioni(int NumeroPagina, int ElementiPagina)
        {
            return registrazioni.Skip((NumeroPagina -1)* ElementiPagina).Take(ElementiPagina)
                .ToList();
        }
    }
}
