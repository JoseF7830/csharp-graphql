using GrphQLServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrphQLServer.Data.Configurations
{
	public class AutorConfiguration : IEntityTypeConfiguration<Autor>
	{
		public void Configure(EntityTypeBuilder<Autor> builder)
		{
			builder.ToTable("Autor", "blog");

			builder.Property(u => u.Nombre)
				.IsRequired()
				.HasMaxLength(100);

			builder.Property(u => u.Apellidos)
				.IsRequired()
				.HasMaxLength(200);

			builder.Property(u => u.CorreoElectronico)
				.IsRequired()
				.HasMaxLength(250);

			builder.Property(u => u.Salario)
				.HasColumnType("decimal(18,2)")
				.HasDefaultValue(0M);

			builder.HasMany(u => u.Publicaciones)
				.WithOne(u => u.Autor)
				.HasForeignKey(u => u.AutorId);


		}
	}
}
