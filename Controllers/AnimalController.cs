using Microsoft.AspNetCore.Mvc;
using MediatR;
using PetStoreApi.Services.AnimalService.Queries;
using PetStoreApi.Services.AnimalService.Dto;

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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAnimalById(int id)
    {
        var result = await _mediator.Send(new GetAnimalQuery(id));
        return result != null
            ? Ok(result) 
            : NotFound();
    }

    [HttpPost()]
    public async Task<IActionResult> CreateAnimal([FromBody] CreateAnimalDto? request)
    {
        if (request == null)
        {
            return BadRequest();
        }
        await _mediator.Send(request);
        return Ok();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateAnimal([FromBody] UpdateAnimalDto? request)
    {
        if (request == null)
        {
            return BadRequest();
        }
        await _mediator.Send(request);
        return Ok();
    }
}