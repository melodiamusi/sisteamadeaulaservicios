using SistemaAula.Aplicaciones.Dto.Estudiante;

namespace SistemaAula.Aplicaciones.Contract
{
    public interface IEstudianteServices
    {
        List<EstudianteDto> ObtenerTodos();

        EstudianteDto ObtenerPorId(int id);

        bool Crear(CrearEstudianteDto dto);

        void Actualizar(ActualizarEstudianteDto dto);

        void Eliminar(int id);
    }
}
