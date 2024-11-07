using Microsoft.EntityFrameworkCore;
using PetStoreApi.Entities;

namespace PetStoreApi.Repository;

public class AccountRepository(PetStoreDbContext _dbContext) : Repository<Account>(_dbContext), IAccountRepository
{
    private IQueryable<Account> _query => _dbContext.Set<Account>()
        .Include(a => a.Animals);

    public async Task<List<Account>> GetAllAccounts()
    {
        return await _query.ToListAsync();
    }

    public async Task<Account?> GetAccountById(int id)
    {
        return await _query.Where(a => a.Id == id).FirstOrDefaultAsync();
    }
} 