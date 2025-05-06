using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace GestaoDeVendas.Application.UseCases.Users;
public class PasswordValidator<T> : PropertyValidator<T, string>
{
	public override string Name => "PasswordValidator";

	private const string MESSAGE_KEY = "message";

	protected override string GetDefaultMessageTemplate(string errorCode)
	{
		return $"{{{MESSAGE_KEY}}}";
	}

	public override bool IsValid(ValidationContext<T> context, string password)
	{
		if (string.IsNullOrWhiteSpace(password))
		{
			context.MessageFormatter.AppendArgument(MESSAGE_KEY, "A senha não pode ser vazia.");
			return false;
		}
		if (password.Length < 8)
		{
			context.MessageFormatter.AppendArgument(MESSAGE_KEY, "A senha deve ter pelo menos 8 caracteres.");
			return false;
		}
		if (Regex.IsMatch(password, @"[a-z]+") == false)
		{
			context.MessageFormatter.AppendArgument(MESSAGE_KEY, "A senha deve conter pelo menos um caractere minúsculo.");
			return false;
		}
		if (Regex.IsMatch(password, @"[A-Z]+") == false)
		{
			context.MessageFormatter.AppendArgument(MESSAGE_KEY, "A senha deve conter pelo menos um caractere maiúsculo.");
			return false;
		}
		if (Regex.IsMatch(password, @"[@\$\%\*\!]+") == false)
		{
			context.MessageFormatter.AppendArgument(MESSAGE_KEY, "A senha deve conter pelo menos um caractere especial.");
			return false;
		}
		if (Regex.IsMatch(password, @"[1-9]+") == false)
		{
			context.MessageFormatter.AppendArgument(MESSAGE_KEY, "A senha deve conter pelo menos um número.");
			return false;
		}

		return true;
	}
}
