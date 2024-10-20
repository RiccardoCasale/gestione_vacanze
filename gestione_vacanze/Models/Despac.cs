using System.ComponentModel.DataAnnotations.Schema;

namespace gestione_vacanze.Models
{
    public class Despac
    {
        public int Id { get; set; }
        [ForeignKey("Destinazione")]
        public int DestinazioneRif { get; set; }
        [ForeignKey("Pacchetto")]
        public int PacchettoRif { get; set; }
    }
}
