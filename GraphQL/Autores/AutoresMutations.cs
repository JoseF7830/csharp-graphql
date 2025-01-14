using AutoMapper;
using GrphQLServer.Data;
using GrphQLServer.GraphQL.Types;
using GrphQLServer.Models;

namespace GrphQLServer.GraphQL.Autores
{
	[ExtendObjectType(OperationTypeNames.Mutation)]
	public class AutoresMutations
	{
		public async Task<AutorPayload> CreateAutor(BlogContext context,
			[Service]IMapper mapper, AutorInputType inputAutor)
		{
			var autor = mapper.Map<Autor>(inputAutor);

			await context.Autores.AddAsync(autor);
			await context.SaveChangesAsync();

			return mapper.Map<AutorPayload>(autor);
		}

		public async Task<AutorPayload> UpdateAutor(BlogContext context,
			[Service] IMapper mapper, AutorInputType inputAutor, int id)
		{
			var autor = mapper.Map<Autor>(inputAutor);
			autor.Id = id;

		    context.Autores.Update(autor);
			await context.SaveChangesAsync();

			return mapper.Map<AutorPayload>(autor);
		}

		public async Task<bool> DeleteAutor(BlogContext context, int id)
		{
			try
			{
				var autorBd = await context.Autores.FindAsync(id);
				if (autorBd is null) return false;

				context.Autores.Remove(autorBd);
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
