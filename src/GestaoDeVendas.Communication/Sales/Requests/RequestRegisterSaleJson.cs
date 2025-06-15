using GestaoDeVendas.Communication.Enums;

namespace GestaoDeVendas.Communication.Sales.Requests;
public class RequestRegisterSaleJson
{
	public string Salesman { get; set; } = string.Empty;
	public string AddressMarket { get; set; } = string.Empty;
	public ICollection<SoldProductData> Products { get; set; } = [];
	public PaymentType PaymentType { get; set; }
	public long CostumerId { get; set; }
}
