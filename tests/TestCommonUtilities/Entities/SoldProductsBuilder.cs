using GestaoDeVendas.Domain.Entities;

namespace TestCommonUtilities.Entities;
public class SoldProductsBuilder
{
	public static List<SoldProduct> Build()
	{
		return
		[
			new() { Id = 1, ProductId = 1, ProductAmount = 4, SaleId = 1 },
			new() { Id = 2, ProductId = 2, ProductAmount = 3, SaleId = 1 }
		];
	}
}
