namespace GestaoDeVendas.Communication.Sales.Responses;
public class ResponseSaleByIdJson
{

	#region Dados do Cliente
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;

	#endregion

	#region Dados da Venda
	public string Salesman { get; set; } = string.Empty;
	public string AddressMarket { get; set; } = string.Empty;
	public DateTime DateOfSale { get; set; } = DateTime.UtcNow;
	public List<string> Products { get; set; } = [];
	public decimal TotalSaleAmount { get; set; }

	#endregion

}
