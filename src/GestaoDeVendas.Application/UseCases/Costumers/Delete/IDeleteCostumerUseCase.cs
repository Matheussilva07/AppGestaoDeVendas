namespace GestaoDeVendas.Application.UseCases.Costumers.Delete;
public interface IDeleteCostumerUseCase
{
	Task ExecuteAsync(long costumerId);
}
