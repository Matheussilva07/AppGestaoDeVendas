using FluentAssertions;
using GestaoDeVendas.Application.UseCases.Sales;
using TestCommonUtilities.RequestsBuilder;

namespace ValidatorsTests.SalesTests;
public class SalesValidatorTests
{
	[Fact]
	public void Success()
	{
		var request = RequestRegisterSaleBuilder.Build();

		var validator = new SalesValidator();
		var result = validator.Validate(request);

		result.IsValid.Should().BeTrue();
		result.Errors.Should().HaveCount(0);
	}

	[Theory]
	[InlineData("")]
	[InlineData("  ")]
	[InlineData(null)]
	public void Error_Salesman_Empty(string name)
	{
		var request = RequestRegisterSaleBuilder.Build();
		request.Salesman = name;

		var validator = new SalesValidator();
		var result = validator.Validate(request);

		result.IsValid.Should().BeFalse();
		result.Errors.Should().HaveCount(1).And.Contain(e => e.ErrorMessage.Equals("Informe o vendedor."));
	}

	[Theory]
	[InlineData("")]
	[InlineData("  ")]
	[InlineData(null)]
	public void Error_AddressMarket_Empty(string address)
	{
		var request = RequestRegisterSaleBuilder.Build();
		request.AddressMarket = address;

		var validator = new SalesValidator();
		var result = validator.Validate(request);

		result.IsValid.Should().BeFalse();
		result.Errors.Should().HaveCount(1).And.Contain(e => e.ErrorMessage.Equals("Informe o mercado onde foi feita a venda."));
	}

	[Fact]
	public void Error_Products_CostumerId_Empty()
	{
		var request = RequestRegisterSaleBuilder.Build();
		request.Products = [];

		var validator = new SalesValidator();
		var result = validator.Validate(request);

		result.IsValid.Should().BeFalse();
		result.Errors.Should().HaveCount(1).And.Contain(e => e.ErrorMessage.Equals("Liste os produtos vendidos."));
	}
}
