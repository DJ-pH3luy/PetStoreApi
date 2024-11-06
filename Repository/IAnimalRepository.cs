using PetStoreApi.Entities;

namespace PetStoreApi.Repository;

public interface IAnimalRepository
{
    Task<List<Animal>> GetAllAnimals();
}