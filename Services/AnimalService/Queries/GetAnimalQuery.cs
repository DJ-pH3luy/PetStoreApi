using MediatR;
using PetStoreApi.Services.AnimalService.ViewModels;

namespace PetStoreApi.Services.AnimalService.Queries;

public record GetAnimalQuery(int Id) : IRequest<AnimalView>;