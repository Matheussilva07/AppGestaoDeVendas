namespace GestaoDeVendas.Communication.Products.Responses;
public class ResponseProductsListJson
{
	public long Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public int Amount { get; set; }
	public decimal Price { get; set; }
}
