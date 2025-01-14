using AutoMapper;
using GrphQLServer.Data;
using GrphQLServer.GraphQL.Types;
using GrphQLServer.Models;

namespace GrphQLServer.GraphQL.Categorias
{
	[ExtendObjectType(OperationTypeNames.Mutation)]
	public class CategoriasMutations
	{
		public async Task<CategoriaPayload>CreateCategoria(BlogContext context,
			[Service] IMapper mapper, CategoriaInputType inputCategoria)
		{

			var categoria = mapper.Map<Categoria>(inputCategoria);

			await context.Categorias.AddAsync(categoria);
			await context.SaveChangesAsync();

			return mapper.Map<CategoriaPayload>(categoria);
		}


		public async Task<CategoriaPayload> UpdateCategoria(BlogContext context,
			[Service] IMapper mapper, CategoriaInputType inputCategoria, int id)
		{
			var categoria = mapper.Map<Categoria>(inputCategoria);
			categoria.Id = id;

			context.Categorias.Update(categoria);
			await context.SaveChangesAsync();

			return mapper.Map<CategoriaPayload>(categoria);
		}

		public async Task<bool> DeleteCategoria(BlogContext context, int id)
		{
			try
			{
				var categoriaBd = await context.Categorias.FindAsync(id);
				if (categoriaBd is null) return false;

				context.Categorias.Remove(categoriaBd);
				await context.SaveChangesAsync();

				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

	}
}
