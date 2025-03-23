using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Repositories.Sales;

namespace GestaoDeVendas.Application.UseCases.Sales.Delete;
public class DeleteSaleUseCase : IDeleteSaleUseCase
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IWriteOnlySalesRepository _salesRepository;
	private readonly IReadOnlySalesRepository _readOnlySalesRepository;

	public DeleteSaleUseCase(IUnitOfWork unitOfWork, IWriteOnlySalesRepository salesRepository, IReadOnlySalesRepository readOnlySalesRepository)
	{
		_unitOfWork = unitOfWork;
		_salesRepository = salesRepository;
		_readOnlySalesRepository = readOnlySalesRepository;
	}

	public async Task ExecuteAsync(long saleId)
	{
		var sale = await _readOnlySalesRepository.GetSaleByIdAsync(saleId) ?? throw new ArgumentException("Venda não encontrada!");

		_salesRepository.Delete(sale);

		await _unitOfWork.CommitAsync();
	}
}
