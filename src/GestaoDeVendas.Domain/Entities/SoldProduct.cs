namespace GestaoDeVendas.Domain.Entities;
public class SoldProduct
{
	public long Id { get; set; }
	public long SaleId { get; set; }
	public long ProductId { get; set; }
	public uint ProductAmount {  get; set; } 
	public Product Product { get; set; } = default!;
	public Sale Sale { get; set; } = default!;

	public override bool Equals(object obj)
	{
		if (obj == null || GetType() != obj.GetType())
			return false;

		SoldProduct other = (SoldProduct)obj;
		return SaleId == other.SaleId;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(SaleId);
	}
}
