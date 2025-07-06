using GestaoDeVendas.Domain.Repositories.Sales;
using Moq;

namespace TestCommonUtilities.Mocks;
public class WriteOnlySalesRepositoryBuilder
{
	public static IWriteOnlySalesRepository Build()
	{
		return new Mock<IWriteOnlySalesRepository>().Object;
	}
}
