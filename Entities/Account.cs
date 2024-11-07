using PetStoreApi.Services.AccountService.ViewModels;
using PetStoreApi.Services.AnimalService;

namespace PetStoreApi.Entities;

public class Account : BaseEntity
{
    public string EmailAddress { get; set; } = "";

    public string Iban {get; set; } = "";

    public List<Animal> Animals { get; set;}

    public Account()
    {
        Animals = new List<Animal>();
    }

    public AccountView ToView()
    {
        return new AccountView(EmailAddress, Iban, AnimalService.ToListView(Animals).ToList());
    }
}