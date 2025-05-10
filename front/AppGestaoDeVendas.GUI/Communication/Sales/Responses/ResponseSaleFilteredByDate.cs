namespace AppGestaoDeVendas.GUI.Communication.Sales.Responses;
public class ResponseSaleFilteredByDate
{
	//public long Id { get; set; }
	public string Salesman { get; set; } = string.Empty;
	public string AddressMarket { get; set; } = string.Empty;
	public DateTime DateOfSale { get; set; } = DateTime.UtcNow;

	//public ICollection<SoldProduct> Products { get; set; } = [];
	public decimal TotalSaleAmount { get; set; }

	//public long CostumerId { get; set; }
}
