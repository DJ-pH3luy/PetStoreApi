using MediatR;
using PetStoreApi.Repository;
using PetStoreApi.Services.AnimalService.Queries;
using PetStoreApi.Services.AnimalService.ViewModels;

namespace PetStoreApi.Services.AnimalService.Handlers;

public class GetAnimalHandler(IAnimalRepository _repo) : IRequestHandler<GetAnimalQuery, AnimalView?>
{
    public async Task<AnimalView?> Handle(GetAnimalQuery request, CancellationToken cancellationToken)
    {
        var animal = await _repo.GetAnimalById(request.Id);
        return animal?.ToView();
    }
}
