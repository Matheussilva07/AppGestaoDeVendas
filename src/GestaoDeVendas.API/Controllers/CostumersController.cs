using GestaoDeVendas.Application.UseCases.Costumers.Register;
using GestaoDeVendas.Communication.Costumers.Requests;
using GestaoDeVendas.Communication.Costumers.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeVendas.API.Controllers;

[Route("[controller]")]
[ApiController]
public class CostumersController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredCostumerJson), StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterCostumerUseCase useCase, [FromBody] RequestRegisterCostumerJson request)
	{
		var response = await useCase.ExecuteAsync(request);

		return Created(string.Empty, response);
	}
}
