using GestaoDeVendas.Communication.ExceptionResponses;
using GestaoDeVendas.Exception.ExceptionBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace GestaoDeVendas.API.Filters;

public class ExceptionFilter : IExceptionFilter
{
	public void OnException(ExceptionContext context)
	{
		if(context.Exception is GestaoDeVendasException)
		{
			HandleProjectException(context);
		}
		else
		{
			ThrowUnkownError(context);
		}
	}

	private static void HandleProjectException(ExceptionContext context)
	{
		var gestaoVendasException = (GestaoDeVendasException)context.Exception;
		var errorResponse = new ResponseErrorJson(gestaoVendasException.GetErrors());

		context.HttpContext.Response.StatusCode = gestaoVendasException.StatusCode;
		context.Result = new ObjectResult(string.Join(Environment.NewLine,errorResponse.ErrorMessages));
	}
	private static void ThrowUnkownError(ExceptionContext context)
	{
		var errorResponse = new ResponseErrorJson("Erro desconhecido fi de uma mãe!");

		context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
		context.Result = new ObjectResult(errorResponse);
	}
}
