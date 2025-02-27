﻿using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Repositories;

public class ObjectiveCharacteristicRepository : Repository<ObjectiveCharacteristic>, IObjectiveCharacteristicRepository
{
    public ObjectiveCharacteristicRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
