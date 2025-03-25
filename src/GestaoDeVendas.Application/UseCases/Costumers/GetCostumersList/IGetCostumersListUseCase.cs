using GestaoDeVendas.Communication.Costumers.Responses;

namespace GestaoDeVendas.Application.UseCases.Costumers.GetCostumersList;
public interface IGetCostumersListUseCase
{
	Task<List<ResponseShortCostumerJson>> ExecuteAsync();
}
