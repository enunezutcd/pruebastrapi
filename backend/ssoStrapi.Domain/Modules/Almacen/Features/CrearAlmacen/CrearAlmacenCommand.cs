
using Enee.Core.CQRS.Command;

namespace ssoStrapi.Domain.Modules.Almacen.Features.CrearAlmacen;

public record CrearAlmacenCommand(Guid Id, string NombreSucursal, string NombreAdministrador, string Telefono, string Direccion,string Fax, double? NumeroPedidos) : ICommand;
