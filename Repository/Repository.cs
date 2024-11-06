using Microsoft.EntityFrameworkCore;
using PetStoreApi.Entities;

namespace PetStoreApi.Repository;

public class Repository<T>(PetStoreDbContext context) : IRepository<T> where T : BaseEntity
{
    protected readonly PetStoreDbContext _dbContext = context;

    public async Task<T> Create(T entity)
    {
        _dbContext.Set<T>()
            .Add(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task Delete(T entity)
    {
        _dbContext.Set<T>()
            .Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<T>> GetAll()
    {
        return await _dbContext.Set<T>()
            .AsQueryable()
            .ToListAsync();
    }

    public async Task<T?> GetById(int id)
    {
        return await _dbContext.Set<T>()
            .AsQueryable()
            .Where(e => e.Id == id)
            .SingleOrDefaultAsync();
    }

    public async Task<T> Update(T entity)
    {
        _dbContext.Set<T>()
            .Update(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }
}
