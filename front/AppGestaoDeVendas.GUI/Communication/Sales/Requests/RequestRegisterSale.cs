using AppGestaoDeVendas.GUI.Communication.Enums;

namespace AppGestaoDeVendas.GUI.Communication.Sales.Requests;
internal class RequestRegisterSale
{
	public string Salesman { get; set; } = string.Empty;
	public string AddressMarket { get; set; } = string.Empty;
	public ICollection<SoldProduct> Products { get; set; } = [];
    public PaymentType PaymentType { get; set; }
    public long CostumerId { get; set; }
}
