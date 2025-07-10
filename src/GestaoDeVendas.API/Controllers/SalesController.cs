using GestaoDeVendas.Application.UseCases.Sales.Delete;
using GestaoDeVendas.Application.UseCases.Sales.FilterSalesByDate;
using GestaoDeVendas.Application.UseCases.Sales.GetSaleById;
using GestaoDeVendas.Application.UseCases.Sales.Register;
using GestaoDeVendas.Application.UseCases.Sales.Update;
using GestaoDeVendas.Communication.Sales.Requests;
using GestaoDeVendas.Communication.Sales.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeVendas.API.Controllers;

[Route("[controller]")]
[ApiController]
public class SalesController : ControllerBase
{

	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredSaleJson), StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterSaleUseCase useCase, [FromBody] RequestRegisterSaleJson request)
	{
		var response = await useCase.ExecuteAsync(request);

		return Created(string.Empty, response);
	}

	[HttpGet]
	[Route("{id}")]
	[ProducesResponseType(typeof(ResponseSaleByIdJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<IActionResult> GetById([FromServices] IGetSaleByIdUseCase useCase, [FromRoute] long id)
	{
		var response = await useCase.ExecuteAsync(id);

		return Ok(response);
	}

	[HttpGet("filter-sales")]
	[ProducesResponseType(typeof(ResponseSaleFilteredByDateJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	public async Task<IActionResult> FilterSales([FromServices] IFilterSalesByDateUseCase useCase, [FromQuery] DateOnly period)
	{
		var response = await useCase.ExecuteAsync(period);

		if (response.Count > 0)
			return Ok(response);
		return NoContent();
	}

	[HttpDelete]
	[Route("{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Delete([FromServices] IDeleteSaleUseCase useCase, [FromRoute] long id)
	{
		await useCase.ExecuteAsync(id);

		return NoContent();
	}

	[HttpPut]
	[Route("{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Update([FromServices] IUpdateSaleUseCase useCase, [FromBody] RequestUpdateSaleJson request, [FromRoute] long id)
	{
		await useCase.ExecuteAsync(request, id);

		return NoContent();
	}

}
