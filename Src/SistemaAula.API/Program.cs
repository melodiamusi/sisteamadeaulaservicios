using Aplicaciones.Contract;
using Aplicaciones.Services;
using Microsoft.EntityFrameworkCore;
using SistemaAula.Aplicaciones.Contract;
using SistemaAula.Infrastructure.Contexto;
using SistemaAula.Infrastructure.Repositorio;

var builder = WebApplication.CreateBuilder(args);


// Controllers
builder.Services.AddControllers();


// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Conexion")
    );
});


// Servicios
// Servicios
builder.Services.AddScoped<IEstudianteServices, EstudianteServicio>();
builder.Services.AddScoped<IAulaServices, AulaServices>();
builder.Services.AddScoped<ICursoServices, CursoServices>();


// Repositorios
builder.Services.AddScoped<EstudianteRepositorio, EstudianteRepositorio>();


var app = builder.Build();


// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();

