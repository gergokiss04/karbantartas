using karbantartas.Models;
using karbantartas.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace karbantartas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KarbantartasController : ControllerBase
    {
        private readonly KarbantartasRepository _repository;

        public KarbantartasController(KarbantartasRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("vegpont1")]

        public async Task<IEnumerable<object>> GetKarbantartasok()
        {
            return await _repository.GetKarbantartok();
        }

        [HttpGet("vegpont2/{id}")]

        public async Task<IEnumerable<object>> GetFeladatok(long f_id)
        {
            return await _repository.GetFeladatok(f_id);
        }

    }
}
