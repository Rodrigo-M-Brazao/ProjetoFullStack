using LibFilmes.API.Repository;
using LibFilmes.API.Repository.Interface;
using LibFilmes.API.Service;
using LibFilmes.API.Service.Interface;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Injeção de dependencia Services
builder.Services.AddTransient<IFilmesService, FilmesService>();
builder.Services.AddTransient<IGeneroService, GeneroService>();

//Injeção de dependencia Repository
builder.Services.AddTransient<IFilmesRepository, FilmesRepository>();
builder.Services.AddTransient<IGeneroRepository, GeneroRepository>();


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
