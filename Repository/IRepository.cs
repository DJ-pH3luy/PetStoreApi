using PetStoreApi.Entities;

namespace PetStoreApi.Repository;

public interface IRepository<T> where T : BaseEntity
{
    public Task<T> Create(T entity);
    public Task<List<T>> GetAll();
    public Task<T?> GetById(int id);
    public Task<T> Update(T entity);
    public Task Delete(T entity);
}
