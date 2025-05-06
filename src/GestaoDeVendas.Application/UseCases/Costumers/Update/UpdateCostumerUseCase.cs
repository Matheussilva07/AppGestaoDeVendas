using AutoMapper;
using GestaoDeVendas.Communication.Costumers.Requests;
using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Repositories.Costumers;

namespace GestaoDeVendas.Application.UseCases.Costumers.Update;
public class UpdateCostumerUseCase : IUpdateCostumerUseCase
{
	private readonly IMapper _mapper;
	private readonly IUnitOfWork _unitOfWork;
	private readonly IUpdateOnlyCostumerRepository _repository;

	public UpdateCostumerUseCase(IMapper mapper, IUnitOfWork unitOfWork, IUpdateOnlyCostumerRepository repository)
	{
		_mapper = mapper;
		_unitOfWork = unitOfWork;
		_repository = repository;
	}

	public async Task ExecuteAsync(RequestUpdateCostumerJson request, long costumerId)
	{
		Validate(request);

		var costumer = await _repository.GetCostumerByIdAsync(costumerId) ?? throw new ArgumentException("Cliente não encontrado.");

		costumer = _mapper.Map(request,costumer);

		_repository.Update(costumer);

		await _unitOfWork.CommitAsync();
	}

	private static void Validate(RequestUpdateCostumerJson request)
	{
		var result = new UpdateCostumerValidator().Validate(request);

		if (!result.IsValid)
		{
			throw new InvalidOperationException("Dados inválidos.");
		}
	}
}
