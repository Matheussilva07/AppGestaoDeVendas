using GestaoDeVendas.Communication.Sales.Requests;

namespace GestaoDeVendas.Application.UseCases.Sales.Update;
public interface IUpdateSaleUseCase
{
	Task ExecuteAsync(RequestUpdateSaleJson request, long saleId);
}
