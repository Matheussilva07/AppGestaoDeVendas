namespace GestaoDeVendas.Domain.Entities;
public class SoldProduct
{
	public long Id { get; set; }
	public long SaleId { get; set; }
	public long ProductId { get; set; }
	public uint ProductAmount {  get; set; } 
	public Product Product { get; set; } = default!;
	public Sale Sale { get; set; } = default!;
}
