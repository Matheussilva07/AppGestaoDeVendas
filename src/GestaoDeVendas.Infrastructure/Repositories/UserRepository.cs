using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories;
using GestaoDeVendas.Infrastructure.DataAccess;

namespace GestaoDeVendas.Infrastructure.Repositories;
internal class UserRepository : IWriteOnlyUserRepository
{
	private readonly SaleManagerDbContext _dbContext;

	public UserRepository(SaleManagerDbContext saleManagerDbContext)
	{
		_dbContext = saleManagerDbContext;
	}

	public async Task AddAsync(User user)
	{
		await _dbContext.Users.AddAsync(user);
	}
}
