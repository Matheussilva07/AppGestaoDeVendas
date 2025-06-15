using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Sales;
public interface IUpdateOnlySalesRepository
{
	void Update(Sale sale); 
}
