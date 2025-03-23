using GestaoDeVendas.Communication.Products.Responses;

namespace GestaoDeVendas.Application.UseCases.Products.GetAllProducts;
public interface IGetProductsListUseCase
{
	Task<List<ResponseProductsListJson>> ExecuteAsync();
}
