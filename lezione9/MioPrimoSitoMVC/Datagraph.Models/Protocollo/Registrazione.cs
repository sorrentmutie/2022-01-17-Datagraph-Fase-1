using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagraph.Models.Protocollo
{
    public class Registrazione
    {
        public int Id { get; set; }
        public int Anno { get; set; }
        public int Numero { get; set; }
        [DisplayName("Data Registrazione")]
        public DateTime DataRegistrazione { get; set; }
        public string Oggetto { get; set; }
        public List<Soggetto> Soggetti {get;set;}
    }
}
