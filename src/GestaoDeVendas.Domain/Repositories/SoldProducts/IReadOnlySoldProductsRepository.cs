using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.SoldProducts;
public interface IReadOnlySoldProductsRepository
{
	Task<List<Product>> GetSoldProductsAsync(long saleId);
}
