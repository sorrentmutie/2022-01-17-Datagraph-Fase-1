using System.ComponentModel.DataAnnotations;

namespace Datagraph.Models.Protocollo.ViewModels
{
    public class ViewModelCreazioneRegistrazione
    {
        [Required(ErrorMessage = "Oggetto è obbligatorio")]
        //[MinLength(10, ErrorMessage = "La lunghezza minima è di {1} caratteri")]
        //[MaxLength(20, ErrorMessage = "La lunghezza massima è di ${0} caratteri")]
        [StringLength(100, ErrorMessage = "La lunghezza è compresa tra {2} e {1} caratteri", MinimumLength = 6)]
        public string Oggetto { get; set; }
    }
}
