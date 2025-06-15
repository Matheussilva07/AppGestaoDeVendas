using AppGestaoDeVendas.GUI.Communication.Enums;
using AppGestaoDeVendas.GUI.Communication.Products.Responses;

namespace AppGestaoDeVendas.GUI.Communication.Sales.Responses;
public class ResponseSaleFilteredByDate
{
	
	#region Costumer Information
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Telephone { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;

	#endregion

	public long Id { get; set; }
	public string Salesman { get; set; } = string.Empty;
	public string AddressMarket { get; set; } = string.Empty;
	public DateTime DateOfSale { get; set; }
	public ICollection<ResponseProduct> Products { get; set; } = [];
    public PaymentType PaymentType { get; set; }
    public decimal TotalSaleAmount { get; set; }

	
}
