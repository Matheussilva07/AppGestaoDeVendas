namespace GestaoDeVendas.Communication.Products.Requests;
public class RequestRegisterProductJson
{
	public string Name { get; set; } = string.Empty;
	public string? Discription { get; set; } = string.Empty;
	public string Code { get; set; } = string.Empty;
	public int Amount { get; set; }
	public decimal Price { get; set; }
}
