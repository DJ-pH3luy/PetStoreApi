using MediatR;
using PetStoreApi.Services.AccountService.ViewModels;

namespace PetStoreApi.Services.AccountService.Queries;

public record GetAllAccountsQuery() : IRequest<AccountViewList>;