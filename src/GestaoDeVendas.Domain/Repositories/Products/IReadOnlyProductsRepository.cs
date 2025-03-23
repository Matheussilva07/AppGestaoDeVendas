using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Products;
public interface IReadOnlyProductsRepository
{
	Task<List<Product>> GetProductsListAsync();
	Task<Product?> GetProductByIdAsync(long productId);
}
