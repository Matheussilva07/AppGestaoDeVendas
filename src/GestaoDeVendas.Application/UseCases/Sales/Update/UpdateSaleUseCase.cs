using AutoMapper;
using GestaoDeVendas.Communication.Sales.Requests;
using GestaoDeVendas.Domain;
using GestaoDeVendas.Domain.Repositories.Sales;
using GestaoDeVendas.Exception;
using GestaoDeVendas.Exception.ExceptionBase;

namespace GestaoDeVendas.Application.UseCases.Sales.Update;
public class UpdateSaleUseCase : IUpdateSaleUseCase
{
	private readonly IMapper _mapper;
	private readonly IUnitOfWork _unitOfWork;
	private readonly IReadOnlySalesRepository _readRepository;
	private readonly IUpdateOnlySalesRepository _updateRepository;


	public UpdateSaleUseCase(IMapper mapper,
							 IUnitOfWork unitOfWork,
							 IReadOnlySalesRepository readRepository,
							 IUpdateOnlySalesRepository updateRepository)
	{
		_mapper = mapper;
		_unitOfWork = unitOfWork;
		_readRepository = readRepository;
		_updateRepository = updateRepository;
	}

	public async Task ExecuteAsync(RequestUpdateSaleJson request, long saleId)
	{
		Validate(request);

		var sale = await _readRepository.GetSaleByIdAsync(saleId) ?? throw new NotFoundException(ExceptionMessages.SALE_NOT_FOUND);

		sale = _mapper.Map(request, sale);

		_updateRepository.Update(sale);

		await _unitOfWork.CommitAsync();
	}
	private static void Validate(RequestUpdateSaleJson request)
	{
		var result = new UpdateSalesValidator().Validate(request);

		if (!result.IsValid)
		{
			var errorsMessages = result.Errors.Select(e => e.ErrorMessage).ToList();

			throw new ErrorOnValidationExcepion(errorsMessages);
		}
	}
}
