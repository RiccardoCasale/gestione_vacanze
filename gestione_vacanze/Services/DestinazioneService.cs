using gestione_vacanze.Models;
using gestione_vacanze.Repos;
using Microsoft.AspNetCore.Mvc;

namespace gestione_vacanze.Services
{
    public class DestinazioneService
    {
        private readonly DestinazioneRepository _repository;

        public DestinazioneService(DestinazioneRepository repository)
        {
            _repository = repository;   
        }

        public bool EliminaDestinazione(int varId) 
        { 
            return _repository.Delete(varId);
        }

        public List<DestinazioneDTO> GetAllDestinazioni()
        {
           List<Destinazione> listaEntity = _repository.GetAll();
            List<DestinazioneDTO> result = new List<DestinazioneDTO>();

            foreach (var currentDestinazione in listaEntity)
            {
                DestinazioneDTO destinazioneDTO = new DestinazioneDTO();
                destinazioneDTO.Nome = currentDestinazione.Nome;
                destinazioneDTO.Descrizione = currentDestinazione.Descrizione;
                destinazioneDTO.immagine = currentDestinazione.immagine;
                destinazioneDTO.Paese = currentDestinazione.Paese;

                result.Add(destinazioneDTO);
            }

            return result;
        }
    }
}
