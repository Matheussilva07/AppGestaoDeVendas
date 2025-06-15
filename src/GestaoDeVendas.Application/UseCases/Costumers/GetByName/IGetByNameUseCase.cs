using GestaoDeVendas.Communication.Costumers.Responses;

namespace GestaoDeVendas.Application.UseCases.Costumers.GetByName;
public interface IGetByNameUseCase
{
	Task<ResponseCostumerJson?> ExecuteAsync(string nameCostumer);
}
