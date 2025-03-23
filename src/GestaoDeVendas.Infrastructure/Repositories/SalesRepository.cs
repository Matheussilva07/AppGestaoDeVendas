using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Sales;
using GestaoDeVendas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeVendas.Infrastructure.Repositories;
internal class SalesRepository : IWriteOnlySalesRepository, IReadOnlySalesRepository
{
	private readonly SaleManagerDbContext _dbContext;
	public SalesRepository(SaleManagerDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task AddAsync(Sale sale)
	{
		await _dbContext.Sales.AddAsync(sale);
	}

	public void Delete(Sale sale)
	{
		_dbContext.Sales.Remove(sale);
	}

	public async Task<Sale?> GetSaleByIdAsync(long saleId)
	{
		return await _dbContext.Sales.FirstOrDefaultAsync(s => s.Id == saleId);
	}

	public async Task<Sale?> GetSaleByIdWithAsNoTrakcing(long saleId)
	{
		return await _dbContext.Sales.Include(c => c.Costumer).AsNoTracking().FirstOrDefaultAsync(s => s.Id == saleId);
	}

}
