using MediatR;
using PetStoreApi.Repository;
using PetStoreApi.Services.AnimalService.Dto;

namespace PetStoreApi.Services.AnimalService.Handlers;

public class UpdateAnimalHandler(IAnimalRepository _repo) : IRequestHandler<UpdateAnimalDto>
{
    public async Task Handle(UpdateAnimalDto request, CancellationToken cancellationToken)
    {
        var animal = await _repo.GetAnimalById(request.Id);
        if (animal != null) 
        {
            animal.Kind = request.Kind;
            animal.Price = request.Price;
            animal.Name = request.Name;
            await _repo.Update(animal);
        }
    }
}
