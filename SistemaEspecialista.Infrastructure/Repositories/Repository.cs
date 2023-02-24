using Microsoft.EntityFrameworkCore;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;
using System.Linq.Expressions;

namespace SistemaEspecialista.Infrastructure.Repositories;

public abstract class Repository<TEntity> where TEntity : Entity
{
    protected readonly IApplicationDbContext DbContext;
    protected readonly DbSet<TEntity> EntityDbSet;

    protected Repository(IApplicationDbContext dbContext)
    {
        DbContext = dbContext;
        EntityDbSet = DbContext.Set<TEntity>();
    }

    /// <summary>
    /// Search for a collection of items of Type TEntity based on a lambda expression to filter and a cancellation token
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A Task of type IEnumerable of TEntity</returns>
    public virtual async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
    {
        return await EntityDbSet.AsNoTracking().Where(predicate).ToListAsync(cancellationToken);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public virtual async Task<TEntity> GetById(int id, CancellationToken cancellationToken)
    {
        return await EntityDbSet.FindAsync(new object[] { id }, cancellationToken);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public virtual async Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await EntityDbSet.ToListAsync(cancellationToken);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public virtual async Task<TEntity> Add(TEntity entity, CancellationToken cancellationToken)
    {
        await EntityDbSet.AddAsync(entity, cancellationToken);
        return entity;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public virtual async Task<TEntity> Update(TEntity entity)
    {
        await Task.FromResult(EntityDbSet.Update(entity));
        return entity;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public virtual async Task<TEntity> Remove(TEntity entity)
    {
        await Task.FromResult(EntityDbSet.Remove(entity));
        return entity;
    }
}
