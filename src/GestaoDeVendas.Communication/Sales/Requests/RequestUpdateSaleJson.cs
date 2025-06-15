namespace GestaoDeVendas.Communication.Sales.Requests;
public class RequestUpdateSaleJson
{

	public string Salesman { get; set; } = string.Empty;
	public string AddressMarket { get; set; } = string.Empty;
	public ICollection<SoldProductData> Products { get; set; } = [];

}
