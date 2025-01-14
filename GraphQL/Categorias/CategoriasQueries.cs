using GrphQLServer.Data;
using GrphQLServer.Models;

namespace GrphQLServer.GraphQL.Categorias
{
	[ExtendObjectType(OperationTypeNames.Query)]
	public class CategoriasQueries
	{
		[UseOffsetPaging(IncludeTotalCount = true)]
		[UseProjection]
		[UseFiltering]
		[UseSorting]

		public IQueryable<Categoria> GetCategorias(BlogContext context)
			=> context.Categorias;

		[UseFirstOrDefault]
		[UseProjection]

		public IQueryable<Categoria?> GetCategoria(BlogContext context, int id)
			=> context.Categorias.Where(u => u.Id == id);

	}
}
