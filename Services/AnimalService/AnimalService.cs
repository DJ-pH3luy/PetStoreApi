using PetStoreApi.Entities;
using PetStoreApi.Services.AnimalService.ViewModels;

namespace PetStoreApi.Services.AnimalService;

public class AnimalService : IAnimalService
{
    public static IEnumerable<AnimalView> ToListView(List<Animal> animals)
    {
        foreach (var item in animals)
            yield return item.ToView();
    }
}