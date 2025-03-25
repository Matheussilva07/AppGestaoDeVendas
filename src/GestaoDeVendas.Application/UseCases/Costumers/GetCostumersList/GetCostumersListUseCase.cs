using AutoMapper;
using GestaoDeVendas.Communication.Costumers.Responses;
using GestaoDeVendas.Domain.Repositories.Costumers;

namespace GestaoDeVendas.Application.UseCases.Costumers.GetCostumersList;
public class GetCostumersListUseCase : IGetCostumersListUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyCostumersRepository _repository;

	public GetCostumersListUseCase(IMapper mapper, IReadOnlyCostumersRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<List<ResponseShortCostumerJson>> ExecuteAsync()
	{
		var costumers = await _repository.GetCostumersListAsync();

		return _mapper.Map<List<ResponseShortCostumerJson>>(costumers);
	}
}
