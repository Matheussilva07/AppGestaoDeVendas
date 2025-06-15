using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Costumers;
public interface IReadOnlyCostumersRepository
{
	Task<List<Costumer>> GetCostumersListAsync();
	Task<Costumer?> GetCostumerByIdAsync(long idCostumer);
	Task<Costumer?> GetCostumerByNameAsync(string nameCostumer);
}
