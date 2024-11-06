using PetStoreApi.Entities;
using PetStoreApi.Services.AnimalService.ViewModels;

namespace PetStoreApi.Services.AnimalService;

public interface IAnimalService
{
    IEnumerable<AnimalView> ToListView(List<Animal> animals);
}