using gestione_vacanze.Models;
using gestione_vacanze.Repos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace gestione_vacanze.Services
{
    public class PacchettoService
    {
        private readonly PacchettoRepository _repository;

        public PacchettoService(PacchettoRepository repository)
        {
            _repository = repository;
        }

        //RACCOGLI I PACCHETTI DI UNA DESTINAZIONE

        public List<PacchettoDTO> GetPacchettiByDestinazione(string destinazione)
        {
            List<Pacchetto> pacchettiInArrivo = _repository.GetPacchettiByDestinazione();
            List<PacchettoDTO> pacchettiDellaDestinazioneRichiesta = new List<PacchettoDTO>();

            foreach (Pacchetto currentPacchetto in pacchettiInArrivo)
            {
                string[] destinazioniPacchetto = currentPacchetto.ElencoDes.Split(",");

                if (destinazioniPacchetto.Contains(destinazione))
                {
                    PacchettoDTO pacchettoDTO = new PacchettoDTO();

                    pacchettoDTO.NomeP = currentPacchetto.NomeP;
                    pacchettoDTO.prezzo = currentPacchetto.prezzo;
                    pacchettoDTO.Durata = currentPacchetto.Durata;
                    pacchettoDTO.DataIni = currentPacchetto.DataIni;
                    pacchettoDTO.DataFin = currentPacchetto.DataFin;
                    pacchettoDTO.ElencoDes = currentPacchetto.ElencoDes;

                    pacchettiDellaDestinazioneRichiesta.Add(pacchettoDTO);

                }
            }
            return pacchettiDellaDestinazioneRichiesta;
        }

        //RACCOGLI LE DESTINAZIONI DI UN PACCHETTO

        public string[] DettaglioVacanza(int varId)
        {
            Pacchetto pacchetto = _repository.DettaglioVacanza(varId);
            string[] destinazioni = pacchetto.ElencoDes.Split(",");

            return destinazioni;
        }
    }
}
