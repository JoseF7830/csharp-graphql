using GrphQLServer.Data;
using GrphQLServer.Models;
using Microsoft.EntityFrameworkCore;

namespace GrphQLServer.GraphQL.Publicaciones
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class PublicacionesQueries
    {
        [UseOffsetPaging(IncludeTotalCount = true)]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Publicacion> GetPublicaciones(BlogContext context)
            => context.Publicaciones;

        [UseFirstOrDefault]
        [UseProjection]
        public IQueryable<Publicacion?> GetPublicacion(BlogContext context, int id)
            => context.Publicaciones.Where(u => u.Id == id);
    }
}
