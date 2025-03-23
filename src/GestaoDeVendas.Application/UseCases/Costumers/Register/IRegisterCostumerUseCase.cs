using GestaoDeVendas.Communication.Costumers.Requests;
using GestaoDeVendas.Communication.Costumers.Responses;

namespace GestaoDeVendas.Application.UseCases.Costumers.Register;
public interface IRegisterCostumerUseCase
{
	Task<ResponseRegisteredCostumerJson> ExecuteAsync(RequestRegisterCostumerJson request);
}
