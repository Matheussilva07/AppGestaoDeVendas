using GestaoDeVendas.Domain.Entities;
using GestaoDeVendas.Domain.Security.Token;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GestaoDeVendas.Infrastructure.Security.Token;
internal class TokenGenerator : ITokenGenerator
{
	private readonly string _signingKey;
	private readonly int _tokenLifetime;

	public TokenGenerator(string tokenKey, int tokenLifetime)
	{
		_signingKey = tokenKey;
		_tokenLifetime = tokenLifetime;
	}

	public string GenerateToken(User user)
	{
		var claims = new List<Claim>
		{
			new(ClaimTypes.Name, user.Name),
			new(ClaimTypes.Sid, user.UserIdentifier.ToString())
		};

		var tokenDescriptor = new SecurityTokenDescriptor
		{
			SigningCredentials = new SigningCredentials(SecurityKey(), SecurityAlgorithms.HmacSha256Signature),
			Expires = DateTime.UtcNow.AddMinutes(_tokenLifetime),
			Subject = new ClaimsIdentity(claims)
		};

		var tokenHandler = new JwtSecurityTokenHandler();

		var securityToken = tokenHandler.CreateToken(tokenDescriptor);

		return tokenHandler.WriteToken(securityToken);
	}

	private SymmetricSecurityKey SecurityKey()
	{
		var key = Encoding.UTF8.GetBytes(_signingKey);

		return new SymmetricSecurityKey(key);
	}
}
