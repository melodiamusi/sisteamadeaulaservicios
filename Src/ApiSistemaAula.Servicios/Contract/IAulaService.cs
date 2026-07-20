using ApiSistemaAula.Servicios.Dtos;

namespace ApiSistemaAula.Servicios.Contract
{
    public interface IAulaService
    {
        List<AulaDTO> ObtenerTodos();

        AulaDTO ObtenerPorId(int id);

        bool Crear(AulaDTO aula);
    }
}