using Microsoft.EntityFrameworkCore;
using PetStoreApi.Entities;

namespace PetStoreApi.Repository;

public class AnimalRepository(PetStoreDbContext _dbContext) : Repository<Animal>(_dbContext), IAnimalRepository
{
    private IQueryable<Animal> _query => _dbContext.Set<Animal>()
        .Include(i => i.Owner);

    public async Task<List<Animal>> GetAllAnimals()
    {
        return await _query.ToListAsync();
    }

    public async Task<Animal?> GetAnimalById(int id)
    {
        return await _query.Where(a => a.Id == id).FirstOrDefaultAsync();
    }
}