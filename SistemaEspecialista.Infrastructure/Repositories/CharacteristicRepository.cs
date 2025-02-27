﻿using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Repositories;

public class CharacteristicRepository : Repository<Characteristic>, ICharacteristicsRepository
{
    public CharacteristicRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
