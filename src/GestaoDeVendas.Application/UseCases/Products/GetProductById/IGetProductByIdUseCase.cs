using GestaoDeVendas.Communication.Products.Responses;

namespace GestaoDeVendas.Application.UseCases.Products.GetProductById;
public interface IGetProductByIdUseCase
{
	Task<ResponseProductDetailsJson?> Executeasync(long productId);
}
