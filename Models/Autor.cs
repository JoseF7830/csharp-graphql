﻿namespace GrphQLServer.Models
{
	public class Autor
	{
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;
		public string Apellidos { get; set; } = null!;
		public string CorreoElectronico { get; set; } = null!;
		public decimal Salario { get; set; }
		public ICollection<Publicacion> Publicaciones { get; set; } = null!;

	}
}
