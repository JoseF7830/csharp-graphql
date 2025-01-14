using AutoMapper;
using GrphQLServer.Data;
using GrphQLServer.GraphQL.Types;
using GrphQLServer.Models;
using HotChocolate.Utilities;
using System.Linq.Expressions;

namespace GrphQLServer.GraphQL.Publicaciones
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class PublicacionesMutations
    {
        //Crear Datos
        public async Task<PublicacionPayload> CreatePublicacion(BlogContext context,
            [Service] IMapper mapper,
            PublicacionInputType inputPublicacion)
        {
            var publicacion = mapper.Map<Publicacion>(inputPublicacion);

            await context.Publicaciones.AddAsync(publicacion);
            await context.SaveChangesAsync();

            return mapper.Map<PublicacionPayload>(publicacion);
        }

        //Modificar Datos
        public async Task<PublicacionPayload> UpdatePublicacion(
            BlogContext context,
            [Service] IMapper mapper,
            int id,
            PublicacionInputType inputPublicacion)
        {

            var publicacion = mapper.Map<Publicacion>(inputPublicacion);
            publicacion.Id = id;

            context.Publicaciones.Update(publicacion);
            await context.SaveChangesAsync();

            return mapper.Map<PublicacionPayload>(publicacion);
        }
        //Eliminar datos
        public async Task<bool> DeletePublicacion(BlogContext context, int id)
        {
            try
            {
                var publicacionBd = await context.Publicaciones.FindAsync(id);
                if (publicacionBd is null) return false;

                context.Publicaciones.Remove(publicacionBd);
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
