﻿using Enee.Core.Common;

namespace ssoStrapi.Domain.Modules.Almacen.Features.EliminarAlmacen;

public class AlmacenEliminado:DomainEvent<Guid>
{
    public AlmacenEliminado(Guid aggregateId) : base(aggregateId)
    {
    }
}
