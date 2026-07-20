using Aplicaciones.Dto.Aula;

namespace Aplicaciones.Contract
{
    public interface IAulaServices
    {
        List<AulaDto> ObtenerTodos();

        AulaDto ObtenerPorId(int id);

        bool Crear(CrearAulaDto aula);
    }
}