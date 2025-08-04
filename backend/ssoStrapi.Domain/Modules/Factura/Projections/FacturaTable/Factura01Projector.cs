using Enee.Core.CQRS.Query;
using ssoStrapi.Domain.Modules.Factura.Features.CrearFactura;
using ssoStrapi.Domain.Modules.Factura.Features.EditarFactura;
using ssoStrapi.Domain.Modules.Factura.Features.EliminarFactura;

namespace ssoStrapi.Domain.Modules.Factura.Projections.FacturaTable;

public class FacturaProjector : TableProjector<Facturas>
{
    public FacturaProjector()
    {
        Create<FacturaCreada>((@event, tabla) =>
        {
            tabla.Id = @event.AggregateId;
            tabla.Numero = @event.Numero;
            tabla.FechaEmision = @event.FechaEmision;
            tabla.EstadoId = @event.EstadoId;
        });

        Project<FacturaEditada>((@event, tabla) =>
        {
            tabla.Numero = @event.Numero;
            tabla.FechaEmision = @event.FechaEmision;
            tabla.EstadoId = @event.EstadoId;
        });

        SoftDeleted<FacturaEliminada>();
    }
}

