using GestaoDeVendas.Domain;
using GestaoDeVendas.Infrastructure.DataAccess;

namespace GestaoDeVendas.Infrastructure;
internal class UnitOfWork : IUnitOfWork
{
	private readonly SaleManagerDbContext _dbContext;

	public UnitOfWork(SaleManagerDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task CommitAsync()
	{
		await _dbContext.SaveChangesAsync();
	}
}
