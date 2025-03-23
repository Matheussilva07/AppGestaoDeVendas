using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Sales;
public interface IWriteOnlySalesRepository
{
	Task AddAsync(Sale sale);
	void Delete(Sale sale);
}
