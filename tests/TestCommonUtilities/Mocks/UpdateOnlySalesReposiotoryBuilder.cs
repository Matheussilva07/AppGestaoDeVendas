using GestaoDeVendas.Domain.Repositories.Sales;
using Moq;

namespace TestCommonUtilities.Mocks;
public class UpdateOnlySalesReposiotoryBuilder
{
	public static IUpdateOnlySalesRepository Build()
	{
		var mock = new Mock<IUpdateOnlySalesRepository>();

		return mock.Object;
	}
}
