using Aplicaciones.Contract;
using Aplicaciones.Dto.Curso;
using Microsoft.AspNetCore.Mvc;


namespace ApiSistemaAula.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {

        private readonly ICursoServices servicio;


        public CursoController(ICursoServices servicio)
        {
            this.servicio = servicio;
        }



        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var resultado = servicio.ObtenerTodos();

            return Ok(resultado);
        }



        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var resultado = servicio.ObtenerPorId(id);

            return Ok(resultado);
        }



        [HttpPost]
        public IActionResult Crear([FromBody] CrearCursoDto curso)
        {
            var resultado = servicio.Crear(curso);

            if (resultado)
            {
                return Ok("Curso creado correctamente");
            }

            return BadRequest("No se pudo crear el curso");
        }

    }

}