using Microsoft.AspNetCore.Mvc;
using Servicios.Api.Libreria.Core.Entities;
using Servicios.Api.Libreria.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Servicios.Api.Libreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaServicioController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;

        public LibreriaServicioController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        [HttpGet("autores")]
        public async Task<ActionResult<IEnumerable<Autor>>> GetAutores()
        {
            var autores = await _autorRepository.GetAutores();

            return Ok(autores);
        }
    }
}
