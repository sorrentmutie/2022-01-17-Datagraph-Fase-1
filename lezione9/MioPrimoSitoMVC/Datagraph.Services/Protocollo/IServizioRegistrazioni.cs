using Datagraph.Models.Protocollo;
using Datagraph.Models.Protocollo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagraph.Services.Protocollo
{
    public interface IServizioRegistrazioni
    {
        List<Registrazione> EstraiRegistrazioni(int NumeroPagina, int ElementiPagina);
        Registrazione EstraiRegistrazionePerId(int Id);
        int CreaRegistrazione(ViewModelCreazioneRegistrazione NuovaRegistrazione);
        Registrazione EstraiUltimaRegistrazione();
    }
}
