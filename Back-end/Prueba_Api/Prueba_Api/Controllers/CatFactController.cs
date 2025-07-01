using Microsoft.AspNetCore.Mvc;
using Prueba_Api.Models;
using Prueba_Api.Repositories;
using Prueba_Api.Services;

namespace Prueba_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatFactController
    {
        private readonly ICatFactService _service;

        public CatFactController(ICatFactService service, IGifRepository gifRepository)
        {
            _service = service;
        }

        [HttpGet("random")]
        public async Task<ActionResult<CastFact>> GetRandomFact()
        {
            var response = await _service.GetFactWithWordsAsync();
            return response;
        }

        [HttpGet("gif/{id}")]
        public async Task<ActionResult<CastFact>> ReprocessGif(int id)
        {
            var response = await _service.ReprocessGifAsync(id);

            if (response == null)
                return null;

            return response;
        }

        [HttpPost("history")]
        public async Task<ActionResult<List<CastFact>>> GetHistory()
        {
            var history = await _service.GetHistoryAsync();
            return history;
        }



    }
}
