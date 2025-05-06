using GestaoDeVendas.Communication.Costumers.Requests;

namespace GestaoDeVendas.Application.UseCases.Costumers.Update;
public interface IUpdateCostumerUseCase
{
	Task ExecuteAsync(RequestUpdateCostumerJson request, long costumerId);
}
