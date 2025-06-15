using AutoMapper;
using GestaoDeVendas.Communication.Costumers.Responses;
using GestaoDeVendas.Domain.Repositories.Costumers;

namespace GestaoDeVendas.Application.UseCases.Costumers.GetByName;
internal class GetByNameUseCase : IGetByNameUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyCostumersRepository _costumersRepository;

	public GetByNameUseCase(IMapper mapper, IReadOnlyCostumersRepository costumersRepository)
	{
		_mapper = mapper;
		_costumersRepository = costumersRepository;
	}

	public async Task<ResponseCostumerJson?> ExecuteAsync(string nameCostumer)
	{
		var costumer = await _costumersRepository.GetCostumerByNameAsync(nameCostumer) ?? throw new ArgumentException("Cliente não encontrado.");

		return _mapper.Map<ResponseCostumerJson>(costumer);
	}
}
