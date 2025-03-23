using GestaoDeVendas.Communication.Sales.Responses;
using GestaoDeVendas.Domain.Repositories.Sales;
using GestaoDeVendas.Domain.Repositories.SoldProducts;

namespace GestaoDeVendas.Application.UseCases.Sales.GetSaleById;
internal class GetSaleByIdUseCase : IGetSaleByIdUseCase 
{
	private readonly IReadOnlySalesRepository _repository;
	private readonly IReadOnlySoldProductsRepository _readOnlySoldProductsRepository;

	public GetSaleByIdUseCase(IReadOnlySalesRepository repository, IReadOnlySoldProductsRepository readOnlySoldProductsRepository)
	{
		_repository = repository;
		_readOnlySoldProductsRepository = readOnlySoldProductsRepository;
	}

	public async Task<ResponseSaleByIdJson> ExecuteAsync(long saleId)
	{
		var sale = await _repository.GetSaleByIdWithAsNoTrakcing(saleId);
		var productList = await _readOnlySoldProductsRepository.GetSoldProductsAsync(saleId);

		if (sale is null)
		{
			 throw new ArgumentException("Venda não encontrada");
		}

		return new ResponseSaleByIdJson
		{
			Name = sale.Costumer.Name,
			Email = sale.Costumer.Email,
			Salesman = sale.Salesman,
			AddressMarket = sale.AddressMarket,
			DateOfSale = sale.DateOfSale,
			Products = productList.Select(p => p.Name).ToList(),
			TotalSaleAmount = sale.TotalSaleAmount,		
		};
	}
}
