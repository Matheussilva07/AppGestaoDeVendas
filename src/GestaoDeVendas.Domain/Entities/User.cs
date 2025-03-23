using GestaoDeVendas.Domain.Enums;

namespace GestaoDeVendas.Domain.Entities;
public class User
{
	public long Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Password { get; set; } = string.Empty;
	public Guid UserIdentifier { get; set; }
	public DateTime DateOfRegister { get; set; }
	public string Role { get; set; } = UserRole.USER_NORMAL;
}
