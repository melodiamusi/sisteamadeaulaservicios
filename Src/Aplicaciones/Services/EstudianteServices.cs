using SistemaAula.Aplicaciones.Contract;
using SistemaAula.Aplicaciones.Dto.Estudiante;

namespace Aplicaciones.Services
{
    public class EstudianteServicio : IEstudianteServices
    {
        private static List<EstudianteDto> estudiantes = new List<EstudianteDto>();


        public bool Crear(CrearEstudianteDto estudiante)
        {
            var nuevo = new EstudianteDto
            {
                Id = estudiantes.Count + 1,
                Nombre = estudiante.Nombre,
                Apellido = estudiante.Apellido,
                Matricula = estudiante.Matricula,
                Email = estudiante.Email
            };

            estudiantes.Add(nuevo);

            return true;
        }


        public List<EstudianteDto> ObtenerTodos()
        {
            return estudiantes;
        }


        public EstudianteDto ObtenerPorId(int id)
        {
            return estudiantes.FirstOrDefault(x => x.Id == id);
        }


        public void Actualizar(ActualizarEstudianteDto dto)
        {
            var estudiante = estudiantes.FirstOrDefault(x => x.Id == dto.Id);

            if (estudiante != null)
            {
                estudiante.Nombre = dto.Nombre;
                estudiante.Apellido = dto.Apellido;
                estudiante.Matricula = dto.Matricula;
                estudiante.Email = dto.Email;
            }
        }


        public void Eliminar(int id)
        {
            var estudiante = estudiantes.FirstOrDefault(x => x.Id == id);

            if (estudiante != null)
            {
                estudiantes.Remove(estudiante);
            }
        }
    }
}