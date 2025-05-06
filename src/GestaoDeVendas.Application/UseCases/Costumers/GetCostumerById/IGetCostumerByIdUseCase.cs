using GestaoDeVendas.Communication.Costumers.Responses;

namespace GestaoDeVendas.Application.UseCases.Costumers.GetCostumerByName;
public interface IGetCostumerByIdUseCase
{
	Task<ResponseCostumerJson?> ExecuteAsync(long costumerId);
}
