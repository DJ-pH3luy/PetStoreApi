using MediatR;

namespace PetStoreApi.Services.AnimalService.Dto;

public record UpdateAnimalDto(int Id, int Price, string Kind, string Name, int? OwnerId) : IRequest;
