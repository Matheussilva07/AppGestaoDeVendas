using GestaoDeVendas.Application.UseCases.Costumers.Delete;
using GestaoDeVendas.Application.UseCases.Costumers.GetCostumerByName;
using GestaoDeVendas.Application.UseCases.Costumers.GetCostumersList;
using GestaoDeVendas.Application.UseCases.Costumers.Register;
using GestaoDeVendas.Application.UseCases.Costumers.Update;
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

	[HttpGet]
	[ProducesResponseType(typeof(List<ResponseShortCostumerJson>), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	public async Task<IActionResult> GetAll([FromServices] IGetCostumersListUseCase useCase)
	{
		var response = await useCase.ExecuteAsync();

		if (response.Count > 0)
			return Ok(response);
		return NoContent();
	}

	[HttpGet]
	[Route("{costumerId}")]
	[ProducesResponseType(typeof(ResponseCostumerJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> GetById([FromServices] IGetCostumerByIdUseCase useCase, [FromRoute] long costumerId)
	{
		var response = await useCase.ExecuteAsync(costumerId);

		return Ok(response);
	}

	[HttpPut]
	[Route("{costumerId}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Update([FromServices] IUpdateCostumerUseCase useCase, [FromBody] RequestUpdateCostumerJson request, [FromRoute] long costumerId)
	{
		await useCase.ExecuteAsync(request, costumerId);

		return NoContent();
	}

	[HttpDelete]
	[Route("{costumerId}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Delete([FromServices] IDeleteCostumerUseCase useCase, [FromRoute] long costumerId)
	{
		await useCase.ExecuteAsync(costumerId);

		return NoContent();
	}
}
