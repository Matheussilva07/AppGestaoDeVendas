using GestaoDeVendas.Communication.Users.Requests;
using GestaoDeVendas.Communication.Users.Responses;

namespace GestaoDeVendas.Application.UseCases.Users.Register;
public interface IRequestRegisterUserUseCase
{
	Task<ResponseRegisteredUserJson> ExecuteAsync(RequestRegisterUserJson request);
}
