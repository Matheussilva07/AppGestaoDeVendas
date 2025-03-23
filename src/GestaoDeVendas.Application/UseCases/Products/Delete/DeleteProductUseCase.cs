using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Repositories.Products;

namespace GestaoDeVendas.Application.UseCases.Products.Delete;
internal class DeleteProductUseCase : IDeleteProductUseCase
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IUpdateOnlyProductsRepository _updateRepository;
	private readonly IWriteOnlyProductsRepository _writeRepository;

	public DeleteProductUseCase(IUnitOfWork unitOfWork, IUpdateOnlyProductsRepository updateRepository, IWriteOnlyProductsRepository writeRepository)
	{
		_unitOfWork = unitOfWork;
		_updateRepository = updateRepository;
		_writeRepository = writeRepository;
	}

	public async Task ExecuteAsync(long productId)
	{
		var product = await _updateRepository.GetProductByIdAsync(productId) ?? throw new ArgumentException("Produto não encontrado!");

		 _writeRepository.Delete(product);

		await _unitOfWork.CommitAsync();
	}
}
