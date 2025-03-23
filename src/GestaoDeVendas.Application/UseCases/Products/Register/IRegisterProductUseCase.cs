using GestaoDeVendas.Communication.Products.Requests;
using GestaoDeVendas.Communication.Products.Responses;

namespace GestaoDeVendas.Application.UseCases.Products.Register;
public interface IRegisterProductUseCase
{
	Task<ResponseRegisteredProductJson> ExecuteAsync(RequestRegisterProductJson request);
}
