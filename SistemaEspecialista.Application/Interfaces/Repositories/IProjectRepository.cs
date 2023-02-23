using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Application.Interfaces.Repositories;

public interface IProjectRepository
{
    public Task<IEnumerable<Project>> GetAll(CancellationToken token);
    public Task<Project> GetById(int id, CancellationToken cancellationToken);
    public Task<Project> Add(Project project, CancellationToken token);
    public Task<Project> Update(Project project);
    public Task<Project> Remove(Project project);
}

