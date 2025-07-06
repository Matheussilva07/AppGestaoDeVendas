using GestaoDeVendas.Domain.Repositories.Sales;
using Moq;
using TestCommonUtilities.Entities;

namespace TestCommonUtilities.Mocks;
public class ReadOnlySalesRepositoryBuilder
{
    private readonly Mock<IReadOnlySalesRepository> _repository;

	public ReadOnlySalesRepositoryBuilder()
    {
		_repository = new Mock<IReadOnlySalesRepository>();
	}

	public ReadOnlySalesRepositoryBuilder GetSaleByIdWithAsNoTrakcing(long saleId)
	{
		var sale = SaleBuilder.Build();

		if(saleId == sale.SaleId)
		{
			_repository.Setup(repository => repository.GetSaleByIdWithAsNoTrakcing(saleId)).ReturnsAsync(sale);

			return this;
		}

		return this;	
	}

	public ReadOnlySalesRepositoryBuilder GetSaleByIdAsync(long saleId)
	{
		var sale = SaleBuilder.Build();

		if (saleId == sale.SaleId)
		{
			_repository.Setup(repository => repository.GetSaleByIdAsync(saleId)).ReturnsAsync(sale);

			return this;
		}

		return this;
	}
	public IReadOnlySalesRepository Build()
	{
		return _repository.Object;
	}
}
