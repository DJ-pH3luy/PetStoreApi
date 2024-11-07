using MediatR;

namespace PetStoreApi.Services.AccountService.Dto;

public record CreateAccountDto(string EmailAddress, string Iban, List<int> AnimalIds) : IRequest;