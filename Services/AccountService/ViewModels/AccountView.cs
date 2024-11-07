using PetStoreApi.Entities;
using PetStoreApi.Services.AnimalService.ViewModels;

namespace PetStoreApi.Services.AccountService.ViewModels;

public record AccountView(string EmailAddress, string Iban, List<AnimalView> Animals);

public record AccountViewList(List<AccountView> Accounts);