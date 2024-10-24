using CitasMedicaApp.Domain.Repositories;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Falta completar el Db context. //
builder.Services.AddDbContext<CitaContext>(options => options.UseSqlServer(builder.Reservation.GetConnectionString("CitasDb")));

//Registro de cada una de los repositorios solo hay uno por el momento//
builder.Services.AddScoped<IBaseRepository, BaseRepository >();

//Servicios de logica de negocio

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
