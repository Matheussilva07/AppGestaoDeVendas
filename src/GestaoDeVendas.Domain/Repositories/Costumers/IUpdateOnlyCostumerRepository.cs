using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Costumers;
public interface IUpdateOnlyCostumerRepository
{
	void Update(Costumer costumer);
	Task<Costumer?> GetCostumerByIdAsync(long costumerId);
}
