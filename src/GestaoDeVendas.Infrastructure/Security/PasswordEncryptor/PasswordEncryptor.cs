using GestaoDeVendas.Domain.Security.PasswordEncryptor;
using BC = BCrypt.Net.BCrypt;

namespace GestaoDeVendas.Infrastructure.Security.PasswordEncryptor;
internal class PasswordEncryptor : IPasswordEncryptor
{
	public string EncryptPassword(string password)
	{
		var passwordEncrypted = BC.HashPassword(password);

		return passwordEncrypted;
	}
}
