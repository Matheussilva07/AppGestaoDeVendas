using GestaoDeVendas.Domain.Entities;

namespace GestaoDeVendas.Domain.Security.Token;
public interface ITokenGenerator
{
	string GenerateToken(User user);
}

