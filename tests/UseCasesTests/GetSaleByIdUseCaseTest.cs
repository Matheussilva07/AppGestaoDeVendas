using FluentAssertions;
using GestaoDeVendas.Application.UseCases.Sales.GetSaleById;
using GestaoDeVendas.Exception.ExceptionBase;
using TestCommonUtilities.Mocks;

namespace UseCasesTests;
public class GetSaleByIdUseCaseTest
{
	[Fact]
	public async Task Success()
	{
		long saleId = 1;
		
		var useCase = CreateUseCase(saleId);

		var response = await useCase.ExecuteAsync(saleId);

		response.Name.Should().NotBeNullOrWhiteSpace();
		response.Email.Should().NotBeNullOrWhiteSpace();		
		response.Salesman.Should().NotBeNullOrWhiteSpace();
		response.AddressMarket.Should().NotBeNullOrWhiteSpace();
		response.Products.Count.Should().BeGreaterThan(0);
		response.TotalSaleAmount.Should().BeGreaterThan(0);
	}


	[Fact]
	public async Task Error_Sale_NotFound()
	{
		long saleId = 4;

		var useCase = CreateUseCase(saleId);

		var act = async () => await useCase.ExecuteAsync(saleId);

		var response = await act.Should().ThrowAsync<NotFoundException>();

		response.Where(e => e.GetErrors().Count == 1 && e.Message.Equals("Venda não encontrada"));
	}

	private static GetSaleByIdUseCase CreateUseCase(long saleId)
	{
		var readSalesRepository = new ReadOnlySalesRepositoryBuilder().GetSaleByIdWithAsNoTrakcing(saleId).Build();
		var readSoldProductsRepository = new ReadOnlySoldProductsRepositoryBuilder().GetSoldProductsAsync(saleId).Build();

		return new GetSaleByIdUseCase(readSalesRepository, readSoldProductsRepository);
	}
}
