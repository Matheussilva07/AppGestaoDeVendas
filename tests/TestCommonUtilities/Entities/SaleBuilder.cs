using Bogus;
using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Enums;

namespace TestCommonUtilities.Entities;
public class SaleBuilder
{
	public static Sale Build()
	{
		return new Faker<Sale>()
			.RuleFor(s => s.SaleId, 1)
			.RuleFor(s => s.Salesman, f => f.Person.FirstName)
			.RuleFor(s => s.AddressMarket, f => f.Person.Address.ToString())
			.RuleFor(s => s.DateOfSale, DateTime.UtcNow)
			.RuleFor(s => s.Products, SoldProductsBuilder.Build())
			.RuleFor(s => s.PaymentType, f => f.PickRandom<PaymentType>())
			.RuleFor(s => s.TotalSaleAmount, f => f.Random.Decimal(10, 150))
			.RuleFor(s => s.CostumerId, 1)
			.RuleFor(s => s.Costumer,
			f => new Costumer
			{
				Id = 1,
				Name = f.Person.FirstName,
				Email = f.Person.Email,
				Address = f.Person.Address.ToString()!,
				Telephone = f.Person.Phone,
				Sales = []
			});

	}
}
