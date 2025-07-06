using GestaoDeVendas.Communication.Sales.Requests;
using Bogus;
using GestaoDeVendas.Communication.Enums;

namespace TestCommonUtilities.RequestsBuilder;
public class RequestRegisterSaleBuilder
{
	public static RequestRegisterSaleJson Build()
	{
		return new Faker<RequestRegisterSaleJson>()
			.RuleFor(r => r.Salesman, f => f.Person.FirstName)
			.RuleFor(r => r.AddressMarket, f => f.Person.Address.ToString())
			.RuleFor(r => r.Products, SoldProductsListBuilder.GetSoldProducts())
			.RuleFor(r => r.PaymentType, f => f.Random.Enum<PaymentType>())
			.RuleFor(r => r.CostumerId, f => f.Random.Long(1,10));
	}
}
