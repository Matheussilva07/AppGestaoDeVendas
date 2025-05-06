using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories;
public interface IWriteOnlyUserRepository
{
	Task AddAsync(User user);
}
