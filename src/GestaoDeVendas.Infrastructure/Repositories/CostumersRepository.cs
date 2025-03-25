using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Costumers;
using GestaoDeVendas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeVendas.Infrastructure.Repositories;
internal class CostumersRepository : IWriteOnlyCostumersRepository , IReadOnlyCostumersRepository
{
	private readonly SaleManagerDbContext _dbContext;

	public CostumersRepository(SaleManagerDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task AddAsync(Costumer costumer)
	{
		await _dbContext.Costumers.AddAsync(costumer);
	}

	public async Task<List<Costumer>> GetCostumersListAsync()
	{
		return await _dbContext.Costumers.AsNoTracking().ToListAsync();
	}
}
