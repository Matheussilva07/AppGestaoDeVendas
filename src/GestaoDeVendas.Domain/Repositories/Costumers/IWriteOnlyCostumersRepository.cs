using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Costumers;
public interface IWriteOnlyCostumersRepository
{
	Task AddAsync(Costumer costumer);
	void Delete(Costumer costumer);
}
