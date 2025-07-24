using Application.interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using Persistance.Repositories.AuthorRepositories;
using Persistance.Repositories.BookRepositories;
using Persistance.Repositories.CarGo.Persistence.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Controller ve Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext (SQL Server baðlantýsý)
builder.Services.AddDbContext<WebProjeContext>(options =>
    options.UseSqlServer("Server=YASINEFEDEMIR\\SQLEXPRESS;Database=webProje;Trusted_Connection=True;TrustServerCertificate=True;"));

// MediatR (Tüm assembly'leri tara, ekstra referanssýz)
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

// Dependency Injection
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();

// Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware pipeline
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
