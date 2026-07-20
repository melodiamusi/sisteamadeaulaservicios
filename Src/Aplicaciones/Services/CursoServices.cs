using Aplicaciones.Contract;
using Aplicaciones.Dto.Curso;

namespace Aplicaciones.Services
{
    public class CursoServices : ICursoServices
    {
        private static List<CursoDto> cursos = new List<CursoDto>();


        public bool Crear(CrearCursoDto curso)
        {
            var nuevoCurso = new CursoDto
            {
                Id = cursos.Count + 1,
                Nombre = curso.Nombre
            };

            cursos.Add(nuevoCurso);

            return true;
        }


        public CursoDto ObtenerPorId(int id)
        {
            return cursos.FirstOrDefault(x => x.Id == id);
        }


        public List<CursoDto> ObtenerTodos()
        {
            return cursos;
        }
    }
}