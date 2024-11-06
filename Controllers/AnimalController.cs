using Microsoft.AspNetCore.Mvc;
using MediatR;
using PetStoreApi.Services.AnimalService.Queries;

namespace PetStoreApi.Controllers;

[ApiController]
[Route("/v1/animals")]
public class AnimalController(ILogger<AnimalController> logger, IMediator mediator) : ControllerBase
{
    private readonly ILogger<AnimalController> _logger = logger;
    private readonly IMediator _mediator = mediator;


    [HttpGet()]
    public async Task<IActionResult> GetAnimals()
    {
        var results = await _mediator.Send(new GetAnimalsQuery());
        return Ok(results);
    }
}