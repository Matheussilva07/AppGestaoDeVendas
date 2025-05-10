using GestaoDeVendas.Communication.Sales.Responses;

namespace GestaoDeVendas.Application.UseCases.Sales.FilterSalesByDate;
public interface IFilterSalesByDateUseCase
{
	Task<HashSet<ResponseSaleFilteredByDateJson>> ExecuteAsync(DateOnly period);
}
