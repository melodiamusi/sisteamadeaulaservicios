using ApiSistemaAula.Servicios.Dtos;

namespace ApiSistemaAula.Servicios.Contract
{
    public interface IEstudianteService
    {
        List<EstudianteDTO> ObtenerTodos();

        EstudianteDTO ObtenerPorId(int id);

        bool Crear(EstudianteDTO estudiante);
    }
}
