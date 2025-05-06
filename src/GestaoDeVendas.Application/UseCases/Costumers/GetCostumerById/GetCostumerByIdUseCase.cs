using AutoMapper;
using GestaoDeVendas.Communication.Costumers.Responses;
using GestaoDeVendas.Domain.Repositories.Costumers;

namespace GestaoDeVendas.Application.UseCases.Costumers.GetCostumerByName;
public class GetCostumerByIdUseCase : IGetCostumerByIdUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyCostumersRepository _repository;

	public GetCostumerByIdUseCase(IMapper mapper, IReadOnlyCostumersRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<ResponseCostumerJson?> ExecuteAsync(long costumerId)
	{
		var costumer = await _repository.GetCostumerByIdAsync(costumerId) ?? throw new ArgumentException("Cliente não encontrado.");
	
		return _mapper.Map<ResponseCostumerJson>(costumer);
	}
}
