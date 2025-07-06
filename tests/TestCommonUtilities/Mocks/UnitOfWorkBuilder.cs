using GestaoDeVendas.Domain;
using Moq;

namespace TestCommonUtilities.Mocks;
public class UnitOfWorkBuilder
{
	public static IUnitOfWork Build()
	{
		var mock = new Mock<IUnitOfWork>();

		return mock.Object;
	}
}
