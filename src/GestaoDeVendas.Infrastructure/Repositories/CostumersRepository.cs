using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Costumers;
using GestaoDeVendas.Infrastructure.DataAccess;

namespace GestaoDeVendas.Infrastructure.Repositories;
internal class CostumersRepository : IWriteOnlyCostumersRepository
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
}
