namespace GestaoDeVendas.Domain.Security.PasswordEncryptor;
public interface IPasswordEncryptor
{
	string EncryptPassword(string password);
}
