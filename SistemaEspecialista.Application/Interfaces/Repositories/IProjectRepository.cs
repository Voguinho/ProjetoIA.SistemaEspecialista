using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.Interfaces.Repositories;

public interface IProjectRepository
{
    /// <summary>
    /// Get all projects in the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>A Task of type IEnumerable of Project</returns>
    public Task<IEnumerable<Project>> GetAll(CancellationToken token);
    /// <summary>
    /// Get a project by Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type Project</returns>
    public Task<Project> GetById(int id, CancellationToken cancellationToken);

    /// <summary>
    /// Add a project to the database.
    /// </summary>
    /// <param name="project"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type Project</returns>
    public Task<Project> Add(Project project, CancellationToken cancellationToken);

    /// <summary>
    /// Update a project to the database by the primary key
    /// </summary>
    /// <param name="project"></param>
    /// <returns>A task of type Project</returns>
    public Task<Project> Update(Project project);

    /// <summary>
    /// Removes a project to the database by the primary key
    /// </summary>
    /// <param name="project"></param>
    /// <returns>A task of type Project</returns>
    public Task<Project> Remove(Project project);
}

