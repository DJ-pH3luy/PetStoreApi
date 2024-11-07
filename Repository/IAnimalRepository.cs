using PetStoreApi.Entities;

namespace PetStoreApi.Repository;

public interface IAnimalRepository : IRepository<Animal>
{
    Task<List<Animal>> GetAllAnimals();

    Task<Animal?> GetAnimalById(int id);
}