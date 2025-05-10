using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Repositories.Sales;
public interface IReadOnlySalesRepository
{
	Task<Sale?> GetSaleByIdWithAsNoTrakcing(long saleId);
	Task<Sale?> GetSaleByIdAsync(long saleId);
	Task<List<SoldProduct>> FilterSalesByDateAsync(DateOnly period);
}
