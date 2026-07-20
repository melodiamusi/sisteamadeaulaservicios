using ApiSistemaAula.Servicios.Dtos;

namespace ApiSistemaAula.Servicios.Contract
{
    public interface ICursoService
    {
        List<CursoDTO> ObtenerTodos();

        CursoDTO ObtenerPorId(int id);

        bool Crear(CursoDTO curso);
    }
}