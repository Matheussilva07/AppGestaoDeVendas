namespace GestaoDeVendas.Exception.ExceptionBase;
public abstract class GestaoDeVendasException : SystemException
{
	protected GestaoDeVendasException(string message) : base(message)
	{

	}

	public abstract int StatusCode { get; }
	public abstract List<string> GetErrors();
}
