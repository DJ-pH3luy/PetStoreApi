using PetStoreApi.Entities;

namespace PetStoreApi.Repository;

public interface IAccountRepository : IRepository<Account>
{
    Task<List<Account>> GetAllAccounts();
    Task<Account?> GetAccountById(int id);
}