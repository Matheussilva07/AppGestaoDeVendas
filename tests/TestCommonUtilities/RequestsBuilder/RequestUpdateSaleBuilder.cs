using Bogus;
using GestaoDeVendas.Communication.Sales.Requests;

namespace TestCommonUtilities.RequestsBuilder;
public class RequestUpdateSaleBuilder
{
	public static RequestUpdateSaleJson Build()
	{
		return new Faker<RequestUpdateSaleJson>()
			.RuleFor(s => s.Salesman, f => f.Person.FullName)
			.RuleFor(s => s.AddressMarket, f => f.Person.Address.ToString())
			.RuleFor(s => s.Products, SoldProductsListBuilder.GetSoldProducts());
	}
}
