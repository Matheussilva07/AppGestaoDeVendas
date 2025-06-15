using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Costumers;
using GestaoDeVendas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeVendas.Infrastructure.Repositories;
internal class CostumersRepository : IWriteOnlyCostumersRepository, IReadOnlyCostumersRepository, IUpdateOnlyCostumerRepository
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

	public void Delete(Costumer costumer)
	{
		_dbContext.Costumers.Remove(costumer);
	}

	async Task<Costumer?> IReadOnlyCostumersRepository.GetCostumerByIdAsync(long costumerId)
	{
		return await _dbContext.Costumers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == costumerId);
	}

	public async Task<List<Costumer>> GetCostumersListAsync()
	{
		return await _dbContext.Costumers.AsNoTracking().ToListAsync();
	}

	async Task<Costumer?> IUpdateOnlyCostumerRepository.GetCostumerByIdAsync(long costumerId)
	{
		return await _dbContext.Costumers.FirstOrDefaultAsync(c => c.Id == costumerId);
	}

	void IUpdateOnlyCostumerRepository.Update(Costumer costumer)
	{
		_dbContext.Costumers.Update(costumer);
	}

	public async Task<Costumer?> GetCostumerByNameAsync(string nameCostumer)
	{
		return await _dbContext.Costumers.Where(c => c.Name.StartsWith(nameCostumer)).FirstOrDefaultAsync();
	}
}
