using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Products;
using GestaoDeVendas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeVendas.Infrastructure.Repositories;
internal class ProductsRepository : IWriteOnlyProductsRepository , IReadOnlyProductsRepository, IUpdateOnlyProductsRepository
{

	private readonly SaleManagerDbContext _dbContext;

	public ProductsRepository(SaleManagerDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task AddAsync(Product product)
	{
		await _dbContext.Products.AddAsync(product);
	}

	public void Delete(Product product)
	{
		 _dbContext.Products.Remove(product);
	}

	public async Task<Product?> GetProductByIdAsync(long productId)
	{
		return await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == productId);
	}

	public async Task<List<Product>> GetProductsListAsync()
	{
		return await _dbContext.Products.AsNoTracking().ToListAsync();
	}

	void IUpdateOnlyProductsRepository.UpdateProductAmount(int productAmount)
	{
		_dbContext.Products.ExecuteUpdate(config => config.SetProperty(p => p.Amount, productAmount));
	}

	Task<Product?> IUpdateOnlyProductsRepository.GetProductByIdAsync(long id)
	{
		return _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
	}

	void IUpdateOnlyProductsRepository.Update(Product product)
	{
		_dbContext.Products.Update(product);
	}
}
