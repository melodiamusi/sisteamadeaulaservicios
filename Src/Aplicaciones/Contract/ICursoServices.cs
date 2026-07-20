using Aplicaciones.Dto.Curso;

namespace Aplicaciones.Contract
{
    public interface ICursoServices
    {
        List<CursoDto> ObtenerTodos();

        CursoDto ObtenerPorId(int id);

        bool Crear(CrearCursoDto curso);
    }
}