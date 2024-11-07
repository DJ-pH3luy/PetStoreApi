using MediatR;
using PetStoreApi.Entities;
using PetStoreApi.Repository;
using PetStoreApi.Services.AccountService.Queries;
using PetStoreApi.Services.AccountService.ViewModels;

namespace PetStoreApi.Services.AccountService.Handler;

public class GetAllAccountsHandler(IAccountRepository _repo) : IRequestHandler<GetAllAccountsQuery, AccountViewList>
{
    public async Task<AccountViewList> Handle(GetAllAccountsQuery request, CancellationToken cancellationToken)
    {
        var res = await _repo.GetAllAccounts();
        var list = ToViewList(res).ToList();
        return new AccountViewList(list);

    }

    private static IEnumerable<AccountView> ToViewList(List<Account> accounts)
    {
        foreach (var item in accounts)
        {
            yield return item.ToView();
        }
    }
}
