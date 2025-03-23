namespace GestaoDeVendas.Communication.Costumers.Requests;
public class RequestRegisterCostumerJson
{
	public string Name { get; set; } = string.Empty;
	public string? Email { get; set; } = string.Empty;
	public string? Telephone { get; set; } = string.Empty;
	public string? Address { get; set; } = string.Empty;
}
