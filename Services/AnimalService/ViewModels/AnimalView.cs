namespace PetStoreApi.Services.AnimalService.ViewModels;

public record AnimalView(string Kind, string Name, string? Owner, int Price);

public record AnimalViewList(List<AnimalView>? Animals);