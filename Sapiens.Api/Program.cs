using Microsoft.EntityFrameworkCore;
using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SapiensContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapGet("/migrate", (SapiensContext context) =>
{
    context.Database.Migrate();
});

app.MapGet("/cursos", (SapiensContext context) =>
{
    var cursos = context.Cursos.OrderBy(c => c.Nome).ToList();
    return Results.Ok(cursos);
}).Produces<IEnumerable<Curso>>().WithOpenApi();

app.MapGet("/cursos/{id}", (int id, SapiensContext context) =>
{
    var curso = context.Cursos.Find(id);
    return curso == null ? Results.NotFound() : Results.Ok(curso);
}).Produces<Curso>().WithOpenApi();

app.MapGet("/cursos/pornome/{nome}", (string nome, SapiensContext context) =>
{
    var cursos = context.Cursos.Where(c => c.Nome.ToLower().Contains(nome.ToLower())).ToList();
    return cursos == null ? Results.NotFound() : Results.Ok(cursos);
}).Produces<IEnumerable<Curso>>().WithOpenApi();

app.MapPost("/cursos", (Curso curso, SapiensContext context) =>
{
    context.Add(curso);
    context.SaveChanges();
    return Results.Ok(curso);
}).Produces<Curso>().WithOpenApi();

app.MapDelete("/cursos", (int id, SapiensContext context) =>
{
    var curso = context.Cursos.Find(id);
    if (curso != null)
    {
        context.Remove(curso);
        context.SaveChanges();
    }
    return Results.NoContent();
}).WithOpenApi();

app.Run();

