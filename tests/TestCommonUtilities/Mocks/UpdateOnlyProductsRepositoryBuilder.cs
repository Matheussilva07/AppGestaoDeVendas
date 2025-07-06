using GestaoDeVendas.Domain.Repositories.Products;
using Moq;

namespace TestCommonUtilities.Mocks;
public class UpdateOnlyProductsRepositoryBuilder
{
	private readonly Mock<IUpdateOnlyProductsRepository> _repository;

	public UpdateOnlyProductsRepositoryBuilder()
	{
		_repository = new Mock<IUpdateOnlyProductsRepository>();
	}
	public UpdateOnlyProductsRepositoryBuilder GetProductByIdAsync()
	{
		_repository.Setup(repository => repository.GetProductByIdAsync(It.IsAny<long>()))
			.ReturnsAsync(new GestaoDeVendas.Domain.Entities.Product
			{
				Id = 1,
				Name = "Vassoura",
				Discription = "De palha",
				Code = "DWDOP",
				Amount = 1,
				Price = 19.90m
			});

		return this;
	}

	public IUpdateOnlyProductsRepository Build() => _repository.Object;
}

