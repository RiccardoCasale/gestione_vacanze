namespace gestione_vacanze.Models
{
    public class DestinazioneDTO
    {
        public string Nome { get; set; } = null!;
        public string Descrizione { get; set; }
        public string Paese { get; set; }
        public string? immagine { get; set; }
    }
}
