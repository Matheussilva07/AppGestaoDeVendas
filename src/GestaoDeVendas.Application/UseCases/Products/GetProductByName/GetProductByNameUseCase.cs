using AutoMapper;
using GestaoDeVendas.Communication.Products.Responses;
using GestaoDeVendas.Domain.Repositories.Products;
using GestaoDeVendas.Exception;
using GestaoDeVendas.Exception.ExceptionBase;

namespace GestaoDeVendas.Application.UseCases.Products.GetProductByName;
internal class GetProductByNameUseCase : IGetProductByNameUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyProductsRepository _productsRepository;

	public GetProductByNameUseCase(IMapper mapper, IReadOnlyProductsRepository productsRepository)
	{
		_mapper = mapper;
		_productsRepository = productsRepository;
	}

	public async Task<ResponseProductDetailsJson> ExecuteAscyn(string productName)
	{
		if (string.IsNullOrWhiteSpace(productName)) 
		{ 
			throw new ArgumentNullException(paramName: "Informe o nome do producto.");
		}

		var product = await _productsRepository.GetProductByNameAsync(productName) ?? throw new NotFoundException(ExceptionMessages.PRODUTO_NOT_FOUND);

		return _mapper.Map<ResponseProductDetailsJson>(product);
	}
}
