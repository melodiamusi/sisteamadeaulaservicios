using System.ComponentModel.DataAnnotations;

namespace Aplicaciones.Dto.Curso
{
    public class CrearCursoDto
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Profesor { get; set; } = string.Empty;

        [Required]
        public string Horario { get; set; } = string.Empty;
    }
}
