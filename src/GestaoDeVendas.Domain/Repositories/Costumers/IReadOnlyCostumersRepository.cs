using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Costumers;
public interface IReadOnlyCostumersRepository
{
	Task<List<Costumer>> GetCostumersListAsync();
	Task<Costumer?> GetCostumerByIdAsync(long costumerId);
}
