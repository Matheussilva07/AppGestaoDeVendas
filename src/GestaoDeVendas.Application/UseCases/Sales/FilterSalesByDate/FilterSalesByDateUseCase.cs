using GestaoDeVendas.Communication.Sales.Responses;
using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Sales;

namespace GestaoDeVendas.Application.UseCases.Sales.FilterSalesByDate;
internal class FilterSalesByDateUseCase : IFilterSalesByDateUseCase
{
	private readonly IReadOnlySalesRepository _salesRepository;

	public FilterSalesByDateUseCase( IReadOnlySalesRepository repository)
	{
		_salesRepository = repository;
	}

	public async Task<HashSet<ResponseSaleFilteredByDateJson>> ExecuteAsync(DateOnly period)
	{
		var sales = await _salesRepository.FilterSalesByDateAsync(period);
		
		var vendasList = new HashSet<ResponseSaleFilteredByDateJson>();

		foreach (var venda in sales)
		{
			var sale = new ResponseSaleFilteredByDateJson
			{
				Id = venda.Sale.SaleId,
				Salesman = venda.Sale.Salesman,
				AddressMarket = venda.Sale.AddressMarket,
				DateOfSale = venda.Sale.DateOfSale,
				PaymentType = (Communication.Enums.PaymentType)venda.Sale.PaymentType,
				TotalSaleAmount = venda.Sale.TotalSaleAmount,
				Name = venda.Sale.Costumer.Name,
				Email = venda.Sale.Costumer.Email,
				Telephone = venda.Sale.Costumer.Telephone,
				Address = venda.Sale.Costumer.Address
			};

			foreach (var item in venda.Sale.Products)
			{

				sale.Products.Add(new Product
				{
					Id = item.Product.Id,
					Name = item.Product.Name,
					Discription = item.Product.Discription,
					Code = item.Product.Code,
					Price = item.Product.Price,

					Amount = (int)item.ProductAmount
				});
			}

            vendasList.Add(sale);
		}

		return vendasList;
	}

}

