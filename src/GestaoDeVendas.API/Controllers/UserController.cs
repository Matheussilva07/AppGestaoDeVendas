using GestaoDeVendas.Application.UseCases.Users.Register;
using GestaoDeVendas.Communication.Users.Requests;
using GestaoDeVendas.Communication.Users.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeVendas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
	
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredUserJson),StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRequestRegisterUserUseCase useCase, [FromBody] RequestRegisterUserJson request)
	{
		var response = await useCase.ExecuteAsync(request);

		return Created(string.Empty, response);
	}
}
