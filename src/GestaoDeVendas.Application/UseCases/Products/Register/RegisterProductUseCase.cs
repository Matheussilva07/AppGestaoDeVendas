using AutoMapper;
using GestaoDeVendas.Communication.Products.Requests;
using GestaoDeVendas.Communication.Products.Responses;
using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Repositories.Products;

namespace GestaoDeVendas.Application.UseCases.Products.Register;
internal class RegisterProductUseCase : IRegisterProductUseCase
{
	private readonly IMapper _mapper;
	private readonly IUnitOfWork _unitOfWork;
	private readonly IWriteOnlyProductsRepository _repository;

	public RegisterProductUseCase(IMapper mapper, IUnitOfWork unitOfWork, IWriteOnlyProductsRepository repository)
	{
		_mapper = mapper;
		_unitOfWork = unitOfWork;
		_repository = repository;
	}

	public async Task<ResponseRegisteredProductJson> ExecuteAsync(RequestRegisterProductJson request)
	{
		Validate(request);

		var product = _mapper.Map<Product>(request);

		await _repository.AddAsync(product);

		await _unitOfWork.CommitAsync();

		return _mapper.Map<ResponseRegisteredProductJson>(product);
	}

	private static void Validate(RequestRegisterProductJson request)
	{
		var result = new ProductValidator().Validate(request);

		if(result.IsValid == false)
		{
			throw new ArgumentException("Dados inválidos!");
		}
	}
}
