using GrphQLServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GrphQLServer.Data
{
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Autor> Autores { get; set; } = default!;
		public DbSet<Categoria> Categorias { get; set; } = default!;
		public DbSet<Publicacion> Publicaciones { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			base.OnModelCreating(modelBuilder);
		}
	}
}
