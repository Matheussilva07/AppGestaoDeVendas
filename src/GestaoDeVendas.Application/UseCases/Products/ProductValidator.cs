using FluentValidation;
using GestaoDeVendas.Communication.Products.Requests;

namespace GestaoDeVendas.Application.UseCases.Products;
public class ProductValidator: AbstractValidator<RequestRegisterProductJson>
{
    public ProductValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Digite o nome do produto.");
        RuleFor(p => p.Code).NotEmpty().WithMessage("Digite o código do produto.");
        RuleFor(p => p.Price).GreaterThan(0).WithMessage("O preço do produto deve ser maior que 0.");
    }
}

public class UpdateProductValidator : AbstractValidator<RequestUpdateProductJson>
{
	public UpdateProductValidator()
	{
		RuleFor(p => p.Name).NotEmpty().WithMessage("Digite o nome do produto.");
		RuleFor(p => p.Code).NotEmpty().WithMessage("Digite o código do produto.");
		RuleFor(p => p.Price).GreaterThan(0).WithMessage("O preço do produto deve ser maior que 0.");
	}
}