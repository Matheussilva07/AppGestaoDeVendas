using GestaoDeVendas.Domain.Repositories.SoldProducts;
using Moq;
using TestCommonUtilities.Entities;

namespace TestCommonUtilities.Mocks;
public class ReadOnlySoldProductsRepositoryBuilder
{
	private readonly Mock<IReadOnlySoldProductsRepository> _mock;

	public ReadOnlySoldProductsRepositoryBuilder()
	{
		_mock = new Mock<IReadOnlySoldProductsRepository>();
	}

	public ReadOnlySoldProductsRepositoryBuilder GetSoldProductsAsync(long saleID)
	{
		_mock.Setup(repository => repository.GetSoldProductsAsync(saleID)).ReturnsAsync(ProductsListBuilder.Build());

		return this;
	}

	public IReadOnlySoldProductsRepository Build()
	{
		return _mock.Object;
	}
}
