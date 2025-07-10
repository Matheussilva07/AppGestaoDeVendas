using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Sales;
using GestaoDeVendas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeVendas.Infrastructure.Repositories;
internal class SalesRepository : IWriteOnlySalesRepository, IReadOnlySalesRepository, IUpdateOnlySalesRepository
{
	private readonly SaleManagerDbContext _dbContext;
	public SalesRepository(SaleManagerDbContext dbContext) => _dbContext = dbContext;

	public async Task AddAsync(Sale sale)
	{
		await _dbContext.Sales.AddAsync(sale);
	}
	public void Delete(Sale sale)
	{
		_dbContext.Sales.Remove(sale);
	}
	public async Task<List<SoldProduct>> FilterSalesByDateAsync(DateOnly date)
	{
		var initialDate = new DateTime(year: date.Year, month: date.Month, day: 1).Date;

		var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

		var finalDate = new DateTime(year: date.Year, month: date.Month, day: daysInMonth, hour: 23, minute: 59, second: 59).Date.AddHours(24);

		var fullSale = await _dbContext.SoldProducts.Include(t => t.Sale).ThenInclude(sale => sale.Costumer).Include(t => t.Product)
			.Where(soldProduct => soldProduct.Sale.DateOfSale >= initialDate && soldProduct.Sale.DateOfSale < finalDate)
			.OrderBy(soldProduct => soldProduct.SaleId).ToListAsync();

		return fullSale;
	}
	public async Task<Sale?> GetSaleByIdAsync(long saleId)
	{
		return await _dbContext.Sales.FirstOrDefaultAsync(s => s.SaleId == saleId);
	}
	public async Task<Sale?> GetSaleByIdWithAsNoTrakcing(long saleId)
	{
		return await _dbContext.Sales.Include(c => c.Costumer).AsNoTracking().FirstOrDefaultAsync(s => s.SaleId == saleId);
	}
	public void Update(Sale sale)
	{
		_dbContext.Sales.Update(sale);
	}
}
