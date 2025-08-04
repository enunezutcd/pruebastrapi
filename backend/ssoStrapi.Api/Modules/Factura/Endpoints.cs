using Carter;
using ssoStrapi.Api.Modules.Factura.Features.ConsultarFacturas;
using ssoStrapi.Api.Modules.Factura.Features.CrearFacturas;
using ssoStrapi.Api.Modules.Factura.Features.EditarFacturas;
using ssoStrapi.Api.Modules.Factura.Features.EliminarFactura;
using ssoStrapi.Api.Modules.Factura.Features.EliminarItemFactura;
using ssoStrapi.Api.Modules.Factura.Features.RecuperarFactura;

namespace ssoStrapi.Api.Modules.Factura;

public class Endpoints : CarterModule
{
    public Endpoints() : base("/api/v1/facturas")
    {
        this.WithTags("Facturas");

    }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.CrearFactura();
        app.EditarFactura();
        app.RecuperarFactura();
        app.ConsultarFacturas();
        app.EliminarFactura();
        app.EliminarItemFactura();
    }
}
