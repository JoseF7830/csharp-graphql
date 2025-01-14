using AutoMapper;
using GrphQLServer.GraphQL.Types;
using GrphQLServer.Models;

namespace GrphQLServer.Helpers
{
	public class MappingProfile:Profile
	{

		public MappingProfile()
		{
			CreateMap<Publicacion,PublicacionInputType>()
				.ReverseMap()
				.ForMember(u => u.Autor, pubInput => pubInput.Ignore())
				.ForMember(u => u.Categoria, pubInput => pubInput.Ignore());

			CreateMap<Publicacion, PublicacionPayload>()
				.ReverseMap()
				.ForMember(u => u.Autor, pubInput => pubInput.Ignore())
				.ForMember(u => u.Categoria, pubInput => pubInput.Ignore());

			CreateMap<Autor, AutorInputType>()
				.ReverseMap();

			CreateMap<Autor, AutorPayload>()
				.ReverseMap();

			CreateMap<Categoria, CategoriaInputType>()
				.ReverseMap();

			CreateMap<Categoria, CategoriaPayload>()
				.ReverseMap();

		}

	}
}
