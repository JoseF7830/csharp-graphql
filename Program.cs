using GrphQLServer.Data;
using GrphQLServer.GraphQL.Autores;
using GrphQLServer.GraphQL.Publicaciones;
using GrphQLServer.MethodExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services
	.AddGraphQLServer()
	.AddQueryType()
	.AddMutationType()
	.AddServidorGraphQLTypes()
	.RegisterDbContext<BlogContext>()
	.AddProjections()
	.AddFiltering()
	.AddSorting();

builder.Services
	.AddDbContext<BlogContext>(options =>
		options.UseSqlServer(builder.Configuration.GetConnectionString("BlogConnection"),
		x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "blog")));

var app = builder.Build();

await app.ConfigurarMigraciones();

app.UseCors(c=>c.AllowAnyHeader().WithMethods("POST").AllowAnyOrigin());

app.MapGraphQL();

app.MapGet("/", () => "Hola Shemico!");

app.Run();
