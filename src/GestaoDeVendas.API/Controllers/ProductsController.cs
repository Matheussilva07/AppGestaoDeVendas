using GestaoDeVendas.Application.UseCases.Products.Delete;
using GestaoDeVendas.Application.UseCases.Products.GetAllProducts;
using GestaoDeVendas.Application.UseCases.Products.GetProductById;
using GestaoDeVendas.Application.UseCases.Products.GetProductByName;
using GestaoDeVendas.Application.UseCases.Products.Register;
using GestaoDeVendas.Application.UseCases.Products.Update;
using GestaoDeVendas.Communication.Products.Requests;
using GestaoDeVendas.Communication.Products.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeVendas.API.Controllers;
[Route("[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredProductJson), StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterProductUseCase useCase, [FromBody] RequestRegisterProductJson request)
	{
		var response = await useCase.ExecuteAsync(request);

		return Created(string.Empty, response);
	}

	[HttpGet]
	[ProducesResponseType(typeof(List<ResponseProductsListJson>), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	public async Task<IActionResult> GetProductsList([FromServices] IGetProductsListUseCase useCase)
	{
		var response = await useCase.ExecuteAsync();

		return Ok(response);
	}

	[HttpGet]
	[Route("{productId}")]
	[ProducesResponseType(typeof(ResponseProductDetailsJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> GetProductById([FromServices] IGetProductByIdUseCase useCase, [FromRoute] long productId)
	{
		var response = await useCase.Executeasync(productId);

		return Ok(response);
	}

	[HttpGet("product-by-name")]
	[ProducesResponseType(typeof(ResponseProductDetailsJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> GetProductByName([FromServices] IGetProductByNameUseCase useCase, [FromQuery] string productName)
	{
		var response = await useCase.ExecuteAscyn(productName);

		return Ok(response);
	}

	[HttpPut]
	[Route("{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Update([FromServices] IUpdateProductUseCase useCase, [FromBody] RequestUpdateProductJson request, [FromRoute] long id)
	{
		await useCase.ExecuteAsync(request, id);

		return NoContent();
	}

	[HttpDelete]
	[Route("{productId}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Delete([FromServices] IDeleteProductUseCase useCase, [FromRoute] long productId)
	{
		await useCase.ExecuteAsync(productId);

		return NoContent();
	}
}
