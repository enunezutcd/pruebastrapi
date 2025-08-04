using ssoStrapi.Api.Modules.Almacen.Features.CrearAlmacen;
using ssoStrapi.Api.Utilities.Response;
using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using Enee.Core.CQRS.Validation;
using ssoStrapi.Domain.Modules.Almacen.Features.CrearAlmacen;

namespace ssoStrapi.Api.Modules.Almacen.Features.EliminarAlmacen;

public static class Endpoint
{
    public static void EliminarAlmancen(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/", async (AlmacenRequest request, IDispatcher dispatcher) =>
            {
                var id = Guid.NewGuid();
                Either<OK, List<MessageValidation>>? result = await dispatcher.Dispatch(new CrearAlmacenCommand(
                    id,
                    request.NombreSucursal,
                    request.NombreAdministrador,
                    request.Telefono,
                    request.Direccion,
                    request.Fax,
                    request.NumeroPedidos

                ));
                return result.ToResponse(new AlmancenResponse(){ Id = id });
            })
            .Produces<AlmancenResponse>()
            .WithSummary("Crear almacen")
            .WithDescription("Permite crear un almacen y devuelve el identificador del almacen creado")
            .WithOpenApi();
    }


}
