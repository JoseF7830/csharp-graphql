﻿using GrphQLServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrphQLServer.Data.Configurations
{
	public class PublicacionConfiguration : IEntityTypeConfiguration<Publicacion>
	{
		public void Configure(EntityTypeBuilder<Publicacion> builder)
		{
			builder.ToTable("Publicacion", "blog");

			builder.Property(u => u.Titulo)
				.IsRequired()
				.HasMaxLength(250);

			builder.Property(u => u.Contenido)
				.IsRequired ()
				.HasMaxLength(5000);

			builder.Property(u => u.ImagenUrl)
				.IsRequired()
				.HasMaxLength(500);

			builder.Property(u => u.Estado)
				.HasDefaultValue(EstadoPublicacion.REVISION);
		}
	}
}
