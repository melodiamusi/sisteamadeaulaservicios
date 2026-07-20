using ApiSistemaAula.Servicios.Dtos;
using SistemaAula.Domain.Entidades;
using SistemaAula.Infrastructure.Repositorio;

namespace ApiSistemaAula.Servicios
{
    public class EstudianteServicio
    {
        private readonly IEstudianteRepositorio repositorio;

        public EstudianteServicio(IEstudianteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public bool Crear(EstudianteDTO estudiante)
        {
            if (string.IsNullOrWhiteSpace(estudiante.Nombre))
                throw new Exception("El nombre es obligatorio");

            if (string.IsNullOrWhiteSpace(estudiante.Apellido))
                throw new Exception("El apellido es obligatorio");

            if (string.IsNullOrWhiteSpace(estudiante.Matricula))
                throw new Exception("La matrícula es obligatoria");

            if (string.IsNullOrWhiteSpace(estudiante.Email))
                throw new Exception("El email es obligatorio");

            var entidad = new Estudiante
            {
                Nombre = estudiante.Nombre,
                Apellido = estudiante.Apellido,
                Matricula = estudiante.Matricula,
                Email = estudiante.Email
            };

            repositorio.Agregar(entidad);

            return true;
        }
    }
}