using FluentAssertions;
using GestaoDeVendas.Application.UseCases.Sales.Register;
using TestCommonUtilities.Mocks;
using TestCommonUtilities.RequestsBuilder;

namespace UseCasesTests;
public class RegisterSaleUseCaseTest
{
	[Fact]
	public async Task Success()
	{
		var request = RequestRegisterSaleBuilder.Build();

		var useCase = CreateUseCase();

		var response = await useCase.ExecuteAsync(request);

		response.Salesman.Should().NotBeNullOrEmpty();
		response.Salesman.Should().Be(request.Salesman);
	}

	[Theory]
	[InlineData("")]
	[InlineData("   ")]
	[InlineData(null)]
	public async Task Error_Salesman_Empty(string salesman)
	{
		var request = RequestRegisterSaleBuilder.Build();
		request.Salesman = salesman;

		var useCase = CreateUseCase();

		var act = async () => await useCase.ExecuteAsync(request);

		await act.Should().ThrowAsync<ArgumentException>();	
	}

	[Theory]
	[InlineData("")]
	[InlineData("   ")]
	[InlineData(null)]
	public async Task Error_AdressMarket_Empty(string adress)
	{
		var request = RequestRegisterSaleBuilder.Build();
		request.AddressMarket = adress;

		var useCase = CreateUseCase();

		var act = async () => await useCase.ExecuteAsync(request);

		await act.Should().ThrowAsync<ArgumentException>();
	}

	[Fact]
	public async Task Error_Products_Empty()
	{
		var request = RequestRegisterSaleBuilder.Build();
		request.Products = []; 

		var useCase = CreateUseCase();

		var act = async () => await useCase.ExecuteAsync(request);

		await act.Should().ThrowAsync<ArgumentException>();

	}

	private static RegisterSaleUseCase CreateUseCase()
	{
		var mapper = AutomapperBuilder.Build();
		var unitOfWork = UnitOfWorkBuilder.Build();
		var writeRepository = WriteOnlySalesRepositoryBuilder.Build();
		var updateRepository = new UpdateOnlyProductsRepositoryBuilder().GetProductByIdAsync().Build();

		return new RegisterSaleUseCase(mapper, writeRepository, unitOfWork, updateRepository);
	}
}
