namespace ApiSistemaAula.Servicios.Dtos
{
    public class CursoDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Profesor { get; set; }

        public string Horario { get; set; }

        public int AulaId { get; set; }
    }
}