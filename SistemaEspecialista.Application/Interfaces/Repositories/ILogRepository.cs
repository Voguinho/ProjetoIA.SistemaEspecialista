using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.Interfaces.Repositories;

public interface ILogRepository
{
    /// <summary>
    /// Get all Log in the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>A Task of type IEnumerable of Log</returns>
    public Task<IEnumerable<Log>> GetAll(CancellationToken cancellationToken);
    /// <summary>
    /// Get a log by Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type Log</returns>
    public Task<Log> GetById(int id, CancellationToken cancellationToken);

    /// <summary>
    /// Add a log to the database.
    /// </summary>
    /// <param name="Log"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type Log</returns>
    public Task<Log> Add(Log Log, CancellationToken cancellationToken);

    /// <summary>
    /// Update a log to the database by the primary key
    /// </summary>
    /// <param name="Log"></param>
    /// <returns>A task of type Objective</returns>
    public Task<Log> Update(Log Log);

    /// <summary>
    /// Removes a log to the database by the primary key
    /// </summary>
    /// <param name="Log"></param>
    /// <returns>A task of type Log</returns>
    public Task<Log> Remove(Log Log);
}
