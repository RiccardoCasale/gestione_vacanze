using gestione_vacanze.Models;
using gestione_vacanze.Repos;

namespace gestione_vacanze.Services
{
    public class RecUtenteService
    {
        private readonly RecUtenteRepository _repository;

        public RecUtenteService(RecUtenteRepository repository)
        {
            _repository = repository;
        }

        public List<RecUtenteDTO> GetAllRecUtenteService()
        {
            List<RecUtente> local = _repository.GetAll();
            List<RecUtenteDTO> risultato = new List<RecUtenteDTO>();

            foreach (RecUtente recUtente in local)
            {
                RecUtenteDTO obj = new RecUtenteDTO()
                {
                    NomeUtente = recUtente.NomeUtente,
                    Codice = recUtente.Codice,
                    Commento = recUtente.Commento,
                    DataRec = recUtente.DataRec,
                    Voto = recUtente.Voto
                };
                risultato.Add(obj);
            }
            return risultato;
        }

        public bool InsertRec(RecUtentePostDTO recUtente) 
        { 
            RecUtente newRecensione = new RecUtente()
            {
                NomeUtente = recUtente.NomeUtente,
                Codice = Guid.NewGuid().ToString().Substring(0, 29),
                Voto = recUtente.Voto,
                DataRec = DateOnly.FromDateTime(DateTime.Now),
                Commento = recUtente.Commento,
                PacchettoRif = recUtente.PacchettoRif
            };

              return _repository.InsertRecensione(newRecensione);
        }

    }
}
