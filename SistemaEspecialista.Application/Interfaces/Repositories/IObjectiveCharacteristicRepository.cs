﻿using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.Interfaces.Repositories;

public interface IObjectiveCharacteristicRepository
{
    /// <summary>
    /// Get all ObjectiveCharacteristic in the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>A Task of type IEnumerable of ObjectiveCharacteristic</returns>
    public Task<IEnumerable<ObjectiveCharacteristic>> GetAll(CancellationToken cancellationToken);
    /// <summary>
    /// Get a ObjectiveCharacteristic by Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type ObjectiveCharacteristic</returns>
    public Task<ObjectiveCharacteristic> GetById(int id, CancellationToken cancellationToken);

    /// <summary>
    /// Add a ObjectiveCharacteristic to the database.
    /// </summary>
    /// <param name="ObjectiveCharacteristic"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type ObjectiveCharacteristic</returns>
    public Task<ObjectiveCharacteristic> Add(ObjectiveCharacteristic ObjectiveCharacteristic, CancellationToken cancellationToken);

    /// <summary>
    /// Update a ObjectiveCharacteristic to the database by the primary key
    /// </summary>
    /// <param name="ObjectiveCharacteristic"></param>
    /// <returns>A task of type ObjectiveCharacteristic</returns>
    public Task<ObjectiveCharacteristic> Update(ObjectiveCharacteristic ObjectiveCharacteristic);

    /// <summary>
    /// Removes a ObjectiveCharacteristic to the database by the primary key
    /// </summary>
    /// <param name="ObjectiveCharacteristic"></param>
    /// <returns>A task of type ObjectiveCharacteristic</returns>
    public Task<ObjectiveCharacteristic> Remove(ObjectiveCharacteristic ObjectiveCharacteristic);
}
