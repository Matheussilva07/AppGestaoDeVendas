using GestaoDeVendas.Domain.Enums;

namespace GestaoDeVendas.Domain.Entities;
public class Sale
{
	public long SaleId { get; set; }
	public string Salesman { get; set; } = string.Empty;
	public string AddressMarket { get; set; } = string.Empty;
	public DateTime DateOfSale { get; set; } = DateTime.UtcNow;
	public ICollection<SoldProduct> Products { get; set; } = [];
	public PaymentType PaymentType { get; set; }
	public decimal TotalSaleAmount { get; set; }
	public long CostumerId { get; set; }
	public Costumer Costumer { get; set; } = default!;
}
