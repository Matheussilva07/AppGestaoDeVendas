using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Products;
public interface IWriteOnlyProductsRepository
{
	Task AddAsync(Product product);
	void Delete(Product product);
}
