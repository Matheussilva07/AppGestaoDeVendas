using GestaoDeVendas.Communication.Sales.Responses;

namespace GestaoDeVendas.Application.UseCases.Sales.GetSaleById;
public interface IGetSaleByIdUseCase
{
	Task<ResponseSaleByIdJson> ExecuteAsync(long saleId);
}
