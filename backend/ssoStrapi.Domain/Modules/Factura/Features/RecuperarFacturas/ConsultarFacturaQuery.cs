using Enee.Core.CQRS.Query;
using ssoStrapi.Domain.Modules.Factura.Features.ConsultarFacturas;
using ssoStrapi.Domain.Modules.Factura.Projections.FacturaTable;
using ssoStrapi.Domain.Query;

namespace ssoStrapi.Domain.Modules.Factura.Features.RecuperarFacturas;

public class RecuperarFacturaQuery:IQuery<Facturas?>
{
    public RecuperaFacturaFilter Filters { get; }

    public RecuperarFacturaQuery(RecuperaFacturaFilter filters)
    {
        Filters = filters;
    }

    public string Description { get; } = "Recuperar factura";


}
