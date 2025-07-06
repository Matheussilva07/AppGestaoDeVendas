using FluentAssertions;
using GestaoDeVendas.Application.UseCases.Sales.Update;
using GestaoDeVendas.Exception.ExceptionBase;
using TestCommonUtilities.Mocks;
using TestCommonUtilities.RequestsBuilder;

namespace UseCasesTests;
public class UpdateSaleUseCaseTest
{
	[Fact]
	public async Task Success()
	{
		var request = RequestUpdateSaleBuilder.Build();
		long saleId = 1;

		var useCase = CreateUseCase(saleId);

		var act = async () => { await useCase.ExecuteAsync(request, saleId); };

		await act.Should().NotThrowAsync<ErrorOnValidationExcepion>();
	}

	[Fact]
	public async Task Error_Sale_Not_Found()
	{
		var request = RequestUpdateSaleBuilder.Build();
		long salesId = 3;

		var useCase = CreateUseCase(salesId);

		var act = async () => await useCase.ExecuteAsync(request,salesId);

		await act.Should().ThrowAsync<NotFoundException>();
	}

	[Fact]
	public async Task Error_Salesman_Empty()
	{
		var request = RequestUpdateSaleBuilder.Build();
		request.Salesman = string.Empty;

		var saleId = 1;

		var useCase = CreateUseCase(saleId);

		var act = async () => await useCase.ExecuteAsync(request, saleId);

		await act.Should().ThrowAsync<ErrorOnValidationExcepion>();
	}

	[Fact]
	public async Task Error_Adressmarket_Empty()
	{
		var request = RequestUpdateSaleBuilder.Build();
		request.AddressMarket = string.Empty;

		var saleId = 1;

		var useCase = CreateUseCase(saleId);

		var act = async () => await useCase.ExecuteAsync(request, saleId);

		await act.Should().ThrowAsync<ErrorOnValidationExcepion>();
	}

	private static UpdateSaleUseCase CreateUseCase(long saleId)
	{
		var mapper = AutomapperBuilder.Build();
		var unitOfWork = UnitOfWorkBuilder.Build();
		var readRepository = new ReadOnlySalesRepositoryBuilder().GetSaleByIdAsync(saleId).Build();
		var updateRepository = UpdateOnlySalesReposiotoryBuilder.Build();

		return new UpdateSaleUseCase(mapper, unitOfWork, readRepository, updateRepository);
	}
}
