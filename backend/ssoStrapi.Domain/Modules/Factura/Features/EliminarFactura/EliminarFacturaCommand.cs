using Enee.Core.CQRS.Command;

namespace ssoStrapi.Domain.Modules.Factura.Features.EliminarFactura;

public record EliminarFacturaCommand(Guid Id):ICommand;
