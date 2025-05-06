using GestaoDeVendas.Communication.Products.Responses;

namespace GestaoDeVendas.Application.UseCases.Products.GetProductByName;
public interface IGetProductByNameUseCase
{
	Task<ResponseProductDetailsJson> ExecuteAscyn(string nameProduct);
}
