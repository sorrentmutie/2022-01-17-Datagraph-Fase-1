using System.Collections.Generic;

namespace Datagraph.Models.Protocollo
{
    public class Soggetto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public List<Recapito> Recapiti { get; set; }
    }
}