using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWeb.Interfacce.Implementazioni
{
    public class GeneratoreSaluto : ISaluto
    {
        private readonly IGestioneTempo gestioneTempo;
        private readonly IConfiguration configurazione;

        public GeneratoreSaluto(IGestioneTempo gestioneTempo, IConfiguration configurazione)
        {
            this.gestioneTempo = gestioneTempo;
            this.configurazione = configurazione;
        }

        public string EstraiSaluto()
        {
            return $"{configurazione["ConnectionsStrings:databaselocale"]} Sono le {gestioneTempo.OraCorrente()}";
        }
    }
}
