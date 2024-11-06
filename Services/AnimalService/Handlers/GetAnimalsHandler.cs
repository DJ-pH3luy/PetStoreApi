using MediatR;
using PetStoreApi.Repository;
using PetStoreApi.Services.AnimalService.Queries;
using PetStoreApi.Services.AnimalService.ViewModels;

namespace PetStoreApi.Services.AnimalService.Handlers;

public class GetAnimalsHandler(IAnimalRepository _repo, IAnimalService _service) : IRequestHandler<GetAnimalsQuery, AnimalViewList>
{
    public async Task<AnimalViewList> Handle(GetAnimalsQuery request, CancellationToken cancellationToken)
    {
        var animals = await _repo.GetAllAnimals();
        var views = _service.ToListView(animals).ToList();
        return new AnimalViewList(views);
    }


}