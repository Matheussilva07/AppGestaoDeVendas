namespace GestaoDeVendas.Application.UseCases.SoldProducts;
public interface IGetProductsListOfASaleUseCase
{
	Task<List<string>> ExecuteAsync(long saleId);
}
