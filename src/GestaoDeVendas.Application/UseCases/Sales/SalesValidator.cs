using FluentValidation;
using GestaoDeVendas.Communication.Sales.Requests;

namespace GestaoDeVendas.Application.UseCases.Sales;
public class SalesValidator : AbstractValidator<RequestRegisterSaleJson>
{
    public SalesValidator()
    {
        RuleFor(s => s.Salesman).NotEmpty().WithMessage("Informe o vendedor.");
        RuleFor(s => s.AddressMarket).NotEmpty().WithMessage("Informe o mercado onde foi feita a venda.");
        RuleFor(s => s.Products).NotEmpty().WithMessage("Liste os produtos vendidos.");
        RuleFor(s => s.CostumerId).NotEmpty().WithMessage("Informe o do cliente.");
    }
}


public class UpdateSalesValidator : AbstractValidator<RequestUpdateSaleJson>
{
	public UpdateSalesValidator()
	{
		RuleFor(s => s.Salesman).NotEmpty().WithMessage("Informe o vendedor.");
		RuleFor(s => s.AddressMarket).NotEmpty().WithMessage("Informe o mercado onde foi feita a venda.");
	}
}
