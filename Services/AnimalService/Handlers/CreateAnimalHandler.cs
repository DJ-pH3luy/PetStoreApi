using MediatR;
using PetStoreApi.Repository;
using PetStoreApi.Services.AnimalService.Dto;

namespace PetStoreApi.Services.AnimalService.Handlers;

public class CreateAnimalHandler(IAnimalRepository _repo) : IRequestHandler<CreateAnimalDto>
{
    public async Task Handle(CreateAnimalDto request, CancellationToken cancellationToken)
    {
        await _repo.Create(new Entities.Animal{
            Name = request.Name,
            Price = request.Price,
            Kind = request.Kind
        });
    }
}
