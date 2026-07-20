using Aplicaciones.Contract;
using Aplicaciones.Dto.Aula;

namespace Aplicaciones.Services
{
    public class AulaServices : IAulaServices
    {
        private static List<AulaDto> aulas = new List<AulaDto>();


        public bool Crear(CrearAulaDto aula)
        {
            var nuevaAula = new AulaDto
            {
                Id = aulas.Count + 1,
                Nombre = aula.Nombre
            };

            aulas.Add(nuevaAula);

            return true;
        }


        public AulaDto ObtenerPorId(int id)
        {
            var aula = aulas.FirstOrDefault(x => x.Id == id);

            return aula;
        }


        public List<AulaDto> ObtenerTodos()
        {
            return aulas;
        }
    }
}