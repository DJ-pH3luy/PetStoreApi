using MediatR;

namespace PetStoreApi.Services.AnimalService.Dto;

public record CreateAnimalDto(int Price, string Kind, string Name, int? OwnerId) : IRequest;