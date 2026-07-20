using Microsoft.AspNetCore.Mvc;
using SistemaAula.Aplicaciones.Contract;
using SistemaAula.Aplicaciones.Dto.Estudiante;

namespace ApiSistemaAula.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteServices servicio;


        public EstudianteController(IEstudianteServices servicio)
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
        public IActionResult Crear([FromBody] CrearEstudianteDto dto)
        {
            servicio.Crear(dto);

            return Ok("Estudiante creado correctamente");
        }
    }
}