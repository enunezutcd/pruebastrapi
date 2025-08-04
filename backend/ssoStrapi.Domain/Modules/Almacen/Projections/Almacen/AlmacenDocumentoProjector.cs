using Enee.Core.CQRS.Query;
using ssoStrapi.Domain.Modules.Almacen.Features.CrearAlmacen;
using ssoStrapi.Domain.Modules.Almacen.Features.EliminarAlmacen;

namespace ssoStrapi.Domain.Modules.Almacen.Projections.Almacen;

public class AlmacenDocumentoProjector:DocumentProjector<AlmacenDocumento>
{

    public AlmacenDocumentoProjector()
    {
        Create<AlmacenCreado>((@event, documento) =>
        {
            documento.Id = @event.AggregateId;
            documento.NombreSucursal = @event.NombreSucursal;
            documento.NombreAdministrador  = @event.NombreAdministrador ;
            documento.Telefono  = @event.Telefono ;
            documento.Direccion  = @event.Direccion;
            documento.Fax  = @event.Fax ;
            documento.NumeroPedidos  = @event.NumeroPedidos;
            documento.Otro = "Otro";

        });


        Deleted<AlmacenEliminado>();
    }
}
