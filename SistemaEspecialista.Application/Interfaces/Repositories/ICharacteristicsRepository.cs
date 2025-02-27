﻿using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.Interfaces.Repositories;

public interface ICharacteristicsRepository
{
    /// <summary>
    /// Get all characteristic in the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>A Task of type IEnumerable of Characteristic</returns>
    public Task<IEnumerable<Characteristic>> GetAll(CancellationToken cancellationToken);
    /// <summary>
    /// Get a characteristic by Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type Characteristic</returns>
    public Task<Characteristic> GetById(int id, CancellationToken cancellationToken);

    /// <summary>
    /// Add a characteristic to the database.
    /// </summary>
    /// <param name="characteristic"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type Characteristic</returns>
    public Task<Characteristic> Add(Characteristic characteristic, CancellationToken cancellationToken);

    /// <summary>
    /// Update a characteristic to the database by the primary key
    /// </summary>
    /// <param name="characteristic"></param>
    /// <returns>A task of type Objective</returns>
    public Task<Characteristic> Update(Characteristic characteristic);

    /// <summary>
    /// Removes a characteristic to the database by the primary key
    /// </summary>
    /// <param name="characteristic"></param>
    /// <returns>A task of type Characteristic</returns>
    public Task<Characteristic> Remove(Characteristic characteristic);
}

