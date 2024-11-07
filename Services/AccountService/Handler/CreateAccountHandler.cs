using MediatR;
using PetStoreApi.Repository;
using PetStoreApi.Services.AccountService.Dto;

namespace PetStoreApi.Services.AccountService.Handler;

public class CreateAccountHandler(IAccountRepository _repo, IAnimalRepository _animalRepo) : IRequestHandler<CreateAccountDto>
{
    public async Task Handle(CreateAccountDto request, CancellationToken cancellationToken)
    {
        var acc = new Entities.Account{
            EmailAddress = request.EmailAddress,
            Iban = request.Iban,
        };
        foreach (var item in request.AnimalIds)
        {
            var animal = await _animalRepo.GetById(item);
            if (animal != null) 
            {
                acc.Animals.Add(animal);
            }
        }
        await _repo.Create(acc);
    }
}
