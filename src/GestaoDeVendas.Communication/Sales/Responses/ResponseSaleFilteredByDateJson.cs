using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Communication.Sales.Responses;
public class ResponseSaleFilteredByDateJson
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
	public DateTime DateOfSale { get; set; }
	public ICollection<Product> Products { get; set; } = [];
	public decimal TotalSaleAmount { get; set; }

	#endregion


	public override bool Equals(object? obj)
	{
		if (obj is ResponseSaleFilteredByDateJson sale)
		{
			return Id == sale.Id;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Id);
	}
}

