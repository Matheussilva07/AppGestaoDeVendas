using FluentValidation;
using GestaoDeVendas.Communication.Costumers.Requests;

namespace GestaoDeVendas.Application.UseCases.Costumers;
public class CostumerValidator: AbstractValidator<RequestRegisterCostumerJson>
{
    public CostumerValidator()
    {
        RuleFor(c => c.Name).NotEmpty().WithMessage("Informe o nome do cliente");
        RuleFor(c => c.Email).EmailAddress().WithMessage("Email inválido");
    }
}
