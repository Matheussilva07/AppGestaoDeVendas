using GestaoDeVendas.Communication.Sales.Requests;
using GestaoDeVendas.Communication.Sales.Responses;

namespace GestaoDeVendas.Application.UseCases.Sales.Register;
public interface IRegisterSaleUseCase
{
    Task<ResponseRegisteredSaleJson> ExecuteAsync(RequestRegisterSaleJson request);
}
