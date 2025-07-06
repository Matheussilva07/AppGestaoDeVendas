using Bogus;
using GestaoDeVendas.Communication.Sales.Requests;

namespace TestCommonUtilities.RequestsBuilder;
internal class SoldProductsListBuilder
{
	public static List<SoldProductData> GetSoldProducts()
	{
		return [new() { SaleId = 1, ProductAmount = 2, ProductId = 1 }];
	}
}
