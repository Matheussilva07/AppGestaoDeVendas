using AutoMapper;
using GestaoDeVendas.Communication.Sales.Requests;
using GestaoDeVendas.Communication.Sales.Responses;
using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Products;
using GestaoDeVendas.Domain.Repositories.Sales;

namespace GestaoDeVendas.Application.UseCases.Sales.Register;
public class RegisterSaleUseCase : IRegisterSaleUseCase
{
    private readonly IMapper _mapper;
    private readonly IWriteOnlySalesRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUpdateOnlyProductsRepository _productsRepository;

	public RegisterSaleUseCase(IMapper mapper, IWriteOnlySalesRepository repository, IUnitOfWork unitOfWork, IUpdateOnlyProductsRepository productsRepository)
	{
		_mapper = mapper;
		_repository = repository;
		_unitOfWork = unitOfWork;
		_productsRepository = productsRepository;
	}

	public async Task<ResponseRegisteredSaleJson> ExecuteAsync(RequestRegisterSaleJson request)
    {
        Validate(request);

        var sale = _mapper.Map<Sale>(request);
        
		foreach (var itens in request.Products)
        {
            var productsFromRepository = await _productsRepository.GetProductByIdAsync(itens.ProductId);

            var productFromRequest = request.Products.First(p => p.ProductId == productsFromRepository!.Id);

           productsFromRepository!.Amount -= (int)productFromRequest.ProductAmount;

			_productsRepository.Update(productsFromRepository);

            sale.TotalSaleAmount += productsFromRepository.Price;
        }

		await _repository.AddAsync(sale);

        await _unitOfWork.CommitAsync();

        return _mapper.Map<ResponseRegisteredSaleJson>(sale);
    }

    private static void Validate(RequestRegisterSaleJson request)
    {
        var result = new SalesValidator().Validate(request);

        if(result.IsValid == false)
        {
            throw new ArgumentException("Dados inválidos");
        }
	}
}

