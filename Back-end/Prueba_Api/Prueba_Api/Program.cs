
using Microsoft.EntityFrameworkCore;
using Prueba_Api.Data;
using Prueba_Api.Repositories;
using Prueba_Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar HttpClient para el repositorio
builder.Services.AddHttpClient<ICatFactRepository, CatFactRepository>();

//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});



// Add services to the container.
builder.Services.AddScoped<ICatFactService, CatFactService>();
builder.Services.AddHttpClient<IGifRepository, GifRepository>();

//add connection to the database
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
