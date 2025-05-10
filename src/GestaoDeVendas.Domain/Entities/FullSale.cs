namespace GestaoDeVendas.Domain.Entities;
public class FullSale
{
	#region Costumer Information
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Telephone { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;

	#endregion

	#region Sale Information
	public long Id { get; set; }
	public string Salesman { get; set; } = string.Empty;
	public string AddressMarket { get; set; } = string.Empty;
	public DateTime DateOfSale { get; set; } = DateTime.UtcNow;
	public ICollection<Product> Products { get; set; } = [];
	public decimal TotalSaleAmount { get; set; }

	#endregion


	#region Product Information
	public string ProductName { get; set; } = string.Empty;
	public string? Discription { get; set; } = string.Empty;
	public string Code { get; set; } = string.Empty;
	public int Amount { get; set; }
	public decimal Price { get; set; }

	#endregion

}
