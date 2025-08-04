﻿using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using ssoStrapi.Domain.Modules.Factura.Features.ConsultarFacturas;
using ssoStrapi.Domain.Modules.Factura.Features.RecuperarFacturas;
using MiFactura = ssoStrapi.Domain.Modules.Factura.Projections.FacturaTable.Facturas;

namespace ssoStrapi.Api.Modules.Factura.Features.RecuperarFactura;

public static class Endpoint
{
    public static void RecuperarFactura(this IEndpointRouteBuilder app)
    {
        app.MapGet("/{id}", async (IQueryDispatcher dispatcher, [AsParameters] RecuperaFacturaFilter filters) =>
            {

                MiFactura? facutura = await dispatcher.Execute(new RecuperarFacturaQuery(filters));
                return facutura;
            })
            .Produces<MiFactura>()
            .WithSummary("Recupera factura")
            .WithDescription("Permite listar facturas")
            .WithOpenApi();
        // .Access();
    }
}
