using Aplicaciones.Contract;
using Aplicaciones.Dto.Aula;
using Microsoft.AspNetCore.Mvc;


namespace ApiSistemaAula.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AulaController : ControllerBase
    {

        private readonly IAulaServices servicio;


        public AulaController(IAulaServices servicio)
        {
            this.servicio = servicio;
        }



        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            return Ok(servicio.ObtenerTodos());
        }



        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            return Ok(servicio.ObtenerPorId(id));
        }



        [HttpPost]
        public IActionResult Crear([FromBody] CrearAulaDto aula)
        {
            bool resultado = servicio.Crear(aula);

            if (resultado)
            {
                return Ok("Aula creada correctamente");
            }

            return BadRequest("No se pudo crear el aula");
        }

    }

}