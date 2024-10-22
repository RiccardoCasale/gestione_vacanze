using gestione_vacanze.Models;
using gestione_vacanze.Repos;
using gestione_vacanze.Services;
using Microsoft.AspNetCore.Mvc;

namespace gestione_vacanze.Controllers
{
    [ApiController]
    [Route("api/recUtente")]
    public class RecUtenteController : Controller
    {
        private readonly RecUtenteService _service;

        public RecUtenteController(RecUtenteService service)
        {
            _service = service;
        }

        [HttpGet("getAll")]
        public ActionResult<List<RecUtenteDTO>> GetAllRecUtente()
        {
            List<RecUtenteDTO> risultato = _service.GetAllRecUtenteService();
            return risultato;
        }

        [HttpPost("insert")]
        public ActionResult<bool> InsertRec(RecUtentePostDTO newRec)
        {
            bool result = _service.InsertRec(newRec);
            
            return result;
        }
    }
}
