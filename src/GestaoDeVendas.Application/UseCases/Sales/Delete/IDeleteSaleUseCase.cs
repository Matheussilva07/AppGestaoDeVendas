namespace GestaoDeVendas.Application.UseCases.Sales.Delete;
public interface IDeleteSaleUseCase
{
	Task ExecuteAsync(long saleId);
}
