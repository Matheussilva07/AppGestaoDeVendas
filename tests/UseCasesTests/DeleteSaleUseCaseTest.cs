using FluentAssertions;
using GestaoDeVendas.Application.UseCases.Sales.Delete;
using GestaoDeVendas.Exception.ExceptionBase;
using TestCommonUtilities.Mocks;

namespace UseCasesTests;
public class DeleteSaleUseCaseTest
{
	
	[Fact]
	public async Task Success()
	{
		var saleId = 1;

		var useCase = CreateUseCase(saleId);

		var act = async () => await useCase.ExecuteAsync(saleId);

		await act.Should().NotThrowAsync();
	}
	
	[Fact]
	public async Task Error_Sale_Not_Found()
	{
		var saleId = 17;

		var useCase = CreateUseCase(saleId);

		var act = async () => await useCase.ExecuteAsync(saleId);

		var response = await act.Should().ThrowAsync<NotFoundException>();

		response.Where(e => e.GetErrors().Count == 1 && e.Message.Contains("Venda não encontrada!"));
	}


	private static DeleteSaleUseCase CreateUseCase(long saleId)
	{
		var unitOfWork = UnitOfWorkBuilder.Build();
		var writeSalesRepository = WriteOnlySalesRepositoryBuilder.Build();
		var readSalesRepository = new ReadOnlySalesRepositoryBuilder().GetSaleByIdAsync(saleId).Build();

		return new DeleteSaleUseCase(unitOfWork,writeSalesRepository, readSalesRepository);
	}
}
