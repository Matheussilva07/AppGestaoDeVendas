using AutoMapper;
using GestaoDeVendas.Communication.Costumers.Requests;
using GestaoDeVendas.Communication.Costumers.Responses;
using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Costumers;

namespace GestaoDeVendas.Application.UseCases.Costumers.Register;
public class RegisterCostumerUseCase : IRegisterCostumerUseCase
{
	private readonly IWriteOnlyCostumersRepository _repository;
	private readonly IMapper _mapper;
	private readonly IUnitOfWork _unitOfWork;
	public RegisterCostumerUseCase(IWriteOnlyCostumersRepository costumersRepository, IMapper mapper, IUnitOfWork unitOfWork)
	{
		_repository = costumersRepository;
		_mapper = mapper;
		_unitOfWork = unitOfWork;
	}

	public async Task<ResponseRegisteredCostumerJson> ExecuteAsync(RequestRegisterCostumerJson request)
	{
		Validate(request);

		var costumer = _mapper.Map<Costumer>(request);

		await _repository.AddAsync(costumer);

		await _unitOfWork.CommitAsync();

		return _mapper.Map<ResponseRegisteredCostumerJson>(costumer);
	}

	private static void Validate(RequestRegisterCostumerJson request)
	{
		var result = new CostumerValidator().Validate(request);

		if (result.IsValid == false)
		{
			throw new ArgumentException("Dados inválidos!");
		}
	}
}
