using GestaoDeVendas.Communication.Products.Requests;

namespace GestaoDeVendas.Application.UseCases.Products.Update;
public interface IUpdateProductUseCase
{
	Task ExecuteAsync(RequestUpdateProductJson request, long id);
}
