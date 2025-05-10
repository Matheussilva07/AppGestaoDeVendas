using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.SoldProducts;
using GestaoDeVendas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeVendas.Infrastructure.Repositories;
internal class SoldProductsRepository : IReadOnlySoldProductsRepository
{
	private readonly SaleManagerDbContext _dbContext;

	public SoldProductsRepository(SaleManagerDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<List<Product>> GetSoldProductsAsync(long saleId)
	{
		var products = await _dbContext.SoldProducts.Where(s => s.SaleId == saleId).Select(p => p.Product).ToListAsync();

		return products;
	}
}
