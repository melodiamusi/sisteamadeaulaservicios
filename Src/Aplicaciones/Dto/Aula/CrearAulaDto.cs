using System.ComponentModel.DataAnnotations;

namespace Aplicaciones.Dto.Aula
{
    public class CrearAulaDto
    {
        [Required(ErrorMessage = "El nombre del aula es obligatorio.")]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
    }
}
