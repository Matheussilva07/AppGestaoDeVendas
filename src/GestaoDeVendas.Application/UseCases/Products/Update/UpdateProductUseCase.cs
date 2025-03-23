using AutoMapper;
using GestaoDeVendas.Communication.Products.Requests;
using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Repositories.Products;

namespace GestaoDeVendas.Application.UseCases.Products.Update;
public class UpdateProductUseCase : IUpdateProductUseCase
{
	private readonly IMapper _mapper;
	private readonly IUnitOfWork _unitOfWork;
	private readonly IUpdateOnlyProductsRepository _repository;

	public UpdateProductUseCase(IMapper mapper, IUnitOfWork unitOfWork, IUpdateOnlyProductsRepository repository)
	{
		_mapper = mapper;
		_unitOfWork = unitOfWork;
		_repository = repository;
	}
	public async Task ExecuteAsync(RequestUpdateProductJson request, long id)
	{
		Validate(request);

		var product = await _repository.GetProductByIdAsync(id) ?? throw new ArgumentException("Produto não encontrado!");

		product = _mapper.Map(request,product);

		_repository.Update(product);

		await _unitOfWork.CommitAsync();
	}

	private void Validate(RequestUpdateProductJson request)
	{
		var result = new UpdateProductValidator().Validate(request);

		if(result.IsValid == false)
		{
			throw new Exception("Dados inválidos!");
		}
	}
}
