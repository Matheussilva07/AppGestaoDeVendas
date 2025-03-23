using AutoMapper;
using GestaoDeVendas.Communication.Products.Responses;
using GestaoDeVendas.Domain.Repositories.Products;

namespace GestaoDeVendas.Application.UseCases.Products.GetProductById;
internal class GetProductByIdUseCase : IGetProductByIdUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyProductsRepository _repository;

	public GetProductByIdUseCase(IMapper mapper, IReadOnlyProductsRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<ResponseProductDetailsJson?> Executeasync(long productId)
	{
		var product = await _repository.GetProductByIdAsync(productId) ?? throw new ArgumentException("Produto não encontrado!");

		return _mapper.Map<ResponseProductDetailsJson>(product);	
	}
}
