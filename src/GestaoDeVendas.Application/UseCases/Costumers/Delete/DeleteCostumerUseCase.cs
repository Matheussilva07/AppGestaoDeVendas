using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Repositories.Costumers;

namespace GestaoDeVendas.Application.UseCases.Costumers.Delete;
public class DeleteCostumerUseCase : IDeleteCostumerUseCase
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IWriteOnlyCostumersRepository _costumersRepository;
	private readonly IUpdateOnlyCostumerRepository _updateRepository;

	public DeleteCostumerUseCase(IUnitOfWork unitOfWork, IWriteOnlyCostumersRepository costumersRepository, IUpdateOnlyCostumerRepository updateRepository)
	{
		_unitOfWork = unitOfWork;
		_costumersRepository = costumersRepository;
		_updateRepository = updateRepository;
	}

	public async Task ExecuteAsync(long costumerId)
	{
		var costumer = await _updateRepository.GetCostumerByIdAsync(costumerId) ?? throw new ArgumentException("Cliente não encontrado!");

		_costumersRepository.Delete(costumer);

		await _unitOfWork.CommitAsync();
	}
}
