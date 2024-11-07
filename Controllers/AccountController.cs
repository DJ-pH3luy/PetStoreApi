using Microsoft.AspNetCore.Mvc;
using MediatR;
using PetStoreApi.Services.AnimalService.Queries;
using PetStoreApi.Services.AnimalService.Dto;
using PetStoreApi.Services.AccountService.Dto;
using PetStoreApi.Services.AccountService.Queries;

namespace PetStoreApi.Controllers;

[ApiController]
[Route("/v1/accounts")]
public class AccountController(ILogger<AccountController> _logger, IMediator _mediator) : ControllerBase
{
    [HttpGet()]
    public async Task<IActionResult> GetAccounts()
    {
        var results = await _mediator.Send(new GetAllAccountsQuery());
        return Ok(results);
    }

    [HttpPost()]
    public async Task<IActionResult> CreateAccount([FromBody] CreateAccountDto? request)
    {
        if (request == null) 
        {
            return BadRequest();
        }
        await _mediator.Send(request);
        return Ok();
    }
}