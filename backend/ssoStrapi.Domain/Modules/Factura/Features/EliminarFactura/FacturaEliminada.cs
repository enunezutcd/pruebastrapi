using Enee.Core.Common;

namespace ssoStrapi.Domain.Modules.Factura.Features.EliminarFactura;

public class FacturaEliminada:DomainEvent<Guid>
{
    public FacturaEliminada(Guid aggregateId) : base(aggregateId)
    {
    }
}
