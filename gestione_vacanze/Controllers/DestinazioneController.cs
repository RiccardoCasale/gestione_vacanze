using gestione_vacanze.Models;
using gestione_vacanze.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace gestione_vacanze.Controllers
{
    [ApiController]
    [Route("api/destinazione")]
    public class DestinazioneController : Controller
    {
        private readonly DestinazioneService _service;

        public DestinazioneController(DestinazioneService service) 
        {
            _service = service;
        }

        //ELIMINA UNA DESTINAZIONE

        [HttpDelete("/{varId}")]
        public ActionResult<bool> EliminaDestinazione(int varId) 
        {
            if (int.IsNegative(varId) || varId < 1) {
                return BadRequest();
            }
            else
            {
                return _service.EliminaDestinazione(varId);
            }
            return NotFound();
        }

        [HttpGet]
        public ActionResult<List<DestinazioneDTO>> GetAllDestinazioni()
        {
           List<DestinazioneDTO> result = _service.GetAllDestinazioni();
            return result;
        }

    }
}
