using FluentValidation;
using GestaoDeVendas.Communication.Users.Requests;

namespace GestaoDeVendas.Application.UseCases.Users;
public class UserValidator : AbstractValidator<RequestRegisterUserJson>
{
    public UserValidator()
    {
        RuleFor(user => user.Name).NotEmpty().WithMessage("Preencha o nome do usuário.");
        RuleFor(user => user.Email).NotEmpty().WithMessage("O email deve ser informado.")
            .EmailAddress().When(user => string.IsNullOrEmpty(user.Email) == false, ApplyConditionTo.CurrentValidator).WithMessage("Email inválido.");
        RuleFor(user => user.Password).SetValidator(new PasswordValidator<RequestRegisterUserJson>());
    }
}
