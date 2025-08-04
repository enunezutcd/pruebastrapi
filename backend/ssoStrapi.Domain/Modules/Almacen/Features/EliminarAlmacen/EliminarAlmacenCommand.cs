using Enee.Core.CQRS.Command;

namespace ssoStrapi.Domain.Modules.Almacen.Features.EliminarAlmacen;

public record EliminarAlmacenCommand(Guid Id) : ICommand;
