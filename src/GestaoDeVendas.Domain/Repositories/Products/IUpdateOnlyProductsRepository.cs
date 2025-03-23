using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Products;
public interface IUpdateOnlyProductsRepository
{
	void Update(Product product);
	void UpdateProductAmount(int productAmount);
	Task<Product?> GetProductByIdAsync(long id);
}
