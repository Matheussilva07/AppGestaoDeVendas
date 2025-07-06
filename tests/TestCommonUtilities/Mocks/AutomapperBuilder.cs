using AutoMapper;
using GestaoDeVendas.Application.Automapper;

namespace TestCommonUtilities.Mocks;
public class AutomapperBuilder
{
	public static IMapper Build()
	{
		var mapper = new MapperConfiguration(config =>
		{
			config.AddProfile(new Automapping());
		});
		
		return mapper.CreateMapper();
	}
}
