using System.ComponentModel.DataAnnotations.Schema;

namespace gestione_vacanze.Models
{
    public class Destinazione
    {
        public int DestinazioneId { get; set; }
        public string Nome { get; set; } = null!;
        public string Descrizione { get; set; }
        public string Paese { get; set; }
        public string? immagine { get; set; }

    }
}
