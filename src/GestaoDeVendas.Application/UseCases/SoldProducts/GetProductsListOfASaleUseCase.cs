using AutoMapper;
using GestaoDeVendas.Domain.Repositories.SoldProducts;

namespace GestaoDeVendas.Application.UseCases.SoldProducts;
internal class GetProductsListOfASaleUseCase : IGetProductsListOfASaleUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlySoldProductsRepository _repository;

	public GetProductsListOfASaleUseCase(IMapper mapper, IReadOnlySoldProductsRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<List<string>> ExecuteAsync(long saleId)
	{
		var products = await _repository.GetSoldProductsAsync(saleId);

		return _mapper.Map<List<string>>(products.Select(p=>p.Name));
		
	}
}
