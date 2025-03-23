using AutoMapper;
using GestaoDeVendas.Communication.Products.Responses;
using GestaoDeVendas.Domain.Repositories.Products;

namespace GestaoDeVendas.Application.UseCases.Products.GetAllProducts;
internal class GetProductsListUseCase : IGetProductsListUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyProductsRepository _productsRepository;

	public GetProductsListUseCase(IMapper mapper, IReadOnlyProductsRepository productsRepository)
	{
		_mapper = mapper;
		_productsRepository = productsRepository;
	}

	public async Task<List<ResponseProductsListJson>> ExecuteAsync()
	{
		var products = await _productsRepository.GetProductsListAsync();

		return _mapper.Map<List<ResponseProductsListJson>>(products);
	}
}
