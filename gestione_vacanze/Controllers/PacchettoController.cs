using gestione_vacanze.Models;
using gestione_vacanze.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace gestione_vacanze.Controllers
{
    [ApiController]
    [Route("api/pacchetto")]
    public class PacchettoController : Controller
    {
        private readonly PacchettoService _service;

        public PacchettoController(PacchettoService service)
        {
            _service = service;
        }

        //RACCOGLI I PACCHETTI DI UNA DESTINAZIONE

        [HttpGet("{dest}")]
        public ActionResult<List<PacchettoDTO>> GetPacchettiByDestinazione(string dest)
        {
            if (dest.IsNullOrEmpty())
                return BadRequest();

            List<PacchettoDTO> pacchetti = _service.GetPacchettiByDestinazione(dest);
            if (!pacchetti.Any())
                return NotFound();
            
            return pacchetti;
        }

        //RACCOGLI LE DESTINAZIONI DI UN PACCHETTO

        [HttpGet("dettaglioVacanze/{varId}")]
        public ActionResult<string[]> DettaglioVacanza(int varId)
        {
            if(varId < 1)
                return BadRequest();

            string[] destinazioni = _service.DettaglioVacanza(varId);

            if (!destinazioni.Any())
                return NotFound();

            return destinazioni;
        }
    }
}
