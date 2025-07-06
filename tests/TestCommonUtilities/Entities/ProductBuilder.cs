using GestaoDeVendas.Domain.Entities;
using Bogus;

namespace TestCommonUtilities.Entities;
public class ProductBuilder
{
	public static Product Build()
	{
		return new Faker<Product>()
			.RuleFor(p => p.Id, f => f.Random.Short(1, 8))
			.RuleFor(p => p.Name, f => f.Commerce.ProductName())
			.RuleFor(p => p.Discription, f => f.Commerce.ProductDescription())
			.RuleFor(p => p.Code, f => f.Commerce.ProductAdjective().ToUpper())
			.RuleFor(p => p.Amount, f => f.Random.Int(1, 10))
			.RuleFor(p => p.Price,  f => f.Random.Decimal(1,200));
	}
}
