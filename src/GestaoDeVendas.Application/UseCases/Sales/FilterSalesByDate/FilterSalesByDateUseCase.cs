using AutoMapper;
using GestaoDeVendas.Communication.Sales.Responses;
using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Sales;
using GestaoDeVendas.Domain.Repositories.SoldProducts;
using System.Collections.Generic;
using System.Data;

namespace GestaoDeVendas.Application.UseCases.Sales.FilterSalesByDate;
internal class FilterSalesByDateUseCase : IFilterSalesByDateUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlySalesRepository _salesRepository;
	private readonly IReadOnlySoldProductsRepository _readOnlySoldProductsRepository;

	public FilterSalesByDateUseCase(IMapper mapper, IReadOnlySalesRepository repository, IReadOnlySoldProductsRepository readOnlySoldProductsRepository)
	{
		_mapper = mapper;
		_salesRepository = repository;
		_readOnlySoldProductsRepository = readOnlySoldProductsRepository;
	}

	public async Task<HashSet<ResponseSaleFilteredByDateJson>> ExecuteAsync(DateOnly period)
	{
		var sales = await _salesRepository.FilterSalesByDateAsync(period);

		var vendas = new HashSet<ResponseSaleFilteredByDateJson>();

		foreach (var item in sales)
		{
			var soldProducts = await _readOnlySoldProductsRepository.GetSoldProductsAsync(item.SaleId);

			vendas.Add(new ResponseSaleFilteredByDateJson()
			{
				Id = item.Sale.Id,
				Salesman = item.Sale.Salesman,
				AddressMarket = item.Sale.AddressMarket,
				DateOfSale = item.Sale.DateOfSale,
				TotalSaleAmount = item.Sale.TotalSaleAmount,
				Name = item.Sale.Costumer.Name,
				Email = item.Sale.Costumer.Email,
				Telephone = item.Sale.Costumer.Telephone,
				Address= item.Sale.Costumer.Address,
			
				Products = soldProducts
			});			
		}

			return vendas;
	}
}

