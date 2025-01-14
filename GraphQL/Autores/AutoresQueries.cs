using GrphQLServer.Data;
using GrphQLServer.Models;

namespace GrphQLServer.GraphQL.Autores
{
	[ExtendObjectType(OperationTypeNames.Query)]
	public class AutoresQueries
	{
		[UseOffsetPaging(IncludeTotalCount = true)]
		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Autor> GetAutores(BlogContext context)
			=> context.Autores;

		[UseFirstOrDefault]
		[UseProjection]
		public IQueryable<Autor?> GetAutor(BlogContext context, int id)
			=> context.Autores.Where(u => u.Id == id);
	}
}
