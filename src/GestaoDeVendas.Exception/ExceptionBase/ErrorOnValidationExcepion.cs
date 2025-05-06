using System.Net;

namespace GestaoDeVendas.Exception.ExceptionBase;
public class ErrorOnValidationExcepion : GestaoDeVendasException
{
	
	private readonly List<string> _errors;
	public override int StatusCode => (int)HttpStatusCode.BadRequest;

	public ErrorOnValidationExcepion(List<string> errorMessages) : base(string.Empty)
	{
		_errors = errorMessages;
	}


	public override List<string> GetErrors()
	{
		return _errors;
	}
}
